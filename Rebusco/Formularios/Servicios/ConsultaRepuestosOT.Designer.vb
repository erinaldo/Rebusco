<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaRepuestosOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaRepuestosOT))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.cTecnicos = New System.Windows.Forms.ComboBox()
        Me.xTecnico = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xNombreArticulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cEstados = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xOT = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cHasta = New System.Windows.Forms.DateTimePicker()
        Me.cDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bMostrar = New System.Windows.Forms.Button()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tCantidadR = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.oFechaSol = New Rebusco.CustomRadio()
        Me.oFechaEnt = New Rebusco.CustomRadio()
        Me.oImprimir = New Rebusco.CustomCheck()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xArticulo)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.cTecnicos)
        Me.GroupBox1.Controls.Add(Me.xTecnico)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xNombreArticulo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cEstados)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xOT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 142)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 500
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = ""
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = "TipoArticulo = 'P'"
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(77, 81)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(100, 22)
        Me.xArticulo.TabIndex = 255
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.White
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscar.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscar.Location = New System.Drawing.Point(526, 79)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(79, 27)
        Me.bBuscar.TabIndex = 254
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'cTecnicos
        '
        Me.cTecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTecnicos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTecnicos.FormattingEnabled = True
        Me.cTecnicos.Location = New System.Drawing.Point(183, 111)
        Me.cTecnicos.Name = "cTecnicos"
        Me.cTecnicos.Size = New System.Drawing.Size(337, 23)
        Me.cTecnicos.TabIndex = 250
        '
        'xTecnico
        '
        Me.xTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTecnico.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTecnico.Location = New System.Drawing.Point(77, 111)
        Me.xTecnico.Name = "xTecnico"
        Me.xTecnico.Size = New System.Drawing.Size(100, 21)
        Me.xTecnico.TabIndex = 249
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(16, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "Técnico"
        '
        'xNombreArticulo
        '
        Me.xNombreArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreArticulo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreArticulo.Location = New System.Drawing.Point(183, 82)
        Me.xNombreArticulo.Name = "xNombreArticulo"
        Me.xNombreArticulo.ReadOnly = True
        Me.xNombreArticulo.Size = New System.Drawing.Size(337, 21)
        Me.xNombreArticulo.TabIndex = 247
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(16, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "Artíiculo"
        '
        'cEstados
        '
        Me.cEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstados.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstados.FormattingEnabled = True
        Me.cEstados.Location = New System.Drawing.Point(77, 52)
        Me.cEstados.Name = "cEstados"
        Me.cEstados.Size = New System.Drawing.Size(185, 23)
        Me.cEstados.TabIndex = 244
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 15)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "OT"
        '
        'xOT
        '
        Me.xOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xOT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xOT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xOT.Location = New System.Drawing.Point(77, 23)
        Me.xOT.Name = "xOT"
        Me.xOT.Size = New System.Drawing.Size(100, 21)
        Me.xOT.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cHasta)
        Me.GroupBox2.Controls.Add(Me.cDesde)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(631, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 99)
        Me.GroupBox2.TabIndex = 253
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 251
        Me.Label1.Text = "Hasta"
        '
        'cHasta
        '
        Me.cHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cHasta.Location = New System.Drawing.Point(63, 67)
        Me.cHasta.Name = "cHasta"
        Me.cHasta.Size = New System.Drawing.Size(97, 21)
        Me.cHasta.TabIndex = 1
        '
        'cDesde
        '
        Me.cDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cDesde.Location = New System.Drawing.Point(61, 39)
        Me.cDesde.Name = "cDesde"
        Me.cDesde.Size = New System.Drawing.Size(99, 21)
        Me.cDesde.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Desde"
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = resources.GetString("xTabla.ColumnInfo")
        Me.xTabla.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(12, 211)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.Size = New System.Drawing.Size(857, 242)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 233
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 461)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 239
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
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(663, 461)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 240
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(769, 461)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 241
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bMostrar
        '
        Me.bMostrar.BackColor = System.Drawing.Color.White
        Me.bMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMostrar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bMostrar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bMostrar.Location = New System.Drawing.Point(764, 164)
        Me.bMostrar.Name = "bMostrar"
        Me.bMostrar.Size = New System.Drawing.Size(104, 36)
        Me.bMostrar.TabIndex = 254
        Me.bMostrar.Text = "Consultar"
        Me.bMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bMostrar.UseVisualStyleBackColor = False
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso, Me.tCantidadR})
        Me.sBarra.Location = New System.Drawing.Point(0, 500)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(879, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 255
        Me.sBarra.Text = "StatusStrip1"
        '
        'tMensajeBarra
        '
        Me.tMensajeBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tMensajeBarra.ForeColor = System.Drawing.Color.White
        Me.tMensajeBarra.Name = "tMensajeBarra"
        Me.tMensajeBarra.Size = New System.Drawing.Size(35, 17)
        Me.tMensajeBarra.Text = "Listo"
        '
        'tBarraProgreso
        '
        Me.tBarraProgreso.BackColor = System.Drawing.Color.White
        Me.tBarraProgreso.ForeColor = System.Drawing.Color.Black
        Me.tBarraProgreso.Name = "tBarraProgreso"
        Me.tBarraProgreso.Size = New System.Drawing.Size(100, 16)
        Me.tBarraProgreso.Step = 5
        Me.tBarraProgreso.Value = 70
        Me.tBarraProgreso.Visible = False
        '
        'tCantidadR
        '
        Me.tCantidadR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tCantidadR.ForeColor = System.Drawing.Color.White
        Me.tCantidadR.Name = "tCantidadR"
        Me.tCantidadR.Size = New System.Drawing.Size(829, 17)
        Me.tCantidadR.Spring = True
        Me.tCantidadR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(613, 16)
        Me.Label14.TabIndex = 261
        Me.Label14.Text = "Filtros"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oFechaSol
        '
        Me.oFechaSol.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFechaSol.BackColor = System.Drawing.Color.White
        Me.oFechaSol.Checked = True
        Me.oFechaSol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaSol.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaSol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFechaSol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFechaSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFechaSol.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oFechaSol.ForeColor = System.Drawing.Color.White
        Me.oFechaSol.Image = CType(resources.GetObject("oFechaSol.Image"), System.Drawing.Image)
        Me.oFechaSol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oFechaSol.Location = New System.Drawing.Point(631, 56)
        Me.oFechaSol.Name = "oFechaSol"
        Me.oFechaSol.Size = New System.Drawing.Size(119, 28)
        Me.oFechaSol.TabIndex = 262
        Me.oFechaSol.TabStop = True
        Me.oFechaSol.Text = "Fecha Solicitud"
        Me.oFechaSol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFechaSol.UseVisualStyleBackColor = False
        '
        'oFechaEnt
        '
        Me.oFechaEnt.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFechaEnt.BackColor = System.Drawing.Color.White
        Me.oFechaEnt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaEnt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaEnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFechaEnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFechaEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFechaEnt.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oFechaEnt.ForeColor = System.Drawing.Color.Black
        Me.oFechaEnt.Image = CType(resources.GetObject("oFechaEnt.Image"), System.Drawing.Image)
        Me.oFechaEnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oFechaEnt.Location = New System.Drawing.Point(750, 56)
        Me.oFechaEnt.Name = "oFechaEnt"
        Me.oFechaEnt.Size = New System.Drawing.Size(119, 28)
        Me.oFechaEnt.TabIndex = 263
        Me.oFechaEnt.Text = "Fecha Entrega"
        Me.oFechaEnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFechaEnt.UseVisualStyleBackColor = False
        '
        'oImprimir
        '
        Me.oImprimir.Appearance = System.Windows.Forms.Appearance.Button
        Me.oImprimir.BackColor = System.Drawing.Color.White
        Me.oImprimir.Checked = True
        Me.oImprimir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.oImprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oImprimir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.oImprimir.ForeColor = System.Drawing.Color.White
        Me.oImprimir.Image = CType(resources.GetObject("oImprimir.Image"), System.Drawing.Image)
        Me.oImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oImprimir.Location = New System.Drawing.Point(470, 464)
        Me.oImprimir.Name = "oImprimir"
        Me.oImprimir.Size = New System.Drawing.Size(187, 30)
        Me.oImprimir.TabIndex = 263
        Me.oImprimir.Text = "Imprimir Automáticamente"
        Me.oImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oImprimir.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(879, 50)
        Me.WinDeco1.TabIndex = 264
        Me.WinDeco1.TituloVentana = "Consulta de Repuestos OT"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ConsultaRepuestosOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 522)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.oImprimir)
        Me.Controls.Add(Me.oFechaEnt)
        Me.Controls.Add(Me.oFechaSol)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.sBarra)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bMostrar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaRepuestosOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Repuestos OT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sBarra.ResumeLayout(False)
        Me.sBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xOT As TextBox
    Friend WithEvents cEstados As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents xNombreArticulo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cTecnicos As ComboBox
    Friend WithEvents xTecnico As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cDesde As DateTimePicker
    Public WithEvents bBuscar As Button
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button
    
    Public WithEvents bMostrar As Button
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents tCantidadR As ToolStripStatusLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents oFechaSol As CustomRadio
    Friend WithEvents oFechaEnt As CustomRadio
    Friend WithEvents oImprimir As CustomCheck
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents xArticulo As TextBoxAutoComple
End Class
