<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoMovimientos))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cBodega = New System.Windows.Forms.ComboBox()
        Me.xBodega = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cTipoMov = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bBuscarR = New System.Windows.Forms.Button()
        Me.xNombreResponsable = New System.Windows.Forms.TextBox()
        Me.xResponsable = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bBuscarU = New System.Windows.Forms.Button()
        Me.xNombreUsuario = New System.Windows.Forms.TextBox()
        Me.xUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.lNumeroMov = New System.Windows.Forms.Label()
        Me.bImprimirMovimiento = New System.Windows.Forms.Button()
        Me.xTablaMovimientos = New System.Windows.Forms.DataGridView()
        Me.MovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionTipoMovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreLocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreResponsableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionTipoDocRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovEncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTablaMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovEncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(5, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bodega"
        '
        'cBodega
        '
        Me.cBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cBodega.FormattingEnabled = True
        Me.cBodega.Location = New System.Drawing.Point(88, 113)
        Me.cBodega.Name = "cBodega"
        Me.cBodega.Size = New System.Drawing.Size(211, 23)
        Me.cBodega.TabIndex = 4
        '
        'xBodega
        '
        Me.xBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xBodega.Location = New System.Drawing.Point(69, 309)
        Me.xBodega.Name = "xBodega"
        Me.xBodega.Size = New System.Drawing.Size(53, 21)
        Me.xBodega.TabIndex = 3
        Me.xBodega.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(5, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Local"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(88, 84)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(211, 23)
        Me.cLocal.TabIndex = 2
        '
        'xLocal
        '
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xLocal.Location = New System.Drawing.Point(10, 309)
        Me.xLocal.Name = "xLocal"
        Me.xLocal.Size = New System.Drawing.Size(53, 21)
        Me.xLocal.TabIndex = 1
        Me.xLocal.Visible = False
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(88, 171)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(212, 23)
        Me.cTipoDoc.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de Doc."
        '
        'cTipoMov
        '
        Me.cTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoMov.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoMov.FormattingEnabled = True
        Me.cTipoMov.Location = New System.Drawing.Point(88, 142)
        Me.cTipoMov.Name = "cTipoMov"
        Me.cTipoMov.Size = New System.Drawing.Size(212, 23)
        Me.cTipoMov.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Mov."
        '
        'bBuscarR
        '
        Me.bBuscarR.BackColor = System.Drawing.Color.White
        Me.bBuscarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarR.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarR.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarR.Location = New System.Drawing.Point(164, 252)
        Me.bBuscarR.Name = "bBuscarR"
        Me.bBuscarR.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarR.TabIndex = 46
        Me.bBuscarR.Text = "Buscar"
        Me.bBuscarR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarR.UseVisualStyleBackColor = False
        '
        'xNombreResponsable
        '
        Me.xNombreResponsable.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreResponsable.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreResponsable.Location = New System.Drawing.Point(9, 228)
        Me.xNombreResponsable.Name = "xNombreResponsable"
        Me.xNombreResponsable.ReadOnly = True
        Me.xNombreResponsable.Size = New System.Drawing.Size(291, 21)
        Me.xNombreResponsable.TabIndex = 45
        '
        'xResponsable
        '
        Me.xResponsable.BackColor = System.Drawing.Color.White
        Me.xResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xResponsable.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xResponsable.Location = New System.Drawing.Point(89, 201)
        Me.xResponsable.Name = "xResponsable"
        Me.xResponsable.Size = New System.Drawing.Size(69, 21)
        Me.xResponsable.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Responsable"
        '
        'bBuscarU
        '
        Me.bBuscarU.BackColor = System.Drawing.Color.White
        Me.bBuscarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarU.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarU.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarU.Location = New System.Drawing.Point(164, 198)
        Me.bBuscarU.Name = "bBuscarU"
        Me.bBuscarU.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarU.TabIndex = 42
        Me.bBuscarU.Text = "Buscar"
        Me.bBuscarU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarU.UseVisualStyleBackColor = False
        '
        'xNombreUsuario
        '
        Me.xNombreUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreUsuario.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreUsuario.Location = New System.Drawing.Point(9, 282)
        Me.xNombreUsuario.Name = "xNombreUsuario"
        Me.xNombreUsuario.ReadOnly = True
        Me.xNombreUsuario.Size = New System.Drawing.Size(291, 21)
        Me.xNombreUsuario.TabIndex = 4
        '
        'xUsuario
        '
        Me.xUsuario.BackColor = System.Drawing.Color.White
        Me.xUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xUsuario.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xUsuario.Location = New System.Drawing.Point(88, 255)
        Me.xUsuario.Name = "xUsuario"
        Me.xUsuario.Size = New System.Drawing.Size(69, 21)
        Me.xUsuario.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Usuario"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cTipoDoc)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.bBuscarR)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.xNombreResponsable)
        Me.GroupBox4.Controls.Add(Me.bBuscarU)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.xBodega)
        Me.GroupBox4.Controls.Add(Me.xLocal)
        Me.GroupBox4.Controls.Add(Me.xResponsable)
        Me.GroupBox4.Controls.Add(Me.xNombreUsuario)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dHasta)
        Me.GroupBox4.Controls.Add(Me.xUsuario)
        Me.GroupBox4.Controls.Add(Me.cTipoMov)
        Me.GroupBox4.Controls.Add(Me.cBodega)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.dDesde)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cLocal)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 321)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(222, 382)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(99, 36)
        Me.bConsultar.TabIndex = 267
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1110, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Documento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(89, 57)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(109, 21)
        Me.dHasta.TabIndex = 1
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(88, 29)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(109, 21)
        Me.dDesde.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Hasta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Desde"
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(1055, 541)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 541)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 1
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
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print
        Me.bImprimir.Location = New System.Drawing.Point(987, 55)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(161, 28)
        Me.bImprimir.TabIndex = 2
        Me.bImprimir.Text = "Imprimir listado"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(1168, 50)
        Me.WinDeco1.TabIndex = 136
        Me.WinDeco1.TituloVentana = "Listado de Movimientos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(327, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(828, 206)
        Me.GroupBox2.TabIndex = 281
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(653, 28)
        Me.Label7.TabIndex = 265
        Me.Label7.Text = "Movimientos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.xTabla)
        Me.GroupBox3.Controls.Add(Me.lNumeroMov)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(327, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(828, 253)
        Me.GroupBox3.TabIndex = 282
        Me.GroupBox3.TabStop = False
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.AutoGenerateColumns = False
        Me.xTabla.BackgroundColor = System.Drawing.Color.SlateGray
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArticuloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.BarraDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.MovDetalleBindingSource
        Me.xTabla.Location = New System.Drawing.Point(6, 34)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.ReadOnly = True
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xTabla.Size = New System.Drawing.Size(816, 213)
        Me.xTabla.TabIndex = 285
        '
        'lNumeroMov
        '
        Me.lNumeroMov.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lNumeroMov.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lNumeroMov.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lNumeroMov.ForeColor = System.Drawing.Color.White
        Me.lNumeroMov.Location = New System.Drawing.Point(0, 0)
        Me.lNumeroMov.Name = "lNumeroMov"
        Me.lNumeroMov.Size = New System.Drawing.Size(653, 28)
        Me.lNumeroMov.TabIndex = 265
        Me.lNumeroMov.Text = "Detalle movimiento"
        Me.lNumeroMov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bImprimirMovimiento
        '
        Me.bImprimirMovimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimirMovimiento.BackColor = System.Drawing.Color.White
        Me.bImprimirMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimirMovimiento.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimirMovimiento.Image = Global.Rebusco.My.Resources.Resources.print
        Me.bImprimirMovimiento.Location = New System.Drawing.Point(985, 267)
        Me.bImprimirMovimiento.Name = "bImprimirMovimiento"
        Me.bImprimirMovimiento.Size = New System.Drawing.Size(161, 28)
        Me.bImprimirMovimiento.TabIndex = 283
        Me.bImprimirMovimiento.Text = "Imprimir movimiento"
        Me.bImprimirMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimirMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimirMovimiento.UseVisualStyleBackColor = False
        '
        'xTablaMovimientos
        '
        Me.xTablaMovimientos.AllowUserToAddRows = False
        Me.xTablaMovimientos.AllowUserToDeleteRows = False
        Me.xTablaMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTablaMovimientos.AutoGenerateColumns = False
        Me.xTablaMovimientos.BackgroundColor = System.Drawing.Color.SlateGray
        Me.xTablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTablaMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DescripcionTipoMovDataGridViewTextBoxColumn, Me.NombreLocalDataGridViewTextBoxColumn, Me.NombreBodegaDataGridViewTextBoxColumn, Me.NombreUsuarioDataGridViewTextBoxColumn, Me.NombreResponsableDataGridViewTextBoxColumn, Me.DescripcionTipoDocRefDataGridViewTextBoxColumn, Me.NumDocRefDataGridViewTextBoxColumn})
        Me.xTablaMovimientos.DataSource = Me.MovEncabezadoBindingSource
        Me.xTablaMovimientos.Location = New System.Drawing.Point(333, 89)
        Me.xTablaMovimientos.Name = "xTablaMovimientos"
        Me.xTablaMovimientos.ReadOnly = True
        Me.xTablaMovimientos.RowHeadersVisible = False
        Me.xTablaMovimientos.Size = New System.Drawing.Size(816, 163)
        Me.xTablaMovimientos.TabIndex = 285
        '
        'MovimientoDataGridViewTextBoxColumn
        '
        Me.MovimientoDataGridViewTextBoxColumn.DataPropertyName = "Movimiento"
        Me.MovimientoDataGridViewTextBoxColumn.HeaderText = "Movimiento"
        Me.MovimientoDataGridViewTextBoxColumn.Name = "MovimientoDataGridViewTextBoxColumn"
        Me.MovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovimientoDataGridViewTextBoxColumn.Width = 80
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 80
        '
        'DescripcionTipoMovDataGridViewTextBoxColumn
        '
        Me.DescripcionTipoMovDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTipoMov"
        Me.DescripcionTipoMovDataGridViewTextBoxColumn.HeaderText = "Tipo Movimiento"
        Me.DescripcionTipoMovDataGridViewTextBoxColumn.Name = "DescripcionTipoMovDataGridViewTextBoxColumn"
        Me.DescripcionTipoMovDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionTipoMovDataGridViewTextBoxColumn.Width = 120
        '
        'NombreLocalDataGridViewTextBoxColumn
        '
        Me.NombreLocalDataGridViewTextBoxColumn.DataPropertyName = "NombreLocal"
        Me.NombreLocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.NombreLocalDataGridViewTextBoxColumn.Name = "NombreLocalDataGridViewTextBoxColumn"
        Me.NombreLocalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreBodegaDataGridViewTextBoxColumn
        '
        Me.NombreBodegaDataGridViewTextBoxColumn.DataPropertyName = "NombreBodega"
        Me.NombreBodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.NombreBodegaDataGridViewTextBoxColumn.Name = "NombreBodegaDataGridViewTextBoxColumn"
        Me.NombreBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreUsuarioDataGridViewTextBoxColumn
        '
        Me.NombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario"
        Me.NombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario Creador"
        Me.NombreUsuarioDataGridViewTextBoxColumn.Name = "NombreUsuarioDataGridViewTextBoxColumn"
        Me.NombreUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreUsuarioDataGridViewTextBoxColumn.Width = 120
        '
        'NombreResponsableDataGridViewTextBoxColumn
        '
        Me.NombreResponsableDataGridViewTextBoxColumn.DataPropertyName = "NombreResponsable"
        Me.NombreResponsableDataGridViewTextBoxColumn.HeaderText = "Usuario Responsable"
        Me.NombreResponsableDataGridViewTextBoxColumn.Name = "NombreResponsableDataGridViewTextBoxColumn"
        Me.NombreResponsableDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreResponsableDataGridViewTextBoxColumn.Width = 140
        '
        'DescripcionTipoDocRefDataGridViewTextBoxColumn
        '
        Me.DescripcionTipoDocRefDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTipoDocRef"
        Me.DescripcionTipoDocRefDataGridViewTextBoxColumn.HeaderText = "Tipo Doc. Referencia"
        Me.DescripcionTipoDocRefDataGridViewTextBoxColumn.Name = "DescripcionTipoDocRefDataGridViewTextBoxColumn"
        Me.DescripcionTipoDocRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionTipoDocRefDataGridViewTextBoxColumn.Width = 140
        '
        'NumDocRefDataGridViewTextBoxColumn
        '
        Me.NumDocRefDataGridViewTextBoxColumn.DataPropertyName = "NumDocRef"
        Me.NumDocRefDataGridViewTextBoxColumn.HeaderText = "Documento Ref"
        Me.NumDocRefDataGridViewTextBoxColumn.Name = "NumDocRefDataGridViewTextBoxColumn"
        Me.NumDocRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumDocRefDataGridViewTextBoxColumn.Width = 120
        '
        'MovEncabezadoBindingSource
        '
        Me.MovEncabezadoBindingSource.DataSource = GetType(Rebusco.MovEncabezado)
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "Artículo"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 400
        '
        'BarraDataGridViewTextBoxColumn
        '
        Me.BarraDataGridViewTextBoxColumn.DataPropertyName = "Barra"
        Me.BarraDataGridViewTextBoxColumn.HeaderText = "Barra"
        Me.BarraDataGridViewTextBoxColumn.Name = "BarraDataGridViewTextBoxColumn"
        Me.BarraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovDetalleBindingSource
        '
        Me.MovDetalleBindingSource.DataSource = GetType(Rebusco.MovDetalle)
        '
        'ListadoMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 589)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.xTablaMovimientos)
        Me.Controls.Add(Me.bImprimirMovimiento)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ListadoMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Movimientos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTablaMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovEncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents xLocal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cBodega As ComboBox
    Friend WithEvents xBodega As TextBox
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cTipoMov As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xNombreUsuario As TextBox
    Friend WithEvents xUsuario As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents bBuscarR As Button
    Friend WithEvents xNombreResponsable As TextBox
    Friend WithEvents xResponsable As TextBox
    Friend WithEvents Label6 As Label
    Public WithEvents bBuscarU As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents dDesde As DateTimePicker
    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents bCancelar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button

    Friend WithEvents Label14 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Public WithEvents bConsultar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lNumeroMov As Label
    Public WithEvents bImprimirMovimiento As Button
    Friend WithEvents MovEncabezadoBindingSource As BindingSource
    Friend WithEvents MovDetalleBindingSource As BindingSource
    Friend WithEvents xTablaMovimientos As DataGridView
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionTipoMovDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreLocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreResponsableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionTipoDocRefDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumDocRefDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
