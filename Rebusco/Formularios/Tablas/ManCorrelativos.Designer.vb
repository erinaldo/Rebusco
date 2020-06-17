<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManCorrelativos


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManCorrelativos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oCompartir = New Rebusco.CustomCheck()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.xCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xCaja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.fFolios = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dFechaCAF = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xFinal = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xInicial = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.fFolios.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.oCompartir)
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.xCorrelativo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xCaja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xLocal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'oCompartir
        '
        Me.oCompartir.Appearance = System.Windows.Forms.Appearance.Button
        Me.oCompartir.BackColor = System.Drawing.Color.White
        Me.oCompartir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oCompartir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oCompartir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oCompartir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oCompartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oCompartir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oCompartir.ForeColor = System.Drawing.Color.Black
        Me.oCompartir.Image = CType(resources.GetObject("oCompartir.Image"), System.Drawing.Image)
        Me.oCompartir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oCompartir.Location = New System.Drawing.Point(149, 74)
        Me.oCompartir.Name = "oCompartir"
        Me.oCompartir.Size = New System.Drawing.Size(253, 30)
        Me.oCompartir.TabIndex = 133
        Me.oCompartir.Text = "Compartir el mismo correlativo LOCAL"
        Me.oCompartir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oCompartir.UseVisualStyleBackColor = False
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(85, 48)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(317, 23)
        Me.cTipoDoc.TabIndex = 4
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(149, 18)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(253, 23)
        Me.cLocal.TabIndex = 2
        '
        'xCorrelativo
        '
        Me.xCorrelativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCorrelativo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCorrelativo.Location = New System.Drawing.Point(85, 107)
        Me.xCorrelativo.MaxLength = 10
        Me.xCorrelativo.Name = "xCorrelativo"
        Me.xCorrelativo.Size = New System.Drawing.Size(145, 21)
        Me.xCorrelativo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Correlativo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Tipo Doc."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Caja"
        '
        'xCaja
        '
        Me.xCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCaja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCaja.Location = New System.Drawing.Point(85, 78)
        Me.xCaja.Name = "xCaja"
        Me.xCaja.Size = New System.Drawing.Size(58, 21)
        Me.xCaja.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Local"
        '
        'xLocal
        '
        Me.xLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xLocal.Location = New System.Drawing.Point(85, 19)
        Me.xLocal.MaxLength = 4
        Me.xLocal.Name = "xLocal"
        Me.xLocal.Size = New System.Drawing.Size(58, 22)
        Me.xLocal.TabIndex = 1
        '
        'fFolios
        '
        Me.fFolios.BackColor = System.Drawing.Color.Transparent
        Me.fFolios.Controls.Add(Me.Label13)
        Me.fFolios.Controls.Add(Me.dFechaCAF)
        Me.fFolios.Controls.Add(Me.Label7)
        Me.fFolios.Controls.Add(Me.xFinal)
        Me.fFolios.Controls.Add(Me.TextBox3)
        Me.fFolios.Controls.Add(Me.Label6)
        Me.fFolios.Controls.Add(Me.Label12)
        Me.fFolios.Controls.Add(Me.xInicial)
        Me.fFolios.Controls.Add(Me.Label11)
        Me.fFolios.Controls.Add(Me.Label5)
        Me.fFolios.Controls.Add(Me.Label10)
        Me.fFolios.Controls.Add(Me.TextBox1)
        Me.fFolios.Controls.Add(Me.TextBox2)
        Me.fFolios.Controls.Add(Me.Label9)
        Me.fFolios.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.fFolios.Location = New System.Drawing.Point(427, 68)
        Me.fFolios.Name = "fFolios"
        Me.fFolios.Size = New System.Drawing.Size(242, 135)
        Me.fFolios.TabIndex = 47
        Me.fFolios.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(224, -50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(287, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "(0=Todo el local compartirá el mismo correlativo)"
        '
        'dFechaCAF
        '
        Me.dFechaCAF.CustomFormat = "dd/MM/yyyy"
        Me.dFechaCAF.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dFechaCAF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFechaCAF.Location = New System.Drawing.Point(86, 85)
        Me.dFechaCAF.Name = "dFechaCAF"
        Me.dFechaCAF.Size = New System.Drawing.Size(98, 21)
        Me.dFechaCAF.TabIndex = 56
        Me.dFechaCAF.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Fecha CAF"
        '
        'xFinal
        '
        Me.xFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xFinal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xFinal.Location = New System.Drawing.Point(86, 57)
        Me.xFinal.MaxLength = 10
        Me.xFinal.Name = "xFinal"
        Me.xFinal.Size = New System.Drawing.Size(145, 21)
        Me.xFinal.TabIndex = 53
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TextBox3.Location = New System.Drawing.Point(160, -28)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 22)
        Me.TextBox3.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(8, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Final"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(44, -25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Correlativo"
        '
        'xInicial
        '
        Me.xInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xInicial.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xInicial.Location = New System.Drawing.Point(86, 29)
        Me.xInicial.MaxLength = 10
        Me.xInicial.Name = "xInicial"
        Me.xInicial.Size = New System.Drawing.Size(145, 21)
        Me.xInicial.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(44, -84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Tipo Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Inicial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(44, -54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Caja"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(160, -116)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(58, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.TextBox2.Location = New System.Drawing.Point(160, -57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(58, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(44, -118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Local"
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(462, 226)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(9, 226)
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
        Me.bSalir.Location = New System.Drawing.Point(568, 226)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 2
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'lFolios
        '
        Me.lFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lFolios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lFolios.ForeColor = System.Drawing.Color.White
        Me.lFolios.Location = New System.Drawing.Point(427, 59)
        Me.lFolios.Name = "lFolios"
        Me.lFolios.Size = New System.Drawing.Size(241, 18)
        Me.lFolios.TabIndex = 132
        Me.lFolios.Text = "Folios Autorizados por SII"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(412, 18)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Correlativo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WinDeco1.Size = New System.Drawing.Size(680, 50)
        Me.WinDeco1.TabIndex = 134
        Me.WinDeco1.TituloVentana = "Mantenedor de Correlativos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ManCorrelativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(680, 275)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lFolios)
        Me.Controls.Add(Me.fFolios)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManCorrelativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Correlativos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.fFolios.ResumeLayout(False)
        Me.fFolios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bGuardar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents xLocal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents xCaja As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents xCorrelativo As TextBox
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents fFolios As GroupBox
    Friend WithEvents xFinal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xInicial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dFechaCAF As DateTimePicker
    Friend WithEvents Label7 As Label
    
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lFolios As Label
    Friend WithEvents oCompartir As CustomCheck
    Friend WithEvents Label8 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
