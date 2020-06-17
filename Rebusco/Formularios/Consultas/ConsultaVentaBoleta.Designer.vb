<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaVentaBoleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaVentaBoleta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xTicket = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xCaja = New System.Windows.Forms.TextBox()
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tCantidadR = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xTicket)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xCaja)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cFormaPago
        '
        Me.cFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFormaPago.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cFormaPago.FormattingEnabled = True
        Me.cFormaPago.Location = New System.Drawing.Point(124, 74)
        Me.cFormaPago.Name = "cFormaPago"
        Me.cFormaPago.Size = New System.Drawing.Size(291, 24)
        Me.cFormaPago.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(15, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Forma de Pago"
        '
        'xTicket
        '
        Me.xTicket.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xTicket.Location = New System.Drawing.Point(254, 45)
        Me.xTicket.Name = "xTicket"
        Me.xTicket.Size = New System.Drawing.Size(110, 22)
        Me.xTicket.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(187, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "N° Ticket"
        '
        'xCaja
        '
        Me.xCaja.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xCaja.Location = New System.Drawing.Point(124, 46)
        Me.xCaja.Name = "xCaja"
        Me.xCaja.Size = New System.Drawing.Size(57, 22)
        Me.xCaja.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(15, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Caja"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(124, 104)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(144, 24)
        Me.cLocal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Local"
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(267, 17)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(97, 22)
        Me.dHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(235, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Al"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(124, 18)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(97, 22)
        Me.dDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Rango de Fecha"
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarA.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(623, 49)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(28, 28)
        Me.bBuscarA.TabIndex = 210
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'bBuscarV
        '
        Me.bBuscarV.BackColor = System.Drawing.Color.White
        Me.bBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarV.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarV.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarV.Location = New System.Drawing.Point(623, 21)
        Me.bBuscarV.Name = "bBuscarV"
        Me.bBuscarV.Size = New System.Drawing.Size(28, 28)
        Me.bBuscarV.TabIndex = 209
        Me.bBuscarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarV.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(197, 52)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(420, 22)
        Me.xDescripcion.TabIndex = 208
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombre.Location = New System.Drawing.Point(197, 24)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(420, 22)
        Me.xNombre.TabIndex = 207
        '
        'xArticulo
        '
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.Location = New System.Drawing.Point(91, 52)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(100, 22)
        Me.xArticulo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(9, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Artículo"
        '
        'xVendedor
        '
        Me.xVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xVendedor.Location = New System.Drawing.Point(91, 24)
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(100, 22)
        Me.xVendedor.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(9, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Vendedor"
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.MarketONE.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 496)
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
        Me.bImprimir.Location = New System.Drawing.Point(902, 496)
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
        Me.bCancelar.Location = New System.Drawing.Point(1008, 496)
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
        Me.WinDeco1.Size = New System.Drawing.Size(1120, 50)
        Me.WinDeco1.TabIndex = 130
        Me.WinDeco1.TituloVentana = "Consulta de Venta por Boleta"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(445, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(663, 18)
        Me.Label12.TabIndex = 240
        Me.Label12.Text = "Cliente / Usuario"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(427, 18)
        Me.Label11.TabIndex = 239
        Me.Label11.Text = "Documento"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bBuscarA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.xVendedor)
        Me.GroupBox2.Controls.Add(Me.xNombre)
        Me.GroupBox2.Controls.Add(Me.xDescripcion)
        Me.GroupBox2.Controls.Add(Me.bBuscarV)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.xArticulo)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 93)
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
        Me.xTabla.Location = New System.Drawing.Point(12, 203)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(1096, 260)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 242
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bConsultar.Image = Global.MarketONE.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(1002, 160)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(106, 36)
        Me.bConsultar.TabIndex = 243
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso, Me.tCantidadR})
        Me.sBarra.Location = New System.Drawing.Point(0, 537)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(1120, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 244
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
        Me.tCantidadR.Size = New System.Drawing.Size(937, 17)
        Me.tCantidadR.Spring = True
        Me.tCantidadR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xTotal
        '
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(956, 466)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(152, 23)
        Me.xTotal.TabIndex = 245
        Me.xTotal.TabStop = False
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(911, 471)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 246
        Me.Label9.Text = "Total"
        '
        'ConsultaVentaBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 559)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.xTotal)
        Me.Controls.Add(Me.sBarra)
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
        Me.Name = "ConsultaVentaBoleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Ventas por Boleta"
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
    Friend WithEvents cFormaPago As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xTicket As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xArticulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xCaja As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label3 As Label
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents xNombre As TextBox
    Public WithEvents bBuscarA As Button
    Public WithEvents bBuscarV As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bConsultar As Button
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents tCantidadR As ToolStripStatusLabel
    Friend WithEvents xTotal As TextBox
    Friend WithEvents Label9 As Label
End Class
