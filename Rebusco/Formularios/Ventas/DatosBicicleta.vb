Imports System.ComponentModel

Public Class DatosBicicleta
    Dim wCerrar As Boolean = False
    Private Sub DatosBicicleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal")
        cFPago.LoadItemsObj("FPagos", "FPago", "DescFPago")
    End Sub

    Private Sub DatosBicicleta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        xAño.Value = Now.Year
        CargarDatos()
    End Sub
    Public Sub xRut_Validating(Optional sender As Object = Nothing, Optional e As System.ComponentModel.CancelEventArgs = Nothing) Handles xRut.Validating
        Dim wClienteRegistrado As Boolean = False

        If xRut.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim = "" Then
            Exit Sub
        End If

        If Not VerificarRut(xRut.Text) Then
            MsgError("Rut Invalido")
            xRut.Clear()
            xRut.Text = "__.___.___-_"
            xCliente.Text = ""
            xNombre.Text = ""
            xCorreo.Text = ""
            xDireccion.Text = ""
            xTelefono.Text = ""
            cCiudad.SelectedIndex = -1
            cComuna.SelectedIndex = -1
            xRut.Focus()
        End If

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = xRut.Text.Replace(",", "."))

        cComuna.LoadItemsObj("Comunas", "Codigo", "NombreComuna")
        cCiudad.LoadItemsObj("Comunas", "Codigo", "NombreComuna")

        If wCli IsNot Nothing Then
            xCliente.Text = wCli.Cliente.ToString
            xNombre.Text = wCli.Nombre
            xCorreo.Text = wCli.Email
            xDireccion.Text = wCli.Direccion
            xTelefono.Text = wCli.Telefonos
            Dim wCiu = DC.T_Comunas.FirstOrDefault(Function(x) x.Codigo = wCli.Comuna)
            If wCiu IsNot Nothing Then
                cCiudad.SelectedValue = wCiu.Codigo
                cComuna.SelectedValue = wCiu.Codigo
            End If
        Else

            If Pregunta("El cliente indicado no se encuentra registrado, ¿Desea Registralo?") Then
                ManCliente.xRut.Text = xRut.Text
                ManCliente.ShowDialog()
            End If

        End If

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Trim(cLocal.Text) = "" Then
            MsgError("Falta ingresar un Local")
            cLocal.Focus()
            Exit Sub
        End If

        If Trim(cFPago.Text) = "" Then
            MsgError("Falta ingresar una Forma de Pago")
            cFPago.Focus()
            Exit Sub
        End If

        If Trim(xDocumento.Text) = "" Then
            MsgError("Falta ingresar un número de Documento")
            xDocumento.Focus()
            Exit Sub
        End If

        If Trim(xMarca.Text) = "" Then
            MsgError("Falta ingresar una Marca")
            xMarca.Focus()
            Exit Sub
        End If

        If Trim(xModelo.Text) = "" Then
            MsgError("Falta ingresar un Modelo")
            xModelo.Focus()
            Exit Sub
        End If

        If Trim(xColor.Text) = "" Then
            MsgError("Falta ingresar un Color")
            xColor.Focus()
            Exit Sub
        End If

        If Trim(xTalla.Text) = "" Then
            MsgError("Falta ingresar una Talla")
            xTalla.Focus()
            Exit Sub
        End If

        If Trim(xAño.Text) = "" Then
            MsgError("Falta ingresar un Año")
            xAño.Focus()
            Exit Sub
        End If

        If Trim(xSKU.Text) = "" Then
            MsgError("Falta ingresar un Código / Sku")
            xSKU.Focus()
            Exit Sub
        End If

        If Trim(xSerie.Text) = "" Then
            MsgError("Falta ingresar un Número de Serie")
            xSerie.Focus()
            Exit Sub
        End If

        If Trim(xRut.Text) = "__.___.___-_" Then
            MsgError("Falta ingresar un Cliente")
            xRut.Focus()
            Exit Sub
        End If

        If Not VerificarRut(xRut.Text) Then
            MsgError("Rut Incorrecto.")
            xRut.Text = "__.___.___-_"
            xRut.Focus()
            Exit Sub
        End If

        If Trim(xNombre.Text) = "" Then
            MsgError("Falta ingresar el Nombre del Cliente")
            xNombre.Focus()
            Exit Sub
        End If

        If Trim(xCorreo.Text) = "" Then
            MsgError("Falta ingresar un correo")
            xCorreo.Focus()
            Exit Sub
        End If

        If cComuna.SelectedIndex = -1 Then
            MsgError("Falta ingresar Ciudad")
            cComuna.Focus()
            Exit Sub
        End If

        If Trim(xDireccion.Text) = "" Then
            MsgError("Falta ingresar una dirección")
            xDireccion.Focus()
            Exit Sub
        End If

        If Trim(xTelefono.Text) = "" Then
            MsgError("Falta ingresar un teléfono")
            xTelefono.Focus()
            Exit Sub
        End If
        If Not Pregunta("¿Desea registrar estos datos?") Then
            Exit Sub
        End If
        GuardarDatos()
    End Sub

    Sub GuardarDatos()

        Dim DC = New MarketONEDataContext(P_CONEXION)
        Dim wDat As New T_Control_Articulos
        Dim qDAT = DC.T_Control_Articulos.FirstOrDefault(Function(x) x.Documento = xDocumento.Text.Trim And
                                                                      x.Serie = xSerie.Text.Trim And
                                                                      x.Cliente = xCliente.Text.Trim)

        If qDAT IsNot Nothing Then wDat = qDAT

        wDat.Local = cLocal.SelectedValue.ToString
        wDat.Fecha = Now
        wDat.FPago = cFPago.SelectedValue.ToString
        wDat.Documento = xDocumento.Text.Trim
        wDat.Marca = xMarca.Text.Trim
        wDat.Modelo = xModelo.Text.Trim
        wDat.Color = xColor.Text.Trim
        wDat.Talla = xTalla.Text.Trim
        wDat.Año = CInt(xAño.Text.Trim)
        wDat.SKU = xSKU.Text.Trim
        wDat.Serie = xSerie.Text.Trim
        wDat.Articulo = Convert.ToDecimal(lCodigo.Text)
        wDat.Cliente = xCliente.Text.Trim

        If qDAT Is Nothing Then
            DC.T_Control_Articulos.InsertOnSubmit(wDat)
        End If


        Dim wCli = DC.T_Clientes.FirstOrDefault(Function(x) x.Rut = xRut.Text.Trim)

        If wCli IsNot Nothing Then
            If xNombre.Text.Trim <> wCli.Nombre Or
                xCorreo.Text.Trim <> wCli.Email Or
                xDireccion.Text.Trim <> wCli.Direccion Or
                xTelefono.Text.Trim <> wCli.Telefonos Or
                cCiudad.SelectedValue.ToString <> wCli.Ciudad Or
                cComuna.SelectedValue.ToString <> wCli.Comuna Then

                If Pregunta("Hay diferencias en los campos del Cliente" & vbCrLf & "¿Desea actualizar los datos del Cliente?") Then
                    wCli.Nombre = xNombre.Text.Trim
                    wCli.Email = xCorreo.Text.Trim
                    wCli.Direccion = xDireccion.Text.Trim
                    wCli.Telefonos = xTelefono.Text.Trim
                    wCli.Ciudad = cCiudad.SelectedValue.ToString
                    wCli.Comuna = cComuna.SelectedValue.ToString
                End If

            End If
        End If

        DC.SubmitChanges()
        VentaLocal.gSerie = Trim(xSerie.Text)
        VentaLocal.gGuardarDatos = True
        Mensaje("Datos ingresados correctamente")
        Auditoria(Me.Name, "Datos de la Bicicleta", xRut.Text, xSKU.Text)
        If Pregunta("¿Desea imprimir la ficha técnica?") Then
            GenerarReporte()
        End If
        wCerrar = True
        Close()
    End Sub
    Sub GenerarReporte()
        Dim DC = New MarketONEDataContext(P_CONEXION)

        Dim wControlArticulo = DC.T_Control_Articulos.FirstOrDefault(Function(x) x.Documento = xDocumento.Text And
                                                                          x.Cliente = xCliente.Text)
        If wControlArticulo Is Nothing Then
            MsgError("Error al generar la ficha técnica")
            Exit Sub
        End If

        Dim wCliente = DC.T_Clientes.FirstOrDefault(Function(X) X.Cliente = xCliente.Text.ToDecimal())
        Dim wDatosBicicleta As New DatosBicicletaVenta
        Dim wDescripcionFPago = DC.T_FPagos.FirstOrDefault(Function(x) x.FPago = wControlArticulo.FPago)
        Dim wNombreLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = wControlArticulo.Local.ToDecimal)
        Dim wParametrosLocal = ParametroLocal()
        wDatosBicicleta.FPago = wDescripcionFPago.DescFPago
        wDatosBicicleta.Tienda = wNombreLocal.NombreLocal

        Dim wReporte As New ReporteControlArticulo
        wReporte.Database.Tables("MarketONE_T_Clientes").SetDataSource({wCliente}.ToList())
        wReporte.Database.Tables("MarketONE_T_Control_Articulos").SetDataSource({wControlArticulo}.ToList())
        wReporte.Database.Tables("MarketONE_ParametrosLocal").SetDataSource(wParametrosLocal)
        wReporte.Database.Tables("MarketONE_DatosBicicletaVenta").SetDataSource({wDatosBicicleta}.ToList())

        VisorReportes.Visor.ReportSource = wReporte
        VisorReportes.Show()
        VisorReportes.BringToFront()
    End Sub
    Private Sub DatosBicicleta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not wCerrar Then
            MsgError("No se puede cerrar este formulario sin antes registrar los datos")
            e.Cancel = True
            Exit Sub
        End If
    End Sub
    Public Sub CargarDatos()
        Dim DC As New MarketONEDataContext(P_CONEXION)

        Dim wControlArticulo = DC.T_Control_Articulos.FirstOrDefault(Function(x) x.Documento = xDocumento.Text.Trim And
                                                                      x.Cliente = xCliente.Text.Trim And
                                                                      x.Serie = xSerie.Text.Trim)

        If wControlArticulo Is Nothing Then Exit Sub

        cLocal.SelectedValue = wControlArticulo.Local
        cFPago.SelectedValue = wControlArticulo.FPago

        xDocumento.Text = wControlArticulo.Documento
        xMarca.Text = wControlArticulo.Marca
        xModelo.Text = wControlArticulo.Modelo
        xColor.Text = wControlArticulo.Color
        xTalla.Text = wControlArticulo.Talla
        xAño.Text = wControlArticulo.Año.ToString
        xSKU.Text = wControlArticulo.SKU
        xSerie.Text = wControlArticulo.Serie
        xCliente.Text = wControlArticulo.Cliente
    End Sub


    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub xColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xColor.KeyPress
        e.NextControl(xTalla)
    End Sub

    Private Sub xMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xMarca.KeyPress
        e.NextControl(xModelo)
    End Sub

    Private Sub xModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xModelo.KeyPress
        e.NextControl(xColor)
    End Sub

    Private Sub xTalla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xTalla.KeyPress
        e.NextControl(xAño)
    End Sub

    Private Sub xAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xAño.KeyPress
        e.NextControl(xSKU)
    End Sub

    Private Sub xSKU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xSKU.KeyPress
        e.NextControl(xSerie)
    End Sub
End Class
Public Class DatosBicicletaVenta
    Public Property Tienda As String
    Public Property FPago As String
End Class
