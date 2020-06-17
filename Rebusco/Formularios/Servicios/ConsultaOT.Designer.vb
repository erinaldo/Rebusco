<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaOT
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaOT))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bBuscarC = New Rebusco.SearchButton()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.xNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cHasta = New System.Windows.Forms.DateTimePicker()
        Me.oFechaEnt = New Rebusco.CustomRadio()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oFechaOT = New Rebusco.CustomRadio()
        Me.cDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cTecnicos = New System.Windows.Forms.ComboBox()
        Me.xTecnico = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xOT = New System.Windows.Forms.TextBox()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bIngresoOT = New System.Windows.Forms.Button()
        Me.bAnulacionOT = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bMostrar = New System.Windows.Forms.Button()
        Me.oAutomatico = New Rebusco.CustomCheck()
        Me.mMenuTabla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mImprimirOT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mServicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mMenuTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.bBuscarC)
        Me.GroupBox4.Controls.Add(Me.xNombreCliente)
        Me.GroupBox4.Controls.Add(Me.cLocal)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.bMostrar)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.xCliente)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cEstado)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cTecnicos)
        Me.GroupBox4.Controls.Add(Me.xTecnico)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.xOT)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1067, 167)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'bBuscarC
        '
        Me.bBuscarC.CampoBuscar1 = "Nombre"
        Me.bBuscarC.CampoBuscar2 = ""
        Me.bBuscarC.CamposAdicionales = ""
        Me.bBuscarC.ControlCarga = Me.xCliente
        Me.bBuscarC.ControlFocus = Me.cLocal
        Me.bBuscarC.Filtro = ""
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarC.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarC.IDBusqueda = "Cliente"
        Me.bBuscarC.Image = CType(resources.GetObject("bBuscarC.Image"), System.Drawing.Image)
        Me.bBuscarC.Location = New System.Drawing.Point(502, 106)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(82, 27)
        Me.bBuscarC.TabIndex = 38
        Me.bBuscarC.TablaBusqueda = "Clientes"
        Me.bBuscarC.Text = "Buscar"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.Titulo = "Clientes"
        Me.bBuscarC.UseVisualStyleBackColor = True
        '
        'xCliente
        '
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.Location = New System.Drawing.Point(75, 109)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(63, 21)
        Me.xCliente.TabIndex = 4
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(75, 136)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(194, 23)
        Me.cLocal.TabIndex = 246
        '
        'xNombreCliente
        '
        Me.xNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreCliente.Location = New System.Drawing.Point(144, 109)
        Me.xNombreCliente.Name = "xNombreCliente"
        Me.xNombreCliente.Size = New System.Drawing.Size(351, 21)
        Me.xNombreCliente.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(11, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 247
        Me.Label8.Text = "Local"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(-3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1075, 19)
        Me.Label14.TabIndex = 248
        Me.Label14.Text = " OT / Cliente / Técnico"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Cliente"
        '
        'cEstado
        '
        Me.cEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstado.FormattingEnabled = True
        Me.cEstado.Location = New System.Drawing.Point(75, 80)
        Me.cEstado.Name = "cEstado"
        Me.cEstado.Size = New System.Drawing.Size(194, 23)
        Me.cEstado.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cHasta)
        Me.GroupBox1.Controls.Add(Me.oFechaEnt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.oFechaOT)
        Me.GroupBox1.Controls.Add(Me.cDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(590, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 77)
        Me.GroupBox1.TabIndex = 236
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(362, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "Hasta"
        '
        'cHasta
        '
        Me.cHasta.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cHasta.Location = New System.Drawing.Point(365, 38)
        Me.cHasta.Name = "cHasta"
        Me.cHasta.Size = New System.Drawing.Size(103, 22)
        Me.cHasta.TabIndex = 1
        '
        'oFechaEnt
        '
        Me.oFechaEnt.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFechaEnt.BackColor = System.Drawing.Color.White
        Me.oFechaEnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oFechaEnt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaEnt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaEnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFechaEnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFechaEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFechaEnt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFechaEnt.ForeColor = System.Drawing.Color.Black
        Me.oFechaEnt.Image = CType(resources.GetObject("oFechaEnt.Image"), System.Drawing.Image)
        Me.oFechaEnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oFechaEnt.Location = New System.Drawing.Point(115, 33)
        Me.oFechaEnt.Name = "oFechaEnt"
        Me.oFechaEnt.Size = New System.Drawing.Size(105, 27)
        Me.oFechaEnt.TabIndex = 250
        Me.oFechaEnt.Text = "Fecha Cierre"
        Me.oFechaEnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFechaEnt.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(250, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Desde"
        '
        'oFechaOT
        '
        Me.oFechaOT.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFechaOT.BackColor = System.Drawing.Color.White
        Me.oFechaOT.Checked = True
        Me.oFechaOT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oFechaOT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaOT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFechaOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFechaOT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFechaOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFechaOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFechaOT.ForeColor = System.Drawing.Color.White
        Me.oFechaOT.Image = CType(resources.GetObject("oFechaOT.Image"), System.Drawing.Image)
        Me.oFechaOT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oFechaOT.Location = New System.Drawing.Point(6, 33)
        Me.oFechaOT.Name = "oFechaOT"
        Me.oFechaOT.Size = New System.Drawing.Size(105, 27)
        Me.oFechaOT.TabIndex = 249
        Me.oFechaOT.TabStop = True
        Me.oFechaOT.Text = "Fecha OT"
        Me.oFechaOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFechaOT.UseVisualStyleBackColor = False
        '
        'cDesde
        '
        Me.cDesde.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cDesde.Location = New System.Drawing.Point(253, 38)
        Me.cDesde.Name = "cDesde"
        Me.cDesde.Size = New System.Drawing.Size(103, 22)
        Me.cDesde.TabIndex = 0
        Me.cDesde.Value = New Date(2020, 1, 1, 14, 28, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Estado"
        '
        'cTecnicos
        '
        Me.cTecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTecnicos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTecnicos.FormattingEnabled = True
        Me.cTecnicos.Location = New System.Drawing.Point(144, 51)
        Me.cTecnicos.Name = "cTecnicos"
        Me.cTecnicos.Size = New System.Drawing.Size(351, 23)
        Me.cTecnicos.TabIndex = 2
        '
        'xTecnico
        '
        Me.xTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTecnico.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTecnico.Location = New System.Drawing.Point(75, 51)
        Me.xTecnico.Name = "xTecnico"
        Me.xTecnico.Size = New System.Drawing.Size(63, 21)
        Me.xTecnico.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Técnico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "OT"
        '
        'xOT
        '
        Me.xOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xOT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xOT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xOT.Location = New System.Drawing.Point(75, 24)
        Me.xOT.MaxLength = 18
        Me.xOT.Name = "xOT"
        Me.xOT.Size = New System.Drawing.Size(110, 21)
        Me.xOT.TabIndex = 0
        Me.xOT.Tag = "99"
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = resources.GetString("xTabla.ColumnInfo")
        Me.xTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(12, 233)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.Size = New System.Drawing.Size(1067, 248)
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
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(12, 511)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 1
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bIngresoOT
        '
        Me.bIngresoOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bIngresoOT.BackColor = System.Drawing.Color.White
        Me.bIngresoOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIngresoOT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bIngresoOT.Image = Global.Rebusco.My.Resources.Resources.new24
        Me.bIngresoOT.Location = New System.Drawing.Point(118, 511)
        Me.bIngresoOT.Name = "bIngresoOT"
        Me.bIngresoOT.Size = New System.Drawing.Size(133, 36)
        Me.bIngresoOT.TabIndex = 2
        Me.bIngresoOT.Text = "Ingreso de OT"
        Me.bIngresoOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bIngresoOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bIngresoOT.UseVisualStyleBackColor = False
        '
        'bAnulacionOT
        '
        Me.bAnulacionOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAnulacionOT.BackColor = System.Drawing.Color.White
        Me.bAnulacionOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAnulacionOT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAnulacionOT.Image = Global.Rebusco.My.Resources.Resources.null24
        Me.bAnulacionOT.Location = New System.Drawing.Point(257, 511)
        Me.bAnulacionOT.Name = "bAnulacionOT"
        Me.bAnulacionOT.Size = New System.Drawing.Size(100, 36)
        Me.bAnulacionOT.TabIndex = 3
        Me.bAnulacionOT.Text = "Anular"
        Me.bAnulacionOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAnulacionOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAnulacionOT.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(873, 511)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 4
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
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(979, 511)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 5
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bMostrar
        '
        Me.bMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMostrar.BackColor = System.Drawing.Color.White
        Me.bMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMostrar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bMostrar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bMostrar.Location = New System.Drawing.Point(961, 123)
        Me.bMostrar.Name = "bMostrar"
        Me.bMostrar.Size = New System.Drawing.Size(100, 36)
        Me.bMostrar.TabIndex = 242
        Me.bMostrar.Text = "Consultar"
        Me.bMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bMostrar.UseVisualStyleBackColor = False
        '
        'oAutomatico
        '
        Me.oAutomatico.Appearance = System.Windows.Forms.Appearance.Button
        Me.oAutomatico.BackColor = System.Drawing.Color.White
        Me.oAutomatico.Checked = True
        Me.oAutomatico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oAutomatico.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.oAutomatico.FlatAppearance.BorderSize = 2
        Me.oAutomatico.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAutomatico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oAutomatico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oAutomatico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oAutomatico.ForeColor = System.Drawing.Color.White
        Me.oAutomatico.Image = CType(resources.GetObject("oAutomatico.Image"), System.Drawing.Image)
        Me.oAutomatico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oAutomatico.Location = New System.Drawing.Point(685, 514)
        Me.oAutomatico.Name = "oAutomatico"
        Me.oAutomatico.Size = New System.Drawing.Size(182, 30)
        Me.oAutomatico.TabIndex = 251
        Me.oAutomatico.Text = "Imprimir Automáticamente"
        Me.oAutomatico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oAutomatico.UseVisualStyleBackColor = False
        '
        'mMenuTabla
        '
        Me.mMenuTabla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mModificar, Me.mImprimirOT, Me.mServicio})
        Me.mMenuTabla.Name = "mMenuTabla"
        Me.mMenuTabla.Size = New System.Drawing.Size(139, 70)
        '
        'mModificar
        '
        Me.mModificar.Image = Global.Rebusco.My.Resources.Resources.edit16
        Me.mModificar.Name = "mModificar"
        Me.mModificar.Size = New System.Drawing.Size(138, 22)
        Me.mModificar.Text = "Modificar"
        '
        'mImprimirOT
        '
        Me.mImprimirOT.Image = Global.Rebusco.My.Resources.Resources.print
        Me.mImprimirOT.Name = "mImprimirOT"
        Me.mImprimirOT.Size = New System.Drawing.Size(138, 22)
        Me.mImprimirOT.Text = "Imprimir OT"
        '
        'mServicio
        '
        Me.mServicio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mServicio.Image = Global.Rebusco.My.Resources.Resources.Toolsb
        Me.mServicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mServicio.Name = "mServicio"
        Me.mServicio.Size = New System.Drawing.Size(138, 22)
        Me.mServicio.Text = "Servicio"
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
        Me.WinDeco1.Size = New System.Drawing.Size(1091, 50)
        Me.WinDeco1.TabIndex = 252
        Me.WinDeco1.TituloVentana = "Consulta de OT"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(471, 19)
        Me.Label7.TabIndex = 252
        Me.Label7.Text = "Rango de Fechas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsultaOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 559)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.oAutomatico)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAnulacionOT)
        Me.Controls.Add(Me.bIngresoOT)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta OT"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mMenuTabla.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents xOT As TextBox
    Friend WithEvents xNombreCliente As TextBox
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cTecnicos As ComboBox
    Friend WithEvents xTecnico As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cHasta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cDesde As DateTimePicker
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bLimpiar As Button
    Public WithEvents bIngresoOT As Button
    Public WithEvents bAnulacionOT As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button
    
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label8 As Label
    Public WithEvents bMostrar As Button
    Friend WithEvents bBuscarC As SearchButton
    Friend WithEvents Label14 As Label
    Friend WithEvents oFechaOT As CustomRadio
    Friend WithEvents oFechaEnt As CustomRadio
    Friend WithEvents oAutomatico As CustomCheck
    Friend WithEvents mMenuTabla As ContextMenuStrip
    Friend WithEvents mServicio As ToolStripMenuItem
    Friend WithEvents mImprimirOT As ToolStripMenuItem
    Friend WithEvents mModificar As ToolStripMenuItem
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label7 As Label
End Class
