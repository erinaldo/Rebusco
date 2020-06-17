<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaVentas))
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xOT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xCaja = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cFPagos = New System.Windows.Forms.ComboBox()
        Me.xNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bBuscarA = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.bBuscarC = New System.Windows.Forms.Button()
        Me.bBuscarV = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xNombreVendedor = New System.Windows.Forms.TextBox()
        Me.xNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tCantidadR = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.cFamilia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xArticulo = New System.Windows.Forms.TextBox()
        Me.xVendedor = New System.Windows.Forms.TextBox()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.oResumen = New MarketONE.CustomCheck()
        Me.oSoloOT = New MarketONE.CustomCheck()
        Me.oPagados = New MarketONE.CustomCheck()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sBarra.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.WinDeco1.Size = New System.Drawing.Size(1198, 50)
        Me.WinDeco1.TabIndex = 7
        Me.WinDeco1.TituloVentana = "Consulta de Ventas"
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
        Me.GroupBox1.Controls.Add(Me.xOT)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.xCaja)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cFPagos)
        Me.GroupBox1.Controls.Add(Me.xNumero)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 170)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'xOT
        '
        Me.xOT.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xOT.Location = New System.Drawing.Point(319, 113)
        Me.xOT.MaxLength = 30
        Me.xOT.Name = "xOT"
        Me.xOT.Size = New System.Drawing.Size(60, 22)
        Me.xOT.TabIndex = 263
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(288, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 16)
        Me.Label13.TabIndex = 262
        Me.Label13.Text = "OT"
        '
        'xCaja
        '
        Me.xCaja.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xCaja.Location = New System.Drawing.Point(240, 113)
        Me.xCaja.MaxLength = 30
        Me.xCaja.Name = "xCaja"
        Me.xCaja.Size = New System.Drawing.Size(42, 22)
        Me.xCaja.TabIndex = 260
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(200, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 16)
        Me.Label12.TabIndex = 261
        Me.Label12.Text = "Caja"
        '
        'cFPagos
        '
        Me.cFPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPagos.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cFPagos.FormattingEnabled = True
        Me.cFPagos.Location = New System.Drawing.Point(115, 141)
        Me.cFPagos.Name = "cFPagos"
        Me.cFPagos.Size = New System.Drawing.Size(264, 24)
        Me.cFPagos.TabIndex = 5
        '
        'xNumero
        '
        Me.xNumero.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNumero.Location = New System.Drawing.Point(115, 113)
        Me.xNumero.MaxLength = 30
        Me.xNumero.Name = "xNumero"
        Me.xNumero.Size = New System.Drawing.Size(82, 22)
        Me.xNumero.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(6, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "Forma de Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(6, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Número"
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(115, 83)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(264, 24)
        Me.cTipoDoc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Tipo Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Rango de Fecha"
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(232, 25)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(92, 22)
        Me.dHasta.TabIndex = 1
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(115, 25)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(92, 22)
        Me.dDesde.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(209, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "al"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(115, 53)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(264, 24)
        Me.cLocal.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(6, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Local"
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarA.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(594, 77)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarA.TabIndex = 262
        Me.bBuscarA.Text = "Buscar"
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(6, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 263
        Me.Label8.Text = "Artículo"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(166, 80)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(422, 22)
        Me.xDescripcion.TabIndex = 264
        Me.xDescripcion.TabStop = False
        '
        'bBuscarC
        '
        Me.bBuscarC.BackColor = System.Drawing.Color.White
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarC.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarC.Location = New System.Drawing.Point(594, 21)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarC.TabIndex = 9
        Me.bBuscarC.Text = "Buscar"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.UseVisualStyleBackColor = False
        '
        'bBuscarV
        '
        Me.bBuscarV.BackColor = System.Drawing.Color.White
        Me.bBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarV.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarV.Image = Global.MarketONE.My.Resources.Resources.find
        Me.bBuscarV.Location = New System.Drawing.Point(594, 49)
        Me.bBuscarV.Name = "bBuscarV"
        Me.bBuscarV.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarV.TabIndex = 10
        Me.bBuscarV.Text = "Buscar"
        Me.bBuscarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarV.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Vendedor"
        '
        'xNombreVendedor
        '
        Me.xNombreVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreVendedor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombreVendedor.Location = New System.Drawing.Point(166, 52)
        Me.xNombreVendedor.Name = "xNombreVendedor"
        Me.xNombreVendedor.ReadOnly = True
        Me.xNombreVendedor.Size = New System.Drawing.Size(422, 22)
        Me.xNombreVendedor.TabIndex = 254
        Me.xNombreVendedor.TabStop = False
        '
        'xNombreCliente
        '
        Me.xNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreCliente.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombreCliente.Location = New System.Drawing.Point(166, 24)
        Me.xNombreCliente.Name = "xNombreCliente"
        Me.xNombreCliente.ReadOnly = True
        Me.xNombreCliente.Size = New System.Drawing.Size(422, 22)
        Me.xNombreCliente.TabIndex = 251
        Me.xNombreCliente.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(7, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Cliente"
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
        Me.xTabla.Location = New System.Drawing.Point(12, 229)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(1177, 270)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 10
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso, Me.tCantidadR})
        Me.sBarra.Location = New System.Drawing.Point(0, 554)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(1198, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 242
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
        Me.tCantidadR.Size = New System.Drawing.Size(1015, 17)
        Me.tCantidadR.Spring = True
        Me.tCantidadR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bConsultar.Image = Global.MarketONE.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(1090, 155)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(99, 36)
        Me.bConsultar.TabIndex = 243
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bImprimir.Image = Global.MarketONE.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(987, 515)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(96, 36)
        Me.bImprimir.TabIndex = 244
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bSalir.Image = Global.MarketONE.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(1089, 515)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 245
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
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.MarketONE.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 515)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 246
        Me.bLimpiar.Text = " Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'cFamilia
        '
        Me.cFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFamilia.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cFamilia.FormattingEnabled = True
        Me.cFamilia.Location = New System.Drawing.Point(74, 108)
        Me.cFamilia.Name = "cFamilia"
        Me.cFamilia.Size = New System.Drawing.Size(282, 24)
        Me.cFamilia.TabIndex = 268
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(7, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 16)
        Me.Label10.TabIndex = 269
        Me.Label10.Text = "Familia"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xArticulo)
        Me.GroupBox2.Controls.Add(Me.xVendedor)
        Me.GroupBox2.Controls.Add(Me.xCliente)
        Me.GroupBox2.Controls.Add(Me.cFamilia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.bBuscarC)
        Me.GroupBox2.Controls.Add(Me.bBuscarV)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.xNombreVendedor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.xNombreCliente)
        Me.GroupBox2.Controls.Add(Me.xDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.bBuscarA)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 137)
        Me.GroupBox2.TabIndex = 270
        Me.GroupBox2.TabStop = False
        '
        'xArticulo
        '
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.Location = New System.Drawing.Point(75, 80)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(85, 22)
        Me.xArticulo.TabIndex = 273
        '
        'xVendedor
        '
        Me.xVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xVendedor.Location = New System.Drawing.Point(75, 52)
        Me.xVendedor.MaxLength = 3
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(85, 22)
        Me.xVendedor.TabIndex = 272
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.Location = New System.Drawing.Point(74, 24)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(86, 22)
        Me.xCliente.TabIndex = 271
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(385, 18)
        Me.Label14.TabIndex = 260
        Me.Label14.Text = "Documento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(403, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(681, 18)
        Me.Label11.TabIndex = 270
        Me.Label11.Text = "Cliente / Vendedor / Artículo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oResumen
        '
        Me.oResumen.Appearance = System.Windows.Forms.Appearance.Button
        Me.oResumen.BackColor = System.Drawing.Color.White
        Me.oResumen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oResumen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oResumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oResumen.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.oResumen.ForeColor = System.Drawing.Color.Black
        Me.oResumen.Image = CType(resources.GetObject("oResumen.Image"), System.Drawing.Image)
        Me.oResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oResumen.Location = New System.Drawing.Point(406, 196)
        Me.oResumen.Name = "oResumen"
        Me.oResumen.Size = New System.Drawing.Size(239, 30)
        Me.oResumen.TabIndex = 267
        Me.oResumen.Text = "Resumen de Ventas por secciones"
        Me.oResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oResumen.UseVisualStyleBackColor = False
        '
        'oSoloOT
        '
        Me.oSoloOT.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSoloOT.BackColor = System.Drawing.Color.White
        Me.oSoloOT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloOT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSoloOT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSoloOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSoloOT.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.oSoloOT.ForeColor = System.Drawing.Color.Black
        Me.oSoloOT.Image = CType(resources.GetObject("oSoloOT.Image"), System.Drawing.Image)
        Me.oSoloOT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSoloOT.Location = New System.Drawing.Point(651, 196)
        Me.oSoloOT.Name = "oSoloOT"
        Me.oSoloOT.Size = New System.Drawing.Size(87, 30)
        Me.oSoloOT.TabIndex = 266
        Me.oSoloOT.Text = "Solo OT"
        Me.oSoloOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSoloOT.UseVisualStyleBackColor = False
        '
        'oPagados
        '
        Me.oPagados.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPagados.BackColor = System.Drawing.Color.White
        Me.oPagados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPagados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPagados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPagados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPagados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPagados.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.oPagados.ForeColor = System.Drawing.Color.Black
        Me.oPagados.Image = CType(resources.GetObject("oPagados.Image"), System.Drawing.Image)
        Me.oPagados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPagados.Location = New System.Drawing.Point(744, 196)
        Me.oPagados.Name = "oPagados"
        Me.oPagados.Size = New System.Drawing.Size(87, 30)
        Me.oPagados.TabIndex = 8
        Me.oPagados.Text = "Pagados"
        Me.oPagados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPagados.UseVisualStyleBackColor = False
        '
        'ConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 576)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.oResumen)
        Me.Controls.Add(Me.oSoloOT)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.oPagados)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.sBarra)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WinDeco1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1298, 768)
        Me.Name = "ConsultaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sBarra.ResumeLayout(False)
        Me.sBarra.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bBuscarA As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents oPagados As CustomCheck
    Friend WithEvents cFPagos As ComboBox
    Friend WithEvents xNumero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents bBuscarC As Button
    Public WithEvents bBuscarV As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents xNombreVendedor As TextBox
    Friend WithEvents xNombreCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents tCantidadR As ToolStripStatusLabel
    Public WithEvents bConsultar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bSalir As Button
    Friend WithEvents oResumen As CustomCheck
    Friend WithEvents oSoloOT As CustomCheck
    Public WithEvents bLimpiar As Button
    Friend WithEvents cFamilia As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents xCaja As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents xOT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents xArticulo As TextBox
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents xCliente As TextBox
End Class
