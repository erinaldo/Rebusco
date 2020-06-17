Imports System.IO
Imports System.Collections.Generic

Public Class GenerarArchivoBanco
    Private Sub GenerarArchivoBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cAño.AñosMes("A")
        cMes.AñosMes("M")

        If Now.Month = 1 Then
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now) - 1).ToString
        Else
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now)).ToString
        End If


        cFormato.Items.Add("BCI")
        cFormato.Items.Add("OfficeBanking")
        cFormato.Text = "BCI"

        cTipo.Items.Add(".CSV")
        cTipo.Items.Add(".TXT")
        cTipo.Items.Add(".XLS")

        If G_IDCLIENTE = Clientes.Wikets Then
            cFormato.Text = "BCI"
            cTipo.Text = ".TXT"
        Else
            cFormato.Text = "OfficeBanking"
            cTipo.Text = ".CSV"
        End If

    End Sub

    Private Sub bGenerar_Click(sender As Object, e As EventArgs) Handles bGenerar.Click
        Dim Archivo As StreamWriter, Ruta As String, Registro As String, Separador As String
        Dim Datos As String, qRut As String, qDig As String
        Dim xAño As Integer, xMes As Integer, wGlosa As String

        xAño = CInt(cAño.Text)
        xMes = cMes.SelectedIndex

        Ruta = ""
        Datos = ""
        Separador = ""

        If cFormato.Text = "" Then
            MsgError("Falta Formato Archivo del Banco")
            Exit Sub
        End If

        If cTipo.Text = "" Then
            MsgError("Falta Tipo de Archivo a Generar")
            Exit Sub
        End If

        If cTipo.Text = ".XLS" Then
            Separador = vbTab
        End If
        If cTipo.Text = ".CSV" Then
            Separador = ";"
        End If
        If cTipo.Text = ".TXT" Then
            If G_IDCLIENTE = Clientes.Wikets Then
                Separador = ";"
            Else
                Separador = ""
            End If
        End If

        If Pregunta("Desea Emitir Archivo para " & cFormato.Text) = False Then
            Exit Sub
        End If

        Call Auditoria(Me.Name, "Generar Archivo para Bancos", cAño.Text, cMes.Text)

        Dim RmG = SQL("Select * from Sueldos where Año = " & Val(cAño.Text.Trim) & " and Mes = " & cMes.SelectedIndex)
        If RmG Is Nothing Then
            MsgError("No hay cálculo de sueldos para el Año:" & cAño.Text.Trim & "  Mes:" & cMes.Text.Trim)
            Exit Sub
        End If

        Try
            File.Delete(Ruta)
        Catch ex As Exception
            'No existe el archivo
        End Try
        If cFormato.Text = "OfficeBanking" Then
            Ruta = Directorio_TXT & "\" & "OfficeBanking_" & Now.Day.ToString.PadLeft(2, CChar("0")) & Now.ToString.PadLeft(2, CChar("0")) & Now.Year.ToString.PadLeft(4, CChar("0")) & cTipo.Text
            Try
                File.Delete(Ruta)
            Catch ex As Exception
                'No existe el archivo
            End Try

            Archivo = File.AppendText(Ruta)

            '1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
            'Cta_origen  mon_origen  Cta_destino mon_destino Cod_banco   RUT benef.  nombre benef.                Mto Total   Glosa TEF                 Correo                  Glosa correo              Glosa Cartola Cliente   Glosa Cartola Beneficiario
            'XXXXXXX     CLP         XXXXXX      CLP         37          XXXXXXXXX   CARLOS ALFREDO AILEF VALDES  XXXXX       ABONO DE REMUNERACIONES   Ejemplo@santander.cl    ABONO DE REMUNERACIONES   Pago remuneraciones 1   Cancelado 1

            'Encabezado
            Registro = "Cuenta Origen" + Separador + "Moneda" + Separador + "Cuenta Destino" + Separador + "Moneda" + Separador + "Banco" + Separador + "Rut Beneficiario" + Separador + "Nombre Beneficiario" + Separador + "Monto" + Separador + "Glosa TEF" + Separador + "Correo" + Separador + "Glosa Correo" + Separador + "Glosa Cliente" + Separador + "Glosa Beneficiario"
            Archivo.Write(Registro + vbCrLf)

            For Each wR As DataRow In RmG.Rows
                Dim Usr = SQL("Select * from Usuarios where Usuario = '" + wR.GetText("Usuario") + "'").Top
                If Usr IsNot Nothing Then
                    If Usr.GetNum("Banco") = 0 Then
                        'No tiene cuenta corriente
                    Else
                        wGlosa = "Pago Sueldo: " & Usr.GetText("NombreUsr").Trim & " " & cMes.ToString & " " & cAño.ToString

                        Registro = ""
                        If G_IDCLIENTE = Clientes.Wikets Then
                            Registro = Registro + "66787150" + Separador                        ' Cuenta Origen
                        Else
                            Registro = Registro + "00000000" + Separador                        ' Cuenta Origen
                        End If
                        Registro = Registro & "CLP" & Separador                                 ' Moneda
                        Registro = Registro & Usr.GetText("CuentaCorriente") & Separador         ' Cuenta Destino
                        Registro = Registro & "CLP" & Separador                                 ' Moneda
                        Registro = Registro & Usr.GetNum("Banco").ToString.PadLeft(3, CChar("0")) & Separador        ' Codigo Banco
                        Registro = Registro & Replace(Formatea_Rut(Usr.GetText("Rut").Trim), "-", "") & Separador       ' Rut Beneficiario
                        Registro = Registro & Usr.GetText("NombreUsr").Trim & Separador               ' Nombre Beneficiario
                        Registro = Registro & wR.GetNum("TLiquido").ToString & Separador                  ' Monto
                        Registro = Registro & wGlosa & Separador                                ' Glosa TEF
                        Registro = Registro & Usr.GetText("Correo").Trim & Separador                        ' Correo
                        Registro = Registro & wGlosa & Separador                                ' Glosa Correo
                        Registro = Registro & wGlosa & Separador                                ' Glosa Cartola Wikets
                        Registro = Registro & wGlosa                                            ' Glosa Beneficiario

                        Archivo.Write(Registro + vbCrLf)
                    End If
                End If
            Next
            Archivo.Flush()
            Archivo.Close()
        End If

        If cFormato.Text = "BCI" Then
            Ruta = Directorio_TXT & "BCI_" & Now.Day.ToString.PadLeft(2, CChar("0")) & Now.Month.ToString.PadLeft(2, CChar("0")) & Now.Year.ToString.PadLeft(4, CChar("0")) & cTipo.Text
            Try
                File.Delete(Ruta)
            Catch ex As Exception
                'No existe el archivo
            End Try

            Archivo = File.AppendText(Ruta)

            'Cabecera
            'Registro = "Nº Cuenta de Cargo;Nº Cuenta de Destino;Banco Destino;Rut Beneficiario;Dig. Verif.;Beneficiario;Nombre Beneficiario;Monto Transferencia;Nro.Factura Boleta (1);Nº Orden de Compra(1);Tipo de Pago(2);Mensaje Destinatario (3);Email Destinatario(3);Cuenta Destino inscrita como(4)"
            'Archivo = File.AppendText(Ruta)

            For Each wR As DataRow In RmG.Rows
                Dim Usr = SQL("Select * from Usuarios where Usuario = '" + wR.GetText("Usuario") + "'").Top
                If Usr IsNot Nothing Then
                    If Usr.GetNum("Banco") = 0 Then
                        'No tiene cuenta corriente
                    Else
                        wGlosa = "Sueldo " & cMes.Text & " " & cAño.SelectedValue.ToString

                        qRut = Usr.GetText("Rut")
                        qRut = Replace(qRut, ".", "")
                        qRut = Replace(qRut, "-", "")
                        qRut = Mid(qRut, 1, Len(qRut) - 1)
                        qDig = UCase(Mid(Usr.GetText("Rut"), Len(Usr.GetText("Rut")), 1))

                        Registro = ""
                        If G_IDCLIENTE = Clientes.Wikets Then
                            Registro = Registro + "61991210" + Separador                            'Cuenta Origen
                        Else
                            Registro = Registro + "00000000" + Separador                            'Cuenta Origen
                        End If
                        Registro = Registro & Usr.GetText("CuentaCorriente") & Separador             'Cuenta estino
                        Registro = Registro & Usr.GetNum("Banco").ToString.PadLeft(3, CChar("0")) & Separador             'Codigo del Banco
                        Registro = Registro & qRut.PadLeft(8, CChar("0")) & Separador                           'Rut
                        Registro = Registro & qDig & Separador                                      'Digito Verificador
                        Registro = Registro & Texto_DTE(Usr.GetText("NombreUsr"), 45) & Separador     'Nombre del Receptor
                        Registro = Registro & wR.GetInt("TLiquido").ToString & Separador                      'Monto a pagar
                        Registro = Registro & "" & Separador                                        'N° Factura o Boleta
                        Registro = Registro & "" & Separador                                        'N° Orden de Compra
                        Registro = Registro & "REM" & Separador                                     'FAC:PAgo Factura   REM:REmuneraciones
                        Registro = Registro & Texto_DTE(wGlosa, 30) & Separador                'Glosa
                        Registro = Registro & Mid(Usr.GetText("Correo") + Space(30), 1, 30) & Separador    'Email
                        Registro = Registro & Texto_DTE(Usr.GetText("NombreUsr"), 25) & Separador     'Nombre de Cuenta

                        Archivo.Write(Registro + vbCrLf)
                    End If
                End If
            Next
            Archivo.Flush()
            Archivo.Close()
        End If

        Mensaje("Archivo Generado:" + vbCrLf + Ruta)

    End Sub

    Private Function Formatear_Rut(qRut As String) As String
        Formatear_Rut = qRut
        Formatear_Rut = Replace(Formatear_Rut, ".", "")
        Formatear_Rut = Replace(Formatear_Rut, "-", "")
        Formatear_Rut = Replace(Formatear_Rut, " ", "")

        Formatear_Rut = "000000000" + Formatear_Rut
        Formatear_Rut = Microsoft.VisualBasic.Strings.Right(Formatear_Rut, 10)
    End Function

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub
End Class