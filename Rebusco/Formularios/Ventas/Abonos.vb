Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions

Public Class Abonos
    Const T_FECHA = 0
    Const T_MONTO = 1
    Const T_FPAGOS = 2
    Const T_USUARIO = 3
    Const T_LOCAL = 4
    Const T_ESTADO = 5
    Const T_FECHAPAGO = 6
    Const T_DOCUMENTO = 7
    Const T_NUMERO = 8
    Const T_OBSERVACION = 9

    Private Sub xCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xCliente.KeyPress
        ValidarDigitos(e)
    End Sub

    Public Sub xCliente_Validating(Optional sender As Object = Nothing, Optional e As CancelEventArgs = Nothing) Handles xCliente.Validating
        If xCliente.Text <> "" Then
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Cliente = CInt(Val(xCliente.Text)))
            If wCli IsNot Nothing Then
                xNombre.Text = wCli.Nombre.ToUpper

                Dim wAbonos = DC.T_Abonos.Where(Function(x) x.Cliente = CInt(Val(xCliente.Text)))
                If wAbonos.Any() Then
                    Titulos()
                    xTabla.Redraw = False
                    Dim wFPago = DC.T_FPagos()
                    Dim wLocales = DC.T_Locales()
                    Dim wEstados = DC.T_Estados.Where(Function(x) x.Tipo = "P")
                    Dim wTipoDocs = DC.T_TipoDoc()
                    For Each wA In wAbonos
                        xTabla.AddItem("")
                        xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, wA.FechaAbono)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, FormatNumber(wA.Monto, 0,, TriState.True))
                        xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, wFPago.First(Function(x) x.FPago = wA.FPago).DescFPago)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, wA.Usuario)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, wLocales.FirstOrDefault(Function(x) x.Local = wA.Local).NombreLocal)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, wEstados.FirstOrDefault(Function(x) x.Estado = wA.Estado).DescEstado)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAPAGO, wA.FechaPago)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_DOCUMENTO, wTipoDocs.FirstOrDefault(Function(x) x.TipoDoc = wA.TipoDoc).DescTipoDoc)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_NUMERO, wA.NumDoc)
                        xTabla.SetData(xTabla.Rows.Count - 1, T_OBSERVACION, wA.Observaciones)
                    Next
                    xTabla.Redraw = True
                End If
            Else
                MsgError("El cliente indicado no existe")
                xCliente.Clear()
                xNombre.Clear()
            End If
        End If
    End Sub

    Private Sub Abonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
    End Sub

    Private Sub Abonos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cFPagos.LoadItemsObj("Fpagos", "Fpago", "DescFPago")
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = CInt(Val(LocalUsuario)))
        If wLocal IsNot Nothing Then
            xLocal.Text = wLocal.NombreLocal.ToUpper
        End If

        Dim wUsr = DC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = UsuarioActual)
        If wUsr IsNot Nothing Then
            xUsuario.Text = wUsr.NombreUsr.ToUpper
        End If
    End Sub

    Sub Titulos()

        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 10
        xTabla.Clear()

        xTabla.Cols(T_FECHA).Caption = "Fecha Crea."
        xTabla.Cols(T_MONTO).Caption = "Monto"
        xTabla.Cols(T_FPAGOS).Caption = "Forma Pago"
        xTabla.Cols(T_USUARIO).Caption = "Usuario Crea."
        xTabla.Cols(T_LOCAL).Caption = "Local"
        xTabla.Cols(T_ESTADO).Caption = "Estado"
        xTabla.Cols(T_FECHAPAGO).Caption = "Fecha Pago"
        xTabla.Cols(T_DOCUMENTO).Caption = "Tipo Doc."
        xTabla.Cols(T_NUMERO).Caption = "Nº Documento"
        xTabla.Cols(T_OBSERVACION).Caption = "Observaciòn"

        xTabla.Cols(T_FECHA).Width = 90
        xTabla.Cols(T_MONTO).Width = 90
        xTabla.Cols(T_FPAGOS).Width = 100
        xTabla.Cols(T_USUARIO).Width = 90
        xTabla.Cols(T_LOCAL).Width = 150
        xTabla.Cols(T_ESTADO).Width = 100
        xTabla.Cols(T_FECHAPAGO).Width = 100
        xTabla.Cols(T_DOCUMENTO).Width = 90
        xTabla.Cols(T_NUMERO).Width = 90
        xTabla.Cols(T_OBSERVACION).Width = 160

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If xCliente.Text = "" Then
            MsgError("Debe indicar cliente")
            Exit Sub
        End If

        If xUsuario.Text = "" Then
            MsgError("Error en usuario creador, vuelva a intentarlo")
            Exit Sub
        End If

        If xFecha.Value.ToShortDateString < Now.ToShortDateString Then
            MsgError("La fecha del Abono no debe ser menor a la del dìa actual")
            Exit Sub
        End If

        If xMonto.Text = "" Then
            MsgError("Debe indicar monto del Abono")
            Exit Sub
        End If

        If cFPagos.Text = "" Then
            MsgError("Debe indicar forma de pago del Abono")
            Exit Sub
        End If

        If xObservacion.Text = "" Then
            If Not Pregunta("Desea ingresar un Abono sin Observaciòn") Then
                Exit Sub
            End If
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wAbono = New T_Abonos With {
            .Cliente = CInt(xCliente.Text),
            .FechaAbono = Now(),
            .Monto = CInt(xMonto.Text),
            .FPago = cFPagos.SelectedValue.ToString,
            .Usuario = UsuarioActual,
            .Local = G_LOCALACTUAL,
            .Estado = "P",
            .Observaciones = xObservacion.Text,
            .FechaPago = New Date(2000, 1, 1),
            .TipoDoc = "SD",
            .NumDoc = 0
        }
        DC.T_Abonos.InsertOnSubmit(wAbono)
        DC.SubmitChanges()

        Dim wLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = G_LOCALACTUAL)

        If xTabla.Rows.Count = 1 Then Titulos()


        xTabla.AddItem("")
        xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA, Now)
        xTabla.SetData(xTabla.Rows.Count - 1, T_MONTO, FormatNumber(xMonto.Text,,, TriState.True, 0))
        xTabla.SetData(xTabla.Rows.Count - 1, T_FPAGOS, cFPagos.Text)
        xTabla.SetData(xTabla.Rows.Count - 1, T_USUARIO, UsuarioActual)
        xTabla.SetData(xTabla.Rows.Count - 1, T_LOCAL, If(wLocal IsNot Nothing, wLocal.NombreLocal, ""))
        xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, "Pendiente")
        xTabla.SetData(xTabla.Rows.Count - 1, T_FECHAPAGO, "01/01/2000")
        xTabla.SetData(xTabla.Rows.Count - 1, T_DOCUMENTO, "SD")
        xTabla.SetData(xTabla.Rows.Count - 1, T_NUMERO, 0)
        xTabla.SetData(xTabla.Rows.Count - 1, T_OBSERVACION, xObservacion.Text)

        Mensaje("Abono guardado correctamente")
        Auditoria(Text, "Registro de Abono", "Cliente :" & xCliente.Text & " Monto: " & xMonto.Text, UsuarioActual)

    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

        If xCliente.Text = "" Then
            MsgError("Debe indicar Cliente")
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wListaClientes = DC.T_Clientes.ToList
        Dim wListaEstados = DC.T_Estados.Where(Function(x) x.Tipo = "P").ToList
        Dim wListaFPagos = DC.T_FPagos.ToList
        Dim wListaLocales = DC.T_Locales.ToList
        Dim wListaTipoDoc = DC.T_TipoDoc.ToList
        Dim wListaUsuarios = DC.T_Usuarios.ToList

        Dim wListaAbono = DC.T_Abonos.Where(Function(x) x.Cliente = CInt(xCliente.Text)).ToList

        Dim wListaReporte As New List(Of AbonosReporte)
        For Each wA In wListaAbono
            wListaReporte.Add(New AbonosReporte With {.Documento = wListaTipoDoc.FirstOrDefault(Function(x) x.TipoDoc = wA.TipoDoc).DescTipoDoc,
                                                  .Estado = wListaEstados.FirstOrDefault(Function(x) x.Estado = wA.Estado).DescEstado,
                                                  .FechaAbono = wA.FechaAbono,
                                                  .FechaPago = wA.FechaPago,
                                                  .FPago = wListaFPagos.FirstOrDefault(Function(x) x.FPago = wA.FPago).DescFPago,
                                                  .Monto = wA.Monto,
                                                  .NombreCliente = wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Nombre,
                                                  .NombreLocal = wListaLocales.FirstOrDefault(Function(x) x.Local = wA.Local).NombreLocal,
                                                  .Numero = wA.NumDoc,
                                                  .Observacion = wA.Observaciones,
                                                  .RutCliente = wListaClientes.FirstOrDefault(Function(x) x.Cliente = wA.Cliente).Rut,
                                                  .Usuario = wA.Usuario})
        Next

        If wListaReporte.Any() Then
            Dim wReporte As New ReporteAbonos
            Dim wListaParametros = ParametroReporte()
            wReporte.Database.Tables("MarKetONE_RT_Abonos").SetDataSource(wListaReporte)
            wReporte.Database.Tables("MarKetONE_ParametrosReporte").SetDataSource(wListaParametros)
            VisorReportes.MostrarReporte(wReporte)
            VisorReportes.Show()
            VisorReportes.BringToFront()
        Else
            MsgError("No se encuentras abonos para el cliente indicado")
        End If
    End Sub
End Class