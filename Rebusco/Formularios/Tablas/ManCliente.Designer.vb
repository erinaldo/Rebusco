<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.xCiudad = New Rebusco.TextBoxAutoComple()
        Me.cCiudad = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.oProveedor = New Rebusco.CustomCheck()
        Me.xComuna = New Rebusco.TextBoxAutoComple()
        Me.oComision = New Rebusco.CustomCheck()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.cEstado = New System.Windows.Forms.ComboBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xRut = New System.Windows.Forms.MaskedTextBox()
        Me.cComuna = New System.Windows.Forms.ComboBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.xTelefono = New System.Windows.Forms.TextBox()
        Me.xContacto = New System.Windows.Forms.TextBox()
        Me.xEmail = New System.Windows.Forms.TextBox()
        Me.xGiro = New System.Windows.Forms.TextBox()
        Me.xDireccion = New System.Windows.Forms.TextBox()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.xFantasia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xDescuentoServ = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.xDescuento = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cFPago = New System.Windows.Forms.ComboBox()
        Me.xGlosa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xVencimiento = New System.Windows.Forms.TextBox()
        Me.xCupoMax = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tAyuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xDescuentoServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lFolios)
        Me.GroupBox1.Controls.Add(Me.xCiudad)
        Me.GroupBox1.Controls.Add(Me.cCiudad)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.oProveedor)
        Me.GroupBox1.Controls.Add(Me.xComuna)
        Me.GroupBox1.Controls.Add(Me.oComision)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.bNuevo)
        Me.GroupBox1.Controls.Add(Me.cEstado)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xRut)
        Me.GroupBox1.Controls.Add(Me.cComuna)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.xTelefono)
        Me.GroupBox1.Controls.Add(Me.xContacto)
        Me.GroupBox1.Controls.Add(Me.xEmail)
        Me.GroupBox1.Controls.Add(Me.xGiro)
        Me.GroupBox1.Controls.Add(Me.xDireccion)
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.xFantasia)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 400)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lFolios
        '
        Me.lFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lFolios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lFolios.ForeColor = System.Drawing.Color.White
        Me.lFolios.Location = New System.Drawing.Point(0, 1)
        Me.lFolios.Name = "lFolios"
        Me.lFolios.Size = New System.Drawing.Size(573, 16)
        Me.lFolios.TabIndex = 136
        Me.lFolios.Text = "Cliente"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xCiudad
        '
        Me.xCiudad.AnchoLista = 300
        Me.xCiudad.AutoCompletarActivo = True
        Me.xCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xCiudad.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xCiudad.DescBusqueda = "NombreComuna"
        Me.xCiudad.DescBusquedaAdicional = ""
        Me.xCiudad.DescBusquedaAdicional2 = ""
        Me.xCiudad.Filtro = ""
        Me.xCiudad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCiudad.IDBusqueda = "Codigo"
        Me.xCiudad.IntervaloBusquedaNumeros = 1
        Me.xCiudad.IntervaloBusquedaTexto = 3
        Me.xCiudad.Location = New System.Drawing.Point(120, 222)
        Me.xCiudad.Name = "xCiudad"
        Me.xCiudad.Size = New System.Drawing.Size(100, 21)
        Me.xCiudad.TabIndex = 6
        Me.xCiudad.TablaBusqueda = "Comunas"
        Me.xCiudad.TextFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cCiudad
        '
        Me.cCiudad.BackColor = System.Drawing.Color.White
        Me.cCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCiudad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCiudad.FormattingEnabled = True
        Me.cCiudad.Location = New System.Drawing.Point(226, 222)
        Me.cCiudad.Name = "cCiudad"
        Me.cCiudad.Size = New System.Drawing.Size(340, 23)
        Me.cCiudad.TabIndex = 134
        Me.cCiudad.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 15)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "Ciudad"
        '
        'oProveedor
        '
        Me.oProveedor.Appearance = System.Windows.Forms.Appearance.Button
        Me.oProveedor.BackColor = System.Drawing.Color.White
        Me.oProveedor.Checked = True
        Me.oProveedor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oProveedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oProveedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oProveedor.ForeColor = System.Drawing.Color.White
        Me.oProveedor.Image = CType(resources.GetObject("oProveedor.Image"), System.Drawing.Image)
        Me.oProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oProveedor.Location = New System.Drawing.Point(475, 365)
        Me.oProveedor.Name = "oProveedor"
        Me.oProveedor.Size = New System.Drawing.Size(91, 27)
        Me.oProveedor.TabIndex = 130
        Me.oProveedor.Text = "Proveedor"
        Me.oProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oProveedor.UseVisualStyleBackColor = False
        '
        'xComuna
        '
        Me.xComuna.AnchoLista = 300
        Me.xComuna.AutoCompletarActivo = True
        Me.xComuna.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xComuna.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xComuna.DescBusqueda = "NombreComuna"
        Me.xComuna.DescBusquedaAdicional = ""
        Me.xComuna.DescBusquedaAdicional2 = ""
        Me.xComuna.Filtro = ""
        Me.xComuna.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xComuna.IDBusqueda = "Codigo"
        Me.xComuna.IntervaloBusquedaNumeros = 1
        Me.xComuna.IntervaloBusquedaTexto = 3
        Me.xComuna.Location = New System.Drawing.Point(120, 252)
        Me.xComuna.Name = "xComuna"
        Me.xComuna.Size = New System.Drawing.Size(100, 21)
        Me.xComuna.TabIndex = 7
        Me.xComuna.TablaBusqueda = "Comunas"
        Me.xComuna.TextFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'oComision
        '
        Me.oComision.Appearance = System.Windows.Forms.Appearance.Button
        Me.oComision.BackColor = System.Drawing.Color.White
        Me.oComision.Checked = True
        Me.oComision.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oComision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oComision.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oComision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oComision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oComision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oComision.ForeColor = System.Drawing.Color.White
        Me.oComision.Image = CType(resources.GetObject("oComision.Image"), System.Drawing.Image)
        Me.oComision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oComision.Location = New System.Drawing.Point(378, 365)
        Me.oComision.Name = "oComision"
        Me.oComision.Size = New System.Drawing.Size(91, 27)
        Me.oComision.TabIndex = 129
        Me.oComision.Text = "Comisión"
        Me.oComision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oComision.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 371)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Estado"
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.White
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(211, 24)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(87, 28)
        Me.bNuevo.TabIndex = 13
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'cEstado
        '
        Me.cEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cEstado.FormattingEnabled = True
        Me.cEstado.ItemHeight = 15
        Me.cEstado.Location = New System.Drawing.Point(120, 368)
        Me.cEstado.Name = "cEstado"
        Me.cEstado.Size = New System.Drawing.Size(175, 23)
        Me.cEstado.TabIndex = 11
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.White
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(304, 24)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(87, 28)
        Me.bBuscar.TabIndex = 14
        Me.bBuscar.TabStop = False
        Me.bBuscar.Tag = " "
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Teléfonos"
        '
        'xRut
        '
        Me.xRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xRut.Culture = New System.Globalization.CultureInfo("en-US")
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRut.Location = New System.Drawing.Point(120, 83)
        Me.xRut.Mask = "##.###.###-A"
        Me.xRut.Name = "xRut"
        Me.xRut.Size = New System.Drawing.Size(100, 21)
        Me.xRut.TabIndex = 2
        '
        'cComuna
        '
        Me.cComuna.BackColor = System.Drawing.Color.White
        Me.cComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cComuna.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cComuna.FormattingEnabled = True
        Me.cComuna.Location = New System.Drawing.Point(226, 252)
        Me.cComuna.Name = "cComuna"
        Me.cComuna.Size = New System.Drawing.Size(340, 23)
        Me.cComuna.TabIndex = 8
        Me.cComuna.TabStop = False
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombre.Location = New System.Drawing.Point(120, 55)
        Me.xNombre.MaxLength = 200
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(446, 21)
        Me.xNombre.TabIndex = 1
        '
        'xTelefono
        '
        Me.xTelefono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTelefono.Location = New System.Drawing.Point(120, 338)
        Me.xTelefono.MaxLength = 50
        Me.xTelefono.Name = "xTelefono"
        Me.xTelefono.Size = New System.Drawing.Size(100, 21)
        Me.xTelefono.TabIndex = 10
        '
        'xContacto
        '
        Me.xContacto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xContacto.Location = New System.Drawing.Point(120, 310)
        Me.xContacto.MaxLength = 100
        Me.xContacto.Name = "xContacto"
        Me.xContacto.Size = New System.Drawing.Size(446, 21)
        Me.xContacto.TabIndex = 9
        '
        'xEmail
        '
        Me.xEmail.BackColor = System.Drawing.Color.White
        Me.xEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xEmail.Location = New System.Drawing.Point(120, 282)
        Me.xEmail.MaxLength = 100
        Me.xEmail.Name = "xEmail"
        Me.xEmail.Size = New System.Drawing.Size(446, 21)
        Me.xEmail.TabIndex = 8
        Me.tAyuda.SetToolTip(Me.xEmail, "Idealmente ingresar correo de distribución electrónica o correo de personal de co" &
        "ntacto o administración")
        '
        'xGiro
        '
        Me.xGiro.BackColor = System.Drawing.Color.White
        Me.xGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xGiro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xGiro.Location = New System.Drawing.Point(120, 114)
        Me.xGiro.MaxLength = 100
        Me.xGiro.Name = "xGiro"
        Me.xGiro.Size = New System.Drawing.Size(446, 21)
        Me.xGiro.TabIndex = 3
        '
        'xDireccion
        '
        Me.xDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDireccion.Location = New System.Drawing.Point(120, 170)
        Me.xDireccion.MaxLength = 255
        Me.xDireccion.Multiline = True
        Me.xDireccion.Name = "xDireccion"
        Me.xDireccion.Size = New System.Drawing.Size(446, 46)
        Me.xDireccion.TabIndex = 5
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.Location = New System.Drawing.Point(120, 27)
        Me.xCliente.MaxLength = 18
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(85, 21)
        Me.xCliente.TabIndex = 0
        Me.xCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFantasia
        '
        Me.xFantasia.BackColor = System.Drawing.Color.White
        Me.xFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xFantasia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFantasia.Location = New System.Drawing.Point(120, 142)
        Me.xFantasia.MaxLength = 30
        Me.xFantasia.Name = "xFantasia"
        Me.xFantasia.Size = New System.Drawing.Size(446, 21)
        Me.xFantasia.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Contacto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Giro Comercial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Comuna"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fantasía"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Rut"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xDescuentoServ)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.xDescuento)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cFPago)
        Me.GroupBox2.Controls.Add(Me.xGlosa)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.xVencimiento)
        Me.GroupBox2.Controls.Add(Me.xCupoMax)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 462)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 104)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'xDescuentoServ
        '
        Me.xDescuentoServ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescuentoServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.xDescuentoServ.Location = New System.Drawing.Point(497, 73)
        Me.xDescuentoServ.Name = "xDescuentoServ"
        Me.xDescuentoServ.Size = New System.Drawing.Size(52, 21)
        Me.xDescuentoServ.TabIndex = 141
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(551, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 18)
        Me.Label21.TabIndex = 140
        Me.Label21.Text = "%"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(369, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(122, 15)
        Me.Label22.TabIndex = 139
        Me.Label22.Text = "Máx. Dcto. Servicios"
        '
        'xDescuento
        '
        Me.xDescuento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.xDescuento.Location = New System.Drawing.Point(497, 46)
        Me.xDescuento.Name = "xDescuento"
        Me.xDescuento.Size = New System.Drawing.Size(52, 21)
        Me.xDescuento.TabIndex = 138
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(551, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 18)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "%"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(573, 16)
        Me.Label19.TabIndex = 136
        Me.Label19.Text = "Tratamiento con Documentos"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(6, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Forma de Pago"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(6, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 16)
        Me.Label13.TabIndex = 12
        '
        'cFPago
        '
        Me.cFPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPago.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFPago.FormattingEnabled = True
        Me.cFPago.ItemHeight = 15
        Me.cFPago.Location = New System.Drawing.Point(114, 46)
        Me.cFPago.Name = "cFPago"
        Me.cFPago.Size = New System.Drawing.Size(178, 23)
        Me.cFPago.TabIndex = 15
        '
        'xGlosa
        '
        Me.xGlosa.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xGlosa.Location = New System.Drawing.Point(114, 76)
        Me.xGlosa.MaxLength = 100
        Me.xGlosa.Name = "xGlosa"
        Me.xGlosa.Size = New System.Drawing.Size(249, 21)
        Me.xGlosa.TabIndex = 16
        Me.tAyuda.SetToolTip(Me.xGlosa, "Leyenda:  % = Mes Actual,  # = Mes Anterior,  & = Fecha de Facturación")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(7, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Glosa Especial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(369, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Máx. Dcto. Productos"
        '
        'xVencimiento
        '
        Me.xVencimiento.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVencimiento.Location = New System.Drawing.Point(114, 22)
        Me.xVencimiento.MaxLength = 18
        Me.xVencimiento.Name = "xVencimiento"
        Me.xVencimiento.Size = New System.Drawing.Size(48, 21)
        Me.xVencimiento.TabIndex = 12
        Me.tAyuda.SetToolTip(Me.xVencimiento, "Cantidad de dias en vencer una factura emitida a este cliente")
        '
        'xCupoMax
        '
        Me.xCupoMax.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCupoMax.Location = New System.Drawing.Point(489, 19)
        Me.xCupoMax.MaxLength = 18
        Me.xCupoMax.Name = "xCupoMax"
        Me.xCupoMax.Size = New System.Drawing.Size(71, 21)
        Me.xCupoMax.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(6, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Vencimiento Fact."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(367, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Máx. Cupo Crédito"
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(275, 588)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 3
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
        Me.bEliminar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Image = Global.Rebusco.My.Resources.Resources.delete24
        Me.bEliminar.Location = New System.Drawing.Point(381, 588)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 36)
        Me.bEliminar.TabIndex = 4
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(487, 588)
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
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(12, 588)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 2
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(597, 50)
        Me.WinDeco1.TabIndex = 133
        Me.WinDeco1.TituloVentana = "Mantención de Clientes"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ManCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 636)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xDescuentoServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cComuna As ComboBox
    Friend WithEvents xFantasia As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cEstado As ComboBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xEmail As TextBox
    Friend WithEvents xContacto As TextBox
    Friend WithEvents xTelefono As TextBox
    Friend WithEvents xGiro As TextBox
    Friend WithEvents xDireccion As TextBox
    Friend WithEvents xVencimiento As TextBox
    Friend WithEvents xCupoMax As TextBox
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents xRut As MaskedTextBox
    Public WithEvents bBuscar As Button
    Public WithEvents bGuardar As Button
    Public WithEvents bEliminar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bNuevo As Button
    
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xComuna As TextBoxAutoComple
    Friend WithEvents oComision As CustomCheck
    Friend WithEvents oProveedor As CustomCheck
    Friend WithEvents Label13 As Label
    Friend WithEvents cFPago As ComboBox
    Friend WithEvents xGlosa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tAyuda As ToolTip
    Friend WithEvents xCiudad As TextBoxAutoComple
    Friend WithEvents cCiudad As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents lFolios As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents xDescuento As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents xDescuentoServ As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
End Class
