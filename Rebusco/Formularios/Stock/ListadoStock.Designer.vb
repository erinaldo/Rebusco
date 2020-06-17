<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoStock))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rDes = New Rebusco.CustomRadio()
        Me.cOrdenar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rAsc = New Rebusco.CustomRadio()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cSubFamilia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cFamilia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oStockPositivo = New Rebusco.CustomCheck()
        Me.oBajoStockMinimo = New Rebusco.CustomCheck()
        Me.oStockCero = New Rebusco.CustomCheck()
        Me.oStockNegativo = New Rebusco.CustomCheck()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cLocalBodega = New System.Windows.Forms.ComboBox()
        Me.oBodega = New Rebusco.CustomRadio()
        Me.oLocal = New Rebusco.CustomRadio()
        Me.sStock = New System.Windows.Forms.BindingSource(Me.components)
        Me.bExportar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.sStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 500
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = ""
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = "TipoArticulo = 'P'"
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(91, 22)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(104, 22)
        Me.xArticulo.TabIndex = 48
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Descripción"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(91, 53)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(428, 21)
        Me.xDescripcion.TabIndex = 1
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.White
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscar.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscar.Location = New System.Drawing.Point(201, 19)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(80, 28)
        Me.bBuscar.TabIndex = 42
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rDes)
        Me.GroupBox2.Controls.Add(Me.cOrdenar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rAsc)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 59)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'rDes
        '
        Me.rDes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rDes.BackColor = System.Drawing.Color.White
        Me.rDes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rDes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rDes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.rDes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.rDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rDes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.rDes.ForeColor = System.Drawing.Color.Black
        Me.rDes.Image = CType(resources.GetObject("rDes.Image"), System.Drawing.Image)
        Me.rDes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rDes.Location = New System.Drawing.Point(324, 22)
        Me.rDes.Name = "rDes"
        Me.rDes.Size = New System.Drawing.Size(94, 30)
        Me.rDes.TabIndex = 2
        Me.rDes.Text = "Desendente"
        Me.rDes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rDes.UseVisualStyleBackColor = False
        '
        'cOrdenar
        '
        Me.cOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cOrdenar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cOrdenar.FormattingEnabled = True
        Me.cOrdenar.Items.AddRange(New Object() {" ", "Artículo", "Descripción", "SKU"})
        Me.cOrdenar.Location = New System.Drawing.Point(6, 27)
        Me.cOrdenar.Name = "cOrdenar"
        Me.cOrdenar.Size = New System.Drawing.Size(212, 23)
        Me.cOrdenar.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(427, 16)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Ordenar por"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rAsc
        '
        Me.rAsc.Appearance = System.Windows.Forms.Appearance.Button
        Me.rAsc.BackColor = System.Drawing.Color.White
        Me.rAsc.Checked = True
        Me.rAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rAsc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rAsc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.rAsc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.rAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rAsc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.rAsc.ForeColor = System.Drawing.Color.White
        Me.rAsc.Image = CType(resources.GetObject("rAsc.Image"), System.Drawing.Image)
        Me.rAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rAsc.Location = New System.Drawing.Point(224, 22)
        Me.rAsc.Name = "rAsc"
        Me.rAsc.Size = New System.Drawing.Size(94, 30)
        Me.rAsc.TabIndex = 1
        Me.rAsc.TabStop = True
        Me.rAsc.Text = "Ascendente"
        Me.rAsc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rAsc.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(1017, 527)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 49
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(911, 527)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 60
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.delete24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 527)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 76
        Me.bLimpiar.Text = "Eliminar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(525, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Artículo"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WinDeco1.Size = New System.Drawing.Size(1129, 50)
        Me.WinDeco1.TabIndex = 136
        Me.WinDeco1.TituloVentana = "Listado de Stock de Artículos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(870, 179)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(99, 36)
        Me.bConsultar.TabIndex = 138
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.BackgroundColor = System.Drawing.Color.SlateGray
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Location = New System.Drawing.Point(12, 225)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.ReadOnly = True
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(1105, 280)
        Me.xTabla.TabIndex = 284
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cSubFamilia)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cFamilia)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.oStockPositivo)
        Me.GroupBox3.Controls.Add(Me.oBajoStockMinimo)
        Me.GroupBox3.Controls.Add(Me.oStockCero)
        Me.GroupBox3.Controls.Add(Me.oStockNegativo)
        Me.GroupBox3.Location = New System.Drawing.Point(542, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 98)
        Me.GroupBox3.TabIndex = 285
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(275, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Sub-Familia"
        '
        'cSubFamilia
        '
        Me.cSubFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSubFamilia.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cSubFamilia.FormattingEnabled = True
        Me.cSubFamilia.Location = New System.Drawing.Point(357, 58)
        Me.cSubFamilia.Name = "cSubFamilia"
        Me.cSubFamilia.Size = New System.Drawing.Size(212, 23)
        Me.cSubFamilia.TabIndex = 146
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(275, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Familia"
        '
        'cFamilia
        '
        Me.cFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFamilia.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFamilia.FormattingEnabled = True
        Me.cFamilia.Location = New System.Drawing.Point(357, 29)
        Me.cFamilia.Name = "cFamilia"
        Me.cFamilia.Size = New System.Drawing.Size(212, 23)
        Me.cFamilia.TabIndex = 144
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(575, 16)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Filtros"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oStockPositivo
        '
        Me.oStockPositivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.oStockPositivo.BackColor = System.Drawing.Color.White
        Me.oStockPositivo.Checked = True
        Me.oStockPositivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oStockPositivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockPositivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockPositivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oStockPositivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oStockPositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oStockPositivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oStockPositivo.ForeColor = System.Drawing.Color.White
        Me.oStockPositivo.Image = CType(resources.GetObject("oStockPositivo.Image"), System.Drawing.Image)
        Me.oStockPositivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oStockPositivo.Location = New System.Drawing.Point(6, 27)
        Me.oStockPositivo.Name = "oStockPositivo"
        Me.oStockPositivo.Size = New System.Drawing.Size(121, 30)
        Me.oStockPositivo.TabIndex = 140
        Me.oStockPositivo.Text = "Stock Positivo"
        Me.oStockPositivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oStockPositivo.UseVisualStyleBackColor = False
        '
        'oBajoStockMinimo
        '
        Me.oBajoStockMinimo.Appearance = System.Windows.Forms.Appearance.Button
        Me.oBajoStockMinimo.BackColor = System.Drawing.Color.White
        Me.oBajoStockMinimo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBajoStockMinimo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBajoStockMinimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oBajoStockMinimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oBajoStockMinimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oBajoStockMinimo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.oBajoStockMinimo.ForeColor = System.Drawing.Color.Black
        Me.oBajoStockMinimo.Image = CType(resources.GetObject("oBajoStockMinimo.Image"), System.Drawing.Image)
        Me.oBajoStockMinimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oBajoStockMinimo.Location = New System.Drawing.Point(130, 63)
        Me.oBajoStockMinimo.Name = "oBajoStockMinimo"
        Me.oBajoStockMinimo.Size = New System.Drawing.Size(121, 30)
        Me.oBajoStockMinimo.TabIndex = 143
        Me.oBajoStockMinimo.Text = "Bajo stock mínimo"
        Me.oBajoStockMinimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oBajoStockMinimo.UseVisualStyleBackColor = False
        '
        'oStockCero
        '
        Me.oStockCero.Appearance = System.Windows.Forms.Appearance.Button
        Me.oStockCero.BackColor = System.Drawing.Color.White
        Me.oStockCero.Checked = True
        Me.oStockCero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oStockCero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockCero.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockCero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oStockCero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oStockCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oStockCero.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.oStockCero.ForeColor = System.Drawing.Color.White
        Me.oStockCero.Image = CType(resources.GetObject("oStockCero.Image"), System.Drawing.Image)
        Me.oStockCero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oStockCero.Location = New System.Drawing.Point(130, 27)
        Me.oStockCero.Name = "oStockCero"
        Me.oStockCero.Size = New System.Drawing.Size(121, 30)
        Me.oStockCero.TabIndex = 142
        Me.oStockCero.Text = "Stock Cero"
        Me.oStockCero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oStockCero.UseVisualStyleBackColor = False
        '
        'oStockNegativo
        '
        Me.oStockNegativo.Appearance = System.Windows.Forms.Appearance.Button
        Me.oStockNegativo.BackColor = System.Drawing.Color.White
        Me.oStockNegativo.Checked = True
        Me.oStockNegativo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oStockNegativo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockNegativo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockNegativo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oStockNegativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oStockNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oStockNegativo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.oStockNegativo.ForeColor = System.Drawing.Color.White
        Me.oStockNegativo.Image = CType(resources.GetObject("oStockNegativo.Image"), System.Drawing.Image)
        Me.oStockNegativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oStockNegativo.Location = New System.Drawing.Point(6, 63)
        Me.oStockNegativo.Name = "oStockNegativo"
        Me.oStockNegativo.Size = New System.Drawing.Size(121, 30)
        Me.oStockNegativo.TabIndex = 141
        Me.oStockNegativo.Text = "Stock Negativo"
        Me.oStockNegativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oStockNegativo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(443, 16)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Local / Bodega"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cLocalBodega)
        Me.GroupBox4.Controls.Add(Me.oBodega)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.oLocal)
        Me.GroupBox4.Location = New System.Drawing.Point(445, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(419, 59)
        Me.GroupBox4.TabIndex = 286
        Me.GroupBox4.TabStop = False
        '
        'cLocalBodega
        '
        Me.cLocalBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocalBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocalBodega.FormattingEnabled = True
        Me.cLocalBodega.Location = New System.Drawing.Point(6, 27)
        Me.cLocalBodega.Name = "cLocalBodega"
        Me.cLocalBodega.Size = New System.Drawing.Size(212, 23)
        Me.cLocalBodega.TabIndex = 137
        '
        'oBodega
        '
        Me.oBodega.Appearance = System.Windows.Forms.Appearance.Button
        Me.oBodega.BackColor = System.Drawing.Color.White
        Me.oBodega.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBodega.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBodega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oBodega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oBodega.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.oBodega.ForeColor = System.Drawing.Color.Black
        Me.oBodega.Image = CType(resources.GetObject("oBodega.Image"), System.Drawing.Image)
        Me.oBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oBodega.Location = New System.Drawing.Point(320, 22)
        Me.oBodega.Name = "oBodega"
        Me.oBodega.Size = New System.Drawing.Size(90, 30)
        Me.oBodega.TabIndex = 49
        Me.oBodega.Text = "Por Bodega"
        Me.oBodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oBodega.UseVisualStyleBackColor = False
        '
        'oLocal
        '
        Me.oLocal.Appearance = System.Windows.Forms.Appearance.Button
        Me.oLocal.BackColor = System.Drawing.Color.White
        Me.oLocal.Checked = True
        Me.oLocal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oLocal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oLocal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oLocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oLocal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.oLocal.ForeColor = System.Drawing.Color.White
        Me.oLocal.Image = CType(resources.GetObject("oLocal.Image"), System.Drawing.Image)
        Me.oLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oLocal.Location = New System.Drawing.Point(224, 22)
        Me.oLocal.Name = "oLocal"
        Me.oLocal.Size = New System.Drawing.Size(90, 30)
        Me.oLocal.TabIndex = 48
        Me.oLocal.TabStop = True
        Me.oLocal.Text = "Por Local"
        Me.oLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oLocal.UseVisualStyleBackColor = False
        '
        'sStock
        '
        Me.sStock.DataSource = GetType(Rebusco.StockConsulta)
        '
        'bExportar
        '
        Me.bExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bExportar.BackColor = System.Drawing.Color.White
        Me.bExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExportar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bExportar.Image = Global.Rebusco.My.Resources.Resources.excel24
        Me.bExportar.Location = New System.Drawing.Point(805, 527)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(100, 36)
        Me.bExportar.TabIndex = 287
        Me.bExportar.Text = "Exportar"
        Me.bExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bExportar.UseVisualStyleBackColor = False
        '
        'ListadoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 575)
        Me.Controls.Add(Me.bExportar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ListadoStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Stock de Artículos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.sStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Public WithEvents bBuscar As Button
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cOrdenar As ComboBox
    Public WithEvents bCancelar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bLimpiar As Button

    Friend WithEvents Label3 As Label
    Friend WithEvents rDes As CustomRadio
    Friend WithEvents rAsc As CustomRadio
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Public WithEvents bConsultar As Button
    Friend WithEvents oStockPositivo As CustomCheck
    Friend WithEvents oStockNegativo As CustomCheck
    Friend WithEvents oStockCero As CustomCheck
    Friend WithEvents oBajoStockMinimo As CustomCheck
    Friend WithEvents sStock As BindingSource
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents oBodega As CustomRadio
    Friend WithEvents oLocal As CustomRadio
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cLocalBodega As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cSubFamilia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cFamilia As ComboBox
    Public WithEvents bExportar As Button
    Friend WithEvents xArticulo As TextBoxAutoComple
End Class
