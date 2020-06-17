<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contadores_DTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contadores_DTE))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gDatosCliente = New System.Windows.Forms.GroupBox()
        Me.bBuscarCli = New Rebusco.SearchButton()
        Me.xRut = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xBEe = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.bEmitidos = New System.Windows.Forms.Button()
        Me.xEmitidos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xOCe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xNDe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.xNCe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xGDe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xFVe = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xFEe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xFCe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xBVe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.xBEr = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.bRecibidos = New System.Windows.Forms.Button()
        Me.xRecibidos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.xOCr = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.xNDr = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xNCr = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.xGDr = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.xFVr = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.xFEr = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.xFCr = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.xBVr = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.bTotales = New System.Windows.Forms.Button()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.oAcumular = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.gDatosCliente.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 16)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Rango de Fechas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 61)
        Me.GroupBox1.TabIndex = 139
        Me.GroupBox1.TabStop = False
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(133, 30)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(97, 21)
        Me.dHasta.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(109, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "al"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(6, 30)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(97, 21)
        Me.dDesde.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 16)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gDatosCliente
        '
        Me.gDatosCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDatosCliente.BackColor = System.Drawing.Color.Transparent
        Me.gDatosCliente.Controls.Add(Me.bBuscarCli)
        Me.gDatosCliente.Controls.Add(Me.xNombre)
        Me.gDatosCliente.Controls.Add(Me.xRut)
        Me.gDatosCliente.Location = New System.Drawing.Point(12, 117)
        Me.gDatosCliente.Name = "gDatosCliente"
        Me.gDatosCliente.Size = New System.Drawing.Size(618, 51)
        Me.gDatosCliente.TabIndex = 141
        Me.gDatosCliente.TabStop = False
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
        Me.bBuscarCli.Location = New System.Drawing.Point(584, 18)
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
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xRut.Location = New System.Drawing.Point(5, 21)
        Me.xRut.Name = "xRut"
        Me.xRut.Size = New System.Drawing.Size(100, 21)
        Me.xRut.TabIndex = 0
        '
        'xNombre
        '
        Me.xNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombre.Location = New System.Drawing.Point(112, 21)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(469, 21)
        Me.xNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(618, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Documentos Emitidos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.xBEe)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.bEmitidos)
        Me.GroupBox3.Controls.Add(Me.xEmitidos)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.xOCe)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.xNDe)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.xNCe)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.xGDe)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.xFVe)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.xFEe)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.xFCe)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.xBVe)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(618, 74)
        Me.GroupBox3.TabIndex = 143
        Me.GroupBox3.TabStop = False
        '
        'xBEe
        '
        Me.xBEe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xBEe.Location = New System.Drawing.Point(59, 42)
        Me.xBEe.Name = "xBEe"
        Me.xBEe.Size = New System.Drawing.Size(44, 22)
        Me.xBEe.TabIndex = 159
        Me.xBEe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(59, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 18)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "BE"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bEmitidos
        '
        Me.bEmitidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEmitidos.Location = New System.Drawing.Point(585, 42)
        Me.bEmitidos.Name = "bEmitidos"
        Me.bEmitidos.Size = New System.Drawing.Size(28, 22)
        Me.bEmitidos.TabIndex = 157
        Me.bEmitidos.Text = "+"
        Me.bEmitidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bEmitidos.UseVisualStyleBackColor = True
        '
        'xEmitidos
        '
        Me.xEmitidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xEmitidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xEmitidos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xEmitidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.xEmitidos.Location = New System.Drawing.Point(479, 42)
        Me.xEmitidos.Name = "xEmitidos"
        Me.xEmitidos.Size = New System.Drawing.Size(102, 21)
        Me.xEmitidos.TabIndex = 156
        Me.xEmitidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(479, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 18)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "TOTAL"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xOCe
        '
        Me.xOCe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOCe.Location = New System.Drawing.Point(408, 42)
        Me.xOCe.Name = "xOCe"
        Me.xOCe.Size = New System.Drawing.Size(44, 22)
        Me.xOCe.TabIndex = 154
        Me.xOCe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.xOCe.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(408, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "OC"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'xNDe
        '
        Me.xNDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNDe.Location = New System.Drawing.Point(358, 42)
        Me.xNDe.Name = "xNDe"
        Me.xNDe.Size = New System.Drawing.Size(44, 22)
        Me.xNDe.TabIndex = 152
        Me.xNDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(358, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "ND"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xNCe
        '
        Me.xNCe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNCe.Location = New System.Drawing.Point(308, 42)
        Me.xNCe.Name = "xNCe"
        Me.xNCe.Size = New System.Drawing.Size(44, 22)
        Me.xNCe.TabIndex = 150
        Me.xNCe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(308, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "NC"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xGDe
        '
        Me.xGDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xGDe.Location = New System.Drawing.Point(258, 42)
        Me.xGDe.Name = "xGDe"
        Me.xGDe.Size = New System.Drawing.Size(44, 22)
        Me.xGDe.TabIndex = 148
        Me.xGDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(258, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 18)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "GD"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xFVe
        '
        Me.xFVe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFVe.Location = New System.Drawing.Point(208, 42)
        Me.xFVe.Name = "xFVe"
        Me.xFVe.Size = New System.Drawing.Size(44, 22)
        Me.xFVe.TabIndex = 146
        Me.xFVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(208, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "FV"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xFEe
        '
        Me.xFEe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFEe.Location = New System.Drawing.Point(158, 42)
        Me.xFEe.Name = "xFEe"
        Me.xFEe.Size = New System.Drawing.Size(44, 22)
        Me.xFEe.TabIndex = 144
        Me.xFEe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(158, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "FE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xFCe
        '
        Me.xFCe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFCe.Location = New System.Drawing.Point(108, 42)
        Me.xFCe.Name = "xFCe"
        Me.xFCe.Size = New System.Drawing.Size(44, 22)
        Me.xFCe.TabIndex = 142
        Me.xFCe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(108, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "FC"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xBVe
        '
        Me.xBVe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xBVe.Location = New System.Drawing.Point(9, 42)
        Me.xBVe.Name = "xBVe"
        Me.xBVe.Size = New System.Drawing.Size(44, 22)
        Me.xBVe.TabIndex = 140
        Me.xBVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "BV"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 251)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(618, 16)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "Documentos Recibidos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.xBEr)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.bRecibidos)
        Me.GroupBox4.Controls.Add(Me.xRecibidos)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.xOCr)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.xNDr)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.xNCr)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.xGDr)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.xFVr)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.xFEr)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.xFCr)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.xBVr)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(618, 74)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        '
        'xBEr
        '
        Me.xBEr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xBEr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xBEr.Location = New System.Drawing.Point(59, 42)
        Me.xBEr.Name = "xBEr"
        Me.xBEr.Size = New System.Drawing.Size(44, 21)
        Me.xBEr.TabIndex = 160
        Me.xBEr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(59, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 18)
        Me.Label26.TabIndex = 159
        Me.Label26.Text = "BE"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bRecibidos
        '
        Me.bRecibidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRecibidos.Location = New System.Drawing.Point(585, 42)
        Me.bRecibidos.Name = "bRecibidos"
        Me.bRecibidos.Size = New System.Drawing.Size(28, 21)
        Me.bRecibidos.TabIndex = 158
        Me.bRecibidos.Text = "+"
        Me.bRecibidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bRecibidos.UseVisualStyleBackColor = True
        '
        'xRecibidos
        '
        Me.xRecibidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xRecibidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xRecibidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xRecibidos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xRecibidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.xRecibidos.Location = New System.Drawing.Point(479, 42)
        Me.xRecibidos.Name = "xRecibidos"
        Me.xRecibidos.Size = New System.Drawing.Size(102, 21)
        Me.xRecibidos.TabIndex = 156
        Me.xRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(479, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 18)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "TOTAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xOCr
        '
        Me.xOCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xOCr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xOCr.Location = New System.Drawing.Point(408, 42)
        Me.xOCr.Name = "xOCr"
        Me.xOCr.Size = New System.Drawing.Size(44, 21)
        Me.xOCr.TabIndex = 154
        Me.xOCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.xOCr.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(408, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 18)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "OC"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label16.Visible = False
        '
        'xNDr
        '
        Me.xNDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNDr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNDr.Location = New System.Drawing.Point(358, 42)
        Me.xNDr.Name = "xNDr"
        Me.xNDr.Size = New System.Drawing.Size(44, 21)
        Me.xNDr.TabIndex = 152
        Me.xNDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(358, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 18)
        Me.Label17.TabIndex = 151
        Me.Label17.Text = "ND"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xNCr
        '
        Me.xNCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNCr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNCr.Location = New System.Drawing.Point(308, 42)
        Me.xNCr.Name = "xNCr"
        Me.xNCr.Size = New System.Drawing.Size(44, 21)
        Me.xNCr.TabIndex = 150
        Me.xNCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(308, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 18)
        Me.Label18.TabIndex = 149
        Me.Label18.Text = "NC"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xGDr
        '
        Me.xGDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xGDr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xGDr.Location = New System.Drawing.Point(258, 42)
        Me.xGDr.Name = "xGDr"
        Me.xGDr.Size = New System.Drawing.Size(44, 21)
        Me.xGDr.TabIndex = 148
        Me.xGDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(258, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 18)
        Me.Label19.TabIndex = 147
        Me.Label19.Text = "GD"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xFVr
        '
        Me.xFVr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xFVr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xFVr.Location = New System.Drawing.Point(208, 42)
        Me.xFVr.Name = "xFVr"
        Me.xFVr.Size = New System.Drawing.Size(44, 21)
        Me.xFVr.TabIndex = 146
        Me.xFVr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(208, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 18)
        Me.Label20.TabIndex = 145
        Me.Label20.Text = "FV"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xFEr
        '
        Me.xFEr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xFEr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xFEr.Location = New System.Drawing.Point(158, 42)
        Me.xFEr.Name = "xFEr"
        Me.xFEr.Size = New System.Drawing.Size(44, 21)
        Me.xFEr.TabIndex = 144
        Me.xFEr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(158, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 18)
        Me.Label21.TabIndex = 143
        Me.Label21.Text = "FE"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xFCr
        '
        Me.xFCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xFCr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xFCr.Location = New System.Drawing.Point(108, 42)
        Me.xFCr.Name = "xFCr"
        Me.xFCr.Size = New System.Drawing.Size(44, 21)
        Me.xFCr.TabIndex = 142
        Me.xFCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(108, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 18)
        Me.Label22.TabIndex = 141
        Me.Label22.Text = "FC"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xBVr
        '
        Me.xBVr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xBVr.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xBVr.Location = New System.Drawing.Point(9, 42)
        Me.xBVr.Name = "xBVr"
        Me.xBVr.Size = New System.Drawing.Size(44, 21)
        Me.xBVr.TabIndex = 140
        Me.xBVr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(9, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 18)
        Me.Label23.TabIndex = 139
        Me.Label23.Text = "BV"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(491, 328)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(139, 19)
        Me.Label24.TabIndex = 146
        Me.Label24.Text = "Total Documentos"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.bTotales)
        Me.GroupBox5.Controls.Add(Me.xTotal)
        Me.GroupBox5.Location = New System.Drawing.Point(487, 331)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(143, 48)
        Me.GroupBox5.TabIndex = 147
        Me.GroupBox5.TabStop = False
        '
        'bTotales
        '
        Me.bTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTotales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTotales.Location = New System.Drawing.Point(110, 19)
        Me.bTotales.Name = "bTotales"
        Me.bTotales.Size = New System.Drawing.Size(28, 21)
        Me.bTotales.TabIndex = 157
        Me.bTotales.Text = "+"
        Me.bTotales.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bTotales.UseVisualStyleBackColor = True
        Me.bTotales.Visible = False
        '
        'xTotal
        '
        Me.xTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.xTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(4, 19)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(102, 21)
        Me.xTotal.TabIndex = 246
        Me.xTotal.TabStop = False
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 55
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
        Me.WinDeco1.Size = New System.Drawing.Size(642, 50)
        Me.WinDeco1.TabIndex = 154
        Me.WinDeco1.TituloVentana = "Contadores DTE"
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
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(534, 398)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(96, 36)
        Me.bCancelar.TabIndex = 149
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bConsultar
        '
        Me.bConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(530, 56)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(100, 56)
        Me.bConsultar.TabIndex = 148
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'oAcumular
        '
        Me.oAcumular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oAcumular.AutoSize = True
        Me.oAcumular.BackColor = System.Drawing.Color.Transparent
        Me.oAcumular.ForeColor = System.Drawing.Color.Blue
        Me.oAcumular.Location = New System.Drawing.Point(335, 94)
        Me.oAcumular.Name = "oAcumular"
        Me.oAcumular.Size = New System.Drawing.Size(189, 17)
        Me.oAcumular.TabIndex = 155
        Me.oAcumular.Text = "Acumular Detalles de Documentos"
        Me.oAcumular.UseVisualStyleBackColor = False
        '
        'Contadores_DTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 446)
        Me.Controls.Add(Me.oAcumular)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gDatosCliente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "Contadores_DTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contadores DTE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gDatosCliente.ResumeLayout(False)
        Me.gDatosCliente.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents gDatosCliente As GroupBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xRut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xEmitidos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents xOCe As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents xNDe As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents xNCe As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents xGDe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xFVe As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xFEe As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xFCe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xBVe As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents xRecibidos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents xOCr As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents xNDr As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents xNCr As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents xGDr As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents xFVr As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents xFEr As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents xFCr As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents xBVr As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents xTotal As TextBox
    Public WithEvents bConsultar As Button
    Public WithEvents bCancelar As Button
    Friend WithEvents bBuscarCli As SearchButton
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents oAcumular As CheckBox
    Friend WithEvents bEmitidos As Button
    Friend WithEvents bRecibidos As Button
    Friend WithEvents bTotales As Button
    Friend WithEvents xBEe As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents xBEr As TextBox
    Friend WithEvents Label26 As Label
End Class
