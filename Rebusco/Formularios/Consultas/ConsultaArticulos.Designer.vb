<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaArticulos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.bBuscarA = New System.Windows.Forms.Button()
        Me.cFamilia = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.COrden = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oAsc = New Rebusco.CustomRadio()
        Me.oDesc = New Rebusco.CustomRadio()
        Me.oSoloActivos = New Rebusco.CustomCheck()
        Me.oSoloBarra = New Rebusco.CustomCheck()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.bBuscarA)
        Me.GroupBox1.Controls.Add(Me.cFamilia)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 104)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(750, 16)
        Me.Label3.TabIndex = 244
        Me.Label3.Text = "Filtro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 500
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "SKU"
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(90, 27)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(123, 21)
        Me.xArticulo.TabIndex = 242
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarA.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(650, 25)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(84, 27)
        Me.bBuscarA.TabIndex = 237
        Me.bBuscarA.Text = "Buscar"
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'cFamilia
        '
        Me.cFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFamilia.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFamilia.FormattingEnabled = True
        Me.cFamilia.Location = New System.Drawing.Point(90, 55)
        Me.cFamilia.Name = "cFamilia"
        Me.cFamilia.Size = New System.Drawing.Size(335, 23)
        Me.cFamilia.TabIndex = 121
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(7, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Familia"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(219, 27)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(425, 21)
        Me.xDescripcion.TabIndex = 116
        Me.xDescripcion.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Artículo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.COrden)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.oAsc)
        Me.GroupBox2.Controls.Add(Me.oDesc)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 59)
        Me.GroupBox2.TabIndex = 135
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(750, 16)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Ordenar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'COrden
        '
        Me.COrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COrden.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.COrden.FormattingEnabled = True
        Me.COrden.Location = New System.Drawing.Point(45, 24)
        Me.COrden.Name = "COrden"
        Me.COrden.Size = New System.Drawing.Size(287, 23)
        Me.COrden.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(11, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Por"
        '
        'oAsc
        '
        Me.oAsc.Appearance = System.Windows.Forms.Appearance.Button
        Me.oAsc.BackColor = System.Drawing.Color.White
        Me.oAsc.Checked = True
        Me.oAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAsc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAsc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oAsc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oAsc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oAsc.ForeColor = System.Drawing.Color.White
        Me.oAsc.Image = CType(resources.GetObject("oAsc.Image"), System.Drawing.Image)
        Me.oAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oAsc.Location = New System.Drawing.Point(338, 19)
        Me.oAsc.Name = "oAsc"
        Me.oAsc.Size = New System.Drawing.Size(114, 30)
        Me.oAsc.TabIndex = 124
        Me.oAsc.TabStop = True
        Me.oAsc.Text = "Ascendente"
        Me.oAsc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oAsc.UseVisualStyleBackColor = False
        '
        'oDesc
        '
        Me.oDesc.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDesc.BackColor = System.Drawing.Color.White
        Me.oDesc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDesc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDesc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oDesc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDesc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oDesc.ForeColor = System.Drawing.Color.Black
        Me.oDesc.Image = CType(resources.GetObject("oDesc.Image"), System.Drawing.Image)
        Me.oDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDesc.Location = New System.Drawing.Point(458, 19)
        Me.oDesc.Name = "oDesc"
        Me.oDesc.Size = New System.Drawing.Size(114, 30)
        Me.oDesc.TabIndex = 125
        Me.oDesc.Text = "Descendente"
        Me.oDesc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDesc.UseVisualStyleBackColor = False
        '
        'oSoloActivos
        '
        Me.oSoloActivos.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSoloActivos.BackColor = System.Drawing.Color.White
        Me.oSoloActivos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloActivos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloActivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSoloActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSoloActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSoloActivos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oSoloActivos.ForeColor = System.Drawing.Color.Black
        Me.oSoloActivos.Image = CType(resources.GetObject("oSoloActivos.Image"), System.Drawing.Image)
        Me.oSoloActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSoloActivos.Location = New System.Drawing.Point(6, 24)
        Me.oSoloActivos.Name = "oSoloActivos"
        Me.oSoloActivos.Size = New System.Drawing.Size(149, 30)
        Me.oSoloActivos.TabIndex = 127
        Me.oSoloActivos.Text = "Solo Activos Fijos"
        Me.oSoloActivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSoloActivos.UseVisualStyleBackColor = False
        '
        'oSoloBarra
        '
        Me.oSoloBarra.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSoloBarra.BackColor = System.Drawing.Color.White
        Me.oSoloBarra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloBarra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloBarra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSoloBarra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSoloBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSoloBarra.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oSoloBarra.ForeColor = System.Drawing.Color.Black
        Me.oSoloBarra.Image = CType(resources.GetObject("oSoloBarra.Image"), System.Drawing.Image)
        Me.oSoloBarra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSoloBarra.Location = New System.Drawing.Point(6, 60)
        Me.oSoloBarra.Name = "oSoloBarra"
        Me.oSoloBarra.Size = New System.Drawing.Size(149, 30)
        Me.oSoloBarra.TabIndex = 126
        Me.oSoloBarra.Text = "Solo código de barra"
        Me.oSoloBarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSoloBarra.UseVisualStyleBackColor = False
        '
        'xTabla
        '
        Me.xTabla.AllowDelete = True
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.xTabla.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(12, 233)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(914, 280)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 136
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(762, 166)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(164, 59)
        Me.bConsultar.TabIndex = 137
        Me.bConsultar.Text = "   Consultar"
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(822, 535)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 138
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 535)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 139
        Me.bLimpiar.Text = " Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(720, 535)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(96, 36)
        Me.bImprimir.TabIndex = 140
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(934, 50)
        Me.WinDeco1.TabIndex = 241
        Me.WinDeco1.TituloVentana = "Consulta de Artículos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.oSoloActivos)
        Me.GroupBox3.Controls.Add(Me.oSoloBarra)
        Me.GroupBox3.Location = New System.Drawing.Point(762, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 103)
        Me.GroupBox3.TabIndex = 242
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 16)
        Me.Label6.TabIndex = 245
        Me.Label6.Text = "Opciones"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsultaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 583)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Artículos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents cFamilia As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents COrden As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents oAsc As CustomRadio
    Friend WithEvents oDesc As CustomRadio
    Friend WithEvents oSoloBarra As CustomCheck
    Friend WithEvents oSoloActivos As CustomCheck
    Public WithEvents bBuscarA As Button
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bConsultar As Button
    Public WithEvents bSalir As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
End Class
