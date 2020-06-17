<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IngresoOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoOT))
        Dim Vs2010TabControlRenderer1 As Rebusco.Renderers.Vs2010TabControlRenderer = New Rebusco.Renderers.Vs2010TabControlRenderer()
        Dim Vs2010DefaultTabControlColorTable1 As Rebusco.ColorTables.Vs2010DefaultTabControlColorTable = New Rebusco.ColorTables.Vs2010DefaultTabControlColorTable()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xEmail = New System.Windows.Forms.TextBox()
        Me.xTecnico = New Rebusco.TextBoxAutoComple()
        Me.bBuscarC = New Rebusco.SearchButton()
        Me.xCliente = New Rebusco.TextBoxAutoComple()
        Me.xProductoR = New System.Windows.Forms.TextBox()
        Me.dFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.xEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xNombreTecnico = New System.Windows.Forms.TextBox()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xOT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xTotalOT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bConsultarP = New System.Windows.Forms.Button()
        Me.dFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xCodigoR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gServicio = New System.Windows.Forms.GroupBox()
        Me.xServicio = New Rebusco.TextBoxAutoComple()
        Me.bBuscarServicio = New System.Windows.Forms.Button()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.xNombreServicio = New System.Windows.Forms.TextBox()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.bBuscarArticulo = New System.Windows.Forms.Button()
        Me.bAgregarA = New System.Windows.Forms.Button()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.xTablaArticulos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bBuscarOT = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cPlantilla = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bAgregarPlantilla = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.tObservacion = New Rebusco.Controls.Vs2010TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.xObsCliente = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.xObsTecnico = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gServicio.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xTablaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tObservacion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xEmail)
        Me.GroupBox1.Controls.Add(Me.xTecnico)
        Me.GroupBox1.Controls.Add(Me.bBuscarC)
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.dFecha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.bCrear)
        Me.GroupBox1.Controls.Add(Me.xEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xNombreTecnico)
        Me.GroupBox1.Controls.Add(Me.bNuevo)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xOT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xEmail
        '
        Me.xEmail.BackColor = System.Drawing.Color.White
        Me.xEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xEmail.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xEmail.Location = New System.Drawing.Point(64, 86)
        Me.xEmail.MaxLength = 100
        Me.xEmail.Name = "xEmail"
        Me.xEmail.Size = New System.Drawing.Size(474, 22)
        Me.xEmail.TabIndex = 238
        '
        'xTecnico
        '
        Me.xTecnico.AnchoLista = 300
        Me.xTecnico.AutoCompletarActivo = True
        Me.xTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTecnico.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xTecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTecnico.DescBusqueda = "NombreUsr"
        Me.xTecnico.DescBusquedaAdicional = ""
        Me.xTecnico.DescBusquedaAdicional2 = ""
        Me.xTecnico.Filtro = ""
        Me.xTecnico.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xTecnico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTecnico.IDBusqueda = "Usuario"
        Me.xTecnico.IntervaloBusquedaNumeros = 1
        Me.xTecnico.IntervaloBusquedaTexto = 2
        Me.xTecnico.Location = New System.Drawing.Point(64, 114)
        Me.xTecnico.Name = "xTecnico"
        Me.xTecnico.Size = New System.Drawing.Size(93, 22)
        Me.xTecnico.TabIndex = 2
        Me.xTecnico.TablaBusqueda = "Usuarios"
        Me.xTecnico.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'bBuscarC
        '
        Me.bBuscarC.CampoBuscar1 = "Nombre"
        Me.bBuscarC.CampoBuscar2 = "RUT"
        Me.bBuscarC.CamposAdicionales = ""
        Me.bBuscarC.ControlCarga = Me.xCliente
        Me.bBuscarC.ControlFocus = Me.xProductoR
        Me.bBuscarC.Filtro = ""
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarC.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarC.IDBusqueda = "Cliente"
        Me.bBuscarC.Image = CType(resources.GetObject("bBuscarC.Image"), System.Drawing.Image)
        Me.bBuscarC.Location = New System.Drawing.Point(544, 54)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(28, 28)
        Me.bBuscarC.TabIndex = 237
        Me.bBuscarC.TablaBusqueda = "Clientes"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.Titulo = "Clientes"
        Me.bBuscarC.UseVisualStyleBackColor = True
        '
        'xCliente
        '
        Me.xCliente.AnchoLista = 300
        Me.xCliente.AutoCompletarActivo = True
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.DescBusqueda = "Nombre"
        Me.xCliente.DescBusquedaAdicional = "Rut"
        Me.xCliente.DescBusquedaAdicional2 = "SinPuntos"
        Me.xCliente.Filtro = ""
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.IDBusqueda = "Cliente"
        Me.xCliente.IntervaloBusquedaNumeros = 1
        Me.xCliente.IntervaloBusquedaTexto = 2
        Me.xCliente.Location = New System.Drawing.Point(64, 57)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(93, 22)
        Me.xCliente.TabIndex = 1
        Me.xCliente.TablaBusqueda = "ClientesBusqueda"
        Me.xCliente.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'xProductoR
        '
        Me.xProductoR.BackColor = System.Drawing.Color.White
        Me.xProductoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xProductoR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xProductoR.Location = New System.Drawing.Point(120, 18)
        Me.xProductoR.Multiline = True
        Me.xProductoR.Name = "xProductoR"
        Me.xProductoR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.xProductoR.Size = New System.Drawing.Size(324, 37)
        Me.xProductoR.TabIndex = 0
        '
        'dFecha
        '
        Me.dFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFecha.Location = New System.Drawing.Point(506, 27)
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Size = New System.Drawing.Size(100, 21)
        Me.dFecha.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(440, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Fecha OT"
        '
        'bCrear
        '
        Me.bCrear.BackColor = System.Drawing.Color.White
        Me.bCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCrear.Image = CType(resources.GetObject("bCrear.Image"), System.Drawing.Image)
        Me.bCrear.Location = New System.Drawing.Point(578, 54)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(28, 28)
        Me.bCrear.TabIndex = 89
        Me.bCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCrear.UseVisualStyleBackColor = False
        '
        'xEstado
        '
        Me.xEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xEstado.Enabled = False
        Me.xEstado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xEstado.Location = New System.Drawing.Point(300, 26)
        Me.xEstado.Name = "xEstado"
        Me.xEstado.Size = New System.Drawing.Size(134, 21)
        Me.xEstado.TabIndex = 82
        Me.xEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(248, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Estado"
        '
        'xNombreTecnico
        '
        Me.xNombreTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreTecnico.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombreTecnico.Location = New System.Drawing.Point(163, 114)
        Me.xNombreTecnico.Name = "xNombreTecnico"
        Me.xNombreTecnico.ReadOnly = True
        Me.xNombreTecnico.Size = New System.Drawing.Size(375, 22)
        Me.xNombreTecnico.TabIndex = 85
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.White
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(163, 23)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(79, 27)
        Me.bNuevo.TabIndex = 80
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombre.Location = New System.Drawing.Point(163, 58)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(375, 22)
        Me.xNombre.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Técnico"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cliente"
        '
        'xOT
        '
        Me.xOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOT.Location = New System.Drawing.Point(64, 26)
        Me.xOT.Name = "xOT"
        Me.xOT.Size = New System.Drawing.Size(93, 21)
        Me.xOT.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OT"
        '
        'xTotalOT
        '
        Me.xTotalOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.xTotalOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotalOT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotalOT.Location = New System.Drawing.Point(631, 658)
        Me.xTotalOT.Name = "xTotalOT"
        Me.xTotalOT.Size = New System.Drawing.Size(121, 26)
        Me.xTotalOT.TabIndex = 0
        Me.xTotalOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha Entrega"
        '
        'bConsultarP
        '
        Me.bConsultarP.BackColor = System.Drawing.Color.White
        Me.bConsultarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultarP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bConsultarP.Image = CType(resources.GetObject("bConsultarP.Image"), System.Drawing.Image)
        Me.bConsultarP.Location = New System.Drawing.Point(324, 60)
        Me.bConsultarP.Name = "bConsultarP"
        Me.bConsultarP.Size = New System.Drawing.Size(96, 26)
        Me.bConsultarP.TabIndex = 91
        Me.bConsultarP.Text = "Consultar"
        Me.bConsultarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultarP.UseVisualStyleBackColor = False
        '
        'dFechaEntrega
        '
        Me.dFechaEntrega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFechaEntrega.Location = New System.Drawing.Point(120, 86)
        Me.dFechaEntrega.Name = "dFechaEntrega"
        Me.dFechaEntrega.Size = New System.Drawing.Size(101, 21)
        Me.dFechaEntrega.TabIndex = 2
        Me.dFechaEntrega.Value = New Date(2017, 12, 22, 11, 20, 5, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(553, 663)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Total OT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto Recibido"
        '
        'xCodigoR
        '
        Me.xCodigoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCodigoR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCodigoR.Location = New System.Drawing.Point(120, 61)
        Me.xCodigoR.Name = "xCodigoR"
        Me.xCodigoR.Size = New System.Drawing.Size(152, 21)
        Me.xCodigoR.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Código Producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(278, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 15)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "(SKU)"
        '
        'gServicio
        '
        Me.gServicio.BackColor = System.Drawing.Color.Transparent
        Me.gServicio.Controls.Add(Me.xServicio)
        Me.gServicio.Controls.Add(Me.bBuscarServicio)
        Me.gServicio.Controls.Add(Me.bAgregar)
        Me.gServicio.Controls.Add(Me.xNombreServicio)
        Me.gServicio.Controls.Add(Me.xTabla)
        Me.gServicio.Location = New System.Drawing.Point(12, 211)
        Me.gServicio.Name = "gServicio"
        Me.gServicio.Size = New System.Drawing.Size(1069, 162)
        Me.gServicio.TabIndex = 2
        Me.gServicio.TabStop = False
        '
        'xServicio
        '
        Me.xServicio.AnchoLista = 800
        Me.xServicio.AutoCompletarActivo = True
        Me.xServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xServicio.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xServicio.DescBusqueda = "Descripcion"
        Me.xServicio.DescBusquedaAdicional = "SKU"
        Me.xServicio.DescBusquedaAdicional2 = ""
        Me.xServicio.Filtro = "TipoArticulo='S'"
        Me.xServicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xServicio.IDBusqueda = "Articulo"
        Me.xServicio.IntervaloBusquedaNumeros = 1
        Me.xServicio.IntervaloBusquedaTexto = 2
        Me.xServicio.Location = New System.Drawing.Point(11, 21)
        Me.xServicio.Name = "xServicio"
        Me.xServicio.Size = New System.Drawing.Size(116, 22)
        Me.xServicio.TabIndex = 5
        Me.xServicio.TablaBusqueda = "BuscadorAutocompletar"
        Me.xServicio.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bBuscarServicio
        '
        Me.bBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarServicio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarServicio.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarServicio.Location = New System.Drawing.Point(619, 19)
        Me.bBuscarServicio.Name = "bBuscarServicio"
        Me.bBuscarServicio.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarServicio.TabIndex = 4
        Me.bBuscarServicio.Text = "Buscar"
        Me.bBuscarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarServicio.UseVisualStyleBackColor = True
        '
        'bAgregar
        '
        Me.bAgregar.BackColor = System.Drawing.Color.White
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregar.Image = CType(resources.GetObject("bAgregar.Image"), System.Drawing.Image)
        Me.bAgregar.Location = New System.Drawing.Point(704, 19)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(79, 27)
        Me.bAgregar.TabIndex = 2
        Me.bAgregar.Text = "Cargar"
        Me.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregar.UseVisualStyleBackColor = False
        '
        'xNombreServicio
        '
        Me.xNombreServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreServicio.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombreServicio.Location = New System.Drawing.Point(137, 21)
        Me.xNombreServicio.Name = "xNombreServicio"
        Me.xNombreServicio.Size = New System.Drawing.Size(476, 22)
        Me.xNombreServicio.TabIndex = 1
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = resources.GetString("xTabla.ColumnInfo")
        Me.xTabla.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xTabla.Location = New System.Drawing.Point(9, 50)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.Size = New System.Drawing.Size(1054, 106)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 3
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.xArticulo)
        Me.GroupBox3.Controls.Add(Me.bBuscarArticulo)
        Me.GroupBox3.Controls.Add(Me.bAgregarA)
        Me.GroupBox3.Controls.Add(Me.xDescripcion)
        Me.GroupBox3.Controls.Add(Me.xTablaArticulos)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 377)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1069, 153)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 800
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "SKU"
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 2
        Me.xArticulo.Location = New System.Drawing.Point(10, 23)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(116, 22)
        Me.xArticulo.TabIndex = 107
        Me.xArticulo.TablaBusqueda = "BuscadorAutocompletar"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bBuscarArticulo
        '
        Me.bBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarArticulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarArticulo.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarArticulo.Location = New System.Drawing.Point(618, 21)
        Me.bBuscarArticulo.Name = "bBuscarArticulo"
        Me.bBuscarArticulo.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarArticulo.TabIndex = 106
        Me.bBuscarArticulo.Text = "Buscar"
        Me.bBuscarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarArticulo.UseVisualStyleBackColor = True
        '
        'bAgregarA
        '
        Me.bAgregarA.BackColor = System.Drawing.Color.White
        Me.bAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregarA.Image = CType(resources.GetObject("bAgregarA.Image"), System.Drawing.Image)
        Me.bAgregarA.Location = New System.Drawing.Point(703, 21)
        Me.bAgregarA.Name = "bAgregarA"
        Me.bAgregarA.Size = New System.Drawing.Size(79, 27)
        Me.bAgregarA.TabIndex = 3
        Me.bAgregarA.Text = "Cargar"
        Me.bAgregarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregarA.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(136, 23)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.Size = New System.Drawing.Size(476, 22)
        Me.xDescripcion.TabIndex = 1
        '
        'xTablaArticulos
        '
        Me.xTablaArticulos.AllowEditing = False
        Me.xTablaArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTablaArticulos.ColumnInfo = resources.GetString("xTablaArticulos.ColumnInfo")
        Me.xTablaArticulos.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xTablaArticulos.Location = New System.Drawing.Point(9, 52)
        Me.xTablaArticulos.Name = "xTablaArticulos"
        Me.xTablaArticulos.Rows.Count = 1
        Me.xTablaArticulos.Rows.DefaultSize = 19
        Me.xTablaArticulos.Size = New System.Drawing.Size(1054, 95)
        Me.xTablaArticulos.StyleInfo = resources.GetString("xTablaArticulos.StyleInfo")
        Me.xTablaArticulos.TabIndex = 105
        Me.xTablaArticulos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(12, 652)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 0
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bBuscarOT
        '
        Me.bBuscarOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bBuscarOT.BackColor = System.Drawing.Color.White
        Me.bBuscarOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarOT.Image = CType(resources.GetObject("bBuscarOT.Image"), System.Drawing.Image)
        Me.bBuscarOT.Location = New System.Drawing.Point(118, 652)
        Me.bBuscarOT.Name = "bBuscarOT"
        Me.bBuscarOT.Size = New System.Drawing.Size(116, 36)
        Me.bBuscarOT.TabIndex = 8
        Me.bBuscarOT.Text = "Consultar OT"
        Me.bBuscarOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarOT.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(770, 652)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 9
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(876, 652)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 10
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(982, 652)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 11
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
        Me.Label14.Location = New System.Drawing.Point(12, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(613, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Datos Principales"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.xProductoR)
        Me.GroupBox2.Controls.Add(Me.xCodigoR)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dFechaEntrega)
        Me.GroupBox2.Controls.Add(Me.bConsultarP)
        Me.GroupBox2.Location = New System.Drawing.Point(631, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 146)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(631, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(451, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Producto a Recepcionar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(12, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1070, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Servicios a Realizar"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(12, 378)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1070, 16)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Artículos Utilizados"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cPlantilla
        '
        Me.cPlantilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPlantilla.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cPlantilla.FormattingEnabled = True
        Me.cPlantilla.Location = New System.Drawing.Point(640, 536)
        Me.cPlantilla.Name = "cPlantilla"
        Me.cPlantilla.Size = New System.Drawing.Size(350, 24)
        Me.cPlantilla.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(573, 540)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Plantilla"
        '
        'bAgregarPlantilla
        '
        Me.bAgregarPlantilla.BackColor = System.Drawing.Color.White
        Me.bAgregarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarPlantilla.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAgregarPlantilla.Image = CType(resources.GetObject("bAgregarPlantilla.Image"), System.Drawing.Image)
        Me.bAgregarPlantilla.Location = New System.Drawing.Point(996, 535)
        Me.bAgregarPlantilla.Name = "bAgregarPlantilla"
        Me.bAgregarPlantilla.Size = New System.Drawing.Size(79, 27)
        Me.bAgregarPlantilla.TabIndex = 19
        Me.bAgregarPlantilla.Text = "Cargar"
        Me.bAgregarPlantilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregarPlantilla.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(1093, 50)
        Me.WinDeco1.TabIndex = 133
        Me.WinDeco1.TituloVentana = "Ingreso de OT"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'tObservacion
        '
        Me.tObservacion.Controls.Add(Me.TabPage1)
        Me.tObservacion.Controls.Add(Me.TabPage2)
        Me.tObservacion.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tObservacion.HotTrack = True
        Me.tObservacion.ItemSize = New System.Drawing.Size(0, 26)
        Me.tObservacion.Location = New System.Drawing.Point(12, 533)
        Me.tObservacion.Name = "tObservacion"
        Vs2010TabControlRenderer1.ColorTable = Vs2010DefaultTabControlColorTable1
        Me.tObservacion.Renderer = Vs2010TabControlRenderer1
        Me.tObservacion.SelectedIndex = 0
        Me.tObservacion.Size = New System.Drawing.Size(1069, 100)
        Me.tObservacion.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.xObsCliente)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1061, 66)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Observación del Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'xObsCliente
        '
        Me.xObsCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xObsCliente.Enabled = False
        Me.xObsCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xObsCliente.Location = New System.Drawing.Point(3, 3)
        Me.xObsCliente.Multiline = True
        Me.xObsCliente.Name = "xObsCliente"
        Me.xObsCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.xObsCliente.Size = New System.Drawing.Size(1055, 60)
        Me.xObsCliente.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.xObsTecnico)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1061, 66)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Observacioón del Técnico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'xObsTecnico
        '
        Me.xObsTecnico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xObsTecnico.Enabled = False
        Me.xObsTecnico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xObsTecnico.Location = New System.Drawing.Point(3, 3)
        Me.xObsTecnico.Multiline = True
        Me.xObsTecnico.Name = "xObsTecnico"
        Me.xObsTecnico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.xObsTecnico.Size = New System.Drawing.Size(1055, 60)
        Me.xObsTecnico.TabIndex = 0
        '
        'IngresoOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 700)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bAgregarPlantilla)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cPlantilla)
        Me.Controls.Add(Me.tObservacion)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.xTotalOT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bBuscarOT)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gServicio)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "IngresoOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de OT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gServicio.ResumeLayout(False)
        Me.gServicio.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.xTablaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tObservacion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dFechaEntrega As DateTimePicker
    Friend WithEvents xOT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xTotalOT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xNombreTecnico As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dFecha As DateTimePicker
    Friend WithEvents xEstado As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents bNuevo As Button
    Public WithEvents bCrear As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents gServicio As GroupBox
    Friend WithEvents xNombreServicio As TextBox
    Public WithEvents bAgregar As Button
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents xTablaArticulos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents xObsTecnico As TextBox
    Public WithEvents bLimpiar As Button
    Public WithEvents bBuscarOT As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bGuardar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bAgregarA As Button
    Public WithEvents bConsultarP As Button
    Public WithEvents xCodigoR As TextBox
    Public WithEvents xProductoR As TextBox
    
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tObservacion As Controls.Vs2010TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents xObsCliente As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cPlantilla As ComboBox
    Friend WithEvents Label11 As Label
    Public WithEvents bAgregarPlantilla As Button
    Friend WithEvents xCliente As TextBoxAutoComple
    Friend WithEvents bBuscarC As SearchButton
    Friend WithEvents xTecnico As TextBoxAutoComple
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents bBuscarServicio As Button
    Friend WithEvents bBuscarArticulo As Button
    Friend WithEvents xServicio As TextBoxAutoComple
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents xEmail As TextBox
    Friend WithEvents Label12 As Label
End Class
