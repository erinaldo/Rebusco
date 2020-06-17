<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManArticulos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oVisibleWeb = New Rebusco.CustomCheck()
        Me.oDestacadoComunidad = New Rebusco.CustomCheck()
        Me.oProductoDestactado = New Rebusco.CustomCheck()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.cTipo = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.xAño = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.SearchButton1 = New Rebusco.SearchButton()
        Me.xSKU = New System.Windows.Forms.TextBox()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.xDetalle = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.xCategoria = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.xGrupo = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.xModelo = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.xMarca = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cSubFamilia = New System.Windows.Forms.ComboBox()
        Me.cFamilia = New System.Windows.Forms.ComboBox()
        Me.cUnidad = New System.Windows.Forms.ComboBox()
        Me.cEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xSubfamilia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xFamilia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xUnidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fCostoPrecio = New System.Windows.Forms.GroupBox()
        Me.xDescuento = New System.Windows.Forms.NumericUpDown()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.xMargen = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.xCosto = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.oOferta = New Rebusco.CustomCheck()
        Me.oActivoFijo = New Rebusco.CustomCheck()
        Me.xPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fImpuestos = New System.Windows.Forms.GroupBox()
        Me.oExento = New Rebusco.CustomCheck()
        Me.xOtro = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.xLogistica = New System.Windows.Forms.TextBox()
        Me.xMinerales = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.xCervezas = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.xIva = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xVinos = New System.Windows.Forms.TextBox()
        Me.xBebidas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xTabaco = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xPetroleo = New System.Windows.Forms.TextBox()
        Me.xCarne = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.xHarina = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.xLicores = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bImagenes = New System.Windows.Forms.Button()
        Me.bBarras = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fCostoPrecio.SuspendLayout()
        CType(Me.xDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fImpuestos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.oVisibleWeb)
        Me.GroupBox1.Controls.Add(Me.oDestacadoComunidad)
        Me.GroupBox1.Controls.Add(Me.oProductoDestactado)
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.cTipo)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.xAño)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.SearchButton1)
        Me.GroupBox1.Controls.Add(Me.bNuevo)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.xDetalle)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.xCategoria)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.xGrupo)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.xModelo)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.xMarca)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.xSKU)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.cSubFamilia)
        Me.GroupBox1.Controls.Add(Me.cFamilia)
        Me.GroupBox1.Controls.Add(Me.cUnidad)
        Me.GroupBox1.Controls.Add(Me.cEstado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xSubfamilia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xFamilia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xUnidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.fCostoPrecio)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'oVisibleWeb
        '
        Me.oVisibleWeb.Appearance = System.Windows.Forms.Appearance.Button
        Me.oVisibleWeb.BackColor = System.Drawing.Color.White
        Me.oVisibleWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oVisibleWeb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oVisibleWeb.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oVisibleWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oVisibleWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oVisibleWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oVisibleWeb.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oVisibleWeb.ForeColor = System.Drawing.Color.Black
        Me.oVisibleWeb.Image = CType(resources.GetObject("oVisibleWeb.Image"), System.Drawing.Image)
        Me.oVisibleWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oVisibleWeb.Location = New System.Drawing.Point(118, 332)
        Me.oVisibleWeb.Name = "oVisibleWeb"
        Me.oVisibleWeb.Size = New System.Drawing.Size(103, 27)
        Me.oVisibleWeb.TabIndex = 113
        Me.oVisibleWeb.Text = "Visible Web"
        Me.oVisibleWeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oVisibleWeb.UseVisualStyleBackColor = False
        '
        'oDestacadoComunidad
        '
        Me.oDestacadoComunidad.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDestacadoComunidad.BackColor = System.Drawing.Color.White
        Me.oDestacadoComunidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oDestacadoComunidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDestacadoComunidad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDestacadoComunidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oDestacadoComunidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oDestacadoComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDestacadoComunidad.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oDestacadoComunidad.ForeColor = System.Drawing.Color.Black
        Me.oDestacadoComunidad.Image = CType(resources.GetObject("oDestacadoComunidad.Image"), System.Drawing.Image)
        Me.oDestacadoComunidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDestacadoComunidad.Location = New System.Drawing.Point(382, 332)
        Me.oDestacadoComunidad.Name = "oDestacadoComunidad"
        Me.oDestacadoComunidad.Size = New System.Drawing.Size(163, 27)
        Me.oDestacadoComunidad.TabIndex = 112
        Me.oDestacadoComunidad.Text = "Destacado Comunidad"
        Me.oDestacadoComunidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDestacadoComunidad.UseVisualStyleBackColor = False
        '
        'oProductoDestactado
        '
        Me.oProductoDestactado.Appearance = System.Windows.Forms.Appearance.Button
        Me.oProductoDestactado.BackColor = System.Drawing.Color.White
        Me.oProductoDestactado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oProductoDestactado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oProductoDestactado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oProductoDestactado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oProductoDestactado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oProductoDestactado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oProductoDestactado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oProductoDestactado.ForeColor = System.Drawing.Color.Black
        Me.oProductoDestactado.Image = CType(resources.GetObject("oProductoDestactado.Image"), System.Drawing.Image)
        Me.oProductoDestactado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oProductoDestactado.Location = New System.Drawing.Point(227, 332)
        Me.oProductoDestactado.Name = "oProductoDestactado"
        Me.oProductoDestactado.Size = New System.Drawing.Size(149, 27)
        Me.oProductoDestactado.TabIndex = 111
        Me.oProductoDestactado.Text = "Producto Destactado"
        Me.oProductoDestactado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oProductoDestactado.UseVisualStyleBackColor = False
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 700
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "SKU"
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 1
        Me.xArticulo.Location = New System.Drawing.Point(117, 26)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(151, 21)
        Me.xArticulo.TabIndex = 0
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        '
        'cTipo
        '
        Me.cTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipo.FormattingEnabled = True
        Me.cTipo.Location = New System.Drawing.Point(477, 53)
        Me.cTipo.Name = "cTipo"
        Me.cTipo.Size = New System.Drawing.Size(204, 23)
        Me.cTipo.TabIndex = 18
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(425, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(31, 15)
        Me.Label45.TabIndex = 110
        Me.Label45.Text = "Tipo"
        '
        'xAño
        '
        Me.xAño.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xAño.Location = New System.Drawing.Point(118, 305)
        Me.xAño.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.xAño.Name = "xAño"
        Me.xAño.Size = New System.Drawing.Size(80, 21)
        Me.xAño.TabIndex = 13
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(416, 111)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(265, 16)
        Me.Label43.TabIndex = 105
        Me.Label43.Text = "Costo / Precio"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SearchButton1
        '
        Me.SearchButton1.CampoBuscar1 = "Descripcion"
        Me.SearchButton1.CampoBuscar2 = "SKU"
        Me.SearchButton1.CamposAdicionales = ""
        Me.SearchButton1.ControlCarga = Me.xArticulo
        Me.SearchButton1.ControlFocus = Me.xSKU
        Me.SearchButton1.Filtro = ""
        Me.SearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton1.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton1.IDBusqueda = "Articulo"
        Me.SearchButton1.Image = CType(resources.GetObject("SearchButton1.Image"), System.Drawing.Image)
        Me.SearchButton1.Location = New System.Drawing.Point(307, 23)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(73, 28)
        Me.SearchButton1.TabIndex = 9
        Me.SearchButton1.TablaBusqueda = "Articulos"
        Me.SearchButton1.Text = "Buscar"
        Me.SearchButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton1.Titulo = "Articulos"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'xSKU
        '
        Me.xSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xSKU.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSKU.Location = New System.Drawing.Point(118, 55)
        Me.xSKU.MaxLength = 30
        Me.xSKU.Name = "xSKU"
        Me.xSKU.Size = New System.Drawing.Size(216, 21)
        Me.xSKU.TabIndex = 1
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.White
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = Global.Rebusco.My.Resources.Resources._new
        Me.bNuevo.Location = New System.Drawing.Point(274, 23)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(27, 28)
        Me.bNuevo.TabIndex = 10
        Me.bNuevo.TabStop = False
        Me.bNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(13, 338)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 15)
        Me.Label48.TabIndex = 103
        Me.Label48.Text = "Parámetros Web"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(13, 308)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(28, 15)
        Me.Label41.TabIndex = 103
        Me.Label41.Text = "Año"
        '
        'xDetalle
        '
        Me.xDetalle.BackColor = System.Drawing.Color.White
        Me.xDetalle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDetalle.Location = New System.Drawing.Point(118, 368)
        Me.xDetalle.MaxLength = 200
        Me.xDetalle.Multiline = True
        Me.xDetalle.Name = "xDetalle"
        Me.xDetalle.Size = New System.Drawing.Size(563, 64)
        Me.xDetalle.TabIndex = 14
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(12, 368)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(98, 15)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "Detalle Producto"
        '
        'xCategoria
        '
        Me.xCategoria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCategoria.Location = New System.Drawing.Point(118, 249)
        Me.xCategoria.MaxLength = 18
        Me.xCategoria.Name = "xCategoria"
        Me.xCategoria.Size = New System.Drawing.Size(292, 21)
        Me.xCategoria.TabIndex = 11
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(13, 252)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(61, 15)
        Me.Label39.TabIndex = 99
        Me.Label39.Text = "Categoría"
        '
        'xGrupo
        '
        Me.xGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xGrupo.Location = New System.Drawing.Point(117, 277)
        Me.xGrupo.MaxLength = 18
        Me.xGrupo.Name = "xGrupo"
        Me.xGrupo.Size = New System.Drawing.Size(293, 21)
        Me.xGrupo.TabIndex = 12
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 280)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(41, 15)
        Me.Label38.TabIndex = 97
        Me.Label38.Text = "Grupo"
        '
        'xModelo
        '
        Me.xModelo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xModelo.Location = New System.Drawing.Point(118, 221)
        Me.xModelo.MaxLength = 18
        Me.xModelo.Name = "xModelo"
        Me.xModelo.Size = New System.Drawing.Size(292, 21)
        Me.xModelo.TabIndex = 10
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(13, 224)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 15)
        Me.Label37.TabIndex = 95
        Me.Label37.Text = "Modelo"
        '
        'xMarca
        '
        Me.xMarca.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xMarca.Location = New System.Drawing.Point(118, 193)
        Me.xMarca.MaxLength = 18
        Me.xMarca.Name = "xMarca"
        Me.xMarca.Size = New System.Drawing.Size(292, 21)
        Me.xMarca.TabIndex = 9
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(13, 196)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 15)
        Me.Label36.TabIndex = 93
        Me.Label36.Text = "Marca"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(13, 58)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(32, 15)
        Me.Label32.TabIndex = 90
        Me.Label32.Text = "SKU"
        '
        'cSubFamilia
        '
        Me.cSubFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSubFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSubFamilia.FormattingEnabled = True
        Me.cSubFamilia.Location = New System.Drawing.Point(176, 165)
        Me.cSubFamilia.Name = "cSubFamilia"
        Me.cSubFamilia.Size = New System.Drawing.Size(234, 23)
        Me.cSubFamilia.TabIndex = 8
        Me.cSubFamilia.TabStop = False
        '
        'cFamilia
        '
        Me.cFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cFamilia.FormattingEnabled = True
        Me.cFamilia.Location = New System.Drawing.Point(176, 138)
        Me.cFamilia.Name = "cFamilia"
        Me.cFamilia.Size = New System.Drawing.Size(234, 23)
        Me.cFamilia.TabIndex = 6
        Me.cFamilia.TabStop = False
        '
        'cUnidad
        '
        Me.cUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cUnidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cUnidad.FormattingEnabled = True
        Me.cUnidad.Location = New System.Drawing.Point(176, 111)
        Me.cUnidad.Name = "cUnidad"
        Me.cUnidad.Size = New System.Drawing.Size(234, 23)
        Me.cUnidad.TabIndex = 4
        Me.cUnidad.TabStop = False
        '
        'cEstado
        '
        Me.cEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cEstado.FormattingEnabled = True
        Me.cEstado.Location = New System.Drawing.Point(477, 23)
        Me.cEstado.Name = "cEstado"
        Me.cEstado.Size = New System.Drawing.Size(204, 23)
        Me.cEstado.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Estado"
        '
        'xSubfamilia
        '
        Me.xSubfamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSubfamilia.Location = New System.Drawing.Point(117, 165)
        Me.xSubfamilia.MaxLength = 18
        Me.xSubfamilia.Name = "xSubfamilia"
        Me.xSubfamilia.Size = New System.Drawing.Size(53, 21)
        Me.xSubfamilia.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sub Familia"
        '
        'xFamilia
        '
        Me.xFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFamilia.Location = New System.Drawing.Point(117, 139)
        Me.xFamilia.MaxLength = 18
        Me.xFamilia.Name = "xFamilia"
        Me.xFamilia.Size = New System.Drawing.Size(53, 21)
        Me.xFamilia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Familia"
        '
        'xUnidad
        '
        Me.xUnidad.BackColor = System.Drawing.Color.White
        Me.xUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xUnidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xUnidad.Location = New System.Drawing.Point(117, 111)
        Me.xUnidad.MaxLength = 2
        Me.xUnidad.Name = "xUnidad"
        Me.xUnidad.Size = New System.Drawing.Size(53, 21)
        Me.xUnidad.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidad"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.White
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescripcion.Location = New System.Drawing.Point(118, 83)
        Me.xDescripcion.MaxLength = 200
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.Size = New System.Drawing.Size(563, 21)
        Me.xDescripcion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo"
        '
        'fCostoPrecio
        '
        Me.fCostoPrecio.Controls.Add(Me.xDescuento)
        Me.fCostoPrecio.Controls.Add(Me.Label47)
        Me.fCostoPrecio.Controls.Add(Me.Label46)
        Me.fCostoPrecio.Controls.Add(Me.xMargen)
        Me.fCostoPrecio.Controls.Add(Me.Label44)
        Me.fCostoPrecio.Controls.Add(Me.xCosto)
        Me.fCostoPrecio.Controls.Add(Me.Label27)
        Me.fCostoPrecio.Controls.Add(Me.oOferta)
        Me.fCostoPrecio.Controls.Add(Me.oActivoFijo)
        Me.fCostoPrecio.Controls.Add(Me.xPrecioVenta)
        Me.fCostoPrecio.Controls.Add(Me.Label6)
        Me.fCostoPrecio.Controls.Add(Me.Label7)
        Me.fCostoPrecio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fCostoPrecio.Location = New System.Drawing.Point(416, 112)
        Me.fCostoPrecio.Name = "fCostoPrecio"
        Me.fCostoPrecio.Size = New System.Drawing.Size(265, 186)
        Me.fCostoPrecio.TabIndex = 106
        Me.fCostoPrecio.TabStop = False
        '
        'xDescuento
        '
        Me.xDescuento.Location = New System.Drawing.Point(140, 116)
        Me.xDescuento.Name = "xDescuento"
        Me.xDescuento.Size = New System.Drawing.Size(52, 21)
        Me.xDescuento.TabIndex = 140
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(194, 118)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(21, 18)
        Me.Label47.TabIndex = 139
        Me.Label47.Text = "%"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label46.Location = New System.Drawing.Point(176, 59)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(18, 15)
        Me.Label46.TabIndex = 94
        Me.Label46.Text = "%"
        '
        'xMargen
        '
        Me.xMargen.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xMargen.Location = New System.Drawing.Point(140, 52)
        Me.xMargen.MaxLength = 3
        Me.xMargen.Name = "xMargen"
        Me.xMargen.Size = New System.Drawing.Size(35, 21)
        Me.xMargen.TabIndex = 93
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label44.Location = New System.Drawing.Point(9, 52)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 15)
        Me.Label44.TabIndex = 92
        Me.Label44.Text = "Margen"
        '
        'xCosto
        '
        Me.xCosto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCosto.Location = New System.Drawing.Point(140, 22)
        Me.xCosto.MaxLength = 18
        Me.xCosto.Name = "xCosto"
        Me.xCosto.Size = New System.Drawing.Size(113, 21)
        Me.xCosto.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(9, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(94, 15)
        Me.Label27.TabIndex = 91
        Me.Label27.Text = "Max. Descuento"
        '
        'oOferta
        '
        Me.oOferta.Appearance = System.Windows.Forms.Appearance.Button
        Me.oOferta.BackColor = System.Drawing.Color.White
        Me.oOferta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oOferta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oOferta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oOferta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oOferta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oOferta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oOferta.ForeColor = System.Drawing.Color.Black
        Me.oOferta.Image = CType(resources.GetObject("oOferta.Image"), System.Drawing.Image)
        Me.oOferta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oOferta.Location = New System.Drawing.Point(12, 149)
        Me.oOferta.Name = "oOferta"
        Me.oOferta.Size = New System.Drawing.Size(113, 27)
        Me.oOferta.TabIndex = 15
        Me.oOferta.Text = "Oferta"
        Me.oOferta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oOferta.UseVisualStyleBackColor = False
        '
        'oActivoFijo
        '
        Me.oActivoFijo.Appearance = System.Windows.Forms.Appearance.Button
        Me.oActivoFijo.BackColor = System.Drawing.Color.White
        Me.oActivoFijo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oActivoFijo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oActivoFijo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oActivoFijo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oActivoFijo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oActivoFijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oActivoFijo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oActivoFijo.ForeColor = System.Drawing.Color.Black
        Me.oActivoFijo.Image = CType(resources.GetObject("oActivoFijo.Image"), System.Drawing.Image)
        Me.oActivoFijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oActivoFijo.Location = New System.Drawing.Point(140, 149)
        Me.oActivoFijo.Name = "oActivoFijo"
        Me.oActivoFijo.Size = New System.Drawing.Size(113, 27)
        Me.oActivoFijo.TabIndex = 16
        Me.oActivoFijo.Text = "Activo Fijo"
        Me.oActivoFijo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oActivoFijo.UseVisualStyleBackColor = False
        '
        'xPrecioVenta
        '
        Me.xPrecioVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xPrecioVenta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xPrecioVenta.Location = New System.Drawing.Point(140, 83)
        Me.xPrecioVenta.MaxLength = 18
        Me.xPrecioVenta.Name = "xPrecioVenta"
        Me.xPrecioVenta.Size = New System.Drawing.Size(113, 21)
        Me.xPrecioVenta.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(9, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Costo Neto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(10, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio Venta  Bruto"
        '
        'fImpuestos
        '
        Me.fImpuestos.BackColor = System.Drawing.Color.Transparent
        Me.fImpuestos.Controls.Add(Me.oExento)
        Me.fImpuestos.Controls.Add(Me.Panel1)
        Me.fImpuestos.Controls.Add(Me.xOtro)
        Me.fImpuestos.Controls.Add(Me.Label34)
        Me.fImpuestos.Controls.Add(Me.Label35)
        Me.fImpuestos.Controls.Add(Me.Label16)
        Me.fImpuestos.Controls.Add(Me.xLogistica)
        Me.fImpuestos.Controls.Add(Me.xMinerales)
        Me.fImpuestos.Controls.Add(Me.Label17)
        Me.fImpuestos.Controls.Add(Me.Label18)
        Me.fImpuestos.Controls.Add(Me.Label21)
        Me.fImpuestos.Controls.Add(Me.Label26)
        Me.fImpuestos.Controls.Add(Me.Label28)
        Me.fImpuestos.Controls.Add(Me.Label22)
        Me.fImpuestos.Controls.Add(Me.xCervezas)
        Me.fImpuestos.Controls.Add(Me.Label29)
        Me.fImpuestos.Controls.Add(Me.xIva)
        Me.fImpuestos.Controls.Add(Me.Label30)
        Me.fImpuestos.Controls.Add(Me.Label31)
        Me.fImpuestos.Controls.Add(Me.Label13)
        Me.fImpuestos.Controls.Add(Me.xVinos)
        Me.fImpuestos.Controls.Add(Me.xBebidas)
        Me.fImpuestos.Controls.Add(Me.Label12)
        Me.fImpuestos.Controls.Add(Me.xTabaco)
        Me.fImpuestos.Controls.Add(Me.Label9)
        Me.fImpuestos.Controls.Add(Me.Label14)
        Me.fImpuestos.Controls.Add(Me.xPetroleo)
        Me.fImpuestos.Controls.Add(Me.xCarne)
        Me.fImpuestos.Controls.Add(Me.Label15)
        Me.fImpuestos.Controls.Add(Me.Label25)
        Me.fImpuestos.Controls.Add(Me.xHarina)
        Me.fImpuestos.Controls.Add(Me.Label24)
        Me.fImpuestos.Controls.Add(Me.Label19)
        Me.fImpuestos.Controls.Add(Me.Label11)
        Me.fImpuestos.Controls.Add(Me.Label10)
        Me.fImpuestos.Controls.Add(Me.Label23)
        Me.fImpuestos.Controls.Add(Me.Label20)
        Me.fImpuestos.Controls.Add(Me.xLicores)
        Me.fImpuestos.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.fImpuestos.Location = New System.Drawing.Point(705, 59)
        Me.fImpuestos.Name = "fImpuestos"
        Me.fImpuestos.Size = New System.Drawing.Size(283, 434)
        Me.fImpuestos.TabIndex = 3
        Me.fImpuestos.TabStop = False
        '
        'oExento
        '
        Me.oExento.Appearance = System.Windows.Forms.Appearance.Button
        Me.oExento.BackColor = System.Drawing.Color.White
        Me.oExento.Checked = True
        Me.oExento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oExento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oExento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oExento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oExento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oExento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oExento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oExento.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oExento.ForeColor = System.Drawing.Color.White
        Me.oExento.Image = CType(resources.GetObject("oExento.Image"), System.Drawing.Image)
        Me.oExento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oExento.Location = New System.Drawing.Point(9, 21)
        Me.oExento.Name = "oExento"
        Me.oExento.Size = New System.Drawing.Size(91, 27)
        Me.oExento.TabIndex = 1
        Me.oExento.Text = "Exento"
        Me.oExento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oExento.UseVisualStyleBackColor = False
        '
        'xOtro
        '
        Me.xOtro.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xOtro.Location = New System.Drawing.Point(181, 341)
        Me.xOtro.MaxLength = 18
        Me.xOtro.Name = "xOtro"
        Me.xOtro.Size = New System.Drawing.Size(67, 21)
        Me.xOtro.TabIndex = 24
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label34.Location = New System.Drawing.Point(22, 344)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 15)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "Otro"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(252, 347)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(18, 15)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(22, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "I.V.A."
        '
        'xLogistica
        '
        Me.xLogistica.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xLogistica.Location = New System.Drawing.Point(181, 315)
        Me.xLogistica.MaxLength = 18
        Me.xLogistica.Name = "xLogistica"
        Me.xLogistica.Size = New System.Drawing.Size(67, 21)
        Me.xLogistica.TabIndex = 21
        '
        'xMinerales
        '
        Me.xMinerales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xMinerales.Location = New System.Drawing.Point(181, 89)
        Me.xMinerales.MaxLength = 18
        Me.xMinerales.Name = "xMinerales"
        Me.xMinerales.Size = New System.Drawing.Size(67, 21)
        Me.xMinerales.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(22, 318)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Logística"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(252, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "%"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(252, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "%"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(252, 321)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(18, 15)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "%"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label28.Location = New System.Drawing.Point(22, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(132, 15)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Bebidas Analcohólicas"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(252, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "%"
        '
        'xCervezas
        '
        Me.xCervezas.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCervezas.Location = New System.Drawing.Point(181, 164)
        Me.xCervezas.MaxLength = 18
        Me.xCervezas.Name = "xCervezas"
        Me.xCervezas.Size = New System.Drawing.Size(67, 21)
        Me.xCervezas.TabIndex = 15
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label29.Location = New System.Drawing.Point(252, 95)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(18, 15)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "%"
        '
        'xIva
        '
        Me.xIva.Enabled = False
        Me.xIva.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xIva.Location = New System.Drawing.Point(181, 64)
        Me.xIva.MaxLength = 18
        Me.xIva.Name = "xIva"
        Me.xIva.Size = New System.Drawing.Size(67, 21)
        Me.xIva.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label30.Location = New System.Drawing.Point(22, 167)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 15)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Cervezas"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label31.Location = New System.Drawing.Point(252, 170)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(18, 15)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(22, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Bebida Azucaradas"
        '
        'xVinos
        '
        Me.xVinos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVinos.Location = New System.Drawing.Point(181, 139)
        Me.xVinos.MaxLength = 18
        Me.xVinos.Name = "xVinos"
        Me.xVinos.Size = New System.Drawing.Size(67, 21)
        Me.xVinos.TabIndex = 14
        '
        'xBebidas
        '
        Me.xBebidas.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xBebidas.Location = New System.Drawing.Point(181, 114)
        Me.xBebidas.MaxLength = 18
        Me.xBebidas.Name = "xBebidas"
        Me.xBebidas.Size = New System.Drawing.Size(67, 21)
        Me.xBebidas.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(22, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Vinos"
        '
        'xTabaco
        '
        Me.xTabaco.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTabaco.Location = New System.Drawing.Point(181, 264)
        Me.xTabaco.MaxLength = 18
        Me.xTabaco.Name = "xTabaco"
        Me.xTabaco.Size = New System.Drawing.Size(67, 21)
        Me.xTabaco.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(22, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Carne"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(22, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 15)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Tabaco"
        '
        'xPetroleo
        '
        Me.xPetroleo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xPetroleo.Location = New System.Drawing.Point(181, 290)
        Me.xPetroleo.MaxLength = 18
        Me.xPetroleo.Name = "xPetroleo"
        Me.xPetroleo.Size = New System.Drawing.Size(67, 21)
        Me.xPetroleo.TabIndex = 20
        '
        'xCarne
        '
        Me.xCarne.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCarne.Location = New System.Drawing.Point(181, 214)
        Me.xCarne.MaxLength = 18
        Me.xCarne.Name = "xCarne"
        Me.xCarne.Size = New System.Drawing.Size(67, 21)
        Me.xCarne.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(22, 293)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Petróleo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(252, 220)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "%"
        '
        'xHarina
        '
        Me.xHarina.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xHarina.Location = New System.Drawing.Point(181, 239)
        Me.xHarina.MaxLength = 18
        Me.xHarina.Name = "xHarina"
        Me.xHarina.Size = New System.Drawing.Size(67, 21)
        Me.xHarina.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label24.Location = New System.Drawing.Point(252, 245)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(18, 15)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(252, 296)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 15)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(22, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Licores"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(22, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Harina"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label23.Location = New System.Drawing.Point(252, 195)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 15)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "%"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(252, 271)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "%"
        '
        'xLicores
        '
        Me.xLicores.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xLicores.Location = New System.Drawing.Point(181, 189)
        Me.xLicores.MaxLength = 18
        Me.xLicores.Name = "xLicores"
        Me.xLicores.Size = New System.Drawing.Size(67, 21)
        Me.xLicores.TabIndex = 16
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(705, 57)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(283, 16)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Datos de los Impuestos"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(12, 57)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(687, 16)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Artículo"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 60
        Me.WinDeco1.AlturaTitulo = 50
        Me.WinDeco1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.WinDeco1.BordeVentana = 2
        Me.WinDeco1.ColorBordeVentana = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.WinDeco1.ColorPanelBanner = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.WinDeco1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinDeco1.FondoAplicacionA = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinDeco1.FondoAplicacionB = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.WinDeco1.FondoColorA = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WinDeco1.FondoColorB = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WinDeco1.FooterColorA = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WinDeco1.FooterColorB = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco1.FooterSolido = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco1.ImagenBanner = Global.Rebusco.My.Resources.Resources.banner3
        Me.WinDeco1.Location = New System.Drawing.Point(0, 0)
        Me.WinDeco1.Margin = New System.Windows.Forms.Padding(2)
        Me.WinDeco1.MuestraBordeExterior = -1
        Me.WinDeco1.Name = "WinDeco1"
        Me.WinDeco1.SiempreVisible = False
        Me.WinDeco1.Size = New System.Drawing.Size(998, 50)
        Me.WinDeco1.TabIndex = 333
        Me.WinDeco1.TituloVentana = "Mantedor de Artículos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bImagenes
        '
        Me.bImagenes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImagenes.BackColor = System.Drawing.Color.White
        Me.bImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImagenes.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImagenes.Image = Global.Rebusco.My.Resources.Resources.imageAdd24
        Me.bImagenes.Location = New System.Drawing.Point(568, 509)
        Me.bImagenes.Name = "bImagenes"
        Me.bImagenes.Size = New System.Drawing.Size(100, 36)
        Me.bImagenes.TabIndex = 11
        Me.bImagenes.Text = " Imágenes"
        Me.bImagenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImagenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImagenes.UseVisualStyleBackColor = False
        '
        'bBarras
        '
        Me.bBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bBarras.BackColor = System.Drawing.Color.White
        Me.bBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBarras.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBarras.Image = Global.Rebusco.My.Resources.Resources.barcode24
        Me.bBarras.Location = New System.Drawing.Point(118, 509)
        Me.bBarras.Name = "bBarras"
        Me.bBarras.Size = New System.Drawing.Size(100, 36)
        Me.bBarras.TabIndex = 8
        Me.bBarras.Text = "Barras"
        Me.bBarras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBarras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBarras.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(674, 509)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 4
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bEliminar
        '
        Me.bEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEliminar.BackColor = System.Drawing.Color.White
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bEliminar.Image = Global.Rebusco.My.Resources.Resources.delete24
        Me.bEliminar.Location = New System.Drawing.Point(780, 509)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 36)
        Me.bEliminar.TabIndex = 5
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 509)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 7
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(886, 509)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(6, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 4)
        Me.Panel1.TabIndex = 25
        '
        'ManArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 558)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bImagenes)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.bBarras)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.fImpuestos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1264, 768)
        Me.Name = "ManArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Artículos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fCostoPrecio.ResumeLayout(False)
        Me.fCostoPrecio.PerformLayout()
        CType(Me.xDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fImpuestos.ResumeLayout(False)
        Me.fImpuestos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cSubFamilia As ComboBox
    Friend WithEvents cFamilia As ComboBox
    Friend WithEvents cUnidad As ComboBox
    Friend WithEvents cEstado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xPrecioVenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xCosto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xSubfamilia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xFamilia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents xUnidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fImpuestos As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xCarne As TextBox
    Friend WithEvents xHarina As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents xLicores As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents xVinos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents xBebidas As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents xTabaco As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents xPetroleo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents xIva As TextBox
    Friend WithEvents Label16 As Label
    Public WithEvents bGuardar As Button
    Public WithEvents bEliminar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents xMinerales As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents xLogistica As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents xCervezas As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Public WithEvents bBarras As Button
    Friend WithEvents xSKU As TextBox
    Friend WithEvents Label32 As Label
    Public WithEvents bNuevo As Button

    Friend WithEvents Label33 As Label
    Friend WithEvents oExento As CustomCheck
    Friend WithEvents SearchButton1 As SearchButton
    Friend WithEvents Label27 As Label
    Friend WithEvents xOtro As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents xDetalle As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents xCategoria As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents xGrupo As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents xModelo As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents xMarca As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents fCostoPrecio As GroupBox
    Friend WithEvents xAño As NumericUpDown
    Friend WithEvents oActivoFijo As CustomCheck
    Friend WithEvents oOferta As CustomCheck
    Friend WithEvents cTipo As ComboBox
    Friend WithEvents Label45 As Label
    Public WithEvents bImagenes As Button
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label46 As Label
    Friend WithEvents xMargen As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents xDescuento As NumericUpDown
    Friend WithEvents Label47 As Label
    Friend WithEvents oVisibleWeb As CustomCheck
    Friend WithEvents oDestacadoComunidad As CustomCheck
    Friend WithEvents oProductoDestactado As CustomCheck
    Friend WithEvents Label48 As Label
    Friend WithEvents Panel1 As Panel
End Class
