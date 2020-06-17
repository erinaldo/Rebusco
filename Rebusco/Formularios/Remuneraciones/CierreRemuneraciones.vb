Public Class CierreRemuneraciones
    Const T_ID = 0
    Const T_MARCA = 1
    Const T_USUARIO = 2
    Const T_MONTO = 3
    Const T_MODO = 4

    Const M_EFE = "EFECTIVO"
    Const M_DEP = "DEPÓSITO"
    Const M_NOC = "NO CANCELADA"
    Const M_PEN = "PENDIENTE"
    Const M_BLA = ""
    Private Sub CerrarRemuneraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cAño.AñosMes("A")
        cMes.AñosMes("M")

        If Now.Month = 1 Then
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now) - 1).ToString
        Else
            cMes.SelectedValue = Now.AddMonths(-1).Month.ToString
            cAño.Text = Val(Year(Now)).ToString
        End If


        Titulos()
        Auditoria(Me.Text, A_INGRESADO, "", "")
    End Sub
    Sub Titulos()

        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 5

        xTabla.Cols(T_ID).Caption = "ID"
        xTabla.Cols(T_MARCA).Caption = "Entregado"
        xTabla.Cols(T_USUARIO).Caption = "Funcionario"
        xTabla.Cols(T_MONTO).Caption = "Sueldo Líquido"
        xTabla.Cols(T_MODO).Caption = "Modo Pago"

        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_MARCA).Width = 100
        xTabla.Cols(T_USUARIO).Width = 375
        xTabla.Cols(T_MONTO).Width = 140
        xTabla.Cols(T_MODO).Width = 160

        Dim cFPagos As New ComboBox
        cFPagos.DropDownStyle = ComboBoxStyle.DropDownList
        LoadComboGrilla(cFPagos, "FPagos", "FPago", "DescFPago")
        xTabla.Cols(T_MODO).Editor = cFPagos

        xTabla.Cols(T_MARCA).DataType = GetType(Boolean)
    End Sub

    Private Sub bMostrar_Click(sender As Object, e As EventArgs) Handles bMostrar.Click
        Titulos()
        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaUsuario = DC.T_Usuarios.ToList()
        Dim wListaFPAgos = DC.T_FPagos.ToList()
        Dim wRmg = SQL("Select * from Sueldos where Cancelado = 0 and Año =" & Val(cAño.Text) & " and Mes = " & Val(cMes.SelectedValue.ToString) & " And estado = 0")

        For Each wR As DataRow In wRmg.Rows
            DoEvents()
            xTabla.AddItem("")
            xTabla.SetData(xTabla.Rows.Count - 1, T_MARCA, CHECK)
            xTabla.SetData(xTabla.Rows.Count - 1, T_ID, wR.GetText("Id"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wListaUsuario.FirstOrDefault(Function(x) x.Usuario = wR.GetText("USuario")).NombreUsr)
            xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, Val(wR.GetText("TLiquido")))
            If wR.GetText("ModoPago") = "" Then
                xTabla.SetData(xTabla.Rows.Count - 1, T_MODO, "")
            Else
                xTabla.SetData(xTabla.Rows.Count - 1, T_MODO, wListaFPAgos.FirstOrDefault(Function(x) x.FPago = wR.GetText("ModoPago")).DescFPago)
            End If
        Next

    End Sub

    Public Function SacaModo(mModo As String) As String
        If mModo = "" Then
            Return ""
        End If

        If mModo = "E" Then
            Return M_EFE
        End If
        If mModo = "D" Then
            Return M_DEP
        End If
        If mModo = "P" Then
            Return M_PEN
        End If
        If mModo = "N" Then
            Return M_NOC
        End If
        If mModo = "" Or mModo = " " Then
            Return M_BLA
        End If

        Return ""
    End Function

    Private Sub xTabla_Click(sender As Object, e As EventArgs) Handles xTabla.Click
        If xTabla.Col = T_MARCA Then
            Dim wCheck = Not CBool(xTabla.GetData(xTabla.Row, T_MARCA))
            xTabla.SetData(xTabla.Row, T_MARCA, wCheck)
        End If
        If xTabla.Col = T_MODO Then
            xTabla.StartEditing()
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        cAño.SelectedValue = Now.Year.ToString
        cMes.SelectedValue = Now.Month.ToString
        Titulos()
        cAño.Focus()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim F1 As Date, F2 As Date

        If Pregunta("Desea Cerrar Remuneraciones para Personal Marcado") = False Then
            Exit Sub
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaFPagos = DC.T_FPagos.ToList()

        For i As Integer = 1 To xTabla.Rows.Count - 1
            If CBool(xTabla.GetData(i, T_MARCA)) = CHECK Then
                Dim wSueldos = DC.T_Sueldos.FirstOrDefault(Function(x) x.Id = CInt(xTabla.GetData(i, T_ID)))

                If wSueldos IsNot Nothing Then

                    If xTabla.GetData(i, T_MODO).ToString = "" Then
                        MsgError("Debe seleccionar un modo de pago")
                        Exit Sub
                    End If

                    wSueldos.Estado = "1"
                    wSueldos.Cancelado = True
                    wSueldos.ModoPago = wListaFPagos.FirstOrDefault(Function(x) x.FPago = xTabla.GetData(i, T_MODO).ToString).FPago
                    wSueldos.FechaPago = Now
                    wSueldos.Usuario = UsuarioActual

                    F1 = IniFinFecha(1, CDate("01/01/2000"))
                    F2 = IniFinFecha(2, CDate("01/" & cMes.SelectedIndex + 1 & "/" & cAño.SelectedIndex + 1))
                    SQLUpdate("Update Sueldos_Detalles Set Estado = 1 Where Fecha >= '01/01/2000'" &
                              " And Fecha <= '" & FormatDateTime(F2, DateFormat.ShortDate) & "' and Estado = 0 and Usuario = '" & wSueldos.Usuario & "'")
                Else
                    MsgError("Error en Remuneración N° " & xTabla.GetData(i, T_ID).ToString)
                End If
            End If
        Next i

        Mensaje("Proceso Finalizado")
        Auditoria(Me.Text, A_GUARDADO, "", "0")
        Titulos()
        cAño.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
End Class