<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimientos
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimientos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cMovimientos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cBodegas = New System.Windows.Forms.ComboBox()
        Me.xMovimiento = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bCargarMovimiento = New System.Windows.Forms.Button()
        Me.cResponsable = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xDocumento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.EliminarDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New Rebusco.TextAndImageColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New Rebusco.TextAndImageColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sDetalleMov = New System.Windows.Forms.BindingSource(Me.components)
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xCantidad = New System.Windows.Forms.TextBox()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.xObservacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDetalleMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cMovimientos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cBodegas)
        Me.GroupBox1.Controls.Add(Me.xMovimiento)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(7, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "N° Movimiento"
        '
        'cMovimientos
        '
        Me.cMovimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMovimientos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cMovimientos.FormattingEnabled = True
        Me.cMovimientos.Location = New System.Drawing.Point(121, 53)
        Me.cMovimientos.Name = "cMovimientos"
        Me.cMovimientos.Size = New System.Drawing.Size(327, 23)
        Me.cMovimientos.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha"
        '
        'dFecha
        '
        Me.dFecha.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFecha.Location = New System.Drawing.Point(121, 82)
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Size = New System.Drawing.Size(90, 21)
        Me.dFecha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(7, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bodega"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipo Movimiento"
        '
        'cBodegas
        '
        Me.cBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodegas.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cBodegas.FormattingEnabled = True
        Me.cBodegas.Location = New System.Drawing.Point(121, 109)
        Me.cBodegas.Name = "cBodegas"
        Me.cBodegas.Size = New System.Drawing.Size(327, 23)
        Me.cBodegas.TabIndex = 0
        '
        'xMovimiento
        '
        Me.xMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xMovimiento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xMovimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xMovimiento.Location = New System.Drawing.Point(121, 26)
        Me.xMovimiento.Name = "xMovimiento"
        Me.xMovimiento.ReadOnly = True
        Me.xMovimiento.Size = New System.Drawing.Size(90, 21)
        Me.xMovimiento.TabIndex = 1
        Me.xMovimiento.Text = "100"
        Me.xMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.bCargarMovimiento)
        Me.GroupBox3.Controls.Add(Me.cResponsable)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.xDocumento)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cTipoDoc)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(472, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 141)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Responsable"
        '
        'bCargarMovimiento
        '
        Me.bCargarMovimiento.BackColor = System.Drawing.Color.White
        Me.bCargarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargarMovimiento.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCargarMovimiento.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bCargarMovimiento.Location = New System.Drawing.Point(229, 54)
        Me.bCargarMovimiento.Name = "bCargarMovimiento"
        Me.bCargarMovimiento.Size = New System.Drawing.Size(140, 28)
        Me.bCargarMovimiento.TabIndex = 74
        Me.bCargarMovimiento.Text = "Cargar Documento"
        Me.bCargarMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCargarMovimiento.UseVisualStyleBackColor = False
        Me.bCargarMovimiento.Visible = False
        '
        'cResponsable
        '
        Me.cResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cResponsable.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cResponsable.FormattingEnabled = True
        Me.cResponsable.Location = New System.Drawing.Point(125, 88)
        Me.cResponsable.Name = "cResponsable"
        Me.cResponsable.Size = New System.Drawing.Size(244, 23)
        Me.cResponsable.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "N° Documento"
        '
        'xDocumento
        '
        Me.xDocumento.BackColor = System.Drawing.Color.White
        Me.xDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDocumento.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDocumento.Location = New System.Drawing.Point(125, 54)
        Me.xDocumento.Name = "xDocumento"
        Me.xDocumento.Size = New System.Drawing.Size(98, 21)
        Me.xDocumento.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tipo Documento"
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(125, 25)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(244, 23)
        Me.cTipoDoc.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.xTabla)
        Me.GroupBox4.Controls.Add(Me.bBuscar)
        Me.GroupBox4.Controls.Add(Me.xArticulo)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.xCantidad)
        Me.GroupBox4.Controls.Add(Me.bAgregar)
        Me.GroupBox4.Controls.Add(Me.xDescripcion)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(835, 337)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        Me.xTabla.AllowUserToResizeRows = False
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
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EliminarDataGridViewImageColumn, Me.BarraDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.Total})
        Me.xTabla.DataSource = Me.sDetalleMov
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xTabla.DefaultCellStyle = DataGridViewCellStyle6
        Me.xTabla.Location = New System.Drawing.Point(6, 44)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(823, 287)
        Me.xTabla.TabIndex = 337
        '
        'EliminarDataGridViewImageColumn
        '
        Me.EliminarDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EliminarDataGridViewImageColumn.DataPropertyName = "Eliminar"
        Me.EliminarDataGridViewImageColumn.HeaderText = "Eliminar"
        Me.EliminarDataGridViewImageColumn.Name = "EliminarDataGridViewImageColumn"
        Me.EliminarDataGridViewImageColumn.ReadOnly = True
        Me.EliminarDataGridViewImageColumn.Width = 60
        '
        'BarraDataGridViewTextBoxColumn
        '
        Me.BarraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BarraDataGridViewTextBoxColumn.DataPropertyName = "Barra"
        Me.BarraDataGridViewTextBoxColumn.HeaderText = "Barra"
        Me.BarraDataGridViewTextBoxColumn.Name = "BarraDataGridViewTextBoxColumn"
        Me.BarraDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarraDataGridViewTextBoxColumn.Width = 64
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Image = Global.Rebusco.My.Resources.Resources.editGrid
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CostoDataGridViewTextBoxColumn.Width = 67
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.PrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.PrecioVentaDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioVentaDataGridViewTextBoxColumn.Width = 120
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Image = Global.Rebusco.My.Resources.Resources.editGrid
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 82
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CantidadDataGridViewTextBoxColumn.Width = 85
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'sDetalleMov
        '
        Me.sDetalleMov.DataSource = GetType(Rebusco.DetalleMovimiento)
        '
        'bBuscar
        '
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscar.Location = New System.Drawing.Point(540, 12)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(73, 27)
        Me.bBuscar.TabIndex = 114
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 800
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "SKU"
        Me.xArticulo.DescBusquedaAdicional2 = "Barra"
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 2
        Me.xArticulo.Location = New System.Drawing.Point(60, 14)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(116, 22)
        Me.xArticulo.TabIndex = 113
        Me.xArticulo.TablaBusqueda = "BuscadorAutocompletar"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(616, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Cantidad"
        '
        'xCantidad
        '
        Me.xCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.xCantidad.Location = New System.Drawing.Point(675, 14)
        Me.xCantidad.Name = "xCantidad"
        Me.xCantidad.Size = New System.Drawing.Size(64, 22)
        Me.xCantidad.TabIndex = 2
        Me.xCantidad.Text = "0"
        Me.xCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bAgregar
        '
        Me.bAgregar.BackColor = System.Drawing.Color.White
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregar.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bAgregar.Location = New System.Drawing.Point(745, 10)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(84, 28)
        Me.bAgregar.TabIndex = 4
        Me.bAgregar.Text = "Agregar"
        Me.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregar.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(182, 15)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(352, 21)
        Me.xDescripcion.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(7, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Artículo"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.xObservacion)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 549)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(834, 72)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        '
        'xObservacion
        '
        Me.xObservacion.BackColor = System.Drawing.Color.White
        Me.xObservacion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xObservacion.Location = New System.Drawing.Point(8, 19)
        Me.xObservacion.Multiline = True
        Me.xObservacion.Name = "xObservacion"
        Me.xObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.xObservacion.Size = New System.Drawing.Size(820, 47)
        Me.xObservacion.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(455, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Documento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(473, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 16)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Documento Referencia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 544)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(835, 16)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Observaciones"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 55
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
        Me.WinDeco1.Size = New System.Drawing.Size(859, 50)
        Me.WinDeco1.TabIndex = 137
        Me.WinDeco1.TituloVentana = "Movimiento de Mercaderías"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bGuardar
        '
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(642, 640)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 2
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 640)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 1
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(748, 640)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'lTotal
        '
        Me.lTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lTotal.AutoSize = True
        Me.lTotal.BackColor = System.Drawing.Color.Transparent
        Me.lTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.Color.White
        Me.lTotal.Location = New System.Drawing.Point(198, 650)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(15, 16)
        Me.lTotal.TabIndex = 339
        Me.lTotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(118, 650)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 340
        Me.Label5.Text = "Total ítems"
        '
        'Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 688)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "Movimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Mercaderías"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDetalleMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xMovimiento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cBodegas As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cResponsable As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xDocumento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label9 As Label
    Public WithEvents bAgregar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bGuardar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents xCantidad As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents xObservacion As TextBox
    Public WithEvents bCargarMovimiento As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents cMovimientos As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents bBuscar As Button
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents sDetalleMov As BindingSource
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EliminarDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents BarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents lTotal As Label
    Friend WithEvents Label5 As Label
End Class
