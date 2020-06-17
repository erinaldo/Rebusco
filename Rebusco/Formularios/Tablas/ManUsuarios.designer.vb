<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManUsuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchButton1 = New Rebusco.SearchButton()
        Me.xCodigo = New System.Windows.Forms.TextBox()
        Me.xNombreUsr = New System.Windows.Forms.TextBox()
        Me.oFuncionario = New Rebusco.CustomCheck()
        Me.xClave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xRut = New System.Windows.Forms.MaskedTextBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.cAcceso = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xAcceso = New System.Windows.Forms.TextBox()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xNombreCliente = New System.Windows.Forms.TextBox()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchButton2 = New Rebusco.SearchButton()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.xDescuento = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xDescuento)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.SearchButton1)
        Me.GroupBox1.Controls.Add(Me.oFuncionario)
        Me.GroupBox1.Controls.Add(Me.xClave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xRut)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.cAcceso)
        Me.GroupBox1.Controls.Add(Me.xNombreUsr)
        Me.GroupBox1.Controls.Add(Me.xCodigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xAcceso)
        Me.GroupBox1.Controls.Add(Me.xLocal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SearchButton1
        '
        Me.SearchButton1.CampoBuscar1 = "NombreUsr"
        Me.SearchButton1.CampoBuscar2 = ""
        Me.SearchButton1.CamposAdicionales = ""
        Me.SearchButton1.ControlCarga = Me.xCodigo
        Me.SearchButton1.ControlFocus = Me.xNombreUsr
        Me.SearchButton1.Filtro = ""
        Me.SearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton1.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton1.IDBusqueda = "Usuario"
        Me.SearchButton1.Image = CType(resources.GetObject("SearchButton1.Image"), System.Drawing.Image)
        Me.SearchButton1.Location = New System.Drawing.Point(149, 36)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(80, 28)
        Me.SearchButton1.TabIndex = 140
        Me.SearchButton1.TablaBusqueda = "Usuarios"
        Me.SearchButton1.Text = "Buscar"
        Me.SearchButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton1.Titulo = "Buscar Usuarios"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'xCodigo
        '
        Me.xCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCodigo.Location = New System.Drawing.Point(68, 38)
        Me.xCodigo.MaxLength = 3
        Me.xCodigo.Name = "xCodigo"
        Me.xCodigo.Size = New System.Drawing.Size(75, 22)
        Me.xCodigo.TabIndex = 0
        '
        'xNombreUsr
        '
        Me.xNombreUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombreUsr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombreUsr.Location = New System.Drawing.Point(68, 69)
        Me.xNombreUsr.MaxLength = 50
        Me.xNombreUsr.Name = "xNombreUsr"
        Me.xNombreUsr.Size = New System.Drawing.Size(409, 21)
        Me.xNombreUsr.TabIndex = 2
        '
        'oFuncionario
        '
        Me.oFuncionario.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFuncionario.BackColor = System.Drawing.Color.White
        Me.oFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFuncionario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFuncionario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFuncionario.ForeColor = System.Drawing.Color.Black
        Me.oFuncionario.Image = CType(resources.GetObject("oFuncionario.Image"), System.Drawing.Image)
        Me.oFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oFuncionario.Location = New System.Drawing.Point(372, 36)
        Me.oFuncionario.Name = "oFuncionario"
        Me.oFuncionario.Size = New System.Drawing.Size(105, 29)
        Me.oFuncionario.TabIndex = 139
        Me.oFuncionario.Text = "Funcionario"
        Me.oFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFuncionario.UseVisualStyleBackColor = False
        '
        'xClave
        '
        Me.xClave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xClave.Location = New System.Drawing.Point(68, 181)
        Me.xClave.MaxLength = 4
        Me.xClave.Name = "xClave"
        Me.xClave.Size = New System.Drawing.Size(75, 21)
        Me.xClave.TabIndex = 6
        Me.xClave.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Clave"
        '
        'xRut
        '
        Me.xRut.Culture = New System.Globalization.CultureInfo("en-US")
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRut.Location = New System.Drawing.Point(68, 97)
        Me.xRut.Mask = "##.###.###-A"
        Me.xRut.Name = "xRut"
        Me.xRut.Size = New System.Drawing.Size(117, 21)
        Me.xRut.TabIndex = 3
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(68, 155)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(409, 23)
        Me.cLocal.TabIndex = 8
        '
        'cAcceso
        '
        Me.cAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cAcceso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cAcceso.FormattingEnabled = True
        Me.cAcceso.Location = New System.Drawing.Point(68, 125)
        Me.cAcceso.Name = "cAcceso"
        Me.cAcceso.Size = New System.Drawing.Size(409, 23)
        Me.cAcceso.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Local"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Acceso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Rut"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Código"
        '
        'xAcceso
        '
        Me.xAcceso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xAcceso.Location = New System.Drawing.Point(458, 128)
        Me.xAcceso.MaxLength = 18
        Me.xAcceso.Name = "xAcceso"
        Me.xAcceso.Size = New System.Drawing.Size(16, 21)
        Me.xAcceso.TabIndex = 138
        Me.xAcceso.Visible = False
        '
        'xLocal
        '
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xLocal.Location = New System.Drawing.Point(458, 156)
        Me.xLocal.MaxLength = 18
        Me.xLocal.Name = "xLocal"
        Me.xLocal.Size = New System.Drawing.Size(16, 21)
        Me.xLocal.TabIndex = 137
        Me.xLocal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Nombre"
        '
        'xNombreCliente
        '
        Me.xNombreCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreCliente.Location = New System.Drawing.Point(68, 51)
        Me.xNombreCliente.Name = "xNombreCliente"
        Me.xNombreCliente.ReadOnly = True
        Me.xNombreCliente.Size = New System.Drawing.Size(406, 21)
        Me.xNombreCliente.TabIndex = 104
        Me.xNombreCliente.TabStop = False
        '
        'xCliente
        '
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.Location = New System.Drawing.Point(68, 23)
        Me.xCliente.MaxLength = 18
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(71, 21)
        Me.xCliente.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(9, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Cliente"
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(396, 417)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 4
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(184, 417)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 2
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
        Me.bEliminar.Location = New System.Drawing.Point(290, 417)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 36)
        Me.bEliminar.TabIndex = 3
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
        Me.bLimpiar.Location = New System.Drawing.Point(12, 417)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 106
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'lFolios
        '
        Me.lFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lFolios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lFolios.ForeColor = System.Drawing.Color.White
        Me.lFolios.Location = New System.Drawing.Point(12, 58)
        Me.lFolios.Name = "lFolios"
        Me.lFolios.Size = New System.Drawing.Size(483, 16)
        Me.lFolios.TabIndex = 134
        Me.lFolios.Text = "Usuario"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(483, 16)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Cliente Asociado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SearchButton2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.xCliente)
        Me.GroupBox2.Controls.Add(Me.xNombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 88)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        '
        'SearchButton2
        '
        Me.SearchButton2.CampoBuscar1 = "Nombre"
        Me.SearchButton2.CampoBuscar2 = ""
        Me.SearchButton2.CamposAdicionales = ""
        Me.SearchButton2.ControlCarga = Me.xCliente
        Me.SearchButton2.ControlFocus = Me.xNombreCliente
        Me.SearchButton2.Filtro = ""
        Me.SearchButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SearchButton2.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton2.IDBusqueda = "Cliente"
        Me.SearchButton2.Image = CType(resources.GetObject("SearchButton2.Image"), System.Drawing.Image)
        Me.SearchButton2.Location = New System.Drawing.Point(145, 20)
        Me.SearchButton2.Name = "SearchButton2"
        Me.SearchButton2.Size = New System.Drawing.Size(80, 28)
        Me.SearchButton2.TabIndex = 141
        Me.SearchButton2.TablaBusqueda = "Clientes"
        Me.SearchButton2.Text = "Buscar"
        Me.SearchButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton2.Titulo = "Buscar Clientes"
        Me.SearchButton2.UseVisualStyleBackColor = True
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
        Me.WinDeco1.Size = New System.Drawing.Size(507, 50)
        Me.WinDeco1.TabIndex = 142
        Me.WinDeco1.TituloVentana = "Mantenedor  de Usuarios"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'xDescuento
        '
        Me.xDescuento.Location = New System.Drawing.Point(123, 208)
        Me.xDescuento.Name = "xDescuento"
        Me.xDescuento.Size = New System.Drawing.Size(52, 20)
        Me.xDescuento.TabIndex = 142
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(177, 210)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 18)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 15)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Máximo descuento"
        '
        'ManUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lFolios)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents xClave As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents xRut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents xNombreUsr As System.Windows.Forms.TextBox
    Friend WithEvents xCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xCliente As System.Windows.Forms.TextBox
    Public WithEvents bCancelar As System.Windows.Forms.Button
    Public WithEvents bGuardar As System.Windows.Forms.Button
    Public WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xNombreCliente As TextBox
    Public WithEvents bLimpiar As Button
    
    Friend WithEvents Label3 As Label
    Friend WithEvents xAcceso As TextBox
    Friend WithEvents xLocal As TextBox
    Friend WithEvents oFuncionario As CustomCheck
    Friend WithEvents lFolios As Label
    Friend WithEvents SearchButton1 As SearchButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SearchButton2 As SearchButton
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label9 As Label
    Friend WithEvents xDescuento As NumericUpDown
    Friend WithEvents Label20 As Label
End Class
