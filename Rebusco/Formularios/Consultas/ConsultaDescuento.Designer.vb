<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaDescuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaDescuento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xDocumento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cDocumento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xTicket = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xPOS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bBuscarA = New System.Windows.Forms.Button()
        Me.bBuscarV = New System.Windows.Forms.Button()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.xArticulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xVendedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tCantidadR = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xDocumento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cDocumento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xTicket)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xPOS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xDocumento
        '
        Me.xDocumento.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDocumento.Location = New System.Drawing.Point(445, 48)
        Me.xDocumento.Name = "xDocumento"
        Me.xDocumento.Size = New System.Drawing.Size(125, 22)
        Me.xDocumento.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(365, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 230
        Me.Label10.Text = "Número"
        '
        'cDocumento
        '
        Me.cDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDocumento.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cDocumento.FormattingEnabled = True
        Me.cDocumento.Location = New System.Drawing.Point(445, 18)
        Me.cDocumento.Name = "cDocumento"
        Me.cDocumento.Size = New System.Drawing.Size(218, 24)
        Me.cDocumento.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(365, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 228
        Me.Label9.Text = "Documento"
        '
        'cFormaPago
        '
        Me.cFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFormaPago.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cFormaPago.FormattingEnabled = True
        Me.cFormaPago.Location = New System.Drawing.Point(131, 76)
        Me.cFormaPago.Name = "cFormaPago"
        Me.cFormaPago.Size = New System.Drawing.Size(228, 24)
        Me.cFormaPago.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(14, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "Forma de Pago"
        '
        'xTicket
        '
        Me.xTicket.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xTicket.Location = New System.Drawing.Point(262, 48)
        Me.xTicket.Name = "xTicket"
        Me.xTicket.Size = New System.Drawing.Size(97, 22)
        Me.xTicket.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(195, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "N° Ticket"
        '
        'xPOS
        '
        Me.xPOS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xPOS.Location = New System.Drawing.Point(131, 48)
        Me.xPOS.Name = "xPOS"
        Me.xPOS.Size = New System.Drawing.Size(53, 22)
        Me.xPOS.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(14, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 218
        Me.Label4.Text = "POS"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(445, 76)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(218, 24)
        Me.cLocal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(365, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Local"
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(262, 16)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(97, 22)
        Me.dHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(236, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Al"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(131, 16)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(97, 22)
        Me.dDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rango de Fecha"
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarA.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(588, 51)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarA.TabIndex = 13
        Me.bBuscarA.Text = "Buscar"
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'bBuscarV
        '
        Me.bBuscarV.BackColor = System.Drawing.Color.White
        Me.bBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarV.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarV.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarV.Location = New System.Drawing.Point(588, 23)
        Me.bBuscarV.Name = "bBuscarV"
        Me.bBuscarV.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarV.TabIndex = 12
        Me.bBuscarV.Text = "Buscar"
        Me.bBuscarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarV.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(202, 54)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(379, 22)
        Me.xDescripcion.TabIndex = 10
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombre.Location = New System.Drawing.Point(202, 26)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(379, 22)
        Me.xNombre.TabIndex = 11
        '
        'xArticulo
        '
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.Location = New System.Drawing.Point(96, 54)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(100, 22)
        Me.xArticulo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(14, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "Artículo"
        '
        'xVendedor
        '
        Me.xVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xVendedor.Location = New System.Drawing.Point(96, 26)
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(100, 22)
        Me.xVendedor.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(13, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 219
        Me.Label5.Text = "Vendedor"
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.MarketONE.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(13, 495)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 1
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bImprimir.Image = Global.MarketONE.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(826, 495)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 2
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCancelar.Image = Global.MarketONE.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(932, 495)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 65
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
        Me.WinDeco1.ImagenBanner = Global.MarketONE.My.Resources.Resources.banner3
        Me.WinDeco1.Location = New System.Drawing.Point(0, 0)
        Me.WinDeco1.MuestraBordeExterior = -1
        Me.WinDeco1.Name = "WinDeco1"
        Me.WinDeco1.SiempreVisible = False
        Me.WinDeco1.Size = New System.Drawing.Size(1044, 50)
        Me.WinDeco1.TabIndex = 238
        Me.WinDeco1.TituloVentana = "Consulta de Descuentos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(674, 18)
        Me.Label11.TabIndex = 239
        Me.Label11.Text = "Documento"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(674, 18)
        Me.Label12.TabIndex = 240
        Me.Label12.Text = "Cliente / Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xNombre)
        Me.GroupBox2.Controls.Add(Me.xArticulo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.xVendedor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.xDescripcion)
        Me.GroupBox2.Controls.Add(Me.bBuscarA)
        Me.GroupBox2.Controls.Add(Me.bBuscarV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 87)
        Me.GroupBox2.TabIndex = 241
        Me.GroupBox2.TabStop = False
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
        Me.xTabla.Location = New System.Drawing.Point(12, 263)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(1023, 195)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 246
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bConsultar.Image = Global.MarketONE.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(692, 224)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(100, 36)
        Me.bConsultar.TabIndex = 247
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(835, 466)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 249
        Me.Label13.Text = "Total"
        '
        'xTotal
        '
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(880, 461)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(152, 23)
        Me.xTotal.TabIndex = 248
        Me.xTotal.TabStop = False
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso, Me.tCantidadR})
        Me.sBarra.Location = New System.Drawing.Point(0, 535)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(1044, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 250
        Me.sBarra.Text = "StatusStrip1"
        '
        'tMensajeBarra
        '
        Me.tMensajeBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tMensajeBarra.ForeColor = System.Drawing.Color.White
        Me.tMensajeBarra.Name = "tMensajeBarra"
        Me.tMensajeBarra.Size = New System.Drawing.Size(35, 17)
        Me.tMensajeBarra.Text = "Listo"
        '
        'tBarraProgreso
        '
        Me.tBarraProgreso.BackColor = System.Drawing.Color.White
        Me.tBarraProgreso.ForeColor = System.Drawing.Color.Black
        Me.tBarraProgreso.Name = "tBarraProgreso"
        Me.tBarraProgreso.Size = New System.Drawing.Size(100, 16)
        Me.tBarraProgreso.Step = 5
        Me.tBarraProgreso.Value = 70
        Me.tBarraProgreso.Visible = False
        '
        'tCantidadR
        '
        Me.tCantidadR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tCantidadR.ForeColor = System.Drawing.Color.White
        Me.tCantidadR.Name = "tCantidadR"
        Me.tCantidadR.Size = New System.Drawing.Size(994, 17)
        Me.tCantidadR.Spring = True
        Me.tCantidadR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConsultaDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 557)
        Me.Controls.Add(Me.sBarra)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.xTotal)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1223, 768)
        Me.Name = "ConsultaDescuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sBarra.ResumeLayout(False)
        Me.sBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents xDocumento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cDocumento As ComboBox
    Friend WithEvents Label9 As Label
    Public WithEvents bBuscarA As Button
    Public WithEvents bBuscarV As Button
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents cFormaPago As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xTicket As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xArticulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xPOS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label3 As Label
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bConsultar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents xTotal As TextBox
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents tCantidadR As ToolStripStatusLabel
End Class
