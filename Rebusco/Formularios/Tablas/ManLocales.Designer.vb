<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManLocales

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
        Dim Vs2010TabControlRenderer1 As Rebusco.Renderers.Vs2010TabControlRenderer = New Rebusco.Renderers.Vs2010TabControlRenderer()
        Dim Vs2010DefaultTabControlColorTable1 As Rebusco.ColorTables.Vs2010DefaultTabControlColorTable = New Rebusco.ColorTables.Vs2010DefaultTabControlColorTable()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManLocales))
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.fLogo = New System.Windows.Forms.OpenFileDialog()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.oLogoVoucher = New System.Windows.Forms.OpenFileDialog()
        Me.xTab = New Rebusco.Controls.Vs2010TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gPrincipal = New System.Windows.Forms.GroupBox()
        Me.oPrecio = New Rebusco.CustomCheck()
        Me.oVenta = New Rebusco.CustomCheck()
        Me.xRut = New System.Windows.Forms.MaskedTextBox()
        Me.bBuscarC = New System.Windows.Forms.Button()
        Me.xNombreCliente = New System.Windows.Forms.TextBox()
        Me.xTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cComunas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cCiudades = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xGiroLocal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gElectronica = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xIP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.oEnvioAuto = New Rebusco.CustomCheck()
        Me.oNC = New Rebusco.CustomCheck()
        Me.xClave = New System.Windows.Forms.TextBox()
        Me.oND = New Rebusco.CustomCheck()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.oGD = New Rebusco.CustomCheck()
        Me.oBE = New Rebusco.CustomCheck()
        Me.oFV = New Rebusco.CustomCheck()
        Me.xNumeroR = New System.Windows.Forms.TextBox()
        Me.xSII = New System.Windows.Forms.TextBox()
        Me.oBO = New Rebusco.CustomCheck()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dFechaR = New System.Windows.Forms.DateTimePicker()
        Me.xAteco = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.oFC = New Rebusco.CustomCheck()
        Me.oFE = New Rebusco.CustomCheck()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.oElectronica = New Rebusco.CustomCheck()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.pLogo = New System.Windows.Forms.PictureBox()
        Me.bCargar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pLogoVoucher = New System.Windows.Forms.PictureBox()
        Me.bCargarLogoVoucher = New System.Windows.Forms.Button()
        Me.xTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gPrincipal.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gElectronica.SuspendLayout()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pLogoVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(451, 533)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bEliminar
        '
        Me.bEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEliminar.BackColor = System.Drawing.Color.White
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bEliminar.Image = Global.Rebusco.My.Resources.Resources.delete24
        Me.bEliminar.Location = New System.Drawing.Point(557, 533)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 36)
        Me.bEliminar.TabIndex = 1
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 533)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 3
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(663, 533)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 2
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'fLogo
        '
        Me.fLogo.FileName = "OpenFileDialog1"
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
        Me.WinDeco1.Size = New System.Drawing.Size(768, 50)
        Me.WinDeco1.TabIndex = 133
        Me.WinDeco1.TituloVentana = "Mantenedor de Locales"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'oLogoVoucher
        '
        Me.oLogoVoucher.FileName = "oDirectorio"
        '
        'xTab
        '
        Me.xTab.Controls.Add(Me.TabPage1)
        Me.xTab.Controls.Add(Me.TabPage2)
        Me.xTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.xTab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTab.HotTrack = True
        Me.xTab.ItemSize = New System.Drawing.Size(0, 26)
        Me.xTab.Location = New System.Drawing.Point(12, 59)
        Me.xTab.Name = "xTab"
        Vs2010TabControlRenderer1.ColorTable = Vs2010DefaultTabControlColorTable1
        Me.xTab.Renderer = Vs2010TabControlRenderer1
        Me.xTab.SelectedIndex = 0
        Me.xTab.Size = New System.Drawing.Size(743, 457)
        Me.xTab.TabIndex = 132
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.gPrincipal)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(735, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Local"
        '
        'gPrincipal
        '
        Me.gPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.gPrincipal.Controls.Add(Me.oPrecio)
        Me.gPrincipal.Controls.Add(Me.oVenta)
        Me.gPrincipal.Controls.Add(Me.xRut)
        Me.gPrincipal.Controls.Add(Me.bBuscarC)
        Me.gPrincipal.Controls.Add(Me.xNombreCliente)
        Me.gPrincipal.Controls.Add(Me.xTelefono)
        Me.gPrincipal.Controls.Add(Me.Label9)
        Me.gPrincipal.Controls.Add(Me.cComunas)
        Me.gPrincipal.Controls.Add(Me.Label8)
        Me.gPrincipal.Controls.Add(Me.cCiudades)
        Me.gPrincipal.Controls.Add(Me.Label7)
        Me.gPrincipal.Controls.Add(Me.xDireccion)
        Me.gPrincipal.Controls.Add(Me.Label6)
        Me.gPrincipal.Controls.Add(Me.xGiroLocal)
        Me.gPrincipal.Controls.Add(Me.Label5)
        Me.gPrincipal.Controls.Add(Me.Label4)
        Me.gPrincipal.Controls.Add(Me.xCliente)
        Me.gPrincipal.Controls.Add(Me.Label3)
        Me.gPrincipal.Controls.Add(Me.bBuscar)
        Me.gPrincipal.Controls.Add(Me.xNombre)
        Me.gPrincipal.Controls.Add(Me.Label2)
        Me.gPrincipal.Controls.Add(Me.bNuevo)
        Me.gPrincipal.Controls.Add(Me.Label1)
        Me.gPrincipal.Controls.Add(Me.xLocal)
        Me.gPrincipal.Location = New System.Drawing.Point(6, 6)
        Me.gPrincipal.Name = "gPrincipal"
        Me.gPrincipal.Size = New System.Drawing.Size(723, 330)
        Me.gPrincipal.TabIndex = 0
        Me.gPrincipal.TabStop = False
        '
        'oPrecio
        '
        Me.oPrecio.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPrecio.BackColor = System.Drawing.Color.White
        Me.oPrecio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPrecio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPrecio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oPrecio.ForeColor = System.Drawing.Color.Black
        Me.oPrecio.Image = CType(resources.GetObject("oPrecio.Image"), System.Drawing.Image)
        Me.oPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPrecio.Location = New System.Drawing.Point(573, 289)
        Me.oPrecio.Name = "oPrecio"
        Me.oPrecio.Size = New System.Drawing.Size(144, 29)
        Me.oPrecio.TabIndex = 108
        Me.oPrecio.Text = "Envio de Precios"
        Me.oPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPrecio.UseVisualStyleBackColor = False
        '
        'oVenta
        '
        Me.oVenta.Appearance = System.Windows.Forms.Appearance.Button
        Me.oVenta.BackColor = System.Drawing.Color.White
        Me.oVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oVenta.ForeColor = System.Drawing.Color.Black
        Me.oVenta.Image = CType(resources.GetObject("oVenta.Image"), System.Drawing.Image)
        Me.oVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oVenta.Location = New System.Drawing.Point(423, 289)
        Me.oVenta.Name = "oVenta"
        Me.oVenta.Size = New System.Drawing.Size(144, 29)
        Me.oVenta.TabIndex = 107
        Me.oVenta.Text = "Carga de Ventas"
        Me.oVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oVenta.UseVisualStyleBackColor = False
        '
        'xRut
        '
        Me.xRut.BackColor = System.Drawing.Color.White
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRut.Location = New System.Drawing.Point(116, 106)
        Me.xRut.Mask = "##,###,###-A"
        Me.xRut.Name = "xRut"
        Me.xRut.Size = New System.Drawing.Size(111, 21)
        Me.xRut.TabIndex = 104
        '
        'bBuscarC
        '
        Me.bBuscarC.BackColor = System.Drawing.Color.White
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarC.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarC.Location = New System.Drawing.Point(637, 75)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarC.TabIndex = 103
        Me.bBuscarC.Text = "Buscar"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.UseVisualStyleBackColor = False
        '
        'xNombreCliente
        '
        Me.xNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombreCliente.Location = New System.Drawing.Point(196, 78)
        Me.xNombreCliente.Name = "xNombreCliente"
        Me.xNombreCliente.ReadOnly = True
        Me.xNombreCliente.Size = New System.Drawing.Size(435, 21)
        Me.xNombreCliente.TabIndex = 3
        Me.xNombreCliente.Tag = "Nombre Cliente"
        '
        'xTelefono
        '
        Me.xTelefono.BackColor = System.Drawing.Color.White
        Me.xTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTelefono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTelefono.Location = New System.Drawing.Point(116, 296)
        Me.xTelefono.MaxLength = 100
        Me.xTelefono.Name = "xTelefono"
        Me.xTelefono.Size = New System.Drawing.Size(246, 21)
        Me.xTelefono.TabIndex = 9
        Me.xTelefono.Tag = "Telefono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Teléfonos"
        '
        'cComunas
        '
        Me.cComunas.BackColor = System.Drawing.Color.White
        Me.cComunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cComunas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cComunas.FormattingEnabled = True
        Me.cComunas.Location = New System.Drawing.Point(116, 265)
        Me.cComunas.Name = "cComunas"
        Me.cComunas.Size = New System.Drawing.Size(246, 23)
        Me.cComunas.TabIndex = 8
        Me.cComunas.Tag = "Comuna"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Comuna"
        '
        'cCiudades
        '
        Me.cCiudades.BackColor = System.Drawing.Color.White
        Me.cCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCiudades.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCiudades.FormattingEnabled = True
        Me.cCiudades.Location = New System.Drawing.Point(116, 235)
        Me.cCiudades.Name = "cCiudades"
        Me.cCiudades.Size = New System.Drawing.Size(246, 23)
        Me.cCiudades.TabIndex = 7
        Me.cCiudades.Tag = "Ciudad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Ciudad"
        '
        'xDireccion
        '
        Me.xDireccion.BackColor = System.Drawing.Color.White
        Me.xDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xDireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDireccion.Location = New System.Drawing.Point(116, 162)
        Me.xDireccion.MaxLength = 100
        Me.xDireccion.Multiline = True
        Me.xDireccion.Name = "xDireccion"
        Me.xDireccion.Size = New System.Drawing.Size(601, 67)
        Me.xDireccion.TabIndex = 6
        Me.xDireccion.Tag = "Dirección del Local"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Dirección"
        '
        'xGiroLocal
        '
        Me.xGiroLocal.BackColor = System.Drawing.Color.White
        Me.xGiroLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xGiroLocal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xGiroLocal.Location = New System.Drawing.Point(116, 134)
        Me.xGiroLocal.MaxLength = 100
        Me.xGiroLocal.Name = "xGiroLocal"
        Me.xGiroLocal.Size = New System.Drawing.Size(601, 21)
        Me.xGiroLocal.TabIndex = 5
        Me.xGiroLocal.Tag = "Giro Local"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Giro Comercial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Rut"
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.White
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCliente.Location = New System.Drawing.Point(116, 78)
        Me.xCliente.MaxLength = 100
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(74, 21)
        Me.xCliente.TabIndex = 2
        Me.xCliente.Tag = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Cliente"
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.White
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscar.Location = New System.Drawing.Point(282, 16)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(80, 28)
        Me.bBuscar.TabIndex = 83
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.White
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombre.Location = New System.Drawing.Point(116, 50)
        Me.xNombre.MaxLength = 100
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(601, 21)
        Me.xNombre.TabIndex = 1
        Me.xNombre.Tag = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Nombre"
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.White
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = Global.Rebusco.My.Resources.Resources._new
        Me.bNuevo.Location = New System.Drawing.Point(196, 16)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 28)
        Me.bNuevo.TabIndex = 80
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Local"
        '
        'xLocal
        '
        Me.xLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xLocal.Location = New System.Drawing.Point(116, 19)
        Me.xLocal.Name = "xLocal"
        Me.xLocal.Size = New System.Drawing.Size(74, 22)
        Me.xLocal.TabIndex = 0
        Me.xLocal.TabStop = False
        Me.xLocal.Tag = "Local"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.gElectronica)
        Me.TabPage2.Controls.Add(Me.oElectronica)
        Me.TabPage2.Controls.Add(Me.lFolios)
        Me.TabPage2.Controls.Add(Me.pLogo)
        Me.TabPage2.Controls.Add(Me.bCargar)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.pLogoVoucher)
        Me.TabPage2.Controls.Add(Me.bCargarLogoVoucher)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(735, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Facturación Electrónica"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(479, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(255, 16)
        Me.Label16.TabIndex = 147
        Me.Label16.Text = "Logo Voucher"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gElectronica
        '
        Me.gElectronica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gElectronica.Controls.Add(Me.Label10)
        Me.gElectronica.Controls.Add(Me.xIP)
        Me.gElectronica.Controls.Add(Me.Label11)
        Me.gElectronica.Controls.Add(Me.oEnvioAuto)
        Me.gElectronica.Controls.Add(Me.oNC)
        Me.gElectronica.Controls.Add(Me.xClave)
        Me.gElectronica.Controls.Add(Me.oND)
        Me.gElectronica.Controls.Add(Me.Label12)
        Me.gElectronica.Controls.Add(Me.oGD)
        Me.gElectronica.Controls.Add(Me.oBE)
        Me.gElectronica.Controls.Add(Me.oFV)
        Me.gElectronica.Controls.Add(Me.xNumeroR)
        Me.gElectronica.Controls.Add(Me.xSII)
        Me.gElectronica.Controls.Add(Me.oBO)
        Me.gElectronica.Controls.Add(Me.Label15)
        Me.gElectronica.Controls.Add(Me.dFechaR)
        Me.gElectronica.Controls.Add(Me.xAteco)
        Me.gElectronica.Controls.Add(Me.Label13)
        Me.gElectronica.Controls.Add(Me.oFC)
        Me.gElectronica.Controls.Add(Me.oFE)
        Me.gElectronica.Controls.Add(Me.Label14)
        Me.gElectronica.Enabled = False
        Me.gElectronica.Location = New System.Drawing.Point(6, 50)
        Me.gElectronica.Name = "gElectronica"
        Me.gElectronica.Size = New System.Drawing.Size(456, 306)
        Me.gElectronica.TabIndex = 101
        Me.gElectronica.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "IP DTE"
        '
        'xIP
        '
        Me.xIP.BackColor = System.Drawing.Color.White
        Me.xIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xIP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIP.Location = New System.Drawing.Point(166, 23)
        Me.xIP.MaxLength = 100
        Me.xIP.Name = "xIP"
        Me.xIP.Size = New System.Drawing.Size(280, 21)
        Me.xIP.TabIndex = 0
        Me.xIP.Tag = "IP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 15)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Clave"
        '
        'oEnvioAuto
        '
        Me.oEnvioAuto.Appearance = System.Windows.Forms.Appearance.Button
        Me.oEnvioAuto.BackColor = System.Drawing.Color.White
        Me.oEnvioAuto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oEnvioAuto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oEnvioAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oEnvioAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oEnvioAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oEnvioAuto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oEnvioAuto.ForeColor = System.Drawing.Color.Black
        Me.oEnvioAuto.Image = CType(resources.GetObject("oEnvioAuto.Image"), System.Drawing.Image)
        Me.oEnvioAuto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oEnvioAuto.Location = New System.Drawing.Point(306, 266)
        Me.oEnvioAuto.Name = "oEnvioAuto"
        Me.oEnvioAuto.Size = New System.Drawing.Size(140, 26)
        Me.oEnvioAuto.TabIndex = 140
        Me.oEnvioAuto.Text = "Envío Automático"
        Me.oEnvioAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oEnvioAuto.UseVisualStyleBackColor = False
        '
        'oNC
        '
        Me.oNC.Appearance = System.Windows.Forms.Appearance.Button
        Me.oNC.BackColor = System.Drawing.Color.White
        Me.oNC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oNC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oNC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oNC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oNC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oNC.ForeColor = System.Drawing.Color.Black
        Me.oNC.Image = CType(resources.GetObject("oNC.Image"), System.Drawing.Image)
        Me.oNC.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oNC.Location = New System.Drawing.Point(14, 234)
        Me.oNC.Name = "oNC"
        Me.oNC.Size = New System.Drawing.Size(140, 26)
        Me.oNC.TabIndex = 134
        Me.oNC.Text = "Nota de Crédito"
        Me.oNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oNC.UseVisualStyleBackColor = False
        '
        'xClave
        '
        Me.xClave.BackColor = System.Drawing.Color.White
        Me.xClave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xClave.Location = New System.Drawing.Point(166, 51)
        Me.xClave.MaxLength = 100
        Me.xClave.Name = "xClave"
        Me.xClave.Size = New System.Drawing.Size(280, 21)
        Me.xClave.TabIndex = 1
        Me.xClave.Tag = "Clave de Producto"
        '
        'oND
        '
        Me.oND.Appearance = System.Windows.Forms.Appearance.Button
        Me.oND.BackColor = System.Drawing.Color.White
        Me.oND.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oND.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oND.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oND.ForeColor = System.Drawing.Color.Black
        Me.oND.Image = CType(resources.GetObject("oND.Image"), System.Drawing.Image)
        Me.oND.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oND.Location = New System.Drawing.Point(160, 234)
        Me.oND.Name = "oND"
        Me.oND.Size = New System.Drawing.Size(140, 26)
        Me.oND.TabIndex = 105
        Me.oND.Text = "Nota de Débito"
        Me.oND.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oND.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 15)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Número Resolución"
        '
        'oGD
        '
        Me.oGD.Appearance = System.Windows.Forms.Appearance.Button
        Me.oGD.BackColor = System.Drawing.Color.White
        Me.oGD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oGD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oGD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oGD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oGD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oGD.ForeColor = System.Drawing.Color.Black
        Me.oGD.Image = CType(resources.GetObject("oGD.Image"), System.Drawing.Image)
        Me.oGD.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oGD.Location = New System.Drawing.Point(306, 202)
        Me.oGD.Name = "oGD"
        Me.oGD.Size = New System.Drawing.Size(140, 26)
        Me.oGD.TabIndex = 135
        Me.oGD.Text = "Guía Despacho"
        Me.oGD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oGD.UseVisualStyleBackColor = False
        '
        'oBE
        '
        Me.oBE.Appearance = System.Windows.Forms.Appearance.Button
        Me.oBE.BackColor = System.Drawing.Color.White
        Me.oBE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oBE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oBE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oBE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oBE.ForeColor = System.Drawing.Color.Black
        Me.oBE.Image = CType(resources.GetObject("oBE.Image"), System.Drawing.Image)
        Me.oBE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oBE.Location = New System.Drawing.Point(14, 266)
        Me.oBE.Name = "oBE"
        Me.oBE.Size = New System.Drawing.Size(140, 26)
        Me.oBE.TabIndex = 139
        Me.oBE.Text = "Boleta Exenta"
        Me.oBE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oBE.UseVisualStyleBackColor = False
        '
        'oFV
        '
        Me.oFV.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFV.BackColor = System.Drawing.Color.White
        Me.oFV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFV.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFV.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFV.ForeColor = System.Drawing.Color.Black
        Me.oFV.Image = CType(resources.GetObject("oFV.Image"), System.Drawing.Image)
        Me.oFV.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oFV.Location = New System.Drawing.Point(14, 202)
        Me.oFV.Name = "oFV"
        Me.oFV.Size = New System.Drawing.Size(140, 26)
        Me.oFV.TabIndex = 104
        Me.oFV.Text = "Factura de Venta"
        Me.oFV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFV.UseVisualStyleBackColor = False
        '
        'xNumeroR
        '
        Me.xNumeroR.BackColor = System.Drawing.Color.White
        Me.xNumeroR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumeroR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNumeroR.Location = New System.Drawing.Point(166, 79)
        Me.xNumeroR.MaxLength = 100
        Me.xNumeroR.Name = "xNumeroR"
        Me.xNumeroR.Size = New System.Drawing.Size(101, 21)
        Me.xNumeroR.TabIndex = 2
        Me.xNumeroR.Tag = "Numero de Resolución"
        '
        'xSII
        '
        Me.xSII.BackColor = System.Drawing.Color.White
        Me.xSII.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xSII.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSII.Location = New System.Drawing.Point(166, 163)
        Me.xSII.MaxLength = 100
        Me.xSII.Name = "xSII"
        Me.xSII.Size = New System.Drawing.Size(280, 21)
        Me.xSII.TabIndex = 5
        Me.xSII.Tag = "SII"
        '
        'oBO
        '
        Me.oBO.Appearance = System.Windows.Forms.Appearance.Button
        Me.oBO.BackColor = System.Drawing.Color.White
        Me.oBO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBO.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oBO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oBO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oBO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oBO.ForeColor = System.Drawing.Color.Black
        Me.oBO.Image = CType(resources.GetObject("oBO.Image"), System.Drawing.Image)
        Me.oBO.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oBO.Location = New System.Drawing.Point(160, 202)
        Me.oBO.Name = "oBO"
        Me.oBO.Size = New System.Drawing.Size(140, 26)
        Me.oBO.TabIndex = 138
        Me.oBO.Text = "Boleta Electrónica"
        Me.oBO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oBO.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 15)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Ciudad Timbraje de SII"
        '
        'dFechaR
        '
        Me.dFechaR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFechaR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFechaR.Location = New System.Drawing.Point(166, 107)
        Me.dFechaR.Name = "dFechaR"
        Me.dFechaR.Size = New System.Drawing.Size(101, 21)
        Me.dFechaR.TabIndex = 3
        Me.dFechaR.Tag = "Fecha de Resolución"
        '
        'xAteco
        '
        Me.xAteco.BackColor = System.Drawing.Color.White
        Me.xAteco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xAteco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xAteco.Location = New System.Drawing.Point(166, 135)
        Me.xAteco.MaxLength = 100
        Me.xAteco.Name = "xAteco"
        Me.xAteco.Size = New System.Drawing.Size(101, 21)
        Me.xAteco.TabIndex = 4
        Me.xAteco.Tag = "ATECO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 15)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Fecha Resolución"
        '
        'oFC
        '
        Me.oFC.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFC.BackColor = System.Drawing.Color.White
        Me.oFC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFC.ForeColor = System.Drawing.Color.Black
        Me.oFC.Image = CType(resources.GetObject("oFC.Image"), System.Drawing.Image)
        Me.oFC.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oFC.Location = New System.Drawing.Point(306, 234)
        Me.oFC.Name = "oFC"
        Me.oFC.Size = New System.Drawing.Size(140, 26)
        Me.oFC.TabIndex = 136
        Me.oFC.Text = "Factura de Compra"
        Me.oFC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFC.UseVisualStyleBackColor = False
        '
        'oFE
        '
        Me.oFE.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFE.BackColor = System.Drawing.Color.White
        Me.oFE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFE.ForeColor = System.Drawing.Color.Black
        Me.oFE.Image = CType(resources.GetObject("oFE.Image"), System.Drawing.Image)
        Me.oFE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.oFE.Location = New System.Drawing.Point(160, 266)
        Me.oFE.Name = "oFE"
        Me.oFE.Size = New System.Drawing.Size(140, 26)
        Me.oFE.TabIndex = 137
        Me.oFE.Text = "Factura Exenta"
        Me.oFE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFE.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Código ACTECO"
        '
        'oElectronica
        '
        Me.oElectronica.Appearance = System.Windows.Forms.Appearance.Button
        Me.oElectronica.BackColor = System.Drawing.Color.White
        Me.oElectronica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oElectronica.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oElectronica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oElectronica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oElectronica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oElectronica.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oElectronica.ForeColor = System.Drawing.Color.Black
        Me.oElectronica.Image = CType(resources.GetObject("oElectronica.Image"), System.Drawing.Image)
        Me.oElectronica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oElectronica.Location = New System.Drawing.Point(6, 13)
        Me.oElectronica.Name = "oElectronica"
        Me.oElectronica.Size = New System.Drawing.Size(190, 31)
        Me.oElectronica.TabIndex = 103
        Me.oElectronica.Text = "Facturación Electrónica"
        Me.oElectronica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oElectronica.UseVisualStyleBackColor = False
        '
        'lFolios
        '
        Me.lFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lFolios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lFolios.ForeColor = System.Drawing.Color.White
        Me.lFolios.Location = New System.Drawing.Point(479, 8)
        Me.lFolios.Name = "lFolios"
        Me.lFolios.Size = New System.Drawing.Size(255, 16)
        Me.lFolios.TabIndex = 146
        Me.lFolios.Text = "Logo Reportes"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pLogo
        '
        Me.pLogo.BackColor = System.Drawing.Color.White
        Me.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pLogo.Location = New System.Drawing.Point(482, 26)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(243, 143)
        Me.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pLogo.TabIndex = 123
        Me.pLogo.TabStop = False
        '
        'bCargar
        '
        Me.bCargar.BackColor = System.Drawing.Color.White
        Me.bCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCargar.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bCargar.Location = New System.Drawing.Point(620, 175)
        Me.bCargar.Name = "bCargar"
        Me.bCargar.Size = New System.Drawing.Size(105, 28)
        Me.bCargar.TabIndex = 122
        Me.bCargar.Text = "Cargar Logo"
        Me.bCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCargar.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(485, 379)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(129, 30)
        Me.TextBox2.TabIndex = 144
        Me.TextBox2.Text = "Imagen de 1000x600 pixels (relación 5:3)"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(485, 174)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(129, 30)
        Me.TextBox1.TabIndex = 141
        Me.TextBox1.Text = "Imagen de 1000x600 pixels (relación 5:3)"
        '
        'pLogoVoucher
        '
        Me.pLogoVoucher.BackColor = System.Drawing.Color.White
        Me.pLogoVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pLogoVoucher.Location = New System.Drawing.Point(482, 230)
        Me.pLogoVoucher.Name = "pLogoVoucher"
        Me.pLogoVoucher.Size = New System.Drawing.Size(243, 143)
        Me.pLogoVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pLogoVoucher.TabIndex = 143
        Me.pLogoVoucher.TabStop = False
        '
        'bCargarLogoVoucher
        '
        Me.bCargarLogoVoucher.BackColor = System.Drawing.Color.White
        Me.bCargarLogoVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargarLogoVoucher.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCargarLogoVoucher.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bCargarLogoVoucher.Location = New System.Drawing.Point(620, 379)
        Me.bCargarLogoVoucher.Name = "bCargarLogoVoucher"
        Me.bCargarLogoVoucher.Size = New System.Drawing.Size(105, 28)
        Me.bCargarLogoVoucher.TabIndex = 142
        Me.bCargarLogoVoucher.Text = "Cargar Logo"
        Me.bCargarLogoVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCargarLogoVoucher.UseVisualStyleBackColor = False
        '
        'ManLocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(768, 582)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.xTab)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManLocales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Locales"
        Me.xTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gPrincipal.ResumeLayout(False)
        Me.gPrincipal.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gElectronica.ResumeLayout(False)
        Me.gElectronica.PerformLayout()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pLogoVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents bGuardar As Button
    Public WithEvents bEliminar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents gElectronica As GroupBox
    Friend WithEvents xIP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents xSII As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents xAteco As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dFechaR As DateTimePicker
    Friend WithEvents xNumeroR As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents xClave As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents pLogo As PictureBox
    Public WithEvents bCargar As Button
    Friend WithEvents fLogo As OpenFileDialog
    
    Friend WithEvents xTab As Controls.Vs2010TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gPrincipal As GroupBox
    Public WithEvents bBuscarC As Button
    Public WithEvents xNombreCliente As TextBox
    Friend WithEvents xTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cComunas As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cCiudades As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xGiroLocal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents bBuscar As Button
    Friend WithEvents xNombre As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents bNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents xLocal As TextBox
    Friend WithEvents xRut As MaskedTextBox
    Friend WithEvents oPrecio As CustomCheck
    Friend WithEvents oVenta As CustomCheck
    Friend WithEvents oElectronica As CustomCheck
    Friend WithEvents oEnvioAuto As CustomCheck
    Friend WithEvents oBE As CustomCheck
    Friend WithEvents oBO As CustomCheck
    Friend WithEvents oFE As CustomCheck
    Friend WithEvents oFC As CustomCheck
    Friend WithEvents oGD As CustomCheck
    Friend WithEvents oNC As CustomCheck
    Friend WithEvents oND As CustomCheck
    Friend WithEvents oFV As CustomCheck
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents TextBox2 As TextBox
    Public WithEvents bCargarLogoVoucher As Button
    Friend WithEvents pLogoVoucher As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lFolios As Label
    Friend WithEvents oLogoVoucher As OpenFileDialog
End Class
