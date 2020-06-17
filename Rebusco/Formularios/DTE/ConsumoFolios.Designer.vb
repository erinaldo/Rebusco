<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumoFolios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsumoFolios))
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bCOF = New System.Windows.Forms.Button()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.gDatosCliente = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bBuscarCli = New Rebusco.SearchButton()
        Me.xRut = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xFechaFE = New System.Windows.Forms.TextBox()
        Me.xDisND = New System.Windows.Forms.TextBox()
        Me.xDisNC = New System.Windows.Forms.TextBox()
        Me.xDisGD = New System.Windows.Forms.TextBox()
        Me.xDisFE = New System.Windows.Forms.TextBox()
        Me.xDisFV = New System.Windows.Forms.TextBox()
        Me.xDisBE = New System.Windows.Forms.TextBox()
        Me.xDisBV = New System.Windows.Forms.TextBox()
        Me.xFinND = New System.Windows.Forms.TextBox()
        Me.xFinNC = New System.Windows.Forms.TextBox()
        Me.xFinGD = New System.Windows.Forms.TextBox()
        Me.xFinFE = New System.Windows.Forms.TextBox()
        Me.xFinFV = New System.Windows.Forms.TextBox()
        Me.xFinBE = New System.Windows.Forms.TextBox()
        Me.xFinBV = New System.Windows.Forms.TextBox()
        Me.xIniND = New System.Windows.Forms.TextBox()
        Me.xIniNC = New System.Windows.Forms.TextBox()
        Me.xIniGD = New System.Windows.Forms.TextBox()
        Me.xIniFE = New System.Windows.Forms.TextBox()
        Me.xIniFV = New System.Windows.Forms.TextBox()
        Me.xIniBE = New System.Windows.Forms.TextBox()
        Me.xIniBV = New System.Windows.Forms.TextBox()
        Me.xFechaND = New System.Windows.Forms.TextBox()
        Me.xFechaNC = New System.Windows.Forms.TextBox()
        Me.xFechaGD = New System.Windows.Forms.TextBox()
        Me.xFechaBE = New System.Windows.Forms.TextBox()
        Me.xFechaFV = New System.Windows.Forms.TextBox()
        Me.xFechaBV = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gDatosCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.WinDeco1.ImagenBanner = Global.Rebusco.My.Resources.Resources.banner3
        Me.WinDeco1.Location = New System.Drawing.Point(0, 0)
        Me.WinDeco1.Margin = New System.Windows.Forms.Padding(2)
        Me.WinDeco1.MuestraBordeExterior = -1
        Me.WinDeco1.Name = "WinDeco1"
        Me.WinDeco1.SiempreVisible = False
        Me.WinDeco1.Size = New System.Drawing.Size(732, 50)
        Me.WinDeco1.TabIndex = 148
        Me.WinDeco1.TituloVentana = "Consumo de Folios"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bCOF
        '
        Me.bCOF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bCOF.BackColor = System.Drawing.Color.White
        Me.bCOF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCOF.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCOF.Image = Global.Rebusco.My.Resources.Resources.invoice_find24
        Me.bCOF.Location = New System.Drawing.Point(12, 402)
        Me.bCOF.Name = "bCOF"
        Me.bCOF.Size = New System.Drawing.Size(142, 36)
        Me.bCOF.TabIndex = 149
        Me.bCOF.Text = "   Control COF"
        Me.bCOF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCOF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCOF.UseVisualStyleBackColor = False
        '
        'bConsultar
        '
        Me.bConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.Location = New System.Drawing.Point(509, 399)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(105, 36)
        Me.bConsultar.TabIndex = 151
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.Location = New System.Drawing.Point(621, 399)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 150
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'gDatosCliente
        '
        Me.gDatosCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDatosCliente.BackColor = System.Drawing.Color.Transparent
        Me.gDatosCliente.Controls.Add(Me.Label1)
        Me.gDatosCliente.Controls.Add(Me.bBuscarCli)
        Me.gDatosCliente.Controls.Add(Me.xNombre)
        Me.gDatosCliente.Controls.Add(Me.xRut)
        Me.gDatosCliente.Location = New System.Drawing.Point(12, 60)
        Me.gDatosCliente.Name = "gDatosCliente"
        Me.gDatosCliente.Size = New System.Drawing.Size(708, 51)
        Me.gDatosCliente.TabIndex = 152
        Me.gDatosCliente.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 16)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = " Empresa Facturador de Mercado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bBuscarCli
        '
        Me.bBuscarCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBuscarCli.CampoBuscar1 = "Nombre"
        Me.bBuscarCli.CampoBuscar2 = ""
        Me.bBuscarCli.CamposAdicionales = ""
        Me.bBuscarCli.ControlCarga = Me.xRut
        Me.bBuscarCli.ControlFocus = Me.xRut
        Me.bBuscarCli.Filtro = ""
        Me.bBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarCli.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarCli.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarCli.IDBusqueda = "Rut"
        Me.bBuscarCli.Image = CType(resources.GetObject("bBuscarCli.Image"), System.Drawing.Image)
        Me.bBuscarCli.Location = New System.Drawing.Point(675, 19)
        Me.bBuscarCli.Name = "bBuscarCli"
        Me.bBuscarCli.Size = New System.Drawing.Size(28, 27)
        Me.bBuscarCli.TabIndex = 2
        Me.bBuscarCli.TablaBusqueda = "Clientes"
        Me.bBuscarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarCli.Titulo = "Clientes"
        Me.bBuscarCli.UseVisualStyleBackColor = True
        Me.bBuscarCli.Visible = False
        '
        'xRut
        '
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRut.Location = New System.Drawing.Point(6, 22)
        Me.xRut.Name = "xRut"
        Me.xRut.ReadOnly = True
        Me.xRut.Size = New System.Drawing.Size(100, 22)
        Me.xRut.TabIndex = 0
        '
        'xNombre
        '
        Me.xNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombre.Location = New System.Drawing.Point(113, 22)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(582, 22)
        Me.xNombre.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xFechaFE)
        Me.GroupBox1.Controls.Add(Me.xDisND)
        Me.GroupBox1.Controls.Add(Me.xDisNC)
        Me.GroupBox1.Controls.Add(Me.xDisGD)
        Me.GroupBox1.Controls.Add(Me.xDisFE)
        Me.GroupBox1.Controls.Add(Me.xDisFV)
        Me.GroupBox1.Controls.Add(Me.xDisBE)
        Me.GroupBox1.Controls.Add(Me.xDisBV)
        Me.GroupBox1.Controls.Add(Me.xFinND)
        Me.GroupBox1.Controls.Add(Me.xFinNC)
        Me.GroupBox1.Controls.Add(Me.xFinGD)
        Me.GroupBox1.Controls.Add(Me.xFinFE)
        Me.GroupBox1.Controls.Add(Me.xFinFV)
        Me.GroupBox1.Controls.Add(Me.xFinBE)
        Me.GroupBox1.Controls.Add(Me.xFinBV)
        Me.GroupBox1.Controls.Add(Me.xIniND)
        Me.GroupBox1.Controls.Add(Me.xIniNC)
        Me.GroupBox1.Controls.Add(Me.xIniGD)
        Me.GroupBox1.Controls.Add(Me.xIniFE)
        Me.GroupBox1.Controls.Add(Me.xIniFV)
        Me.GroupBox1.Controls.Add(Me.xIniBE)
        Me.GroupBox1.Controls.Add(Me.xIniBV)
        Me.GroupBox1.Controls.Add(Me.xFechaND)
        Me.GroupBox1.Controls.Add(Me.xFechaNC)
        Me.GroupBox1.Controls.Add(Me.xFechaGD)
        Me.GroupBox1.Controls.Add(Me.xFechaBE)
        Me.GroupBox1.Controls.Add(Me.xFechaFV)
        Me.GroupBox1.Controls.Add(Me.xFechaBV)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 262)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        '
        'xFechaFE
        '
        Me.xFechaFE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaFE.Location = New System.Drawing.Point(244, 143)
        Me.xFechaFE.Name = "xFechaFE"
        Me.xFechaFE.ReadOnly = True
        Me.xFechaFE.Size = New System.Drawing.Size(112, 22)
        Me.xFechaFE.TabIndex = 193
        '
        'xDisND
        '
        Me.xDisND.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisND.Location = New System.Drawing.Point(599, 227)
        Me.xDisND.Name = "xDisND"
        Me.xDisND.ReadOnly = True
        Me.xDisND.Size = New System.Drawing.Size(96, 22)
        Me.xDisND.TabIndex = 192
        Me.xDisND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDisNC
        '
        Me.xDisNC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisNC.Location = New System.Drawing.Point(599, 199)
        Me.xDisNC.Name = "xDisNC"
        Me.xDisNC.ReadOnly = True
        Me.xDisNC.Size = New System.Drawing.Size(96, 22)
        Me.xDisNC.TabIndex = 191
        Me.xDisNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDisGD
        '
        Me.xDisGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisGD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisGD.Location = New System.Drawing.Point(599, 171)
        Me.xDisGD.Name = "xDisGD"
        Me.xDisGD.ReadOnly = True
        Me.xDisGD.Size = New System.Drawing.Size(96, 22)
        Me.xDisGD.TabIndex = 190
        Me.xDisGD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDisFE
        '
        Me.xDisFE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisFE.Location = New System.Drawing.Point(599, 143)
        Me.xDisFE.Name = "xDisFE"
        Me.xDisFE.ReadOnly = True
        Me.xDisFE.Size = New System.Drawing.Size(96, 22)
        Me.xDisFE.TabIndex = 189
        Me.xDisFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDisFV
        '
        Me.xDisFV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisFV.Location = New System.Drawing.Point(599, 116)
        Me.xDisFV.Name = "xDisFV"
        Me.xDisFV.ReadOnly = True
        Me.xDisFV.Size = New System.Drawing.Size(96, 22)
        Me.xDisFV.TabIndex = 188
        Me.xDisFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDisBE
        '
        Me.xDisBE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisBE.Location = New System.Drawing.Point(599, 88)
        Me.xDisBE.Name = "xDisBE"
        Me.xDisBE.ReadOnly = True
        Me.xDisBE.Size = New System.Drawing.Size(96, 22)
        Me.xDisBE.TabIndex = 187
        Me.xDisBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDisBV
        '
        Me.xDisBV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDisBV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDisBV.Location = New System.Drawing.Point(599, 60)
        Me.xDisBV.Name = "xDisBV"
        Me.xDisBV.ReadOnly = True
        Me.xDisBV.Size = New System.Drawing.Size(96, 22)
        Me.xDisBV.TabIndex = 186
        Me.xDisBV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinND
        '
        Me.xFinND.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinND.Location = New System.Drawing.Point(481, 227)
        Me.xFinND.Name = "xFinND"
        Me.xFinND.ReadOnly = True
        Me.xFinND.Size = New System.Drawing.Size(96, 22)
        Me.xFinND.TabIndex = 185
        Me.xFinND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinNC
        '
        Me.xFinNC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinNC.Location = New System.Drawing.Point(481, 199)
        Me.xFinNC.Name = "xFinNC"
        Me.xFinNC.ReadOnly = True
        Me.xFinNC.Size = New System.Drawing.Size(96, 22)
        Me.xFinNC.TabIndex = 184
        Me.xFinNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinGD
        '
        Me.xFinGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinGD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinGD.Location = New System.Drawing.Point(481, 171)
        Me.xFinGD.Name = "xFinGD"
        Me.xFinGD.ReadOnly = True
        Me.xFinGD.Size = New System.Drawing.Size(96, 22)
        Me.xFinGD.TabIndex = 183
        Me.xFinGD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinFE
        '
        Me.xFinFE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinFE.Location = New System.Drawing.Point(481, 143)
        Me.xFinFE.Name = "xFinFE"
        Me.xFinFE.ReadOnly = True
        Me.xFinFE.Size = New System.Drawing.Size(96, 22)
        Me.xFinFE.TabIndex = 182
        Me.xFinFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinFV
        '
        Me.xFinFV.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinFV.Location = New System.Drawing.Point(481, 116)
        Me.xFinFV.Name = "xFinFV"
        Me.xFinFV.ReadOnly = True
        Me.xFinFV.Size = New System.Drawing.Size(96, 22)
        Me.xFinFV.TabIndex = 181
        Me.xFinFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinBE
        '
        Me.xFinBE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinBE.Location = New System.Drawing.Point(481, 88)
        Me.xFinBE.Name = "xFinBE"
        Me.xFinBE.ReadOnly = True
        Me.xFinBE.Size = New System.Drawing.Size(96, 22)
        Me.xFinBE.TabIndex = 180
        Me.xFinBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFinBV
        '
        Me.xFinBV.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xFinBV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFinBV.Location = New System.Drawing.Point(481, 60)
        Me.xFinBV.Name = "xFinBV"
        Me.xFinBV.ReadOnly = True
        Me.xFinBV.Size = New System.Drawing.Size(96, 22)
        Me.xFinBV.TabIndex = 179
        Me.xFinBV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniND
        '
        Me.xIniND.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniND.Location = New System.Drawing.Point(379, 227)
        Me.xIniND.Name = "xIniND"
        Me.xIniND.ReadOnly = True
        Me.xIniND.Size = New System.Drawing.Size(96, 22)
        Me.xIniND.TabIndex = 178
        Me.xIniND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniNC
        '
        Me.xIniNC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniNC.Location = New System.Drawing.Point(379, 199)
        Me.xIniNC.Name = "xIniNC"
        Me.xIniNC.ReadOnly = True
        Me.xIniNC.Size = New System.Drawing.Size(96, 22)
        Me.xIniNC.TabIndex = 177
        Me.xIniNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniGD
        '
        Me.xIniGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniGD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniGD.Location = New System.Drawing.Point(379, 171)
        Me.xIniGD.Name = "xIniGD"
        Me.xIniGD.ReadOnly = True
        Me.xIniGD.Size = New System.Drawing.Size(96, 22)
        Me.xIniGD.TabIndex = 176
        Me.xIniGD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniFE
        '
        Me.xIniFE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniFE.Location = New System.Drawing.Point(379, 143)
        Me.xIniFE.Name = "xIniFE"
        Me.xIniFE.ReadOnly = True
        Me.xIniFE.Size = New System.Drawing.Size(96, 22)
        Me.xIniFE.TabIndex = 175
        Me.xIniFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniFV
        '
        Me.xIniFV.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniFV.Location = New System.Drawing.Point(379, 115)
        Me.xIniFV.Name = "xIniFV"
        Me.xIniFV.ReadOnly = True
        Me.xIniFV.Size = New System.Drawing.Size(96, 22)
        Me.xIniFV.TabIndex = 174
        Me.xIniFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniBE
        '
        Me.xIniBE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniBE.Location = New System.Drawing.Point(379, 87)
        Me.xIniBE.Name = "xIniBE"
        Me.xIniBE.ReadOnly = True
        Me.xIniBE.Size = New System.Drawing.Size(96, 22)
        Me.xIniBE.TabIndex = 173
        Me.xIniBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIniBV
        '
        Me.xIniBV.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xIniBV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIniBV.Location = New System.Drawing.Point(379, 60)
        Me.xIniBV.Name = "xIniBV"
        Me.xIniBV.ReadOnly = True
        Me.xIniBV.Size = New System.Drawing.Size(96, 22)
        Me.xIniBV.TabIndex = 172
        Me.xIniBV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFechaND
        '
        Me.xFechaND.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaND.Location = New System.Drawing.Point(244, 227)
        Me.xFechaND.Name = "xFechaND"
        Me.xFechaND.ReadOnly = True
        Me.xFechaND.Size = New System.Drawing.Size(112, 22)
        Me.xFechaND.TabIndex = 171
        '
        'xFechaNC
        '
        Me.xFechaNC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaNC.Location = New System.Drawing.Point(244, 199)
        Me.xFechaNC.Name = "xFechaNC"
        Me.xFechaNC.ReadOnly = True
        Me.xFechaNC.Size = New System.Drawing.Size(112, 22)
        Me.xFechaNC.TabIndex = 170
        '
        'xFechaGD
        '
        Me.xFechaGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaGD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaGD.Location = New System.Drawing.Point(244, 171)
        Me.xFechaGD.Name = "xFechaGD"
        Me.xFechaGD.ReadOnly = True
        Me.xFechaGD.Size = New System.Drawing.Size(112, 22)
        Me.xFechaGD.TabIndex = 169
        '
        'xFechaBE
        '
        Me.xFechaBE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaBE.Location = New System.Drawing.Point(244, 87)
        Me.xFechaBE.Name = "xFechaBE"
        Me.xFechaBE.ReadOnly = True
        Me.xFechaBE.Size = New System.Drawing.Size(112, 22)
        Me.xFechaBE.TabIndex = 168
        '
        'xFechaFV
        '
        Me.xFechaFV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaFV.Location = New System.Drawing.Point(244, 115)
        Me.xFechaFV.Name = "xFechaFV"
        Me.xFechaFV.ReadOnly = True
        Me.xFechaFV.Size = New System.Drawing.Size(112, 22)
        Me.xFechaFV.TabIndex = 167
        '
        'xFechaBV
        '
        Me.xFechaBV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xFechaBV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaBV.Location = New System.Drawing.Point(244, 60)
        Me.xFechaBV.Name = "xFechaBV"
        Me.xFechaBV.ReadOnly = True
        Me.xFechaBV.Size = New System.Drawing.Size(112, 22)
        Me.xFechaBV.TabIndex = 165
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(615, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Disponibles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(540, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "Final"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(433, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 16)
        Me.Label11.TabIndex = 162
        Me.Label11.Text = "Inicial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Fecha Emisión"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 16)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Notas de Débito Electrónicas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 16)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "Notas de Crédito Electrónicas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 16)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Guías de Despacho Electrónicas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 16)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Facturas Electrónicas Exentas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Facturas Electrónicas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 16)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Boletas Electrónicas Exentas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Boletas Electrónicas"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 16)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = " Folios Cargados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsumoFolios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 454)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gDatosCliente)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bCOF)
        Me.Controls.Add(Me.WinDeco1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1536, 824)
        Me.Name = "ConsumoFolios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo de Folios"
        Me.gDatosCliente.ResumeLayout(False)
        Me.gDatosCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Public WithEvents bCOF As Button
    Friend WithEvents bConsultar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents gDatosCliente As GroupBox
    Friend WithEvents bBuscarCli As SearchButton
    Friend WithEvents xRut As TextBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xDisND As TextBox
    Friend WithEvents xDisNC As TextBox
    Friend WithEvents xDisGD As TextBox
    Friend WithEvents xDisFE As TextBox
    Friend WithEvents xDisFV As TextBox
    Friend WithEvents xDisBE As TextBox
    Friend WithEvents xDisBV As TextBox
    Friend WithEvents xFinND As TextBox
    Friend WithEvents xFinNC As TextBox
    Friend WithEvents xFinGD As TextBox
    Friend WithEvents xFinFE As TextBox
    Friend WithEvents xFinFV As TextBox
    Friend WithEvents xFinBE As TextBox
    Friend WithEvents xFinBV As TextBox
    Friend WithEvents xIniND As TextBox
    Friend WithEvents xIniNC As TextBox
    Friend WithEvents xIniGD As TextBox
    Friend WithEvents xIniFE As TextBox
    Friend WithEvents xIniFV As TextBox
    Friend WithEvents xIniBE As TextBox
    Friend WithEvents xIniBV As TextBox
    Friend WithEvents xFechaND As TextBox
    Friend WithEvents xFechaNC As TextBox
    Friend WithEvents xFechaGD As TextBox
    Friend WithEvents xFechaFV As TextBox
    Friend WithEvents xFechaBE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents xFechaFE As TextBox
    Friend WithEvents xFechaBV As TextBox
End Class
