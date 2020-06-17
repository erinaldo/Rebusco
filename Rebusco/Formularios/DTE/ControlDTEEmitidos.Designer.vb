<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDTEEmitidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDTEEmitidos))
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.gFiltro = New System.Windows.Forms.GroupBox()
        Me.xF2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xF1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cEstados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xCantDoc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xTexto = New System.Windows.Forms.TextBox()
        Me.bEnviar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sEstado = New System.Windows.Forms.StatusStrip()
        Me.lStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tProgresoBarra = New System.Windows.Forms.ToolStripProgressBar()
        Me.lRegistros = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.mMenuTabla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.oWS = New Rebusco.CustomCheck()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.oSII = New Rebusco.CustomCheck()
        Me.oCheckTED = New Rebusco.CustomCheck()
        Me.oRapido = New Rebusco.CustomCheck()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.gFiltro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.sEstado.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mMenuTabla.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(969, 471)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 101
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
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 471)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(96, 36)
        Me.bLimpiar.TabIndex = 99
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'gFiltro
        '
        Me.gFiltro.BackColor = System.Drawing.Color.Transparent
        Me.gFiltro.Controls.Add(Me.xF2)
        Me.gFiltro.Controls.Add(Me.Label4)
        Me.gFiltro.Controls.Add(Me.xF1)
        Me.gFiltro.Controls.Add(Me.Label5)
        Me.gFiltro.Controls.Add(Me.cEstados)
        Me.gFiltro.Controls.Add(Me.Label3)
        Me.gFiltro.Controls.Add(Me.Label2)
        Me.gFiltro.Controls.Add(Me.cTipoDoc)
        Me.gFiltro.Controls.Add(Me.cLocal)
        Me.gFiltro.Controls.Add(Me.Label1)
        Me.gFiltro.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.gFiltro.Location = New System.Drawing.Point(12, 58)
        Me.gFiltro.Name = "gFiltro"
        Me.gFiltro.Size = New System.Drawing.Size(630, 82)
        Me.gFiltro.TabIndex = 117
        Me.gFiltro.TabStop = False
        '
        'xF2
        '
        Me.xF2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xF2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xF2.Location = New System.Drawing.Point(246, 20)
        Me.xF2.Name = "xF2"
        Me.xF2.Size = New System.Drawing.Size(97, 21)
        Me.xF2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(225, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "al"
        '
        'xF1
        '
        Me.xF1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xF1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xF1.Location = New System.Drawing.Point(125, 21)
        Me.xF1.Name = "xF1"
        Me.xF1.Size = New System.Drawing.Size(97, 21)
        Me.xF1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rango de Fechas"
        '
        'cEstados
        '
        Me.cEstados.BackColor = System.Drawing.Color.White
        Me.cEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstados.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstados.FormattingEnabled = True
        Me.cEstados.Location = New System.Drawing.Point(415, 52)
        Me.cEstados.Name = "cEstados"
        Me.cEstados.Size = New System.Drawing.Size(208, 23)
        Me.cEstados.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(360, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(360, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Local"
        '
        'cTipoDoc
        '
        Me.cTipoDoc.BackColor = System.Drawing.Color.White
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(126, 52)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(217, 23)
        Me.cTipoDoc.TabIndex = 2
        '
        'cLocal
        '
        Me.cLocal.BackColor = System.Drawing.Color.White
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(415, 21)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(208, 23)
        Me.cLocal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Documento"
        '
        'bConsultar
        '
        Me.bConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(950, 76)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(116, 63)
        Me.bConsultar.TabIndex = 12
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xCantDoc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xTexto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 401)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 60)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'xCantDoc
        '
        Me.xCantDoc.Enabled = False
        Me.xCantDoc.Location = New System.Drawing.Point(138, 18)
        Me.xCantDoc.Name = "xCantDoc"
        Me.xCantDoc.Size = New System.Drawing.Size(41, 20)
        Me.xCantDoc.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Cant. de Documentos"
        '
        'xTexto
        '
        Me.xTexto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xTexto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xTexto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTexto.Location = New System.Drawing.Point(185, 21)
        Me.xTexto.Multiline = True
        Me.xTexto.Name = "xTexto"
        Me.xTexto.Size = New System.Drawing.Size(557, 31)
        Me.xTexto.TabIndex = 14
        Me.xTexto.Text = "Seleccione los documentos a enviar a SII que no esten enviados o con algún error." &
    "  Si el documento está aprobado, con reparos, rechazado o ya fué enviado anterio" &
    "rmente, SII  lo rechazará de nuevo. "
        '
        'bEnviar
        '
        Me.bEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEnviar.BackColor = System.Drawing.Color.White
        Me.bEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEnviar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bEnviar.Image = Global.Rebusco.My.Resources.Resources.execute24
        Me.bEnviar.Location = New System.Drawing.Point(170, 24)
        Me.bEnviar.Name = "bEnviar"
        Me.bEnviar.Size = New System.Drawing.Size(127, 30)
        Me.bEnviar.TabIndex = 12
        Me.bEnviar.Text = "Envío a SII"
        Me.bEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bEnviar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(630, 16)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Filtros"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(748, 16)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Notas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sEstado
        '
        Me.sEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.sEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lStatus, Me.tProgresoBarra, Me.lRegistros})
        Me.sEstado.Location = New System.Drawing.Point(0, 510)
        Me.sEstado.Name = "sEstado"
        Me.sEstado.Size = New System.Drawing.Size(1078, 22)
        Me.sEstado.SizingGrip = False
        Me.sEstado.TabIndex = 139
        Me.sEstado.Text = "StatusStrip1"
        '
        'lStatus
        '
        Me.lStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lStatus.ForeColor = System.Drawing.Color.White
        Me.lStatus.Name = "lStatus"
        Me.lStatus.Size = New System.Drawing.Size(35, 17)
        Me.lStatus.Text = "Listo"
        '
        'tProgresoBarra
        '
        Me.tProgresoBarra.ForeColor = System.Drawing.Color.White
        Me.tProgresoBarra.Name = "tProgresoBarra"
        Me.tProgresoBarra.Size = New System.Drawing.Size(1000, 16)
        Me.tProgresoBarra.Value = 10
        Me.tProgresoBarra.Visible = False
        '
        'lRegistros
        '
        Me.lRegistros.Name = "lRegistros"
        Me.lRegistros.Size = New System.Drawing.Size(0, 17)
        '
        'xTabla
        '
        Me.xTabla.AllowDelete = True
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.xTabla.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(12, 143)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(1054, 252)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 116
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'mMenuTabla
        '
        Me.mMenuTabla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mConsultar, Me.mImprimir})
        Me.mMenuTabla.Name = "mMenuTabla"
        Me.mMenuTabla.Size = New System.Drawing.Size(126, 48)
        '
        'mConsultar
        '
        Me.mConsultar.Image = Global.Rebusco.My.Resources.Resources.find
        Me.mConsultar.Name = "mConsultar"
        Me.mConsultar.Size = New System.Drawing.Size(125, 22)
        Me.mConsultar.Text = "Consultar"
        '
        'mImprimir
        '
        Me.mImprimir.Image = Global.Rebusco.My.Resources.Resources.print
        Me.mImprimir.Name = "mImprimir"
        Me.mImprimir.Size = New System.Drawing.Size(125, 22)
        Me.mImprimir.Text = "Imprimir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.oWS)
        Me.GroupBox2.Controls.Add(Me.bEnviar)
        Me.GroupBox2.Location = New System.Drawing.Point(766, 398)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 63)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(303, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Especiales"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oWS
        '
        Me.oWS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oWS.Appearance = System.Windows.Forms.Appearance.Button
        Me.oWS.BackColor = System.Drawing.Color.White
        Me.oWS.Enabled = False
        Me.oWS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oWS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oWS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oWS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oWS.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oWS.ForeColor = System.Drawing.Color.Black
        Me.oWS.Image = CType(resources.GetObject("oWS.Image"), System.Drawing.Image)
        Me.oWS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oWS.Location = New System.Drawing.Point(6, 24)
        Me.oWS.Name = "oWS"
        Me.oWS.Size = New System.Drawing.Size(158, 30)
        Me.oWS.TabIndex = 143
        Me.oWS.Text = "Uso de WebService"
        Me.oWS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oWS.UseVisualStyleBackColor = False
        Me.oWS.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(648, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(418, 16)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Opciones "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oSII
        '
        Me.oSII.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSII.BackColor = System.Drawing.Color.White
        Me.oSII.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSII.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSII.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSII.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSII.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSII.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oSII.ForeColor = System.Drawing.Color.Black
        Me.oSII.Image = CType(resources.GetObject("oSII.Image"), System.Drawing.Image)
        Me.oSII.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSII.Location = New System.Drawing.Point(648, 109)
        Me.oSII.Name = "oSII"
        Me.oSII.Size = New System.Drawing.Size(217, 30)
        Me.oSII.TabIndex = 146
        Me.oSII.Text = "Consulta de Documentos SII"
        Me.oSII.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSII.UseVisualStyleBackColor = False
        '
        'oCheckTED
        '
        Me.oCheckTED.Appearance = System.Windows.Forms.Appearance.Button
        Me.oCheckTED.BackColor = System.Drawing.Color.White
        Me.oCheckTED.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.oCheckTED.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oCheckTED.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oCheckTED.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oCheckTED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oCheckTED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oCheckTED.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oCheckTED.ForeColor = System.Drawing.Color.Black
        Me.oCheckTED.Image = CType(resources.GetObject("oCheckTED.Image"), System.Drawing.Image)
        Me.oCheckTED.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.oCheckTED.Location = New System.Drawing.Point(871, 76)
        Me.oCheckTED.Name = "oCheckTED"
        Me.oCheckTED.Size = New System.Drawing.Size(73, 63)
        Me.oCheckTED.TabIndex = 141
        Me.oCheckTED.Text = "Chequear TED"
        Me.oCheckTED.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.oCheckTED.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.oCheckTED.UseVisualStyleBackColor = False
        '
        'oRapido
        '
        Me.oRapido.Appearance = System.Windows.Forms.Appearance.Button
        Me.oRapido.BackColor = System.Drawing.Color.White
        Me.oRapido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oRapido.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oRapido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oRapido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oRapido.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oRapido.ForeColor = System.Drawing.Color.Black
        Me.oRapido.Image = CType(resources.GetObject("oRapido.Image"), System.Drawing.Image)
        Me.oRapido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oRapido.Location = New System.Drawing.Point(648, 76)
        Me.oRapido.Name = "oRapido"
        Me.oRapido.Size = New System.Drawing.Size(217, 30)
        Me.oRapido.TabIndex = 140
        Me.oRapido.Text = "Consulta Rápida de Documentos"
        Me.oRapido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oRapido.UseVisualStyleBackColor = False
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 65
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
        Me.WinDeco1.Size = New System.Drawing.Size(1078, 50)
        Me.WinDeco1.TabIndex = 147
        Me.WinDeco1.TituloVentana = "Control DTE Emitidos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ControlDTEEmitidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 532)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.oSII)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.oCheckTED)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.oRapido)
        Me.Controls.Add(Me.sEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gFiltro)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ControlDTEEmitidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control DTE Emitidos"
        Me.gFiltro.ResumeLayout(False)
        Me.gFiltro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.sEstado.ResumeLayout(False)
        Me.sEstado.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mMenuTabla.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents bCancelar As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents gFiltro As GroupBox
    Friend WithEvents cEstados As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xF2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents xF1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Public WithEvents bConsultar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bEnviar As Button
    Friend WithEvents xTexto As TextBox
    
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents sEstado As StatusStrip
    Friend WithEvents lStatus As ToolStripStatusLabel
    Friend WithEvents tProgresoBarra As ToolStripProgressBar
    Friend WithEvents oWS As CustomCheck
    Friend WithEvents oCheckTED As CustomCheck
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents oRapido As CustomCheck
    Friend WithEvents mMenuTabla As ContextMenuStrip
    Friend WithEvents mConsultar As ToolStripMenuItem
    Friend WithEvents mImprimir As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xCantDoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lRegistros As ToolStripStatusLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents oSII As CustomCheck
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
