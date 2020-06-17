<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaAbonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaAbonos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xVendedor = New Rebusco.TextBoxAutoComple()
        Me.xCliente = New Rebusco.TextBoxAutoComple()
        Me.oPagados = New Rebusco.CustomCheck()
        Me.cFPagos = New System.Windows.Forms.ComboBox()
        Me.xNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bBuscarC = New System.Windows.Forms.Button()
        Me.bBuscarV = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xNombreVendedor = New System.Windows.Forms.TextBox()
        Me.xNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tCantidadR = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.sBarra.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xVendedor)
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.oPagados)
        Me.GroupBox1.Controls.Add(Me.cFPagos)
        Me.GroupBox1.Controls.Add(Me.xNumero)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.bBuscarC)
        Me.GroupBox1.Controls.Add(Me.bBuscarV)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xNombreVendedor)
        Me.GroupBox1.Controls.Add(Me.xNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xVendedor
        '
        Me.xVendedor.AnchoLista = 500
        Me.xVendedor.AutoCompletarActivo = True
        Me.xVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xVendedor.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xVendedor.DescBusqueda = "NombreUsr"
        Me.xVendedor.Filtro = ""
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xVendedor.IDBusqueda = "Usuario"
        Me.xVendedor.IntervaloBusquedaNumeros = 1
        Me.xVendedor.IntervaloBusquedaTexto = 3
        Me.xVendedor.Location = New System.Drawing.Point(115, 165)
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(91, 21)
        Me.xVendedor.TabIndex = 261
        Me.xVendedor.TablaBusqueda = "Usuarios"
        Me.xVendedor.TextFont = New System.Drawing.Font("Arial", 9.0!)
        '
        'xCliente
        '
        Me.xCliente.AnchoLista = 350
        Me.xCliente.AutoCompletarActivo = True
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xCliente.DescBusqueda = "Nombre"
        Me.xCliente.Filtro = ""
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.IDBusqueda = "Cliente"
        Me.xCliente.IntervaloBusquedaNumeros = 1
        Me.xCliente.IntervaloBusquedaTexto = 3
        Me.xCliente.Location = New System.Drawing.Point(115, 137)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(91, 21)
        Me.xCliente.TabIndex = 260
        Me.xCliente.TablaBusqueda = "Clientes"
        Me.xCliente.TextFont = New System.Drawing.Font("Arial", 9.0!)
        '
        'oPagados
        '
        Me.oPagados.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPagados.BackColor = System.Drawing.Color.White
        Me.oPagados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPagados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPagados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPagados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPagados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPagados.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oPagados.ForeColor = System.Drawing.Color.Black
        Me.oPagados.Image = CType(resources.GetObject("oPagados.Image"), System.Drawing.Image)
        Me.oPagados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPagados.Location = New System.Drawing.Point(647, 14)
        Me.oPagados.Name = "oPagados"
        Me.oPagados.Size = New System.Drawing.Size(105, 30)
        Me.oPagados.TabIndex = 8
        Me.oPagados.Text = "Pagados"
        Me.oPagados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPagados.UseVisualStyleBackColor = False
        '
        'cFPagos
        '
        Me.cFPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPagos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFPagos.FormattingEnabled = True
        Me.cFPagos.Location = New System.Drawing.Point(115, 107)
        Me.cFPagos.Name = "cFPagos"
        Me.cFPagos.Size = New System.Drawing.Size(368, 23)
        Me.cFPagos.TabIndex = 5
        '
        'xNumero
        '
        Me.xNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNumero.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNumero.Location = New System.Drawing.Point(548, 77)
        Me.xNumero.MaxLength = 30
        Me.xNumero.Name = "xNumero"
        Me.xNumero.Size = New System.Drawing.Size(105, 21)
        Me.xNumero.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "Forma de Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(489, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Número"
        '
        'bBuscarC
        '
        Me.bBuscarC.BackColor = System.Drawing.Color.White
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarC.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarC.Location = New System.Drawing.Point(668, 135)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(84, 27)
        Me.bBuscarC.TabIndex = 9
        Me.bBuscarC.Text = "Buscar"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.UseVisualStyleBackColor = False
        '
        'bBuscarV
        '
        Me.bBuscarV.BackColor = System.Drawing.Color.White
        Me.bBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarV.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarV.Location = New System.Drawing.Point(668, 163)
        Me.bBuscarV.Name = "bBuscarV"
        Me.bBuscarV.Size = New System.Drawing.Size(84, 27)
        Me.bBuscarV.TabIndex = 10
        Me.bBuscarV.Text = "Buscar"
        Me.bBuscarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarV.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Vendedor"
        '
        'xNombreVendedor
        '
        Me.xNombreVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreVendedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreVendedor.Location = New System.Drawing.Point(212, 165)
        Me.xNombreVendedor.Name = "xNombreVendedor"
        Me.xNombreVendedor.ReadOnly = True
        Me.xNombreVendedor.Size = New System.Drawing.Size(450, 21)
        Me.xNombreVendedor.TabIndex = 254
        Me.xNombreVendedor.TabStop = False
        '
        'xNombreCliente
        '
        Me.xNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreCliente.Location = New System.Drawing.Point(212, 137)
        Me.xNombreCliente.Name = "xNombreCliente"
        Me.xNombreCliente.ReadOnly = True
        Me.xNombreCliente.Size = New System.Drawing.Size(450, 21)
        Me.xNombreCliente.TabIndex = 251
        Me.xNombreCliente.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Cliente"
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(115, 77)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(368, 23)
        Me.cTipoDoc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Tipo Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Rango de Fecha"
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(232, 19)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(92, 21)
        Me.dHasta.TabIndex = 1
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(115, 19)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(92, 21)
        Me.dDesde.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(209, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "al"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(115, 47)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(368, 23)
        Me.cLocal.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Local"
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(776, 210)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(106, 36)
        Me.bConsultar.TabIndex = 1
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(782, 494)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 4
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 494)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 2
        Me.bLimpiar.Text = " Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso, Me.tCantidadR})
        Me.sBarra.Location = New System.Drawing.Point(0, 533)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(894, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 240
        Me.sBarra.Text = "StatusStrip1"
        '
        'tMensajeBarra
        '
        Me.tMensajeBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tMensajeBarra.ForeColor = System.Drawing.Color.White
        Me.tMensajeBarra.Name = "tMensajeBarra"
        Me.tMensajeBarra.Size = New System.Drawing.Size(203, 17)
        Me.tMensajeBarra.Text = "Guardando Pagos, espere por favor"
        '
        'tBarraProgreso
        '
        Me.tBarraProgreso.BackColor = System.Drawing.Color.White
        Me.tBarraProgreso.ForeColor = System.Drawing.Color.Black
        Me.tBarraProgreso.Name = "tBarraProgreso"
        Me.tBarraProgreso.Size = New System.Drawing.Size(100, 16)
        Me.tBarraProgreso.Step = 5
        Me.tBarraProgreso.Value = 70
        '
        'tCantidadR
        '
        Me.tCantidadR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tCantidadR.ForeColor = System.Drawing.Color.White
        Me.tCantidadR.Name = "tCantidadR"
        Me.tCantidadR.Size = New System.Drawing.Size(574, 17)
        Me.tCantidadR.Spring = True
        Me.tCantidadR.Text = "Cantidad de registros : 100"
        Me.tCantidadR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.xTabla.Location = New System.Drawing.Point(12, 258)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(870, 226)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 6
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bImprimir
        '
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(680, 494)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(96, 36)
        Me.bImprimir.TabIndex = 3
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(894, 50)
        Me.WinDeco1.TabIndex = 241
        Me.WinDeco1.TituloVentana = "Consulta de Abonos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ConsultaAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 555)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.sBarra)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaAbonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Abonos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.sBarra.ResumeLayout(False)
        Me.sBarra.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents xNombreCliente As TextBox
    Public WithEvents bBuscarV As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents xNombreVendedor As TextBox
    Friend WithEvents cFPagos As ComboBox
    Friend WithEvents xNumero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents bBuscarC As Button
    Public WithEvents bConsultar As Button
    Public WithEvents bSalir As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents oPagados As CustomCheck
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bImprimir As Button
    Friend WithEvents xCliente As TextBoxAutoComple
    Friend WithEvents xVendedor As TextBoxAutoComple
    Friend WithEvents tCantidadR As ToolStripStatusLabel
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
