<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CambioPrecios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioPrecios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pLimpiarSubF = New System.Windows.Forms.PictureBox()
        Me.pLImpiarArt = New System.Windows.Forms.PictureBox()
        Me.pLimpiarFam = New System.Windows.Forms.PictureBox()
        Me.oPendienteCosto = New Rebusco.CustomRadio()
        Me.xSKU = New System.Windows.Forms.TextBox()
        Me.oSinPrecioVenta = New Rebusco.CustomRadio()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.oSinCosto = New Rebusco.CustomRadio()
        Me.bBuscar = New Rebusco.SearchButton()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.oTodos = New Rebusco.CustomRadio()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cSubFamilia = New System.Windows.Forms.ComboBox()
        Me.cFamilia = New System.Windows.Forms.ComboBox()
        Me.xSubfamilia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xFamilia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lLocal = New System.Windows.Forms.Label()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New Rebusco.TextAndImageColumn()
        Me.MargenDataGridViewTextBoxColumn = New Rebusco.TextAndImageColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New Rebusco.TextAndImageColumn()
        Me.sArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pLimpiarSubF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pLImpiarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pLimpiarFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pLimpiarSubF)
        Me.GroupBox1.Controls.Add(Me.pLImpiarArt)
        Me.GroupBox1.Controls.Add(Me.pLimpiarFam)
        Me.GroupBox1.Controls.Add(Me.oPendienteCosto)
        Me.GroupBox1.Controls.Add(Me.xSKU)
        Me.GroupBox1.Controls.Add(Me.oSinPrecioVenta)
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.oSinCosto)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.oTodos)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cSubFamilia)
        Me.GroupBox1.Controls.Add(Me.cFamilia)
        Me.GroupBox1.Controls.Add(Me.xSubfamilia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xFamilia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'pLimpiarSubF
        '
        Me.pLimpiarSubF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pLimpiarSubF.Image = Global.Rebusco.My.Resources.Resources.clean16b
        Me.pLimpiarSubF.Location = New System.Drawing.Point(476, 116)
        Me.pLimpiarSubF.Name = "pLimpiarSubF"
        Me.pLimpiarSubF.Size = New System.Drawing.Size(20, 20)
        Me.pLimpiarSubF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pLimpiarSubF.TabIndex = 340
        Me.pLimpiarSubF.TabStop = False
        Me.pLimpiarSubF.Visible = False
        '
        'pLImpiarArt
        '
        Me.pLImpiarArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pLImpiarArt.Image = Global.Rebusco.My.Resources.Resources.clean16b
        Me.pLImpiarArt.Location = New System.Drawing.Point(476, 55)
        Me.pLImpiarArt.Name = "pLImpiarArt"
        Me.pLImpiarArt.Size = New System.Drawing.Size(20, 20)
        Me.pLImpiarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pLImpiarArt.TabIndex = 339
        Me.pLImpiarArt.TabStop = False
        Me.pLImpiarArt.Visible = False
        '
        'pLimpiarFam
        '
        Me.pLimpiarFam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pLimpiarFam.Image = Global.Rebusco.My.Resources.Resources.clean16b
        Me.pLimpiarFam.Location = New System.Drawing.Point(476, 86)
        Me.pLimpiarFam.Name = "pLimpiarFam"
        Me.pLimpiarFam.Size = New System.Drawing.Size(20, 20)
        Me.pLimpiarFam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pLimpiarFam.TabIndex = 338
        Me.pLimpiarFam.TabStop = False
        Me.pLimpiarFam.Visible = False
        '
        'oPendienteCosto
        '
        Me.oPendienteCosto.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPendienteCosto.BackColor = System.Drawing.Color.White
        Me.oPendienteCosto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oPendienteCosto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPendienteCosto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPendienteCosto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPendienteCosto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPendienteCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPendienteCosto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oPendienteCosto.ForeColor = System.Drawing.Color.Black
        Me.oPendienteCosto.Image = CType(resources.GetObject("oPendienteCosto.Image"), System.Drawing.Image)
        Me.oPendienteCosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPendienteCosto.Location = New System.Drawing.Point(514, 110)
        Me.oPendienteCosto.Name = "oPendienteCosto"
        Me.oPendienteCosto.Size = New System.Drawing.Size(168, 27)
        Me.oPendienteCosto.TabIndex = 337
        Me.oPendienteCosto.Text = " Solo diferencia en costo"
        Me.oPendienteCosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPendienteCosto.UseVisualStyleBackColor = False
        '
        'xSKU
        '
        Me.xSKU.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xSKU.Location = New System.Drawing.Point(215, 23)
        Me.xSKU.Name = "xSKU"
        Me.xSKU.ReadOnly = True
        Me.xSKU.Size = New System.Drawing.Size(173, 23)
        Me.xSKU.TabIndex = 14
        '
        'oSinPrecioVenta
        '
        Me.oSinPrecioVenta.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSinPrecioVenta.BackColor = System.Drawing.Color.White
        Me.oSinPrecioVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oSinPrecioVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSinPrecioVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSinPrecioVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSinPrecioVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSinPrecioVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSinPrecioVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oSinPrecioVenta.ForeColor = System.Drawing.Color.Black
        Me.oSinPrecioVenta.Image = CType(resources.GetObject("oSinPrecioVenta.Image"), System.Drawing.Image)
        Me.oSinPrecioVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSinPrecioVenta.Location = New System.Drawing.Point(514, 80)
        Me.oSinPrecioVenta.Name = "oSinPrecioVenta"
        Me.oSinPrecioVenta.Size = New System.Drawing.Size(168, 27)
        Me.oSinPrecioVenta.TabIndex = 337
        Me.oSinPrecioVenta.Text = " Solo sin precio venta"
        Me.oSinPrecioVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSinPrecioVenta.UseVisualStyleBackColor = False
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
        Me.xArticulo.Location = New System.Drawing.Point(108, 24)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(101, 22)
        Me.xArticulo.TabIndex = 9
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'oSinCosto
        '
        Me.oSinCosto.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSinCosto.BackColor = System.Drawing.Color.White
        Me.oSinCosto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oSinCosto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSinCosto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSinCosto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSinCosto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSinCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSinCosto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oSinCosto.ForeColor = System.Drawing.Color.Black
        Me.oSinCosto.Image = CType(resources.GetObject("oSinCosto.Image"), System.Drawing.Image)
        Me.oSinCosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSinCosto.Location = New System.Drawing.Point(514, 50)
        Me.oSinCosto.Name = "oSinCosto"
        Me.oSinCosto.Size = New System.Drawing.Size(168, 27)
        Me.oSinCosto.TabIndex = 337
        Me.oSinCosto.Text = " Solo sin costo"
        Me.oSinCosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSinCosto.UseVisualStyleBackColor = False
        '
        'bBuscar
        '
        Me.bBuscar.CampoBuscar1 = "Descripcion"
        Me.bBuscar.CampoBuscar2 = ""
        Me.bBuscar.CamposAdicionales = ""
        Me.bBuscar.ControlCarga = Me.xArticulo
        Me.bBuscar.ControlFocus = Me.xDescripcion
        Me.bBuscar.Filtro = ""
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscar.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscar.IDBusqueda = "Articulo"
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(394, 20)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(80, 28)
        Me.bBuscar.TabIndex = 10
        Me.bBuscar.TablaBusqueda = "Articulos"
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.Titulo = "Buscar Articulo"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(108, 53)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(366, 21)
        Me.xDescripcion.TabIndex = 11
        '
        'oTodos
        '
        Me.oTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.oTodos.BackColor = System.Drawing.Color.White
        Me.oTodos.Checked = True
        Me.oTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oTodos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oTodos.ForeColor = System.Drawing.Color.White
        Me.oTodos.Image = CType(resources.GetObject("oTodos.Image"), System.Drawing.Image)
        Me.oTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oTodos.Location = New System.Drawing.Point(514, 20)
        Me.oTodos.Name = "oTodos"
        Me.oTodos.Size = New System.Drawing.Size(168, 27)
        Me.oTodos.TabIndex = 337
        Me.oTodos.TabStop = True
        Me.oTodos.Text = " Todos"
        Me.oTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oTodos.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Artículo"
        '
        'cSubFamilia
        '
        Me.cSubFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSubFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSubFamilia.FormattingEnabled = True
        Me.cSubFamilia.Location = New System.Drawing.Point(181, 113)
        Me.cSubFamilia.Name = "cSubFamilia"
        Me.cSubFamilia.Size = New System.Drawing.Size(293, 23)
        Me.cSubFamilia.TabIndex = 8
        Me.cSubFamilia.TabStop = False
        '
        'cFamilia
        '
        Me.cFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cFamilia.FormattingEnabled = True
        Me.cFamilia.Location = New System.Drawing.Point(181, 83)
        Me.cFamilia.Name = "cFamilia"
        Me.cFamilia.Size = New System.Drawing.Size(293, 23)
        Me.cFamilia.TabIndex = 6
        Me.cFamilia.TabStop = False
        '
        'xSubfamilia
        '
        Me.xSubfamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSubfamilia.Location = New System.Drawing.Point(122, 113)
        Me.xSubfamilia.MaxLength = 18
        Me.xSubfamilia.Name = "xSubfamilia"
        Me.xSubfamilia.Size = New System.Drawing.Size(53, 21)
        Me.xSubfamilia.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sub Familia"
        '
        'xFamilia
        '
        Me.xFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFamilia.Location = New System.Drawing.Point(122, 84)
        Me.xFamilia.MaxLength = 18
        Me.xFamilia.Name = "xFamilia"
        Me.xFamilia.Size = New System.Drawing.Size(53, 21)
        Me.xFamilia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Familia"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(12, 57)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(698, 16)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Filtro"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lLocal
        '
        Me.lLocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lLocal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLocal.ForeColor = System.Drawing.Color.White
        Me.lLocal.Location = New System.Drawing.Point(714, 13)
        Me.lLocal.Name = "lLocal"
        Me.lLocal.Size = New System.Drawing.Size(317, 23)
        Me.lLocal.TabIndex = 335
        Me.lLocal.Text = "Local"
        Me.lLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        Me.xTabla.AllowUserToResizeRows = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.AutoGenerateColumns = False
        Me.xTabla.BackgroundColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xTabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArticuloDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CostoMovimiento, Me.CostoDataGridViewTextBoxColumn, Me.MargenDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.sArticulos
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xTabla.DefaultCellStyle = DataGridViewCellStyle7
        Me.xTabla.Location = New System.Drawing.Point(12, 209)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(1240, 246)
        Me.xTabla.TabIndex = 336
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "Artículo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ArticuloDataGridViewTextBoxColumn.Width = 77
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.SKUDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SKUDataGridViewTextBoxColumn.Width = 57
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 400
        '
        'CostoMovimiento
        '
        Me.CostoMovimiento.DataPropertyName = "CostoMovimiento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.CostoMovimiento.DefaultCellStyle = DataGridViewCellStyle3
        Me.CostoMovimiento.HeaderText = "Nuevo Costo Neto"
        Me.CostoMovimiento.MinimumWidth = 180
        Me.CostoMovimiento.Name = "CostoMovimiento"
        Me.CostoMovimiento.Width = 180
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "-1"
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo Neto Actual"
        Me.CostoDataGridViewTextBoxColumn.Image = Global.Rebusco.My.Resources.Resources.editGrid
        Me.CostoDataGridViewTextBoxColumn.MinimumWidth = 180
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CostoDataGridViewTextBoxColumn.Width = 180
        '
        'MargenDataGridViewTextBoxColumn
        '
        Me.MargenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MargenDataGridViewTextBoxColumn.DataPropertyName = "Margen"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "-1"
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.MargenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.MargenDataGridViewTextBoxColumn.HeaderText = "% Margen"
        Me.MargenDataGridViewTextBoxColumn.Image = Global.Rebusco.My.Resources.Resources.editGrid
        Me.MargenDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.MargenDataGridViewTextBoxColumn.Name = "MargenDataGridViewTextBoxColumn"
        Me.MargenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "-1"
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.PrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio Venta (IVA inc.)"
        Me.PrecioVentaDataGridViewTextBoxColumn.Image = Global.Rebusco.My.Resources.Resources.editGrid
        Me.PrecioVentaDataGridViewTextBoxColumn.MinimumWidth = 170
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrecioVentaDataGridViewTextBoxColumn.Width = 170
        '
        'sArticulos
        '
        Me.sArticulos.DataSource = GetType(Rebusco.ArticuloPrecio)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CostoMovimiento"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Costo Ingreso"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bConsultar.Image = CType(resources.GetObject("bConsultar.Image"), System.Drawing.Image)
        Me.bConsultar.Location = New System.Drawing.Point(715, 166)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(102, 36)
        Me.bConsultar.TabIndex = 334
        Me.bConsultar.Text = " Consultar"
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(1264, 50)
        Me.WinDeco1.TabIndex = 333
        Me.WinDeco1.TituloVentana = "Cambio de Precios"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(1046, 480)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 4
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 480)
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
        Me.bSalir.Location = New System.Drawing.Point(1152, 480)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'lTotal
        '
        Me.lTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lTotal.AutoSize = True
        Me.lTotal.BackColor = System.Drawing.Color.Transparent
        Me.lTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.Color.White
        Me.lTotal.Location = New System.Drawing.Point(227, 490)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(15, 16)
        Me.lTotal.TabIndex = 337
        Me.lTotal.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(124, 490)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "Total artículos"
        '
        'CambioPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 529)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.lLocal)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1264, 768)
        Me.Name = "CambioPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Precios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pLimpiarSubF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pLImpiarArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pLimpiarFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cSubFamilia As ComboBox
    Friend WithEvents cFamilia As ComboBox
    Friend WithEvents xSubfamilia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xFamilia As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents bGuardar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label42 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Public WithEvents bConsultar As Button
    Friend WithEvents lLocal As Label
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents sArticulos As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents bBuscar As SearchButton
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents xSKU As TextBox
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents MargenDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents oPendienteCosto As CustomRadio
    Friend WithEvents oSinPrecioVenta As CustomRadio
    Friend WithEvents oSinCosto As CustomRadio
    Friend WithEvents oTodos As CustomRadio
    Friend WithEvents lTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pLimpiarSubF As PictureBox
    Friend WithEvents pLImpiarArt As PictureBox
    Friend WithEvents pLimpiarFam As PictureBox
End Class
