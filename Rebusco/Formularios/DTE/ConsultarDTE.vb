Public Class ConsultarDTE

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub ConsultarDTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", " WHERE FElectronica = 1 Order by Local")
        cTipoDoc.LoadItemsObj("TipoDoc", "TipoDoc", "DescTipoDoc", " WHERE Cod_SII > 0 Order by DescTipoDoc")
        Auditoria(Text, A_INGRESADO, "", "")
        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If
    End Sub
    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        Consultar_Datos()
    End Sub

    Sub Consultar_Datos()
        Dim wLocal As Double, wRut As String

        xStatus.Text = ""

        If cLocal.Text.Trim = "" Then
            MsgError("Falta Local")
            Exit Sub
        End If
        If cTipoDoc.Text.Trim = "" Then
            MsgError("Falta Tipo Documento")
            Exit Sub
        End If
        If Val(xNumero.Text.Trim) = 0 Then
            MsgError("Falta Número de Documento")
            Exit Sub
        End If

        If cLocal.Text <> "" Then
            wLocal = CInt(cLocal.SelectedValue.ToString)
        End If


        Dim wDocG = SQL("Select * from DocumentosG WHERE Local = " & Val(cLocal.SelectedValue) & "" &
                        " And TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Documento no encontrado")
            Exit Sub
        End If
        Dim wDocD = SQL("Select * from DocumentosD WHERE Local = " & Val(cLocal.SelectedValue) & "" &
                        " And TipoDoc = '" & cTipoDoc.SelectedValue.ToString & "' and Numero = " & Val(xNumero.Text)).Top
        If wDocG Is Nothing Then
            MsgError("Detalles del Documento no encontrados")
            Exit Sub
        End If

        Dim wCli = SQL("Select * from Clientes WHERE Cliente = " & Val(wDocG.GetText("Cliente"))).Top
        If wCli Is Nothing Then
            MsgError("Cliente del documento no encontrado")
            Exit Sub
        End If
        wRut = wCli.gettext("Rut")
        Cursor = Cursors.WaitCursor
        'Parametrizar FE con datos del Local
        If Not DTE.Parametros_DTE(wLocal) Then
            MsgError("Error al sacar parámetros del Local")
            Cursor = Cursors.Arrow
            Exit Sub
        End If

        xStatus.Text = ""
        xStatus.Text += "Estado: " + DTE.Consultar_DTE(1, cTipoDoc.SelectedValue.ToString, Val(xNumero.Text)).Item2 + vbCrLf
        xStatus.Text += "ID Seguimiento: " + DTE.Consultar_DTE(2, cTipoDoc.SelectedValue.ToString, Val(xNumero.Text)).Item2.ToString + vbCrLf
        xStatus.Text += "Observaciones: " + DTE.Consultar_DTE(3, cTipoDoc.SelectedValue.ToString, Val(xNumero.Text)).Item2 + vbCrLf
        Auditoria(Text, "Consulta", xNumero.Text.Trim, cTipoDoc.Text)
        Cursor = Cursors.Arrow

    End Sub

    'EJEMPLO

    'Dim apiURL As String
    'Dim apiAuth As String
    'apiURL = FE_DTE
    'apiAuth = FE_Llave

    ''Llamada al servicio

    'Dim ambiente As DTEBoxCliente.Ambiente
    'ambiente = DTEBoxCliente.Ambiente.Produccion

    'Dim grupo As DTEBoxCliente.GrupoBusqueda
    'grupo = DTEBoxCliente.GrupoBusqueda.Emitidos

    'Dim rut As String
    'rut = "76235899-9"
    'Dim tipoDocumento As DTEBoxCliente.TipoDocumento
    'tipoDocumento = DTEBoxCliente.TipoDocumento.TIPO_33
    'Dim folio As Long
    'folio = 1077

    'Dim service As DTEBoxCliente.Servicio
    'service = New DTEBoxCliente.Servicio(apiURL, apiAuth)

    'Dim resultado As DTEBoxCliente.ResultadoEstadoFiscal
    'resultado = service.EstadoFiscal(ambiente, grupo, rut, tipoDocumento, folio)

    ''Fin Llamada al servicio

    ''Procesar resultado

    ''Resultado de la operación (OK: Exitosa, Error: No exitosa)
    'If (resultado.ResultadoServicio.Estado = DTEBoxCliente.EstadoResultado.Ok) Then
    '    'Usar los datos que viene en el resultado de la llamada

    '    'Estado:
    '    '0: si el documento fue autorizado
    '    '1: si la resolución del SII está pendiente
    '    '2: si el documento fue autorizado, pero con observaciones o reparos
    '    '9: si el documento fue rechazado
    '    Dim estado As String
    '    estado = resultado.Estado
    '    Mensaje(estado.ToString)
    '    'TrackId que entregó el SII con la autorización del documento.
    '    Dim idSeguimiento As String
    '    idSeguimiento = resultado.IdSeguimiento
    '    Mensaje(idSeguimiento.ToString)
    '    'Comentarios asociados al estado de autorización.
    '    Dim comentarios As String
    '    comentarios = resultado.Comentarios
    '    Mensaje(comentarios.ToString)
    '    'Código de usuario a partir de aquí
    'Else 'Si la operación no fue exitosa

    '    'Descripción del error en caso que la operación no fuese exitosa
    '    Dim description As String
    '    description = resultado.ResultadoServicio.Descripcion
    '    Mensaje(description.ToString)
    'End If

End Class