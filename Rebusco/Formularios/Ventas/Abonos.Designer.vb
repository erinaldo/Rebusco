Imports WinDecoX.WinDeco
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Abonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Abonos))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchButton1 = New Rebusco.SearchButton()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.xFecha = New System.Windows.Forms.DateTimePicker()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xObservacion = New System.Windows.Forms.TextBox()
        Me.cFPagos = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xMonto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.xInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(621, 16)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SearchButton1)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 62)
        Me.GroupBox1.TabIndex = 242
        Me.GroupBox1.TabStop = False
        '
        'SearchButton1
        '
        Me.SearchButton1.CampoBuscar1 = "Nombre"
        Me.SearchButton1.CampoBuscar2 = ""
        Me.SearchButton1.CamposAdicionales = ""
        Me.SearchButton1.ControlCarga = Me.xCliente
        Me.SearchButton1.ControlFocus = Me.xFecha
        Me.SearchButton1.Filtro = ""
        Me.SearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SearchButton1.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton1.IDBusqueda = "Cliente"
        Me.SearchButton1.Image = CType(resources.GetObject("SearchButton1.Image"), System.Drawing.Image)
        Me.SearchButton1.Location = New System.Drawing.Point(528, 25)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(87, 27)
        Me.SearchButton1.TabIndex = 135
        Me.SearchButton1.TablaBusqueda = "Clientes"
        Me.SearchButton1.Text = "Buscar"
        Me.SearchButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton1.Titulo = "Clientes"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.Location = New System.Drawing.Point(88, 27)
        Me.xCliente.MaxLength = 18
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(88, 21)
        Me.xCliente.TabIndex = 132
        Me.xCliente.TabStop = False
        Me.xCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xFecha
        '
        Me.xFecha.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xFecha.Location = New System.Drawing.Point(88, 23)
        Me.xFecha.Name = "xFecha"
        Me.xFecha.Size = New System.Drawing.Size(97, 21)
        Me.xFecha.TabIndex = 117
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombre.Location = New System.Drawing.Point(182, 27)
        Me.xNombre.MaxLength = 50
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(340, 21)
        Me.xNombre.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Cliente"
        '
        'xUsuario
        '
        Me.xUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xUsuario.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xUsuario.Location = New System.Drawing.Point(88, 27)
        Me.xUsuario.MaxLength = 50
        Me.xUsuario.Name = "xUsuario"
        Me.xUsuario.ReadOnly = True
        Me.xUsuario.Size = New System.Drawing.Size(266, 21)
        Me.xUsuario.TabIndex = 134
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xLocal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.xUsuario)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 59)
        Me.GroupBox2.TabIndex = 243
        Me.GroupBox2.TabStop = False
        '
        'xLocal
        '
        Me.xLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xLocal.Location = New System.Drawing.Point(405, 27)
        Me.xLocal.MaxLength = 50
        Me.xLocal.Name = "xLocal"
        Me.xLocal.ReadOnly = True
        Me.xLocal.Size = New System.Drawing.Size(210, 21)
        Me.xLocal.TabIndex = 136
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(360, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Local"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(621, 16)
        Me.Label3.TabIndex = 244
        Me.Label3.Text = "Usuario / Local"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(514, 16)
        Me.Label6.TabIndex = 245
        Me.Label6.Text = "Abono"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.xObservacion)
        Me.GroupBox3.Controls.Add(Me.cFPagos)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.xMonto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.xFecha)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(514, 114)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 15)
        Me.Label12.TabIndex = 329
        Me.Label12.Text = "Observaciòn"
        '
        'xObservacion
        '
        Me.xObservacion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xObservacion.Location = New System.Drawing.Point(88, 79)
        Me.xObservacion.MaxLength = 18
        Me.xObservacion.Name = "xObservacion"
        Me.xObservacion.Size = New System.Drawing.Size(419, 21)
        Me.xObservacion.TabIndex = 1
        '
        'cFPagos
        '
        Me.cFPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPagos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFPagos.FormattingEnabled = True
        Me.cFPagos.Location = New System.Drawing.Point(294, 23)
        Me.cFPagos.Name = "cFPagos"
        Me.cFPagos.Size = New System.Drawing.Size(213, 23)
        Me.cFPagos.TabIndex = 265
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(191, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 15)
        Me.Label13.TabIndex = 264
        Me.Label13.Text = "Forma de Pago"
        '
        'xMonto
        '
        Me.xMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xMonto.Location = New System.Drawing.Point(88, 51)
        Me.xMonto.MaxLength = 18
        Me.xMonto.Name = "xMonto"
        Me.xMonto.Size = New System.Drawing.Size(97, 22)
        Me.xMonto.TabIndex = 0
        Me.xMonto.TabStop = False
        Me.xMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Monto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Fecha"
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.xTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(12, 309)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.Size = New System.Drawing.Size(620, 97)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 247
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bGuardar
        '
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.load24
        Me.bGuardar.Location = New System.Drawing.Point(532, 267)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(96, 36)
        Me.bGuardar.TabIndex = 1
        Me.bGuardar.Text = "Agregar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(532, 423)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(430, 423)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(96, 36)
        Me.bImprimir.TabIndex = 2
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'xInfo
        '
        Me.xInfo.AutoPopDelay = 5000
        Me.xInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.xInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.xInfo.InitialDelay = 200
        Me.xInfo.OwnerDraw = True
        Me.xInfo.ReshowDelay = 100
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
        Me.WinDeco1.Size = New System.Drawing.Size(644, 50)
        Me.WinDeco1.TabIndex = 251
        Me.WinDeco1.TituloVentana = "Abonos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Abonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 471)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "Abonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abonos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xLocal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents xMonto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xFecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cFPagos As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents xObservacion As TextBox
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bGuardar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bImprimir As Button
    Friend WithEvents SearchButton1 As SearchButton
    Public WithEvents xInfo As ToolTip
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
