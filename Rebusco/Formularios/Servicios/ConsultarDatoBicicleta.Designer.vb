<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarDatoBicicleta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarDatoBicicleta))
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xCliente = New Rebusco.TextBoxAutoComple()
        Me.xSerie = New System.Windows.Forms.TextBox()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TallaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatosBicicletaConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.mOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.bVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.bImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBicicletaConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mOpciones.SuspendLayout()
        Me.SuspendLayout()
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
        Me.WinDeco1.Size = New System.Drawing.Size(987, 50)
        Me.WinDeco1.TabIndex = 244
        Me.WinDeco1.TituloVentana = "Consulta de Datos de Bicicletas"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.xSerie)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xCliente
        '
        Me.xCliente.AnchoLista = 300
        Me.xCliente.AutoCompletarActivo = True
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.DescBusqueda = "Nombre"
        Me.xCliente.DescBusquedaAdicional = "Rut"
        Me.xCliente.DescBusquedaAdicional2 = "SinPuntos"
        Me.xCliente.Filtro = ""
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.IDBusqueda = "Cliente"
        Me.xCliente.IntervaloBusquedaNumeros = 1
        Me.xCliente.IntervaloBusquedaTexto = 2
        Me.xCliente.Location = New System.Drawing.Point(142, 22)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(116, 22)
        Me.xCliente.TabIndex = 0
        Me.xCliente.TablaBusqueda = "ClientesBusqueda"
        Me.xCliente.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'xSerie
        '
        Me.xSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSerie.Location = New System.Drawing.Point(142, 78)
        Me.xSerie.Name = "xSerie"
        Me.xSerie.Size = New System.Drawing.Size(116, 22)
        Me.xSerie.TabIndex = 2
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xDescripcion.Location = New System.Drawing.Point(264, 51)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(337, 22)
        Me.xDescripcion.TabIndex = 245
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 800
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "Modelo"
        Me.xArticulo.DescBusquedaAdicional2 = "SKU"
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(142, 50)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(116, 22)
        Me.xArticulo.TabIndex = 1
        Me.xArticulo.TablaBusqueda = "BuscarControlArticulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(611, 16)
        Me.Label14.TabIndex = 242
        Me.Label14.Text = "Filtros"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xNombre.Location = New System.Drawing.Point(264, 23)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(337, 22)
        Me.xNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Artículo / SKU / Modelo"
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(629, 137)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(96, 36)
        Me.bConsultar.TabIndex = 1
        Me.bConsultar.Text = "Buscar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        Me.xTabla.AutoGenerateColumns = False
        Me.xTabla.BackgroundColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xTabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreClienteDataGridViewTextBoxColumn, Me.DescripcionArticuloDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.TallaDataGridViewTextBoxColumn, Me.AñoDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.DatosBicicletaConsultaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xTabla.DefaultCellStyle = DataGridViewCellStyle2
        Me.xTabla.Location = New System.Drawing.Point(12, 179)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.ReadOnly = True
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(963, 322)
        Me.xTabla.TabIndex = 247
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        Me.NombreClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreClienteDataGridViewTextBoxColumn.Width = 200
        '
        'DescripcionArticuloDataGridViewTextBoxColumn
        '
        Me.DescripcionArticuloDataGridViewTextBoxColumn.DataPropertyName = "DescripcionArticulo"
        Me.DescripcionArticuloDataGridViewTextBoxColumn.HeaderText = "Descripción Artículo"
        Me.DescripcionArticuloDataGridViewTextBoxColumn.Name = "DescripcionArticuloDataGridViewTextBoxColumn"
        Me.DescripcionArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionArticuloDataGridViewTextBoxColumn.Width = 400
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 400
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TallaDataGridViewTextBoxColumn
        '
        Me.TallaDataGridViewTextBoxColumn.DataPropertyName = "Talla"
        Me.TallaDataGridViewTextBoxColumn.HeaderText = "Talla"
        Me.TallaDataGridViewTextBoxColumn.Name = "TallaDataGridViewTextBoxColumn"
        Me.TallaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatosBicicletaConsultaBindingSource
        '
        Me.DatosBicicletaConsultaBindingSource.DataSource = GetType(Rebusco.DatosControlArticulo)
        '
        'bCancelar
        '
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(879, 521)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(96, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 521)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(96, 36)
        Me.bLimpiar.TabIndex = 2
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'mOpciones
        '
        Me.mOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bVer, Me.bImprimir})
        Me.mOpciones.Name = "mEvaluacion"
        Me.mOpciones.Size = New System.Drawing.Size(189, 86)
        '
        'bVer
        '
        Me.bVer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.bVer.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bVer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(188, 30)
        Me.bVer.Text = "Ver"
        '
        'bImprimir
        '
        Me.bImprimir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(188, 30)
        Me.bImprimir.Text = "Imprimir"
        '
        'ConsultarDatoBicicleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 569)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WinDeco1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1266, 768)
        Me.Name = "ConsultarDatoBicicleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Datos de Bicicletas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBicicletaConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents xSerie As TextBox
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents xArticulo As TextBoxAutoComple
    Public WithEvents bConsultar As Button
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents DatosBicicletaConsultaBindingSource As BindingSource
    Public WithEvents bCancelar As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TallaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mOpciones As ContextMenuStrip
    Friend WithEvents bVer As ToolStripMenuItem
    Friend WithEvents bImprimir As ToolStripMenuItem
    Friend WithEvents xCliente As TextBoxAutoComple
End Class
