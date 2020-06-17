<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaKardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaKardex))
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cBodega = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xSKU = New System.Windows.Forms.TextBox()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.FechaHoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionTipoDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KardexConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KardexConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WinDeco1.Size = New System.Drawing.Size(1138, 50)
        Me.WinDeco1.TabIndex = 220
        Me.WinDeco1.TituloVentana = "Consulta de Kardex"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cBodega)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.xSKU)
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 117)
        Me.GroupBox1.TabIndex = 221
        Me.GroupBox1.TabStop = False
        '
        'cBodega
        '
        Me.cBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodega.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cBodega.FormattingEnabled = True
        Me.cBodega.Location = New System.Drawing.Point(479, 57)
        Me.cBodega.Name = "cBodega"
        Me.cBodega.Size = New System.Drawing.Size(213, 25)
        Me.cBodega.TabIndex = 344
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(421, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "Bodega"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(72, 57)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(295, 25)
        Me.cLocal.TabIndex = 342
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(6, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 343
        Me.Label13.Text = "Local"
        '
        'xSKU
        '
        Me.xSKU.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.xSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSKU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xSKU.Location = New System.Drawing.Point(698, 85)
        Me.xSKU.MaxLength = 18
        Me.xSKU.Name = "xSKU"
        Me.xSKU.ReadOnly = True
        Me.xSKU.Size = New System.Drawing.Size(147, 24)
        Me.xSKU.TabIndex = 341
        Me.xSKU.TabStop = False
        Me.xSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 800
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "SKU"
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(72, 87)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(116, 22)
        Me.xArticulo.TabIndex = 338
        Me.xArticulo.TablaBusqueda = "BuscadorAutocompletar"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'xDescripcion
        '
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(194, 87)
        Me.xDescripcion.MaxLength = 18
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.Size = New System.Drawing.Size(498, 22)
        Me.xDescripcion.TabIndex = 339
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 340
        Me.Label11.Text = "Artículo"
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(268, 30)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(99, 22)
        Me.dHasta.TabIndex = 336
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(220, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 337
        Me.Label1.Text = "Hasta"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(72, 30)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(116, 22)
        Me.dDesde.TabIndex = 334
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(6, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 335
        Me.Label5.Text = "Desde"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(851, 18)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "Filtros"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bConsultar
        '
        Me.bConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(1026, 136)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(100, 36)
        Me.bConsultar.TabIndex = 222
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
        Me.xTabla.AutoGenerateColumns = False
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaHoraDataGridViewTextBoxColumn, Me.LocalDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.DescripcionMovimientoDataGridViewTextBoxColumn, Me.DescripcionTipoDocDataGridViewTextBoxColumn, Me.NumDocDataGridViewTextBoxColumn, Me.EntradaDataGridViewTextBoxColumn, Me.SalidaDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.NombreUsuarioDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.KardexConsultaBindingSource
        Me.xTabla.Location = New System.Drawing.Point(12, 178)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.ReadOnly = True
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(1114, 309)
        Me.xTabla.TabIndex = 223
        '
        'FechaHoraDataGridViewTextBoxColumn
        '
        Me.FechaHoraDataGridViewTextBoxColumn.DataPropertyName = "FechaHora"
        Me.FechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha/Hora"
        Me.FechaHoraDataGridViewTextBoxColumn.Name = "FechaHoraDataGridViewTextBoxColumn"
        Me.FechaHoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalDataGridViewTextBoxColumn
        '
        Me.LocalDataGridViewTextBoxColumn.DataPropertyName = "Local"
        Me.LocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.LocalDataGridViewTextBoxColumn.Name = "LocalDataGridViewTextBoxColumn"
        Me.LocalDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalDataGridViewTextBoxColumn.Width = 120
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Width = 120
        '
        'DescripcionMovimientoDataGridViewTextBoxColumn
        '
        Me.DescripcionMovimientoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionMovimiento"
        Me.DescripcionMovimientoDataGridViewTextBoxColumn.HeaderText = "Tipo de Movimiento"
        Me.DescripcionMovimientoDataGridViewTextBoxColumn.Name = "DescripcionMovimientoDataGridViewTextBoxColumn"
        Me.DescripcionMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionMovimientoDataGridViewTextBoxColumn.Width = 160
        '
        'DescripcionTipoDocDataGridViewTextBoxColumn
        '
        Me.DescripcionTipoDocDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTipoDoc"
        Me.DescripcionTipoDocDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.DescripcionTipoDocDataGridViewTextBoxColumn.Name = "DescripcionTipoDocDataGridViewTextBoxColumn"
        Me.DescripcionTipoDocDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionTipoDocDataGridViewTextBoxColumn.Width = 120
        '
        'NumDocDataGridViewTextBoxColumn
        '
        Me.NumDocDataGridViewTextBoxColumn.DataPropertyName = "NumDoc"
        Me.NumDocDataGridViewTextBoxColumn.HeaderText = "N° Documento"
        Me.NumDocDataGridViewTextBoxColumn.Name = "NumDocDataGridViewTextBoxColumn"
        Me.NumDocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntradaDataGridViewTextBoxColumn
        '
        Me.EntradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.HeaderText = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.Name = "EntradaDataGridViewTextBoxColumn"
        Me.EntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntradaDataGridViewTextBoxColumn.Width = 60
        '
        'SalidaDataGridViewTextBoxColumn
        '
        Me.SalidaDataGridViewTextBoxColumn.DataPropertyName = "Salida"
        Me.SalidaDataGridViewTextBoxColumn.HeaderText = "Salida"
        Me.SalidaDataGridViewTextBoxColumn.Name = "SalidaDataGridViewTextBoxColumn"
        Me.SalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalidaDataGridViewTextBoxColumn.Width = 60
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoDataGridViewTextBoxColumn.Width = 60
        '
        'NombreUsuarioDataGridViewTextBoxColumn
        '
        Me.NombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario"
        Me.NombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.NombreUsuarioDataGridViewTextBoxColumn.Name = "NombreUsuarioDataGridViewTextBoxColumn"
        Me.NombreUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreUsuarioDataGridViewTextBoxColumn.Width = 200
        '
        'KardexConsultaBindingSource
        '
        Me.KardexConsultaBindingSource.DataSource = GetType(Rebusco.KardexConsulta)
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(15, 509)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 224
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(1026, 509)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 225
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(924, 509)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(96, 36)
        Me.bImprimir.TabIndex = 226
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'ConsultaKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 557)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WinDeco1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1262, 768)
        Me.Name = "ConsultaKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaKardex"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KardexConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label11 As Label
    Public WithEvents bConsultar As Button
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents bLimpiar As Button
    Public WithEvents bCancelar As Button
    Friend WithEvents xSKU As TextBox
    Friend WithEvents cBodega As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents KardexConsultaBindingSource As BindingSource
    Friend WithEvents FechaHoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionMovimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionTipoDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents bImprimir As Button
End Class
