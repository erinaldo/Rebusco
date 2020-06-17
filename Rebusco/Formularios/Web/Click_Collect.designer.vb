<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Click_Collect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Click_Collect))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oAutomatico = New System.Windows.Forms.CheckBox()
        Me.cHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.xNombreCliente = New System.Windows.Forms.TextBox()
        Me.cDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bMostrar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xTicket = New System.Windows.Forms.TextBox()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.mMenuTabla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mImprimirOT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mServicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.bBuscarC = New Rebusco.SearchButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mMenuTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.oAutomatico)
        Me.GroupBox4.Controls.Add(Me.cHasta)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.bBuscarC)
        Me.GroupBox4.Controls.Add(Me.xNombreCliente)
        Me.GroupBox4.Controls.Add(Me.cDesde)
        Me.GroupBox4.Controls.Add(Me.cLocal)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.bMostrar)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.xCliente)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cEstado)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.xTicket)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(911, 143)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(653, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Consulta Automática"
        '
        'oAutomatico
        '
        Me.oAutomatico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oAutomatico.Appearance = System.Windows.Forms.Appearance.Button
        Me.oAutomatico.BackColor = System.Drawing.Color.Transparent
        Me.oAutomatico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oAutomatico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.oAutomatico.Location = New System.Drawing.Point(652, 98)
        Me.oAutomatico.Name = "oAutomatico"
        Me.oAutomatico.Size = New System.Drawing.Size(124, 38)
        Me.oAutomatico.TabIndex = 252
        Me.oAutomatico.Text = "OFF"
        Me.oAutomatico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.oAutomatico.UseVisualStyleBackColor = False
        '
        'cHasta
        '
        Me.cHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cHasta.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cHasta.Location = New System.Drawing.Point(792, 27)
        Me.cHasta.Name = "cHasta"
        Me.cHasta.Size = New System.Drawing.Size(110, 22)
        Me.cHasta.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(768, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 16)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "al"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(598, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Fechas"
        '
        'xCliente
        '
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.Location = New System.Drawing.Point(75, 86)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(110, 21)
        Me.xCliente.TabIndex = 4
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(75, 55)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(250, 23)
        Me.cLocal.TabIndex = 246
        '
        'xNombreCliente
        '
        Me.xNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreCliente.Location = New System.Drawing.Point(191, 86)
        Me.xNombreCliente.Name = "xNombreCliente"
        Me.xNombreCliente.Size = New System.Drawing.Size(350, 21)
        Me.xNombreCliente.TabIndex = 5
        '
        'cDesde
        '
        Me.cDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cDesde.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cDesde.Location = New System.Drawing.Point(652, 27)
        Me.cDesde.Name = "cDesde"
        Me.cDesde.Size = New System.Drawing.Size(110, 22)
        Me.cDesde.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(11, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 247
        Me.Label8.Text = "Local"
        '
        'bMostrar
        '
        Me.bMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMostrar.BackColor = System.Drawing.Color.White
        Me.bMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMostrar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bMostrar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bMostrar.Location = New System.Drawing.Point(792, 82)
        Me.bMostrar.Name = "bMostrar"
        Me.bMostrar.Size = New System.Drawing.Size(110, 54)
        Me.bMostrar.TabIndex = 242
        Me.bMostrar.Text = "Consultar Tickets"
        Me.bMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bMostrar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(-3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(914, 16)
        Me.Label14.TabIndex = 248
        Me.Label14.Text = " Filtro de Búsqueda"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Cliente"
        '
        'cEstado
        '
        Me.cEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstado.FormattingEnabled = True
        Me.cEstado.Location = New System.Drawing.Point(652, 55)
        Me.cEstado.Name = "cEstado"
        Me.cEstado.Size = New System.Drawing.Size(250, 23)
        Me.cEstado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(598, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Ticket"
        '
        'xTicket
        '
        Me.xTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTicket.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTicket.Location = New System.Drawing.Point(75, 24)
        Me.xTicket.MaxLength = 18
        Me.xTicket.Name = "xTicket"
        Me.xTicket.Size = New System.Drawing.Size(110, 21)
        Me.xTicket.TabIndex = 0
        Me.xTicket.Tag = "99"
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = resources.GetString("xTabla.ColumnInfo")
        Me.xTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.xTabla.Location = New System.Drawing.Point(12, 205)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 21
        Me.xTabla.Size = New System.Drawing.Size(911, 417)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 233
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'mMenuTabla
        '
        Me.mMenuTabla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mModificar, Me.mImprimirOT, Me.mServicio})
        Me.mMenuTabla.Name = "mMenuTabla"
        Me.mMenuTabla.Size = New System.Drawing.Size(139, 70)
        '
        'mModificar
        '
        Me.mModificar.Image = Global.Rebusco.My.Resources.Resources.edit16
        Me.mModificar.Name = "mModificar"
        Me.mModificar.Size = New System.Drawing.Size(138, 22)
        Me.mModificar.Text = "Modificar"
        '
        'mImprimirOT
        '
        Me.mImprimirOT.Image = Global.Rebusco.My.Resources.Resources.print
        Me.mImprimirOT.Name = "mImprimirOT"
        Me.mImprimirOT.Size = New System.Drawing.Size(138, 22)
        Me.mImprimirOT.Text = "Imprimir OT"
        '
        'mServicio
        '
        Me.mServicio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mServicio.Image = Global.Rebusco.My.Resources.Resources.Toolsb
        Me.mServicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mServicio.Name = "mServicio"
        Me.mServicio.Size = New System.Drawing.Size(138, 22)
        Me.mServicio.Text = "Servicio"
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
        Me.WinDeco1.Size = New System.Drawing.Size(932, 50)
        Me.WinDeco1.TabIndex = 252
        Me.WinDeco1.TituloVentana = "Click && Collect"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(820, 643)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 5
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(12, 643)
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
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(694, 643)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(120, 36)
        Me.bImprimir.TabIndex = 4
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 60000
        '
        'bBuscarC
        '
        Me.bBuscarC.CampoBuscar1 = "Nombre"
        Me.bBuscarC.CampoBuscar2 = ""
        Me.bBuscarC.CamposAdicionales = ""
        Me.bBuscarC.ControlCarga = Me.xCliente
        Me.bBuscarC.ControlFocus = Me.cLocal
        Me.bBuscarC.Filtro = ""
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarC.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarC.IDBusqueda = "Cliente"
        Me.bBuscarC.Image = CType(resources.GetObject("bBuscarC.Image"), System.Drawing.Image)
        Me.bBuscarC.Location = New System.Drawing.Point(547, 82)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(30, 27)
        Me.bBuscarC.TabIndex = 38
        Me.bBuscarC.TablaBusqueda = "Clientes"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.Titulo = "Clientes"
        Me.bBuscarC.UseVisualStyleBackColor = True
        '
        'Click_Collect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 691)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.bImprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "Click_Collect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click & Collect"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mMenuTabla.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents xTicket As TextBox
    Friend WithEvents xNombreCliente As TextBox
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cHasta As DateTimePicker
    Friend WithEvents cDesde As DateTimePicker
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button

    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label8 As Label
    Public WithEvents bMostrar As Button
    Friend WithEvents bBuscarC As SearchButton
    Friend WithEvents Label14 As Label
    Friend WithEvents mMenuTabla As ContextMenuStrip
    Friend WithEvents mServicio As ToolStripMenuItem
    Friend WithEvents mImprimirOT As ToolStripMenuItem
    Friend WithEvents mModificar As ToolStripMenuItem
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents oAutomatico As CheckBox
End Class
