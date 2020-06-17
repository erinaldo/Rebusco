<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaTracking
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaTracking))
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xNumdoc = New System.Windows.Forms.TextBox()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lBodega = New System.Windows.Forms.Label()
        Me.cBodega = New System.Windows.Forms.ComboBox()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oDatosDocumento = New Rebusco.CustomCheck()
        Me.oDatosCliente = New Rebusco.CustomCheck()
        Me.oIdentificadores = New Rebusco.CustomCheck()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.colTracking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreLocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumeroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sTracking = New System.Windows.Forms.BindingSource(Me.components)
        Me.bExportar = New System.Windows.Forms.Button()
        Me.fDialogo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(1064, 138)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(164, 35)
        Me.bConsultar.TabIndex = 137
        Me.bConsultar.Text = "   Consultar Tracking"
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
        Me.bSalir.Location = New System.Drawing.Point(1128, 535)
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
        Me.WinDeco1.Size = New System.Drawing.Size(1240, 50)
        Me.WinDeco1.TabIndex = 241
        Me.WinDeco1.TituloVentana = "Consulta de Tracking"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Artículo"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(228, 79)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(409, 21)
        Me.xDescripcion.TabIndex = 116
        Me.xDescripcion.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(831, 16)
        Me.Label11.TabIndex = 340
        Me.Label11.Text = "Filtros"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xNumdoc)
        Me.GroupBox2.Controls.Add(Me.xArticulo)
        Me.GroupBox2.Controls.Add(Me.cTipoDoc)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.xDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cLocal)
        Me.GroupBox2.Controls.Add(Me.dHasta)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dDesde)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lBodega)
        Me.GroupBox2.Controls.Add(Me.cBodega)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(831, 115)
        Me.GroupBox2.TabIndex = 339
        Me.GroupBox2.TabStop = False
        '
        'xNumdoc
        '
        Me.xNumdoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xNumdoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNumdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumdoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNumdoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xNumdoc.Location = New System.Drawing.Point(702, 22)
        Me.xNumdoc.Name = "xNumdoc"
        Me.xNumdoc.Size = New System.Drawing.Size(123, 21)
        Me.xNumdoc.TabIndex = 4
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(452, 21)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(185, 23)
        Me.cTipoDoc.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(336, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Tipo de Documento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(644, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 219
        Me.Label10.Text = "Número"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(114, 49)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(214, 23)
        Me.cLocal.TabIndex = 2
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(237, 21)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(91, 21)
        Me.dHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(214, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Al"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Local"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(114, 21)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(90, 21)
        Me.dDesde.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(8, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Rango de Fecha"
        '
        'lBodega
        '
        Me.lBodega.AutoSize = True
        Me.lBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lBodega.Location = New System.Drawing.Point(336, 53)
        Me.lBodega.Name = "lBodega"
        Me.lBodega.Size = New System.Drawing.Size(50, 15)
        Me.lBodega.TabIndex = 25
        Me.lBodega.Text = "Bodega"
        '
        'cBodega
        '
        Me.cBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cBodega.FormattingEnabled = True
        Me.cBodega.Location = New System.Drawing.Point(452, 50)
        Me.cBodega.Name = "cBodega"
        Me.cBodega.Size = New System.Drawing.Size(185, 23)
        Me.cBodega.TabIndex = 8
        '
        'lTotal
        '
        Me.lTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lTotal.AutoSize = True
        Me.lTotal.BackColor = System.Drawing.Color.Transparent
        Me.lTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.Color.White
        Me.lTotal.Location = New System.Drawing.Point(216, 545)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(15, 16)
        Me.lTotal.TabIndex = 344
        Me.lTotal.Text = "0"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(118, 545)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 16)
        Me.Label19.TabIndex = 345
        Me.Label19.Text = "Total eventos"
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xTabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTracking, Me.FechaEventoDataGridViewTextBoxColumn, Me.colEvento, Me.DataGridViewTextBoxColumn1, Me.ArticuloDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.colLocal, Me.NombreLocalDataGridViewTextBoxColumn, Me.colBodega, Me.NombreBodegaDataGridViewTextBoxColumn, Me.colFechaDocumento, Me.colTipoDocumento, Me.colNumeroDoc, Me.colCliente, Me.colRut, Me.colNombreCliente, Me.UsuarioDataGridViewTextBoxColumn, Me.ModuloDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.sTracking
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xTabla.DefaultCellStyle = DataGridViewCellStyle6
        Me.xTabla.Location = New System.Drawing.Point(12, 182)
        Me.xTabla.MultiSelect = False
        Me.xTabla.Name = "xTabla"
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(1216, 332)
        Me.xTabla.TabIndex = 338
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(849, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 16)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "Columnas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.oDatosDocumento)
        Me.GroupBox1.Controls.Add(Me.oDatosCliente)
        Me.GroupBox1.Controls.Add(Me.oIdentificadores)
        Me.GroupBox1.Location = New System.Drawing.Point(849, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 114)
        Me.GroupBox1.TabIndex = 348
        Me.GroupBox1.TabStop = False
        '
        'oDatosDocumento
        '
        Me.oDatosDocumento.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDatosDocumento.BackColor = System.Drawing.Color.White
        Me.oDatosDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oDatosDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDatosDocumento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDatosDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oDatosDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oDatosDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDatosDocumento.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oDatosDocumento.ForeColor = System.Drawing.Color.Black
        Me.oDatosDocumento.Image = CType(resources.GetObject("oDatosDocumento.Image"), System.Drawing.Image)
        Me.oDatosDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDatosDocumento.Location = New System.Drawing.Point(6, 19)
        Me.oDatosDocumento.Name = "oDatosDocumento"
        Me.oDatosDocumento.Size = New System.Drawing.Size(195, 26)
        Me.oDatosDocumento.TabIndex = 343
        Me.oDatosDocumento.Text = " Mostrar datos de documento"
        Me.oDatosDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDatosDocumento.UseVisualStyleBackColor = False
        '
        'oDatosCliente
        '
        Me.oDatosCliente.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDatosCliente.BackColor = System.Drawing.Color.White
        Me.oDatosCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oDatosCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDatosCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDatosCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oDatosCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oDatosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDatosCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oDatosCliente.ForeColor = System.Drawing.Color.Black
        Me.oDatosCliente.Image = CType(resources.GetObject("oDatosCliente.Image"), System.Drawing.Image)
        Me.oDatosCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDatosCliente.Location = New System.Drawing.Point(6, 51)
        Me.oDatosCliente.Name = "oDatosCliente"
        Me.oDatosCliente.Size = New System.Drawing.Size(195, 26)
        Me.oDatosCliente.TabIndex = 342
        Me.oDatosCliente.Text = " Mostrar datos de cliente"
        Me.oDatosCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDatosCliente.UseVisualStyleBackColor = False
        '
        'oIdentificadores
        '
        Me.oIdentificadores.Appearance = System.Windows.Forms.Appearance.Button
        Me.oIdentificadores.BackColor = System.Drawing.Color.White
        Me.oIdentificadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oIdentificadores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oIdentificadores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oIdentificadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oIdentificadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oIdentificadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oIdentificadores.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oIdentificadores.ForeColor = System.Drawing.Color.Black
        Me.oIdentificadores.Image = CType(resources.GetObject("oIdentificadores.Image"), System.Drawing.Image)
        Me.oIdentificadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oIdentificadores.Location = New System.Drawing.Point(6, 83)
        Me.oIdentificadores.Name = "oIdentificadores"
        Me.oIdentificadores.Size = New System.Drawing.Size(195, 26)
        Me.oIdentificadores.TabIndex = 346
        Me.oIdentificadores.Text = " Mostrar IDs"
        Me.oIdentificadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oIdentificadores.UseVisualStyleBackColor = False
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
        Me.xArticulo.Location = New System.Drawing.Point(114, 79)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(108, 21)
        Me.xArticulo.TabIndex = 242
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'colTracking
        '
        Me.colTracking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTracking.DataPropertyName = "Tracking"
        Me.colTracking.HeaderText = "ID Tracking"
        Me.colTracking.MinimumWidth = 100
        Me.colTracking.Name = "colTracking"
        Me.colTracking.Visible = False
        '
        'FechaEventoDataGridViewTextBoxColumn
        '
        Me.FechaEventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaEventoDataGridViewTextBoxColumn.DataPropertyName = "FechaEvento"
        Me.FechaEventoDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaEventoDataGridViewTextBoxColumn.Name = "FechaEventoDataGridViewTextBoxColumn"
        Me.FechaEventoDataGridViewTextBoxColumn.Width = 66
        '
        'colEvento
        '
        Me.colEvento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEvento.DataPropertyName = "Evento"
        Me.colEvento.HeaderText = "Evento"
        Me.colEvento.Name = "colEvento"
        Me.colEvento.Visible = False
        Me.colEvento.Width = 72
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DescEvento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 59
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "Artículo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.Width = 77
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.Width = 57
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 101
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 85
        '
        'colLocal
        '
        Me.colLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLocal.DataPropertyName = "Local"
        Me.colLocal.HeaderText = "ID Local"
        Me.colLocal.Name = "colLocal"
        Me.colLocal.Visible = False
        Me.colLocal.Width = 79
        '
        'NombreLocalDataGridViewTextBoxColumn
        '
        Me.NombreLocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreLocalDataGridViewTextBoxColumn.DataPropertyName = "NombreLocal"
        Me.NombreLocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.NombreLocalDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.NombreLocalDataGridViewTextBoxColumn.Name = "NombreLocalDataGridViewTextBoxColumn"
        Me.NombreLocalDataGridViewTextBoxColumn.Width = 150
        '
        'colBodega
        '
        Me.colBodega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBodega.DataPropertyName = "Bodega"
        Me.colBodega.HeaderText = "ID Bodega"
        Me.colBodega.Name = "colBodega"
        Me.colBodega.Visible = False
        Me.colBodega.Width = 94
        '
        'NombreBodegaDataGridViewTextBoxColumn
        '
        Me.NombreBodegaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreBodegaDataGridViewTextBoxColumn.DataPropertyName = "NombreBodega"
        Me.NombreBodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.NombreBodegaDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.NombreBodegaDataGridViewTextBoxColumn.Name = "NombreBodegaDataGridViewTextBoxColumn"
        Me.NombreBodegaDataGridViewTextBoxColumn.Width = 150
        '
        'colFechaDocumento
        '
        Me.colFechaDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFechaDocumento.DataPropertyName = "FechaDoc"
        Me.colFechaDocumento.HeaderText = "Fecha Doc."
        Me.colFechaDocumento.Name = "colFechaDocumento"
        Me.colFechaDocumento.Visible = False
        Me.colFechaDocumento.Width = 96
        '
        'colTipoDocumento
        '
        Me.colTipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTipoDocumento.DataPropertyName = "TipoDoc"
        Me.colTipoDocumento.HeaderText = "Tipo doc."
        Me.colTipoDocumento.MinimumWidth = 120
        Me.colTipoDocumento.Name = "colTipoDocumento"
        Me.colTipoDocumento.Visible = False
        Me.colTipoDocumento.Width = 120
        '
        'colNumeroDoc
        '
        Me.colNumeroDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNumeroDoc.DataPropertyName = "NumDoc"
        Me.colNumeroDoc.HeaderText = "Número"
        Me.colNumeroDoc.Name = "colNumeroDoc"
        Me.colNumeroDoc.Visible = False
        Me.colNumeroDoc.Width = 81
        '
        'colCliente
        '
        Me.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCliente.DataPropertyName = "Cliente"
        Me.colCliente.HeaderText = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = False
        Me.colCliente.Width = 72
        '
        'colRut
        '
        Me.colRut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRut.DataPropertyName = "Rut"
        Me.colRut.HeaderText = "Rut"
        Me.colRut.Name = "colRut"
        Me.colRut.Visible = False
        Me.colRut.Width = 52
        '
        'colNombreCliente
        '
        Me.colNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNombreCliente.DataPropertyName = "NombreCliente"
        Me.colNombreCliente.HeaderText = "Nombre Cliente"
        Me.colNombreCliente.MinimumWidth = 150
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.Visible = False
        Me.colNombreCliente.Width = 150
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Width = 78
        '
        'ModuloDataGridViewTextBoxColumn
        '
        Me.ModuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModuloDataGridViewTextBoxColumn.DataPropertyName = "Modulo"
        Me.ModuloDataGridViewTextBoxColumn.HeaderText = "Módulo"
        Me.ModuloDataGridViewTextBoxColumn.Name = "ModuloDataGridViewTextBoxColumn"
        Me.ModuloDataGridViewTextBoxColumn.Width = 79
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "Observación"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.Width = 106
        '
        'sTracking
        '
        Me.sTracking.DataSource = GetType(Rebusco.TrackingConsulta)
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.BackColor = System.Drawing.Color.White
        Me.bExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExportar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bExportar.Image = Global.Rebusco.My.Resources.Resources.excel24
        Me.bExportar.Location = New System.Drawing.Point(975, 535)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(147, 37)
        Me.bExportar.TabIndex = 349
        Me.bExportar.Text = " Exportar resultado"
        Me.bExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bExportar.UseVisualStyleBackColor = False
        '
        'fDialogo
        '
        Me.fDialogo.FileName = "Listado Documentos"
        Me.fDialogo.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm"
        Me.fDialogo.Title = "Exportar listado de documentos"
        '
        'ConsultaTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 583)
        Me.Controls.Add(Me.bExportar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bConsultar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaTracking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Tracking"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.sTracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents bConsultar As Button
    Public WithEvents bSalir As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents DesceventoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BobdegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xNumdoc As TextBox
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lBodega As Label
    Friend WithEvents cBodega As ComboBox
    Friend WithEvents sTracking As BindingSource
    Friend WithEvents oDatosCliente As CustomCheck
    Friend WithEvents oDatosDocumento As CustomCheck
    Friend WithEvents lTotal As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents oIdentificadores As CustomCheck
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents colTracking As DataGridViewTextBoxColumn
    Friend WithEvents FechaEventoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colEvento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colLocal As DataGridViewTextBoxColumn
    Friend WithEvents NombreLocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colBodega As DataGridViewTextBoxColumn
    Friend WithEvents NombreBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colFechaDocumento As DataGridViewTextBoxColumn
    Friend WithEvents colTipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents colNumeroDoc As DataGridViewTextBoxColumn
    Friend WithEvents colCliente As DataGridViewTextBoxColumn
    Friend WithEvents colRut As DataGridViewTextBoxColumn
    Friend WithEvents colNombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bExportar As Button
    Friend WithEvents fDialogo As SaveFileDialog
End Class
