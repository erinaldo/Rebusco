<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaLocal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaLocal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xCliente = New Rebusco.TextBoxAutoComple()
        Me.xFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bBuscarC = New Rebusco.SearchButton()
        Me.xRut = New System.Windows.Forms.MaskedTextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.xUsuario = New Rebusco.TextBoxAutoComple()
        Me.bEditarCliente = New System.Windows.Forms.Button()
        Me.bCrearCliente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cVendedor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xBoleta = New System.Windows.Forms.TextBox()
        Me.xNumDocRef = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bBonos = New System.Windows.Forms.Button()
        Me.bUsarABonos = New System.Windows.Forms.Button()
        Me.xAbonosCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gArticulo = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.oAuto = New System.Windows.Forms.CheckBox()
        Me.bBuscarArticulo = New System.Windows.Forms.Button()
        Me.gCargarDocumento = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bImprimirOT = New System.Windows.Forms.Button()
        Me.bCargar = New System.Windows.Forms.Button()
        Me.bCancelarCarga = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cDocumentoCargar = New System.Windows.Forms.ComboBox()
        Me.bBuscarOT = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.xCantidad = New System.Windows.Forms.TextBox()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lSaldo = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.xSaldo = New System.Windows.Forms.TextBox()
        Me.xNeto = New System.Windows.Forms.TextBox()
        Me.xAbonado = New System.Windows.Forms.TextBox()
        Me.xPagoCliente = New System.Windows.Forms.TextBox()
        Me.xSubTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.xDescuento = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xIVA = New System.Windows.Forms.TextBox()
        Me.xLineas = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.xPOS = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lLocal = New System.Windows.Forms.Label()
        Me.lBodega = New System.Windows.Forms.Label()
        Me.bCargarDocumento = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bGenerarDescuento = New System.Windows.Forms.Button()
        Me.bCuadraturaCaja = New System.Windows.Forms.Button()
        Me.bCambiarCorrelativo = New System.Windows.Forms.Button()
        Me.bConsultarBoleta = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bEmitir = New System.Windows.Forms.Button()
        Me.xToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gArticulo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gCargarDocumento.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.xFecha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.bBuscarC)
        Me.GroupBox1.Controls.Add(Me.xUsuario)
        Me.GroupBox1.Controls.Add(Me.bEditarCliente)
        Me.GroupBox1.Controls.Add(Me.bCrearCliente)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.xRut)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cVendedor)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        Me.xCliente.IntervaloBusquedaTexto = 3
        Me.xCliente.Location = New System.Drawing.Point(178, 51)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(100, 22)
        Me.xCliente.TabIndex = 333
        Me.xCliente.TablaBusqueda = "ClientesBusqueda"
        Me.xCliente.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'xFecha
        '
        Me.xFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xFecha.Location = New System.Drawing.Point(593, 21)
        Me.xFecha.Name = "xFecha"
        Me.xFecha.Size = New System.Drawing.Size(99, 22)
        Me.xFecha.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, -1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(698, 18)
        Me.Label8.TabIndex = 332
        Me.Label8.Text = "Datos Principales"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bBuscarC
        '
        Me.bBuscarC.CampoBuscar1 = "Nombre"
        Me.bBuscarC.CampoBuscar2 = ""
        Me.bBuscarC.CamposAdicionales = ""
        Me.bBuscarC.ControlCarga = Me.xRut
        Me.bBuscarC.ControlFocus = Me.xNombre
        Me.bBuscarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscarC.Filtro = ""
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarC.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarC.IDBusqueda = "Rut"
        Me.bBuscarC.Image = CType(resources.GetObject("bBuscarC.Image"), System.Drawing.Image)
        Me.bBuscarC.Location = New System.Drawing.Point(597, 49)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(28, 27)
        Me.bBuscarC.TabIndex = 331
        Me.bBuscarC.TablaBusqueda = "Clientes"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.Titulo = "Clientes"
        Me.xToolTip.SetToolTip(Me.bBuscarC, "Buscar cliente")
        Me.bBuscarC.UseVisualStyleBackColor = True
        '
        'xRut
        '
        Me.xRut.BackColor = System.Drawing.Color.White
        Me.xRut.Culture = New System.Globalization.CultureInfo("en-US")
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xRut.Location = New System.Drawing.Point(83, 50)
        Me.xRut.Mask = "##.###.###-A"
        Me.xRut.Name = "xRut"
        Me.xRut.Size = New System.Drawing.Size(89, 22)
        Me.xRut.TabIndex = 2
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNombre.Location = New System.Drawing.Point(284, 51)
        Me.xNombre.MaxLength = 50
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(306, 22)
        Me.xNombre.TabIndex = 131
        '
        'xUsuario
        '
        Me.xUsuario.AnchoLista = 350
        Me.xUsuario.AutoCompletarActivo = True
        Me.xUsuario.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xUsuario.DescBusqueda = "NombreUsr"
        Me.xUsuario.DescBusquedaAdicional = ""
        Me.xUsuario.DescBusquedaAdicional2 = ""
        Me.xUsuario.Filtro = ""
        Me.xUsuario.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xUsuario.IDBusqueda = "Usuario"
        Me.xUsuario.IntervaloBusquedaNumeros = 1
        Me.xUsuario.IntervaloBusquedaTexto = 3
        Me.xUsuario.Location = New System.Drawing.Point(83, 21)
        Me.xUsuario.Name = "xUsuario"
        Me.xUsuario.Size = New System.Drawing.Size(89, 23)
        Me.xUsuario.TabIndex = 0
        Me.xUsuario.TablaBusqueda = "Usuarios"
        Me.xUsuario.TextFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bEditarCliente
        '
        Me.bEditarCliente.BackColor = System.Drawing.Color.White
        Me.bEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEditarCliente.Enabled = False
        Me.bEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditarCliente.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditarCliente.Image = Global.Rebusco.My.Resources.Resources.user16
        Me.bEditarCliente.Location = New System.Drawing.Point(664, 49)
        Me.bEditarCliente.Name = "bEditarCliente"
        Me.bEditarCliente.Size = New System.Drawing.Size(28, 27)
        Me.bEditarCliente.TabIndex = 328
        Me.bEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bEditarCliente, "Editar cliente")
        Me.bEditarCliente.UseVisualStyleBackColor = False
        '
        'bCrearCliente
        '
        Me.bCrearCliente.BackColor = System.Drawing.Color.White
        Me.bCrearCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrearCliente.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCrearCliente.Image = Global.Rebusco.My.Resources.Resources._new
        Me.bCrearCliente.Location = New System.Drawing.Point(631, 49)
        Me.bCrearCliente.Name = "bCrearCliente"
        Me.bCrearCliente.Size = New System.Drawing.Size(28, 27)
        Me.bCrearCliente.TabIndex = 328
        Me.bCrearCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bCrearCliente, "Nuevo cliente")
        Me.bCrearCliente.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(7, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Cliente"
        '
        'cVendedor
        '
        Me.cVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cVendedor.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cVendedor.FormattingEnabled = True
        Me.cVendedor.Location = New System.Drawing.Point(178, 21)
        Me.cVendedor.Name = "cVendedor"
        Me.cVendedor.Size = New System.Drawing.Size(359, 24)
        Me.cVendedor.TabIndex = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(7, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Vendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(550, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Fecha"
        '
        'xBoleta
        '
        Me.xBoleta.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.xBoleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xBoleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xBoleta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xBoleta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xBoleta.Location = New System.Drawing.Point(775, 74)
        Me.xBoleta.MaxLength = 18
        Me.xBoleta.Name = "xBoleta"
        Me.xBoleta.ReadOnly = True
        Me.xBoleta.Size = New System.Drawing.Size(109, 21)
        Me.xBoleta.TabIndex = 132
        Me.xBoleta.TabStop = False
        Me.xBoleta.Text = "0"
        Me.xBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'xNumDocRef
        '
        Me.xNumDocRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xNumDocRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumDocRef.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xNumDocRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xNumDocRef.Location = New System.Drawing.Point(118, 76)
        Me.xNumDocRef.MaxLength = 18
        Me.xNumDocRef.Name = "xNumDocRef"
        Me.xNumDocRef.Size = New System.Drawing.Size(120, 22)
        Me.xNumDocRef.TabIndex = 0
        Me.xNumDocRef.TabStop = False
        Me.xNumDocRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(10, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Documento"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bBonos)
        Me.GroupBox2.Controls.Add(Me.bUsarABonos)
        Me.GroupBox2.Controls.Add(Me.xAbonosCli)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(716, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 116)
        Me.GroupBox2.TabIndex = 239
        Me.GroupBox2.TabStop = False
        '
        'bBonos
        '
        Me.bBonos.BackColor = System.Drawing.Color.White
        Me.bBonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBonos.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBonos.Image = Global.Rebusco.My.Resources.Resources.abonos16
        Me.bBonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBonos.Location = New System.Drawing.Point(6, 47)
        Me.bBonos.Name = "bBonos"
        Me.bBonos.Size = New System.Drawing.Size(156, 28)
        Me.bBonos.TabIndex = 138
        Me.bBonos.Text = " Módulo Abonos"
        Me.bBonos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBonos.UseVisualStyleBackColor = False
        '
        'bUsarABonos
        '
        Me.bUsarABonos.BackColor = System.Drawing.Color.White
        Me.bUsarABonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUsarABonos.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bUsarABonos.Image = Global.Rebusco.My.Resources.Resources.abonos16b
        Me.bUsarABonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bUsarABonos.Location = New System.Drawing.Point(6, 81)
        Me.bUsarABonos.Name = "bUsarABonos"
        Me.bUsarABonos.Size = New System.Drawing.Size(156, 28)
        Me.bUsarABonos.TabIndex = 139
        Me.bUsarABonos.Text = " Usar Abonos"
        Me.bUsarABonos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bUsarABonos.UseVisualStyleBackColor = False
        '
        'xAbonosCli
        '
        Me.xAbonosCli.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xAbonosCli.Location = New System.Drawing.Point(6, 21)
        Me.xAbonosCli.MaxLength = 18
        Me.xAbonosCli.Name = "xAbonosCli"
        Me.xAbonosCli.Size = New System.Drawing.Size(156, 22)
        Me.xAbonosCli.TabIndex = 137
        Me.xAbonosCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 18)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Abonos Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gArticulo
        '
        Me.gArticulo.BackColor = System.Drawing.Color.Transparent
        Me.gArticulo.Controls.Add(Me.Panel3)
        Me.gArticulo.Controls.Add(Me.oAuto)
        Me.gArticulo.Controls.Add(Me.bBuscarArticulo)
        Me.gArticulo.Controls.Add(Me.gCargarDocumento)
        Me.gArticulo.Controls.Add(Me.Label3)
        Me.gArticulo.Controls.Add(Me.xArticulo)
        Me.gArticulo.Controls.Add(Me.xCantidad)
        Me.gArticulo.Controls.Add(Me.bAgregar)
        Me.gArticulo.Controls.Add(Me.xDescripcion)
        Me.gArticulo.Controls.Add(Me.xTabla)
        Me.gArticulo.Location = New System.Drawing.Point(12, 221)
        Me.gArticulo.Name = "gArticulo"
        Me.gArticulo.Size = New System.Drawing.Size(872, 392)
        Me.gArticulo.TabIndex = 1
        Me.gArticulo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(5, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(60, 22)
        Me.Panel3.TabIndex = 337
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(2, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 269
        Me.Label11.Text = "Artículo"
        '
        'oAuto
        '
        Me.oAuto.AutoSize = True
        Me.oAuto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oAuto.Checked = True
        Me.oAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oAuto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oAuto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oAuto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.oAuto.Location = New System.Drawing.Point(669, 1)
        Me.oAuto.Name = "oAuto"
        Me.oAuto.Size = New System.Drawing.Size(194, 17)
        Me.oAuto.TabIndex = 336
        Me.oAuto.Text = "Ingreso Automático de Artículos"
        Me.oAuto.UseVisualStyleBackColor = False
        '
        'bBuscarArticulo
        '
        Me.bBuscarArticulo.BackColor = System.Drawing.Color.White
        Me.bBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarArticulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarArticulo.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarArticulo.Location = New System.Drawing.Point(831, 27)
        Me.bBuscarArticulo.Name = "bBuscarArticulo"
        Me.bBuscarArticulo.Size = New System.Drawing.Size(30, 28)
        Me.bBuscarArticulo.TabIndex = 335
        Me.bBuscarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bBuscarArticulo, "Buscar artículo")
        Me.bBuscarArticulo.UseVisualStyleBackColor = False
        '
        'gCargarDocumento
        '
        Me.gCargarDocumento.BackColor = System.Drawing.Color.White
        Me.gCargarDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gCargarDocumento.Controls.Add(Me.Panel2)
        Me.gCargarDocumento.Controls.Add(Me.Label35)
        Me.gCargarDocumento.Controls.Add(Me.Label34)
        Me.gCargarDocumento.Controls.Add(Me.Label7)
        Me.gCargarDocumento.Controls.Add(Me.cDocumentoCargar)
        Me.gCargarDocumento.Controls.Add(Me.xNumDocRef)
        Me.gCargarDocumento.Controls.Add(Me.bBuscarOT)
        Me.gCargarDocumento.Location = New System.Drawing.Point(497, 211)
        Me.gCargarDocumento.Name = "gCargarDocumento"
        Me.gCargarDocumento.Size = New System.Drawing.Size(343, 153)
        Me.gCargarDocumento.TabIndex = 334
        Me.gCargarDocumento.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.bImprimirOT)
        Me.Panel2.Controls.Add(Me.bCargar)
        Me.Panel2.Controls.Add(Me.bCancelarCarga)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 45)
        Me.Panel2.TabIndex = 335
        '
        'bImprimirOT
        '
        Me.bImprimirOT.BackColor = System.Drawing.Color.White
        Me.bImprimirOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimirOT.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bImprimirOT.Image = Global.Rebusco.My.Resources.Resources.print
        Me.bImprimirOT.Location = New System.Drawing.Point(58, 10)
        Me.bImprimirOT.Name = "bImprimirOT"
        Me.bImprimirOT.Size = New System.Drawing.Size(87, 28)
        Me.bImprimirOT.TabIndex = 3
        Me.bImprimirOT.Text = "Imprimir"
        Me.bImprimirOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimirOT.UseVisualStyleBackColor = False
        '
        'bCargar
        '
        Me.bCargar.BackColor = System.Drawing.Color.White
        Me.bCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCargar.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bCargar.Location = New System.Drawing.Point(151, 10)
        Me.bCargar.Name = "bCargar"
        Me.bCargar.Size = New System.Drawing.Size(87, 28)
        Me.bCargar.TabIndex = 2
        Me.bCargar.Text = "Cargar"
        Me.bCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCargar.UseVisualStyleBackColor = False
        '
        'bCancelarCarga
        '
        Me.bCancelarCarga.BackColor = System.Drawing.Color.White
        Me.bCancelarCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelarCarga.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCancelarCarga.Image = Global.Rebusco.My.Resources.Resources.cancel
        Me.bCancelarCarga.Location = New System.Drawing.Point(244, 9)
        Me.bCancelarCarga.Name = "bCancelarCarga"
        Me.bCancelarCarga.Size = New System.Drawing.Size(87, 28)
        Me.bCancelarCarga.TabIndex = 333
        Me.bCancelarCarga.Text = "Cancelar"
        Me.bCancelarCarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelarCarga.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label35.Location = New System.Drawing.Point(10, 46)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(102, 16)
        Me.Label35.TabIndex = 334
        Me.Label35.Text = "Tipo Documento"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(341, 35)
        Me.Label34.TabIndex = 332
        Me.Label34.Text = "Cargar Documento"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cDocumentoCargar
        '
        Me.cDocumentoCargar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDocumentoCargar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cDocumentoCargar.FormattingEnabled = True
        Me.cDocumentoCargar.Location = New System.Drawing.Point(118, 43)
        Me.cDocumentoCargar.Name = "cDocumentoCargar"
        Me.cDocumentoCargar.Size = New System.Drawing.Size(213, 24)
        Me.cDocumentoCargar.TabIndex = 1
        '
        'bBuscarOT
        '
        Me.bBuscarOT.BackColor = System.Drawing.Color.White
        Me.bBuscarOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarOT.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarOT.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarOT.Location = New System.Drawing.Point(244, 73)
        Me.bBuscarOT.Name = "bBuscarOT"
        Me.bBuscarOT.Size = New System.Drawing.Size(87, 28)
        Me.bBuscarOT.TabIndex = 4
        Me.bBuscarOT.Text = "Buscar"
        Me.bBuscarOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarOT.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(872, 18)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Detalle de Artículos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.xArticulo.Location = New System.Drawing.Point(65, 30)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(116, 22)
        Me.xArticulo.TabIndex = 0
        Me.xArticulo.TablaBusqueda = "BuscadorAutocompletar"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'xCantidad
        '
        Me.xCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xCantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.xCantidad.Location = New System.Drawing.Point(666, 30)
        Me.xCantidad.MaxLength = 4
        Me.xCantidad.Name = "xCantidad"
        Me.xCantidad.Size = New System.Drawing.Size(74, 22)
        Me.xCantidad.TabIndex = 2
        Me.xCantidad.TabStop = False
        Me.xCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bAgregar
        '
        Me.bAgregar.BackColor = System.Drawing.Color.White
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bAgregar.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bAgregar.Location = New System.Drawing.Point(746, 27)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(79, 28)
        Me.bAgregar.TabIndex = 3
        Me.bAgregar.Text = "Agregar"
        Me.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bAgregar, "Agregar artículo")
        Me.bAgregar.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(187, 30)
        Me.xDescripcion.MaxLength = 18
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.Size = New System.Drawing.Size(473, 22)
        Me.xDescripcion.TabIndex = 1
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.xTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(5, 61)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.Size = New System.Drawing.Size(861, 322)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 246
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cTipoDoc)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.cFormaPago)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(698, 70)
        Me.GroupBox4.TabIndex = 249
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(698, 18)
        Me.Label6.TabIndex = 266
        Me.Label6.Text = "Forma de Pago"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(408, 28)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(213, 29)
        Me.cTipoDoc.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(328, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 264
        Me.Label14.Text = "Documento"
        '
        'cFormaPago
        '
        Me.cFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFormaPago.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cFormaPago.FormattingEnabled = True
        Me.cFormaPago.Location = New System.Drawing.Point(109, 27)
        Me.cFormaPago.Name = "cFormaPago"
        Me.cFormaPago.Size = New System.Drawing.Size(213, 29)
        Me.cFormaPago.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(6, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 16)
        Me.Label13.TabIndex = 262
        Me.Label13.Text = "Forma de Pago"
        '
        'lSaldo
        '
        Me.lSaldo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lSaldo.AutoSize = True
        Me.lSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lSaldo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lSaldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lSaldo.Location = New System.Drawing.Point(6, 212)
        Me.lSaldo.Name = "lSaldo"
        Me.lSaldo.Size = New System.Drawing.Size(45, 16)
        Me.lSaldo.TabIndex = 250
        Me.lSaldo.Text = "Saldo"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(6, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 16)
        Me.Label24.TabIndex = 252
        Me.Label24.Text = "Neto"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(4, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 16)
        Me.Label22.TabIndex = 254
        Me.Label22.Text = "Abono"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(4, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 16)
        Me.Label21.TabIndex = 255
        Me.Label21.Text = "Sub-Total"
        '
        'xSaldo
        '
        Me.xSaldo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xSaldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSaldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.xSaldo.Location = New System.Drawing.Point(107, 208)
        Me.xSaldo.Name = "xSaldo"
        Me.xSaldo.ReadOnly = True
        Me.xSaldo.Size = New System.Drawing.Size(123, 26)
        Me.xSaldo.TabIndex = 261
        Me.xSaldo.Text = "0"
        Me.xSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xNeto
        '
        Me.xNeto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xNeto.BackColor = System.Drawing.Color.White
        Me.xNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNeto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xNeto.Location = New System.Drawing.Point(107, 14)
        Me.xNeto.Name = "xNeto"
        Me.xNeto.ReadOnly = True
        Me.xNeto.Size = New System.Drawing.Size(123, 22)
        Me.xNeto.TabIndex = 259
        Me.xNeto.Text = "0"
        Me.xNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xAbonado
        '
        Me.xAbonado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xAbonado.BackColor = System.Drawing.Color.White
        Me.xAbonado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xAbonado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xAbonado.Location = New System.Drawing.Point(107, 86)
        Me.xAbonado.Name = "xAbonado"
        Me.xAbonado.ReadOnly = True
        Me.xAbonado.Size = New System.Drawing.Size(123, 22)
        Me.xAbonado.TabIndex = 257
        Me.xAbonado.Text = "0"
        Me.xAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xPagoCliente
        '
        Me.xPagoCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xPagoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xPagoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xPagoCliente.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xPagoCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xPagoCliente.Location = New System.Drawing.Point(107, 167)
        Me.xPagoCliente.Name = "xPagoCliente"
        Me.xPagoCliente.Size = New System.Drawing.Size(123, 35)
        Me.xPagoCliente.TabIndex = 260
        Me.xPagoCliente.Text = "0"
        Me.xPagoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xSubTotal
        '
        Me.xSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.xSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xSubTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xSubTotal.Location = New System.Drawing.Point(107, 56)
        Me.xSubTotal.Name = "xSubTotal"
        Me.xSubTotal.ReadOnly = True
        Me.xSubTotal.Size = New System.Drawing.Size(123, 22)
        Me.xSubTotal.TabIndex = 256
        Me.xSubTotal.Text = "0"
        Me.xSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.xTotal)
        Me.GroupBox5.Controls.Add(Me.xDescuento)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.xPagoCliente)
        Me.GroupBox5.Controls.Add(Me.xIVA)
        Me.GroupBox5.Controls.Add(Me.xSubTotal)
        Me.GroupBox5.Controls.Add(Me.lSaldo)
        Me.GroupBox5.Controls.Add(Me.xAbonado)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.xNeto)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.xSaldo)
        Me.GroupBox5.Location = New System.Drawing.Point(890, 380)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(236, 239)
        Me.GroupBox5.TabIndex = 262
        Me.GroupBox5.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 35)
        Me.Panel1.TabIndex = 277
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Monto Pagar"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(6, 181)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 16)
        Me.Label25.TabIndex = 269
        Me.Label25.Text = "Monto Pago"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(4, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 268
        Me.Label15.Text = "Total a Pagar"
        '
        'xTotal
        '
        Me.xTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotal.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(107, 136)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(123, 32)
        Me.xTotal.TabIndex = 267
        Me.xTotal.TabStop = False
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDescuento
        '
        Me.xDescuento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.xDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescuento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xDescuento.Location = New System.Drawing.Point(107, 107)
        Me.xDescuento.Name = "xDescuento"
        Me.xDescuento.ReadOnly = True
        Me.xDescuento.Size = New System.Drawing.Size(123, 22)
        Me.xDescuento.TabIndex = 266
        Me.xDescuento.Text = "0"
        Me.xDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(4, 109)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 16)
        Me.Label23.TabIndex = 265
        Me.Label23.Text = "Descuento"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 264
        Me.Label12.Text = "Impuesto"
        '
        'xIVA
        '
        Me.xIVA.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.xIVA.BackColor = System.Drawing.Color.White
        Me.xIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xIVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xIVA.Location = New System.Drawing.Point(107, 35)
        Me.xIVA.Name = "xIVA"
        Me.xIVA.ReadOnly = True
        Me.xIVA.Size = New System.Drawing.Size(123, 22)
        Me.xIVA.TabIndex = 263
        Me.xIVA.Text = "0"
        Me.xIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xLineas
        '
        Me.xLineas.BackColor = System.Drawing.Color.White
        Me.xLineas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xLineas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xLineas.Location = New System.Drawing.Point(990, 357)
        Me.xLineas.MaxLength = 18
        Me.xLineas.Name = "xLineas"
        Me.xLineas.ReadOnly = True
        Me.xLineas.Size = New System.Drawing.Size(130, 26)
        Me.xLineas.TabIndex = 268
        Me.xLineas.TabStop = False
        Me.xLineas.Text = "0"
        Me.xLineas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Location = New System.Drawing.Point(890, 55)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(236, 282)
        Me.GroupBox6.TabIndex = 265
        Me.GroupBox6.TabStop = False
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(6, 255)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(222, 23)
        Me.Label31.TabIndex = 279
        Me.Label31.Text = "  F10   Emitir Boleta"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(6, 177)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(222, 23)
        Me.Label30.TabIndex = 278
        Me.Label30.Text = "  F7   Pagar Total"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(6, 203)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(222, 23)
        Me.Label29.TabIndex = 277
        Me.Label29.Text = "  F8   Buscar Artículo"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(6, 151)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(222, 23)
        Me.Label27.TabIndex = 275
        Me.Label27.Text = "  F6   Eliminar último Artículo"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(6, 229)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(222, 23)
        Me.Label28.TabIndex = 276
        Me.Label28.Text = "  F9   Monto a pagar"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(6, 125)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(222, 23)
        Me.Label20.TabIndex = 274
        Me.Label20.Text = "  F5   Repetir último Artículo"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 23)
        Me.Label16.TabIndex = 270
        Me.Label16.Text = "  F1   Forma de Pago"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(6, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(222, 23)
        Me.Label18.TabIndex = 272
        Me.Label18.Text = "  F2   Artículo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(6, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(222, 23)
        Me.Label19.TabIndex = 273
        Me.Label19.Text = "  F4   Limpiar Venta"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(6, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(222, 23)
        Me.Label17.TabIndex = 271
        Me.Label17.Text = "  F3   Documento"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(890, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 18)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "Comandos Rápidos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(990, 338)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(130, 18)
        Me.Label32.TabIndex = 271
        Me.Label32.Text = "Artículos"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(716, 55)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 18)
        Me.Label33.TabIndex = 273
        Me.Label33.Text = "POS"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tiempo
        '
        '
        'xPOS
        '
        Me.xPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.xPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xPOS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xPOS.ForeColor = System.Drawing.Color.Black
        Me.xPOS.Location = New System.Drawing.Point(716, 74)
        Me.xPOS.MaxLength = 18
        Me.xPOS.Name = "xPOS"
        Me.xPOS.ReadOnly = True
        Me.xPOS.Size = New System.Drawing.Size(53, 21)
        Me.xPOS.TabIndex = 275
        Me.xPOS.TabStop = False
        Me.xPOS.Text = "0"
        Me.xPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(775, 55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 18)
        Me.Label26.TabIndex = 276
        Me.Label26.Text = "Número Boleta"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lLocal
        '
        Me.lLocal.AutoSize = True
        Me.lLocal.BackColor = System.Drawing.Color.Transparent
        Me.lLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lLocal.Location = New System.Drawing.Point(658, 637)
        Me.lLocal.Name = "lLocal"
        Me.lLocal.Size = New System.Drawing.Size(38, 13)
        Me.lLocal.TabIndex = 334
        Me.lLocal.Text = "Local"
        '
        'lBodega
        '
        Me.lBodega.AutoSize = True
        Me.lBodega.BackColor = System.Drawing.Color.Transparent
        Me.lBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBodega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lBodega.Location = New System.Drawing.Point(658, 660)
        Me.lBodega.Name = "lBodega"
        Me.lBodega.Size = New System.Drawing.Size(50, 13)
        Me.lBodega.TabIndex = 335
        Me.lBodega.Text = "Bodega"
        '
        'bCargarDocumento
        '
        Me.bCargarDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCargarDocumento.BackColor = System.Drawing.Color.White
        Me.bCargarDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCargarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargarDocumento.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCargarDocumento.Image = Global.Rebusco.My.Resources.Resources.load24
        Me.bCargarDocumento.Location = New System.Drawing.Point(427, 637)
        Me.bCargarDocumento.Name = "bCargarDocumento"
        Me.bCargarDocumento.Size = New System.Drawing.Size(161, 36)
        Me.bCargarDocumento.TabIndex = 333
        Me.bCargarDocumento.Text = " Cargar Documento"
        Me.bCargarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bCargarDocumento, "Cargar documento de referencia")
        Me.bCargarDocumento.UseVisualStyleBackColor = False
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
        Me.WinDeco1.TabIndex = 332
        Me.WinDeco1.TituloVentana = "Venta Local"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bGenerarDescuento
        '
        Me.bGenerarDescuento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bGenerarDescuento.BackColor = System.Drawing.Color.White
        Me.bGenerarDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bGenerarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGenerarDescuento.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bGenerarDescuento.Image = Global.Rebusco.My.Resources.Resources.descuento24
        Me.bGenerarDescuento.Location = New System.Drawing.Point(305, 637)
        Me.bGenerarDescuento.Name = "bGenerarDescuento"
        Me.bGenerarDescuento.Size = New System.Drawing.Size(116, 36)
        Me.bGenerarDescuento.TabIndex = 6
        Me.bGenerarDescuento.Text = " Descuento"
        Me.bGenerarDescuento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bGenerarDescuento, "Aplicar descuentos vigentes")
        Me.bGenerarDescuento.UseVisualStyleBackColor = False
        '
        'bCuadraturaCaja
        '
        Me.bCuadraturaCaja.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCuadraturaCaja.BackColor = System.Drawing.Color.White
        Me.bCuadraturaCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCuadraturaCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCuadraturaCaja.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCuadraturaCaja.Image = Global.Rebusco.My.Resources.Resources.calc_ok24
        Me.bCuadraturaCaja.Location = New System.Drawing.Point(121, 637)
        Me.bCuadraturaCaja.Name = "bCuadraturaCaja"
        Me.bCuadraturaCaja.Size = New System.Drawing.Size(178, 36)
        Me.bCuadraturaCaja.TabIndex = 5
        Me.bCuadraturaCaja.Text = "Cuadratura de Caja"
        Me.bCuadraturaCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bCuadraturaCaja, "Abrir cuadratura de caja")
        Me.bCuadraturaCaja.UseVisualStyleBackColor = False
        '
        'bCambiarCorrelativo
        '
        Me.bCambiarCorrelativo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCambiarCorrelativo.BackColor = System.Drawing.Color.White
        Me.bCambiarCorrelativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCambiarCorrelativo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCambiarCorrelativo.Image = Global.Rebusco.My.Resources.Resources.refresh_update24
        Me.bCambiarCorrelativo.Location = New System.Drawing.Point(617, 637)
        Me.bCambiarCorrelativo.Name = "bCambiarCorrelativo"
        Me.bCambiarCorrelativo.Size = New System.Drawing.Size(19, 36)
        Me.bCambiarCorrelativo.TabIndex = 4
        Me.bCambiarCorrelativo.Text = "Cambio de Correlativo"
        Me.bCambiarCorrelativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCambiarCorrelativo.UseVisualStyleBackColor = False
        Me.bCambiarCorrelativo.Visible = False
        '
        'bConsultarBoleta
        '
        Me.bConsultarBoleta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bConsultarBoleta.BackColor = System.Drawing.Color.White
        Me.bConsultarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultarBoleta.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bConsultarBoleta.Image = Global.Rebusco.My.Resources.Resources.invoice_find24
        Me.bConsultarBoleta.Location = New System.Drawing.Point(594, 637)
        Me.bConsultarBoleta.Name = "bConsultarBoleta"
        Me.bConsultarBoleta.Size = New System.Drawing.Size(17, 36)
        Me.bConsultarBoleta.TabIndex = 3
        Me.bConsultarBoleta.Text = "Consulta de Boleta"
        Me.bConsultarBoleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultarBoleta.UseVisualStyleBackColor = False
        Me.bConsultarBoleta.Visible = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 637)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 2
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bEmitir
        '
        Me.bEmitir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bEmitir.BackColor = System.Drawing.Color.White
        Me.bEmitir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEmitir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bEmitir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bEmitir.Location = New System.Drawing.Point(931, 637)
        Me.bEmitir.Name = "bEmitir"
        Me.bEmitir.Size = New System.Drawing.Size(195, 36)
        Me.bEmitir.TabIndex = 7
        Me.bEmitir.Text = " Emitir Documento (F10)"
        Me.bEmitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xToolTip.SetToolTip(Me.bEmitir, "Crear documento tributario")
        Me.bEmitir.UseVisualStyleBackColor = False
        '
        'xToolTip
        '
        Me.xToolTip.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xToolTip.ForeColor = System.Drawing.Color.White
        '
        'VentaLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 685)
        Me.Controls.Add(Me.lBodega)
        Me.Controls.Add(Me.lLocal)
        Me.Controls.Add(Me.bCargarDocumento)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.xPOS)
        Me.Controls.Add(Me.bGenerarDescuento)
        Me.Controls.Add(Me.xLineas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.xBoleta)
        Me.Controls.Add(Me.bCuadraturaCaja)
        Me.Controls.Add(Me.bCambiarCorrelativo)
        Me.Controls.Add(Me.bConsultarBoleta)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bEmitir)
        Me.Controls.Add(Me.gArticulo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "VentaLocal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta Local"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gArticulo.ResumeLayout(False)
        Me.gArticulo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gCargarDocumento.ResumeLayout(False)
        Me.gCargarDocumento.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xFecha As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cVendedor As ComboBox
    Friend WithEvents xNumDocRef As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xBoleta As TextBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xRut As MaskedTextBox
    Friend WithEvents Label4 As Label
    Public WithEvents bCargar As Button
    Public WithEvents bImprimirOT As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xAbonosCli As TextBox
    Public WithEvents bBonos As Button
    Public WithEvents bUsarABonos As Button
    Friend WithEvents Label2 As Label
    Public WithEvents bCrearCliente As Button
    Friend WithEvents gArticulo As GroupBox
    Friend WithEvents xDescripcion As TextBox
    Public WithEvents bAgregar As Button
    Friend WithEvents xCantidad As TextBox
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bEmitir As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cFormaPago As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lSaldo As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents xSaldo As TextBox
    Friend WithEvents xNeto As TextBox
    Friend WithEvents xAbonado As TextBox
    Friend WithEvents xPagoCliente As TextBox
    Friend WithEvents xSubTotal As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents xLineas As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Public WithEvents bConsultarBoleta As Button
    Public WithEvents bCambiarCorrelativo As Button
    Public WithEvents bCuadraturaCaja As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Public WithEvents bBuscarOT As Button
    Friend WithEvents Tiempo As Timer
    Friend WithEvents xUsuario As TextBoxAutoComple
    Friend WithEvents bBuscarC As SearchButton
    Friend WithEvents xArticulo As TextBoxAutoComple
    Public WithEvents bGenerarDescuento As Button
    Friend WithEvents xPOS As TextBox
    Friend WithEvents xIVA As TextBox
    Friend WithEvents xDescuento As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents xTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents cDocumentoCargar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label34 As Label
    Public WithEvents bCargarDocumento As Button
    Public WithEvents bCancelarCarga As Button
    Friend WithEvents gCargarDocumento As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents bBuscarArticulo As Button
    Friend WithEvents lLocal As Label
    Friend WithEvents lBodega As Label
    Friend WithEvents oAuto As CheckBox
    Friend WithEvents xCliente As TextBoxAutoComple
    Public WithEvents bEditarCliente As Button
    Friend WithEvents xToolTip As ToolTip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
End Class
