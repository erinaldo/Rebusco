﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManPermisos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oUsuarioA = New Rebusco.CustomRadio()
        Me.oAccesoA = New Rebusco.CustomRadio()
        Me.cAccesoUsuario = New System.Windows.Forms.ComboBox()
        Me.bCargarA = New System.Windows.Forms.Button()
        Me.bBuscarA = New System.Windows.Forms.Button()
        Me.xCodigoCargar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.oUsuarioI = New Rebusco.CustomRadio()
        Me.cAccesoUsuarioImportar = New System.Windows.Forms.ComboBox()
        Me.oAccesoI = New Rebusco.CustomRadio()
        Me.bImportarI = New System.Windows.Forms.Button()
        Me.bBuscarI = New System.Windows.Forms.Button()
        Me.xCodigoImportar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bDesmarcarModulos = New System.Windows.Forms.Button()
        Me.bMarcarModulos = New System.Windows.Forms.Button()
        Me.bHabilitar = New System.Windows.Forms.Button()
        Me.xTablaModulos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bBuscarModulos = New System.Windows.Forms.Button()
        Me.xBuscarMod = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bDesmarcarHab = New System.Windows.Forms.Button()
        Me.bMarcarHabilitados = New System.Windows.Forms.Button()
        Me.bDeshabilitar = New System.Windows.Forms.Button()
        Me.xTablaHabilitados = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bBuscarHabilitado = New System.Windows.Forms.Button()
        Me.xBuscarHab = New System.Windows.Forms.TextBox()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bAplicarTodo = New System.Windows.Forms.Button()
        Me.bManAcceso = New System.Windows.Forms.Button()
        Me.bManUsuario = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xTablaModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.xTablaHabilitados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.oUsuarioA)
        Me.GroupBox1.Controls.Add(Me.oAccesoA)
        Me.GroupBox1.Controls.Add(Me.cAccesoUsuario)
        Me.GroupBox1.Controls.Add(Me.bCargarA)
        Me.GroupBox1.Controls.Add(Me.bBuscarA)
        Me.GroupBox1.Controls.Add(Me.xCodigoCargar)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(905, 60)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'oUsuarioA
        '
        Me.oUsuarioA.Appearance = System.Windows.Forms.Appearance.Button
        Me.oUsuarioA.BackColor = System.Drawing.Color.White
        Me.oUsuarioA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oUsuarioA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oUsuarioA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oUsuarioA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oUsuarioA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oUsuarioA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oUsuarioA.ForeColor = System.Drawing.Color.Black
        Me.oUsuarioA.Image = CType(resources.GetObject("oUsuarioA.Image"), System.Drawing.Image)
        Me.oUsuarioA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oUsuarioA.Location = New System.Drawing.Point(104, 21)
        Me.oUsuarioA.Name = "oUsuarioA"
        Me.oUsuarioA.Size = New System.Drawing.Size(91, 29)
        Me.oUsuarioA.TabIndex = 243
        Me.oUsuarioA.Text = "Usuario"
        Me.oUsuarioA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oUsuarioA.UseVisualStyleBackColor = False
        '
        'oAccesoA
        '
        Me.oAccesoA.Appearance = System.Windows.Forms.Appearance.Button
        Me.oAccesoA.BackColor = System.Drawing.Color.White
        Me.oAccesoA.Checked = True
        Me.oAccesoA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAccesoA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAccesoA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oAccesoA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oAccesoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oAccesoA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oAccesoA.ForeColor = System.Drawing.Color.White
        Me.oAccesoA.Image = CType(resources.GetObject("oAccesoA.Image"), System.Drawing.Image)
        Me.oAccesoA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oAccesoA.Location = New System.Drawing.Point(13, 21)
        Me.oAccesoA.Name = "oAccesoA"
        Me.oAccesoA.Size = New System.Drawing.Size(91, 29)
        Me.oAccesoA.TabIndex = 243
        Me.oAccesoA.TabStop = True
        Me.oAccesoA.Text = "Acceso"
        Me.oAccesoA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oAccesoA.UseVisualStyleBackColor = False
        '
        'cAccesoUsuario
        '
        Me.cAccesoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cAccesoUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cAccesoUsuario.FormattingEnabled = True
        Me.cAccesoUsuario.Location = New System.Drawing.Point(293, 25)
        Me.cAccesoUsuario.Name = "cAccesoUsuario"
        Me.cAccesoUsuario.Size = New System.Drawing.Size(428, 23)
        Me.cAccesoUsuario.TabIndex = 241
        '
        'bCargarA
        '
        Me.bCargarA.BackColor = System.Drawing.Color.White
        Me.bCargarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargarA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCargarA.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bCargarA.Location = New System.Drawing.Point(813, 21)
        Me.bCargarA.Name = "bCargarA"
        Me.bCargarA.Size = New System.Drawing.Size(80, 28)
        Me.bCargarA.TabIndex = 240
        Me.bCargarA.Text = "Cargar"
        Me.bCargarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCargarA.UseVisualStyleBackColor = False
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarA.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(727, 21)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarA.TabIndex = 239
        Me.bBuscarA.Text = "Buscar"
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'xCodigoCargar
        '
        Me.xCodigoCargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCodigoCargar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCodigoCargar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCodigoCargar.Location = New System.Drawing.Point(201, 25)
        Me.xCodigoCargar.Name = "xCodigoCargar"
        Me.xCodigoCargar.Size = New System.Drawing.Size(86, 21)
        Me.xCodigoCargar.TabIndex = 237
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.oUsuarioI)
        Me.GroupBox2.Controls.Add(Me.cAccesoUsuarioImportar)
        Me.GroupBox2.Controls.Add(Me.oAccesoI)
        Me.GroupBox2.Controls.Add(Me.bImportarI)
        Me.GroupBox2.Controls.Add(Me.bBuscarI)
        Me.GroupBox2.Controls.Add(Me.xCodigoImportar)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(905, 67)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'oUsuarioI
        '
        Me.oUsuarioI.Appearance = System.Windows.Forms.Appearance.Button
        Me.oUsuarioI.BackColor = System.Drawing.Color.White
        Me.oUsuarioI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oUsuarioI.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oUsuarioI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oUsuarioI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oUsuarioI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oUsuarioI.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oUsuarioI.ForeColor = System.Drawing.Color.Black
        Me.oUsuarioI.Image = CType(resources.GetObject("oUsuarioI.Image"), System.Drawing.Image)
        Me.oUsuarioI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oUsuarioI.Location = New System.Drawing.Point(104, 25)
        Me.oUsuarioI.Name = "oUsuarioI"
        Me.oUsuarioI.Size = New System.Drawing.Size(91, 29)
        Me.oUsuarioI.TabIndex = 244
        Me.oUsuarioI.Text = "Usuario"
        Me.oUsuarioI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oUsuarioI.UseVisualStyleBackColor = False
        '
        'cAccesoUsuarioImportar
        '
        Me.cAccesoUsuarioImportar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cAccesoUsuarioImportar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cAccesoUsuarioImportar.FormattingEnabled = True
        Me.cAccesoUsuarioImportar.Location = New System.Drawing.Point(293, 29)
        Me.cAccesoUsuarioImportar.Name = "cAccesoUsuarioImportar"
        Me.cAccesoUsuarioImportar.Size = New System.Drawing.Size(428, 23)
        Me.cAccesoUsuarioImportar.TabIndex = 241
        '
        'oAccesoI
        '
        Me.oAccesoI.Appearance = System.Windows.Forms.Appearance.Button
        Me.oAccesoI.BackColor = System.Drawing.Color.White
        Me.oAccesoI.Checked = True
        Me.oAccesoI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAccesoI.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAccesoI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oAccesoI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oAccesoI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oAccesoI.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oAccesoI.ForeColor = System.Drawing.Color.White
        Me.oAccesoI.Image = CType(resources.GetObject("oAccesoI.Image"), System.Drawing.Image)
        Me.oAccesoI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oAccesoI.Location = New System.Drawing.Point(13, 25)
        Me.oAccesoI.Name = "oAccesoI"
        Me.oAccesoI.Size = New System.Drawing.Size(91, 29)
        Me.oAccesoI.TabIndex = 243
        Me.oAccesoI.TabStop = True
        Me.oAccesoI.Text = "Acceso"
        Me.oAccesoI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oAccesoI.UseVisualStyleBackColor = False
        '
        'bImportarI
        '
        Me.bImportarI.BackColor = System.Drawing.Color.White
        Me.bImportarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImportarI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImportarI.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bImportarI.Location = New System.Drawing.Point(813, 27)
        Me.bImportarI.Name = "bImportarI"
        Me.bImportarI.Size = New System.Drawing.Size(80, 28)
        Me.bImportarI.TabIndex = 240
        Me.bImportarI.Text = "Importar"
        Me.bImportarI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImportarI.UseVisualStyleBackColor = False
        '
        'bBuscarI
        '
        Me.bBuscarI.BackColor = System.Drawing.Color.White
        Me.bBuscarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarI.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarI.Location = New System.Drawing.Point(727, 27)
        Me.bBuscarI.Name = "bBuscarI"
        Me.bBuscarI.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarI.TabIndex = 239
        Me.bBuscarI.Text = "Buscar"
        Me.bBuscarI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarI.UseVisualStyleBackColor = False
        '
        'xCodigoImportar
        '
        Me.xCodigoImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCodigoImportar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCodigoImportar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCodigoImportar.Location = New System.Drawing.Point(201, 29)
        Me.xCodigoImportar.Name = "xCodigoImportar"
        Me.xCodigoImportar.Size = New System.Drawing.Size(86, 21)
        Me.xCodigoImportar.TabIndex = 237
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.bDesmarcarModulos)
        Me.GroupBox3.Controls.Add(Me.bMarcarModulos)
        Me.GroupBox3.Controls.Add(Me.bHabilitar)
        Me.GroupBox3.Controls.Add(Me.xTablaModulos)
        Me.GroupBox3.Controls.Add(Me.bBuscarModulos)
        Me.GroupBox3.Controls.Add(Me.xBuscarMod)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 424)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'bDesmarcarModulos
        '
        Me.bDesmarcarModulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDesmarcarModulos.BackColor = System.Drawing.Color.White
        Me.bDesmarcarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDesmarcarModulos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDesmarcarModulos.Image = CType(resources.GetObject("bDesmarcarModulos.Image"), System.Drawing.Image)
        Me.bDesmarcarModulos.Location = New System.Drawing.Point(25, 389)
        Me.bDesmarcarModulos.Name = "bDesmarcarModulos"
        Me.bDesmarcarModulos.Size = New System.Drawing.Size(148, 28)
        Me.bDesmarcarModulos.TabIndex = 244
        Me.bDesmarcarModulos.Text = "Desmarcar Todos"
        Me.bDesmarcarModulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bDesmarcarModulos.UseVisualStyleBackColor = False
        '
        'bMarcarModulos
        '
        Me.bMarcarModulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMarcarModulos.BackColor = System.Drawing.Color.White
        Me.bMarcarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMarcarModulos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMarcarModulos.Image = Global.Rebusco.My.Resources.Resources.check
        Me.bMarcarModulos.Location = New System.Drawing.Point(179, 389)
        Me.bMarcarModulos.Name = "bMarcarModulos"
        Me.bMarcarModulos.Size = New System.Drawing.Size(121, 28)
        Me.bMarcarModulos.TabIndex = 243
        Me.bMarcarModulos.Text = "Marcar Todos"
        Me.bMarcarModulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bMarcarModulos.UseVisualStyleBackColor = False
        '
        'bHabilitar
        '
        Me.bHabilitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bHabilitar.BackColor = System.Drawing.Color.White
        Me.bHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHabilitar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHabilitar.Image = Global.Rebusco.My.Resources.Resources.ok
        Me.bHabilitar.Location = New System.Drawing.Point(306, 389)
        Me.bHabilitar.Name = "bHabilitar"
        Me.bHabilitar.Size = New System.Drawing.Size(188, 28)
        Me.bHabilitar.TabIndex = 242
        Me.bHabilitar.Text = "Habilitar seleccionados"
        Me.bHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bHabilitar.UseVisualStyleBackColor = False
        '
        'xTablaModulos
        '
        Me.xTablaModulos.AllowEditing = False
        Me.xTablaModulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTablaModulos.ColumnInfo = resources.GetString("xTablaModulos.ColumnInfo")
        Me.xTablaModulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTablaModulos.Location = New System.Drawing.Point(6, 56)
        Me.xTablaModulos.Name = "xTablaModulos"
        Me.xTablaModulos.Rows.Count = 1
        Me.xTablaModulos.Rows.DefaultSize = 19
        Me.xTablaModulos.Size = New System.Drawing.Size(488, 327)
        Me.xTablaModulos.StyleInfo = resources.GetString("xTablaModulos.StyleInfo")
        Me.xTablaModulos.TabIndex = 241
        Me.xTablaModulos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bBuscarModulos
        '
        Me.bBuscarModulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBuscarModulos.BackColor = System.Drawing.Color.White
        Me.bBuscarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarModulos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarModulos.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarModulos.Location = New System.Drawing.Point(414, 22)
        Me.bBuscarModulos.Name = "bBuscarModulos"
        Me.bBuscarModulos.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarModulos.TabIndex = 240
        Me.bBuscarModulos.Text = "Buscar"
        Me.bBuscarModulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarModulos.UseVisualStyleBackColor = False
        '
        'xBuscarMod
        '
        Me.xBuscarMod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xBuscarMod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xBuscarMod.Location = New System.Drawing.Point(6, 25)
        Me.xBuscarMod.Name = "xBuscarMod"
        Me.xBuscarMod.Size = New System.Drawing.Size(402, 21)
        Me.xBuscarMod.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.bDesmarcarHab)
        Me.GroupBox4.Controls.Add(Me.bMarcarHabilitados)
        Me.GroupBox4.Controls.Add(Me.bDeshabilitar)
        Me.GroupBox4.Controls.Add(Me.xTablaHabilitados)
        Me.GroupBox4.Controls.Add(Me.bBuscarHabilitado)
        Me.GroupBox4.Controls.Add(Me.xBuscarHab)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(518, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(500, 426)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'bDesmarcarHab
        '
        Me.bDesmarcarHab.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDesmarcarHab.BackColor = System.Drawing.Color.White
        Me.bDesmarcarHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDesmarcarHab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDesmarcarHab.Image = CType(resources.GetObject("bDesmarcarHab.Image"), System.Drawing.Image)
        Me.bDesmarcarHab.Location = New System.Drawing.Point(8, 391)
        Me.bDesmarcarHab.Name = "bDesmarcarHab"
        Me.bDesmarcarHab.Size = New System.Drawing.Size(148, 28)
        Me.bDesmarcarHab.TabIndex = 247
        Me.bDesmarcarHab.Text = "Desmarcar Todos"
        Me.bDesmarcarHab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bDesmarcarHab.UseVisualStyleBackColor = False
        '
        'bMarcarHabilitados
        '
        Me.bMarcarHabilitados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMarcarHabilitados.BackColor = System.Drawing.Color.White
        Me.bMarcarHabilitados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMarcarHabilitados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMarcarHabilitados.Image = Global.Rebusco.My.Resources.Resources.check
        Me.bMarcarHabilitados.Location = New System.Drawing.Point(162, 391)
        Me.bMarcarHabilitados.Name = "bMarcarHabilitados"
        Me.bMarcarHabilitados.Size = New System.Drawing.Size(121, 28)
        Me.bMarcarHabilitados.TabIndex = 246
        Me.bMarcarHabilitados.Text = "Marcar Todos"
        Me.bMarcarHabilitados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bMarcarHabilitados.UseVisualStyleBackColor = False
        '
        'bDeshabilitar
        '
        Me.bDeshabilitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDeshabilitar.BackColor = System.Drawing.Color.White
        Me.bDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDeshabilitar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDeshabilitar.Image = Global.Rebusco.My.Resources.Resources.cancel
        Me.bDeshabilitar.Location = New System.Drawing.Point(289, 391)
        Me.bDeshabilitar.Name = "bDeshabilitar"
        Me.bDeshabilitar.Size = New System.Drawing.Size(205, 28)
        Me.bDeshabilitar.TabIndex = 245
        Me.bDeshabilitar.Text = "Deshabilitar seleccionados"
        Me.bDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bDeshabilitar.UseVisualStyleBackColor = False
        '
        'xTablaHabilitados
        '
        Me.xTablaHabilitados.AllowEditing = False
        Me.xTablaHabilitados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTablaHabilitados.ColumnInfo = resources.GetString("xTablaHabilitados.ColumnInfo")
        Me.xTablaHabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTablaHabilitados.Location = New System.Drawing.Point(6, 58)
        Me.xTablaHabilitados.Name = "xTablaHabilitados"
        Me.xTablaHabilitados.Rows.Count = 1
        Me.xTablaHabilitados.Rows.DefaultSize = 19
        Me.xTablaHabilitados.Size = New System.Drawing.Size(488, 327)
        Me.xTablaHabilitados.StyleInfo = resources.GetString("xTablaHabilitados.StyleInfo")
        Me.xTablaHabilitados.TabIndex = 243
        Me.xTablaHabilitados.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bBuscarHabilitado
        '
        Me.bBuscarHabilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBuscarHabilitado.BackColor = System.Drawing.Color.White
        Me.bBuscarHabilitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarHabilitado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarHabilitado.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarHabilitado.Location = New System.Drawing.Point(414, 24)
        Me.bBuscarHabilitado.Name = "bBuscarHabilitado"
        Me.bBuscarHabilitado.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarHabilitado.TabIndex = 242
        Me.bBuscarHabilitado.Text = "Buscar"
        Me.bBuscarHabilitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarHabilitado.UseVisualStyleBackColor = False
        '
        'xBuscarHab
        '
        Me.xBuscarHab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xBuscarHab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xBuscarHab.Location = New System.Drawing.Point(6, 27)
        Me.xBuscarHab.Name = "xBuscarHab"
        Me.xBuscarHab.Size = New System.Drawing.Size(402, 21)
        Me.xBuscarHab.TabIndex = 241
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 638)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 52
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(920, 638)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 53
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
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(812, 638)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 83
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bAplicarTodo
        '
        Me.bAplicarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAplicarTodo.BackColor = System.Drawing.Color.White
        Me.bAplicarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAplicarTodo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAplicarTodo.Image = Global.Rebusco.My.Resources.Resources.Usuarios24
        Me.bAplicarTodo.Location = New System.Drawing.Point(587, 638)
        Me.bAplicarTodo.Name = "bAplicarTodo"
        Me.bAplicarTodo.Size = New System.Drawing.Size(219, 36)
        Me.bAplicarTodo.TabIndex = 84
        Me.bAplicarTodo.Text = "Aplicar a todos los usuarios"
        Me.bAplicarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAplicarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAplicarTodo.UseVisualStyleBackColor = False
        '
        'bManAcceso
        '
        Me.bManAcceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bManAcceso.BackColor = System.Drawing.Color.White
        Me.bManAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bManAcceso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bManAcceso.Image = Global.Rebusco.My.Resources.Resources.lock24
        Me.bManAcceso.Location = New System.Drawing.Point(321, 638)
        Me.bManAcceso.Name = "bManAcceso"
        Me.bManAcceso.Size = New System.Drawing.Size(199, 36)
        Me.bManAcceso.TabIndex = 85
        Me.bManAcceso.Text = "Mantención de Accesos"
        Me.bManAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bManAcceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bManAcceso.UseVisualStyleBackColor = False
        '
        'bManUsuario
        '
        Me.bManUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bManUsuario.BackColor = System.Drawing.Color.White
        Me.bManUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bManUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bManUsuario.Image = Global.Rebusco.My.Resources.Resources.usuario24
        Me.bManUsuario.Location = New System.Drawing.Point(116, 638)
        Me.bManUsuario.Name = "bManUsuario"
        Me.bManUsuario.Size = New System.Drawing.Size(199, 36)
        Me.bManUsuario.TabIndex = 86
        Me.bManUsuario.Text = "Mantención de Usuarios"
        Me.bManUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bManUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bManUsuario.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(905, 16)
        Me.Label14.TabIndex = 238
        Me.Label14.Text = "Modificar Acceso / Usuario"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(905, 16)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Importar Permisos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 16)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Módulos Deshabilitados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(518, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 16)
        Me.Label3.TabIndex = 241
        Me.Label3.Text = "Módulos Habilitados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tEstado, Me.pBarraProgreso})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 677)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1031, 22)
        Me.StatusStrip1.TabIndex = 242
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tEstado
        '
        Me.tEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tEstado.ForeColor = System.Drawing.Color.White
        Me.tEstado.Name = "tEstado"
        Me.tEstado.Size = New System.Drawing.Size(35, 17)
        Me.tEstado.Text = "Listo"
        '
        'pBarraProgreso
        '
        Me.pBarraProgreso.Name = "pBarraProgreso"
        Me.pBarraProgreso.Size = New System.Drawing.Size(100, 16)
        Me.pBarraProgreso.Visible = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(1031, 50)
        Me.WinDeco1.TabIndex = 243
        Me.WinDeco1.TituloVentana = "Mantenedor de Permisos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ManPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 699)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bManUsuario)
        Me.Controls.Add(Me.bManAcceso)
        Me.Controls.Add(Me.bAplicarTodo)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Permisos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.xTablaModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.xTablaHabilitados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xCodigoCargar As TextBox
    Public WithEvents bBuscarA As Button
    Public WithEvents bCargarA As Button
    Friend WithEvents cAccesoUsuario As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cAccesoUsuarioImportar As ComboBox
    Public WithEvents bImportarI As Button
    Public WithEvents bBuscarI As Button
    Friend WithEvents xCodigoImportar As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Public WithEvents bBuscarModulos As Button
    Friend WithEvents xBuscarMod As TextBox
    Friend WithEvents xTablaModulos As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bHabilitar As Button
    Public WithEvents bDesmarcarModulos As Button
    Public WithEvents bMarcarModulos As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bGuardar As Button
    Public WithEvents bAplicarTodo As Button
    Public WithEvents bManAcceso As Button
    Public WithEvents bManUsuario As Button
    Friend WithEvents GroupBox4 As GroupBox
    Public WithEvents bDesmarcarHab As Button
    Public WithEvents bMarcarHabilitados As Button
    Public WithEvents bDeshabilitar As Button
    Friend WithEvents xTablaHabilitados As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bBuscarHabilitado As Button
    Friend WithEvents xBuscarHab As TextBox
    
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tEstado As ToolStripStatusLabel
    Friend WithEvents pBarraProgreso As ToolStripProgressBar
    Friend WithEvents oAccesoA As CustomRadio
    Friend WithEvents oUsuarioA As CustomRadio
    Friend WithEvents oUsuarioI As CustomRadio
    Friend WithEvents oAccesoI As CustomRadio
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
