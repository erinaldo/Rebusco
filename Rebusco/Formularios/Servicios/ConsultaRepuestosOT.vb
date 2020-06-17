Imports System.ComponentModel

Public Class ConsultaRepuestosOT
    Const T_ID As Integer = 0
    Const T_OT As Integer = 1
    Const T_ARTICULO As Integer = 2
    Const T_DESCRIPCION As Integer = 3
    Const T_CANTIDAD As Integer = 4
    Const T_FECHA_SOLICITADA As Integer = 5
    Const T_FECHA_ENTREGA As Integer = 6
    Const T_ESTADO As Integer = 7
    Const T_TECNICO As Integer = 8
    Private Sub xOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xOT.KeyPress
        ValidarDigitos(e)
        e.NextControl(cEstados)
    End Sub

    Private Sub cEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cEstados.SelectedIndexChanged
        xArticulo.Focus()
    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(xTecnico)
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.ListaVisible Then
            If xArticulo.ListaActiva Then
                Exit Sub
            Else
                xArticulo.OcultarLista()
            End If
        End If

        If Trim(xArticulo.Text) = "" Then
            xNombreArticulo.Clear()
            Exit Sub
        End If

        If xArticulo.DescEncontrada = "" Then
            Dim wIDArticulo = ObtenerArticulo(xArticulo.Text)
            Dim DC = New MarketONEDataContext(P_CONEXION)
            Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = wIDArticulo.ToDecimal())
            If wArt IsNot Nothing Then
                xArticulo.AutoCompletarActivo = False
                xArticulo.Text = wArt.Articulo.ToString()
                xnombrearticulo.Text = wArt.Descripcion
                xArticulo.AutoCompletarActivo = True
                Exit Sub
            End If

            'Dim wSer = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = xArticulo.Text.ToDecimal)
            'If wSer IsNot Nothing Then
            '    xDescripcion.Text = wSer.Descripcion
            '    Exit Sub
            'End If
            Informacion("Artículo no encontrado")
            xNombreArticulo.Clear()
            xArticulo.Clear()
            xArticulo.Focus()
        Else
            xArticulo.AutoCompletarActivo = False
            'xArticulo.Text = xArticulo.IdEncontrado
            xNombreArticulo.Text = xArticulo.DescEncontrada
            xArticulo.AutoCompletarActivo = True
        End If
    End Sub

    Private Sub xTecnico_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xTecnico.Validating
        If xTecnico.Text.Trim <> "" Then
            cTecnicos.SelectedValue = xTecnico.Text.Trim
            If cTecnicos.Text = W_SELECCIONAR Then
                MsgError("Técnico no encontrado")
                xTecnico.Clear()
                xTecnico.Focus()
            End If
            bBuscar.Focus()
        End If
    End Sub

    Private Sub cTecnicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cTecnicos.SelectedIndexChanged
        If cEstados.Text <> "" Then
            xTecnico.Text = cTecnicos.SelectedValue.ToString
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarCampos(Me)
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bMostrar_Click(sender As Object, e As EventArgs) Handles bMostrar.Click
        Dim wFiltro As String

        If oFechaSol.Checked Then
            wFiltro = " od.FechaSol Between '" & cDesde.Value & "' AND '" & cHasta.Value & "'"
        Else
            wFiltro = " od.FechaEnt Between '" & cDesde.Value & "' AND '" & cHasta.Value & "'"
        End If

        If xOT.Text.Trim <> "" Then
            wFiltro = wFiltro & " And O.OT=" & xOT.Text.Trim
        End If

        If cEstados.Text.Trim <> "" Then
            wFiltro = wFiltro & " And od.Estado='" & cEstados.SelectedValue.ToString & "' "
        End If

        If xArticulo.Text.Trim <> "" Then
            wFiltro = wFiltro & " And od.Articulo='" & xArticulo.Text.Trim & "' "
        End If

        If cTecnicos.Text.Trim <> "" Then
            wFiltro = wFiltro & " And o.Tecnico='" & xTecnico.Text.Trim & "' "
        End If

        Dim wOT = SQL("SELECT o.OT,od.Articulo,a.Descripcion,od.Cantidad,od.FechaSol, " &
                 " od.FechaEnt,e.DescEstado,u.NombreUsr " &
                 " FROM OT o INNER JOIN OTDet od on o.OT=od.OT AND od.Tipo='A'" &
                 " INNER JOIN Articulos A on od.Articulo=a.Articulo " &
                 " INNER JOIN Estados e on o.Estado=e.Estado AND e.Tipo='O' " &
                 " INNER JOIN Usuarios u on o.Tecnico=u.Usuario" &
                 " WHERE " & wFiltro)

        If wOT.Rows.Count = 0 Then
            MsgError("No hay Datos para Cargar")
            Exit Sub
        End If
        Titulos()

        For Each wO As DataRow In wOT.Rows
            xTabla.AddItem("")
            xTabla.SetData(xTabla.Rows.Count - 1, T_OT, wO.GetText("OT"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ARTICULO, wO.GetText("Articulo"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_DESCRIPCION, wO.GetText("Descripcion"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_CANTIDAD, wO.GetText("Cantidad"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA_SOLICITADA, wO.GetText("FechaSol"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_FECHA_ENTREGA, wO.GetText("FechaEnt"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_ESTADO, wO.GetText("DescEstado"))
            xTabla.SetData(xTabla.Rows.Count - 1, T_TECNICO, wO.GetText("NombreUsr"))
        Next
        xTabla.AjustarColumnas
    End Sub
    Sub Titulos()
        xTabla.Clear()
        xTabla.Rows.Count = 1
        xTabla.Cols.Count = 9

        xTabla.Cols(T_ID).Width = 0
        xTabla.Cols(T_OT).Width = 60
        xTabla.Cols(T_ARTICULO).Width = 100
        xTabla.Cols(T_DESCRIPCION).Width = 150
        xTabla.Cols(T_CANTIDAD).Width = 60
        xTabla.Cols(T_FECHA_SOLICITADA).Width = 120
        xTabla.Cols(T_FECHA_ENTREGA).Width = 120
        xTabla.Cols(T_ESTADO).Width = 100
        xTabla.Cols(T_TECNICO).Width = 130

        xTabla.Cols(T_ID).Caption = ""
        xTabla.Cols(T_OT).Caption = "OT"
        xTabla.Cols(T_ARTICULO).Caption = "Artículo"
        xTabla.Cols(T_DESCRIPCION).Caption = "Descripción"
        xTabla.Cols(T_CANTIDAD).Caption = "Cantidad"
        xTabla.Cols(T_FECHA_SOLICITADA).Caption = "F.Solicitada"
        xTabla.Cols(T_FECHA_ENTREGA).Caption = "F.Entrega"
        xTabla.Cols(T_ESTADO).Caption = "Estado OT"
        xTabla.Cols(T_TECNICO).Caption = "Técnico"

    End Sub

    Private Sub oFechaSol_CheckedChanged(sender As Object, e As EventArgs)
        Dim wRadioButton As RadioButton = DirectCast(sender, RadioButton)
        wRadioButton.ForeColor = If(wRadioButton.Checked, Color.White, Color.Black)

        wRadioButton.Image = If(wRadioButton.Checked, My.Resources.Resources.check16true_b,
                                                    My.Resources.Resources.check16false_b)
    End Sub

    Private Sub ConsultaRepuestosOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cDesde.Value = IniFinFecha(1, Now)
        cHasta.Value = IniFinFecha(2, Now)
        cTecnicos.LoadItemsObj("Usuarios", "Usuario", "NombreUsr", " WHERE Acceso = 3")
        cEstados.LoadItemsObj("Estados", "Estado", "DescEstado", " WHERE Tipo = 'O'")
        Titulos()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

    End Sub
End Class