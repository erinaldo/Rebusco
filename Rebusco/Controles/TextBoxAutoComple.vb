Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public Class TextBoxAutoComple
    Inherits TextBox

    Public Delegate Sub DelItemSeleccionado(ByVal wDescripcion As String)
    Public Event ItemSeleccionado(wDescripcion As String)
    Private _Descripcion As String = ""
    Private _IDBusqueda As String = ""
    Private _DescBusqueda As String = ""
    Private _Tabla As String = ""
    Private _IntervaloBusquedaTexto As Integer = 3
    Private _IntervaloBusquedaNumeros As Integer = 1
    Private _AnchoLista As Integer = 100
    Private DatosPreCargados As Boolean = False
    Private _IdEncontrado As String = ""
    Private _DescEncontrada As String = ""
    Private _DescAdicional As String = ""
    Private _DescAdicional2 As String = ""
    Private _AutoCompletarActivo As Boolean = True
    Private _Filtro As String = ""
    Private _CampoMostrar As Campo = Campo.ID

    Public Enum Campo
        ID = 1
        Desc = 2
    End Enum

    <Category("### DataTextbox ###"),
    Description("ID Encontrado")>
    Public Property CampoMostrar As Campo
        Get
            Return _CampoMostrar
        End Get
        Set(value As Campo)
            _CampoMostrar = value
        End Set
    End Property


    <Category("### DataTextbox ###"),
    Description("Autocompletar Activo")>
    Public Property AutoCompletarActivo As Boolean
        Get
            Return _AutoCompletarActivo
        End Get
        Set(value As Boolean)
            _AutoCompletarActivo = value
        End Set
    End Property

    <Category("### DataTextbox ###"),
    Description("ID Encontrado")>
    Public ReadOnly Property IdEncontrado As String
        Get
            Return _IdEncontrado
        End Get
    End Property

    <Category("### DataTextbox ###"),
    Description("Descripción Encontrada")>
    Public ReadOnly Property DescEncontrada As String
        Get
            If _DescEncontrada = "" OrElse Text <> _IdEncontrado Then
                If DatosPreCargados Then
                    Dim wItem = gListaItems.FirstOrDefault(Function(x) x.ID = Text)
                    If wItem Is Nothing Then
                        wItem = gListaItems.FirstOrDefault(Function(x) x.ID = Text)
                    End If
                    If wItem IsNot Nothing Then
                        Return wItem.Desc
                    Else
                        _IdEncontrado = ""
                        _DescEncontrada = ""
                        Return ""
                    End If

                End If
            End If

            Return _DescEncontrada
        End Get
    End Property

    <Category("### DataTextbox ###"),
    Description("Lista Activa")>
    Public ReadOnly Property ListaActiva As Boolean
        Get
            If gListaBusqueda Is Nothing Then
                Return False
            Else
                Return gListaBusqueda.Focused
            End If
        End Get
    End Property

    <Category("### DataTextbox ###"),
    Description("Lista Visible")>
    Public ReadOnly Property ListaVisible As Boolean
        Get
            If gListaBusqueda Is Nothing Then
                Return False
            Else
                Return gListaBusqueda.Visible
            End If
        End Get
    End Property

    <Category("### DataTextbox ###"),
    Description("Intervalo de Busqueda")>
    Public Property AnchoLista As Integer
        Get
            Return _AnchoLista
        End Get
        Set(value As Integer)
            _AnchoLista = value
        End Set
    End Property

    <Category("### DataTextbox ###"),
    Description("Intervalo de Busqueda")>
    Public Property IntervaloBusquedaTexto As Integer
        Get
            Return _IntervaloBusquedaTexto
        End Get
        Set(value As Integer)
            _IntervaloBusquedaTexto = value
        End Set
    End Property

    <Category("### DataTextbox ###"),
    Description("Intervalo de Busqueda Números")>
    Public Property IntervaloBusquedaNumeros As Integer
        Get
            Return _IntervaloBusquedaNumeros
        End Get
        Set(value As Integer)
            _IntervaloBusquedaNumeros = value
        End Set
    End Property

    <Category("### DataTextbox ###"),
    Description("TextFont")>
    Public Property TextFont As Font
        Get
            Return Font
        End Get
        Set(value As Font)
            Font = value
            Invalidate()
        End Set
    End Property
    <Category("### DataTextbox ###"),
    Description("Tabla de Busqueda")>
    Public Property TablaBusqueda As String
        Get
            Return _Tabla
        End Get
        Set(value As String)
            _Tabla = value
        End Set
    End Property
    <Category("### DataTextbox ###"),
    Description("ID de Busqueda")>
    Public Property IDBusqueda As String
        Get
            Return _IDBusqueda
        End Get
        Set(value As String)
            _IDBusqueda = value
        End Set
    End Property
    <Category("### DataTextbox ###"),
    Description("Descripción de Busqueda")>
    Public Property DescBusqueda As String
        Get
            Return _DescBusqueda
        End Get
        Set(value As String)
            _DescBusqueda = value
        End Set
    End Property
    <Category("### DataTextbox ###"),
    Description("Descripción de Busqueda Adicional")>
    Public Property DescBusquedaAdicional As String
        Get
            Return _DescAdicional
        End Get
        Set(value As String)
            _DescAdicional = value
        End Set
    End Property
    <Category("### DataTextbox ###"),
    Description("Descripción de Busqueda Adicional2")>
    Public Property DescBusquedaAdicional2 As String
        Get
            Return _DescAdicional2
        End Get
        Set(value As String)
            _DescAdicional2 = value
        End Set
    End Property
    <Category("### DataTextbox ###"),
    Description("Filtro")>
    Public Property Filtro As String
        Get
            Return _Filtro
        End Get
        Set(value As String)
            _Filtro = value
        End Set
    End Property

    Dim gListaBusqueda As ListBox = Nothing
    Dim gListaItems As New List(Of ItemListado)



    Public Sub PreCargarDatos()
        Dim wQuery = "SELECT " & _IDBusqueda & "," & _DescBusqueda & If(_DescAdicional <> "", "," & _DescAdicional, "") &
            If(_DescAdicional2 <> "", "," & _DescAdicional2, "") & " FROM " & _Tabla & If(_Filtro = "", "", " WHERE " & _Filtro)

        Dim wItems = SQL(wQuery)
        gListaItems.Clear()
        If wItems.Rows.Count > 0 Then
            For Each wItem As DataRow In wItems.Rows
                gListaItems.Add(New ItemListado With
                                {
                                    .ID = wItem.GetText(_IDBusqueda).FormatoTexto,
                                    .Desc = wItem.GetText(_DescBusqueda).FormatoTexto,
                                    .IDAdicional1 = If(_DescAdicional <> "", wItem.GetText(_DescAdicional).FormatoTexto, ""),
                                    .IDAdicional2 = If(_DescAdicional2 <> "", wItem.GetText(_DescAdicional2).FormatoTexto, "")
                                })
            Next
            DatosPreCargados = True
        Else
            DatosPreCargados = False
        End If
    End Sub

    Public Sub PreCargarDatos(combo As ComboBox)
        PreCargarDatos()
        If combo.DataSource Is Nothing Then
            combo.Items.Clear()
        Else
            combo.DataSource = Nothing
        End If

        Dim wListaCombo = {""}.ToList
        wListaCombo.AddRange(gListaItems.Select(Function(x) x.Desc).Distinct.ToList)
        combo.DataSource = wListaCombo
    End Sub

    Private SelectedParent As Form

    Public Sub Me_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        Try

            If Not AutoCompletarActivo Then Exit Sub

            Dim wLargo = _IntervaloBusquedaTexto
            Dim wLargoNum = _IntervaloBusquedaNumeros

            If gListaBusqueda Is Nothing Then
                gListaBusqueda = New ListBox
                gListaBusqueda.Visible = False
                gListaBusqueda.Tag = "AutoComplete"
            End If

            'If Text.Length > 0 AndAlso Text.Length Mod wLargo = 0 Then
            If Text.Length > 0 AndAlso ((Not IsNumeric(Text) And Text.Length Mod wLargo = 0) OrElse (IsNumeric(Text) And Text.Length Mod wLargoNum = 0)) Then
                gListaBusqueda.Items.Clear()

                Dim wListaItems As New List(Of ItemListado)
                Dim wTextoComparar = Text.FormatoTexto

                If Not DatosPreCargados Then
                    Dim wItems = SQL("Select " & _IDBusqueda & "," & _DescBusqueda &
                                     If(_DescAdicional <> "", "," & _DescAdicional, "") &
                                     If(_DescAdicional2 <> "", "," & _DescAdicional2, "") &
                                    " FROM " & _Tabla & " WHERE " &
                                    "(UPPER(" & _IDBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS Like '%" & wTextoComparar & "%' OR " &
                                    "UPPER(" & _DescBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%'" &
                                    If(_DescAdicional <> "", " OR UPPER(" & _DescAdicional & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%' ", "") &
                                    If(_DescAdicional2 <> "", " OR UPPER(" & _DescAdicional2 & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%' ", "") & ")" &
                                     If(_Filtro = "", "", " AND " & _Filtro))

                    'Dim wItems = SQL("SELECT " & _IDBusqueda & "," & _DescBusqueda & " FROM " & _Tabla & " WHERE " &
                    '            "(UPPER(" & _IDBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%' OR " &
                    '            "UPPER(" & _DescBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%' OR " &
                    '            "UPPER(" & _DescAdicional & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%' OR " &
                    '            "UPPER(" & _DescAdicional2 & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wTextoComparar & "%') " &
                    '             If(_Filtro = "", "", " AND " & _Filtro))


                    For Each wItem As DataRow In wItems.Rows
                        wListaItems.Add(New ItemListado With {.ID = wItem.GetText(_IDBusqueda).FormatoTexto, .Desc = wItem.GetText(_DescBusqueda).FormatoTexto})
                    Next
                Else
                    wListaItems = gListaItems.Where(Function(x) x.ID.Contains(wTextoComparar) Or
                                                                x.Desc.Contains(wTextoComparar) Or
                                                                x.IDAdicional1.Contains(wTextoComparar) Or
                                                                x.IDAdicional2.Contains(wTextoComparar)).ToList
                End If

                wListaItems = wListaItems.Take(30).ToList()

                If wListaItems.Any Then

                    AddHandler gListaBusqueda.DoubleClick, AddressOf wListaBusqueda_DoubleClick
                    AddHandler gListaBusqueda.KeyDown, AddressOf wListaBusqueda_KeyDown
                    AddHandler gListaBusqueda.Leave, AddressOf wListaBusqueda_Leave

                    For Each wItem In wListaItems
                        gListaBusqueda.Items.Add(wItem.ID & " - " & wItem.Desc)
                    Next

                    SelectedParent = BuscarParent()
                    SelectedParent.Controls.Add(gListaBusqueda)

                    Dim Ubicacion = GetPositionInForm(Me)
                    Dim wX = Ubicacion.X
                    Dim wY = Ubicacion.Y + 2 + Height

                    gListaBusqueda.Font = Font
                    gListaBusqueda.ForeColor = ForeColor
                    gListaBusqueda.Location = New Point(wX, wY)
                    gListaBusqueda.Visible = True
                    gListaBusqueda.BringToFront()
                    gListaBusqueda.Width = AnchoLista

                End If
            ElseIf Text.Length = 0 Then
                OcultarLista()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Function BuscarParent() As Form
        Return CType(GetParentForm(Me), Form)
    End Function

    Public Function GetPositionInForm(ByVal wControl As Control) As Point
        Dim wPoint As Point = wControl.Location
        Dim wParent As Control = wControl.Parent

        While Not (TypeOf wParent Is Form)
            wPoint.Offset(wParent.Location.X, wParent.Location.Y)
            wParent = wParent.Parent
        End While
        Return wPoint
    End Function

    Private Function GetParentForm(ByVal wControl As Control) As Control
        Dim wParent As Control = TryCast(wControl, Control)
        If TypeOf wParent Is Form Then
            Return wParent
        End If
        If wParent.Parent Is Nothing Then
            Return wParent
        End If
        If wControl IsNot Nothing Then
            Return GetParentForm(wControl.Parent)
        End If
        Return Nothing
    End Function

    Public Sub OcultarLista()
        Dim control As New Control
        If gListaBusqueda Is Nothing Then Exit Sub
        If SelectedParent Is Nothing Then Exit Sub

        gListaBusqueda.Visible = False

        RemoveHandler gListaBusqueda.DoubleClick, AddressOf wListaBusqueda_DoubleClick
        RemoveHandler gListaBusqueda.KeyDown, AddressOf wListaBusqueda_KeyDown
        RemoveHandler gListaBusqueda.Leave, AddressOf wListaBusqueda_Leave

        For Each control In SelectedParent.Controls
            If control.Tag Is Nothing Then Continue For
            If control.Tag.ToString = "AutoComplete" Then
                Parent.Controls.Remove(control)
                control = Nothing
            End If
        Next

        gListaBusqueda.Dispose()
        gListaBusqueda = Nothing

    End Sub

    Public Function EncontrarID(wDescripcion As String) As String
        If Not DatosPreCargados Then
            _DescEncontrada = ""
            Dim wItems = SQL("SELECT " & _IDBusqueda & ", " & _DescBusqueda & " FROM " & _Tabla & " WHERE " &
            "UPPER(" & _DescBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & wDescripcion.FormatoTexto & "%'" &
             If(_Filtro = "", "", " AND " & _Filtro))
            If wItems.Rows.Count > 0 Then
                _DescEncontrada = wItems.Top.GetText(DescBusqueda)
                Return wItems.Top.GetText(IDBusqueda)
            Else
                Return ""
            End If
        Else
            Dim wItem = gListaItems.FirstOrDefault(Function(x) x.Desc.FormatoTexto = wDescripcion.FormatoTexto)
            Return If(wItem Is Nothing, "", wItem.ID)
        End If
    End Function

    Public Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If gListaBusqueda IsNot Nothing Then
            If e.KeyCode = Keys.Down AndAlso gListaBusqueda.Visible AndAlso gListaBusqueda.Items.Count > 0 Then
                gListaBusqueda.Focus()
                gListaBusqueda.SelectedIndex = 0
            End If
            If e.KeyCode = Keys.Escape Then
                gListaBusqueda.Visible = False
                Focus()
                SelectionStart = 0
                SelectionLength = Len(Text)
            End If
        End If
    End Sub

    Public Sub wListaBusqueda_DoubleClick(sender As Object, e As EventArgs)
        Dim xLista As ListBox = CType(sender, ListBox)
        Dim output() As String

        If xLista.SelectedIndex = -1 Then Exit Sub

        output = Split(xLista.Items(xLista.SelectedIndex).ToString, " - ")
        Text = If(CampoMostrar = Campo.ID, output(0), output(1))
        _IdEncontrado = output(0)
        _DescEncontrada = output(1)
        Focus()
        RaiseEvent ItemSeleccionado(output(1))
        OcultarLista()
    End Sub

    Public Sub wListaBusqueda_KeyDown(sender As Object, e As KeyEventArgs)
        Dim xLista As ListBox = CType(sender, ListBox)
        If e.KeyCode = Keys.Enter Then
            If xLista.SelectedIndex = -1 Then Exit Sub
            Dim output() As String

            output = Split(xLista.Items(xLista.SelectedIndex).ToString, " - ")
            Text = If(CampoMostrar = Campo.ID, output(0), output(1))
            _IdEncontrado = output(0)
            _DescEncontrada = output(1)
            Focus()
            RaiseEvent ItemSeleccionado(output(1))
            OcultarLista()
        End If

        If e.KeyCode = Keys.Up And xLista.SelectedIndex = 0 Then
            Focus()
            SelectionStart = 0
            SelectionLength = Len(Text)
        End If

        If e.KeyCode = Keys.Back Then
            SelectionStart = Len(Text)
            SelectionLength = 0
            Focus()
        End If

    End Sub

    Public Sub AjustarLista(wLista As ListBox, wTexto As TextBox)
        For Each wItem In wLista.Items
            Dim wSize = TextRenderer.MeasureText(wItem.ToString, wTexto.Font)
            wLista.Width = wSize.Width + 50
        Next
    End Sub

    Private Sub TextboxAutoComp_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If gListaBusqueda Is Nothing Then Exit Sub
        If Not gListaBusqueda.Focused Then
            OcultarLista()
        End If
    End Sub

    Private Sub wListaBusqueda_Leave(sender As Object, e As EventArgs)
        If gListaBusqueda Is Nothing Then Exit Sub
        If Not Me.Focused Then
            OcultarLista()
        End If
    End Sub

End Class

Public Module Extensiones

    <Extension()>
    Public Function FormatoTexto(wTexto As String, Optional Largo As Integer = 0) As String
        Return Mid(wTexto.Trim.ToUpper.RemTildes, 1, If(Largo = 0, Len(wTexto.Trim), Largo))
    End Function

    <Extension()>
    Public Function RemTildes(wTexto As String) As String
        Dim wChars As Byte() = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(wTexto)
        Dim wTextoValido = System.Text.Encoding.UTF8.GetString(wChars)
        Return wTextoValido
    End Function

End Module


Public Class ItemListado
    Public Property ID As String
    Public Property Desc As String
    Public Property IDAdicional1 As String
    Public Property IDAdicional2 As String
End Class
