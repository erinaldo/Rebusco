<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaStock))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xSKU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cBodega = New System.Windows.Forms.ComboBox()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bActualizar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NombreLocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New Rebusco.TextAndImageColumn()
        Me.sStock = New System.Windows.Forms.BindingSource(Me.components)
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.bBuscar = New Rebusco.SearchButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.sStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(94, 84)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(479, 21)
        Me.xDescripcion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(11, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bodega"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.xSKU)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.cBodega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xSKU
        '
        Me.xSKU.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xSKU.Location = New System.Drawing.Point(94, 57)
        Me.xSKU.Name = "xSKU"
        Me.xSKU.ReadOnly = True
        Me.xSKU.Size = New System.Drawing.Size(187, 20)
        Me.xSKU.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(11, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SKU"
        '
        'cBodega
        '
        Me.cBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cBodega.FormattingEnabled = True
        Me.cBodega.Location = New System.Drawing.Point(94, 113)
        Me.cBodega.Name = "cBodega"
        Me.cBodega.Size = New System.Drawing.Size(245, 23)
        Me.cBodega.TabIndex = 4
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(610, 154)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(100, 44)
        Me.bConsultar.TabIndex = 5
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'bActualizar
        '
        Me.bActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bActualizar.BackColor = System.Drawing.Color.White
        Me.bActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bActualizar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bActualizar.Image = Global.Rebusco.My.Resources.Resources.refresh_update24
        Me.bActualizar.Location = New System.Drawing.Point(433, 489)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(171, 36)
        Me.bActualizar.TabIndex = 8
        Me.bActualizar.Text = " Actualizar Stocks (F5)"
        Me.bActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bActualizar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 488)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 7
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(610, 489)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 9
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(592, 16)
        Me.Label14.TabIndex = 264
        Me.Label14.Text = "Stock"
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
        Me.WinDeco1.Size = New System.Drawing.Size(720, 50)
        Me.WinDeco1.TabIndex = 265
        Me.WinDeco1.TituloVentana = "Consultar Stocks"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
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
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreLocalDataGridViewTextBoxColumn, Me.NombreBodegaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.sStock
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xTabla.DefaultCellStyle = DataGridViewCellStyle3
        Me.xTabla.Location = New System.Drawing.Point(12, 204)
        Me.xTabla.MultiSelect = False
        Me.xTabla.Name = "xTabla"
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(696, 260)
        Me.xTabla.TabIndex = 338
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(9, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 22)
        Me.Panel1.TabIndex = 278
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(2, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 269
        Me.Label5.Text = "Artículo"
        '
        'NombreLocalDataGridViewTextBoxColumn
        '
        Me.NombreLocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreLocalDataGridViewTextBoxColumn.DataPropertyName = "NombreLocal"
        Me.NombreLocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.NombreLocalDataGridViewTextBoxColumn.MinimumWidth = 180
        Me.NombreLocalDataGridViewTextBoxColumn.Name = "NombreLocalDataGridViewTextBoxColumn"
        Me.NombreLocalDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreLocalDataGridViewTextBoxColumn.Width = 180
        '
        'NombreBodegaDataGridViewTextBoxColumn
        '
        Me.NombreBodegaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreBodegaDataGridViewTextBoxColumn.DataPropertyName = "NombreBodega"
        Me.NombreBodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.NombreBodegaDataGridViewTextBoxColumn.MinimumWidth = 180
        Me.NombreBodegaDataGridViewTextBoxColumn.Name = "NombreBodegaDataGridViewTextBoxColumn"
        Me.NombreBodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreBodegaDataGridViewTextBoxColumn.Width = 180
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle2.Format = "0.##"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.StockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Image = Global.Rebusco.My.Resources.Resources.editGrid
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StockDataGridViewTextBoxColumn.Width = 120
        '
        'sStock
        '
        Me.sStock.DataSource = GetType(Rebusco.DatosStock)
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 500
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = ""
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = "TipoArticulo = 'P'"
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(94, 26)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(101, 22)
        Me.xArticulo.TabIndex = 0
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!)
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
        Me.bBuscar.Location = New System.Drawing.Point(201, 24)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(80, 28)
        Me.bBuscar.TabIndex = 1
        Me.bBuscar.TablaBusqueda = "Articulos"
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.Titulo = "Buscar Articulo"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'ConsultaStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 537)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.bActualizar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents bCancelar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cBodega As ComboBox
    
    Public WithEvents bConsultar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents bBuscar As SearchButton
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents xSKU As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents sStock As BindingSource
    Friend WithEvents NombreLocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
End Class
