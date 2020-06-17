<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaDocumento))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oSoloVentas = New Rebusco.CustomCheck()
        Me.xNumdoc = New System.Windows.Forms.TextBox()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.xTicket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cFormaPago = New System.Windows.Forms.ComboBox()
        Me.bBuscarA = New System.Windows.Forms.Button()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bBuscarV = New System.Windows.Forms.Button()
        Me.bBuscarC = New System.Windows.Forms.Button()
        Me.xNombreV = New System.Windows.Forms.TextBox()
        Me.xNombreC = New System.Windows.Forms.TextBox()
        Me.xVendedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.xSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.xImpuesto = New System.Windows.Forms.TextBox()
        Me.xNeto = New System.Windows.Forms.TextBox()
        Me.xDescuento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bPortapapeles = New System.Windows.Forms.Button()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.LocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescFPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sDocumentos = New System.Windows.Forms.BindingSource(Me.components)
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oDetalle = New Rebusco.CustomRadio()
        Me.oGeneral = New Rebusco.CustomRadio()
        Me.bExportar = New System.Windows.Forms.Button()
        Me.fDialogo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.oSoloVentas)
        Me.GroupBox1.Controls.Add(Me.xNumdoc)
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.xTicket)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.dHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cFormaPago)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(950, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'oSoloVentas
        '
        Me.oSoloVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oSoloVentas.Appearance = System.Windows.Forms.Appearance.Button
        Me.oSoloVentas.BackColor = System.Drawing.Color.White
        Me.oSoloVentas.Checked = True
        Me.oSoloVentas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oSoloVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oSoloVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloVentas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oSoloVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oSoloVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oSoloVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oSoloVentas.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oSoloVentas.ForeColor = System.Drawing.Color.White
        Me.oSoloVentas.Image = CType(resources.GetObject("oSoloVentas.Image"), System.Drawing.Image)
        Me.oSoloVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oSoloVentas.Location = New System.Drawing.Point(642, 20)
        Me.oSoloVentas.Name = "oSoloVentas"
        Me.oSoloVentas.Size = New System.Drawing.Size(105, 26)
        Me.oSoloVentas.TabIndex = 341
        Me.oSoloVentas.Text = " Solo ventas"
        Me.oSoloVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oSoloVentas.UseVisualStyleBackColor = False
        '
        'xNumdoc
        '
        Me.xNumdoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xNumdoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNumdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumdoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNumdoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xNumdoc.Location = New System.Drawing.Point(821, 22)
        Me.xNumdoc.Name = "xNumdoc"
        Me.xNumdoc.Size = New System.Drawing.Size(123, 21)
        Me.xNumdoc.TabIndex = 4
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(454, 21)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(182, 23)
        Me.cTipoDoc.TabIndex = 3
        '
        'xTicket
        '
        Me.xTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTicket.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTicket.Location = New System.Drawing.Point(821, 50)
        Me.xTicket.Name = "xTicket"
        Me.xTicket.Size = New System.Drawing.Size(123, 21)
        Me.xTicket.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(338, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Tipo de Documento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(753, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 219
        Me.Label10.Text = "Número"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(753, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "N° Ticket"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(114, 49)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(217, 23)
        Me.cLocal.TabIndex = 2
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(240, 21)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(91, 21)
        Me.dHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(217, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Al"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Local"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(117, 21)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(90, 21)
        Me.dDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Rango de Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(338, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Forma de Pago"
        '
        'cFormaPago
        '
        Me.cFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFormaPago.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFormaPago.FormattingEnabled = True
        Me.cFormaPago.Location = New System.Drawing.Point(454, 50)
        Me.cFormaPago.Name = "cFormaPago"
        Me.cFormaPago.Size = New System.Drawing.Size(182, 23)
        Me.cFormaPago.TabIndex = 8
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarA.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(864, 77)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarA.TabIndex = 13
        Me.bBuscarA.Text = " Buscar"
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(192, 79)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(666, 21)
        Me.xDescripcion.TabIndex = 215
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(19, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Artículo"
        '
        'bBuscarV
        '
        Me.bBuscarV.BackColor = System.Drawing.Color.White
        Me.bBuscarV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarV.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarV.Location = New System.Drawing.Point(864, 48)
        Me.bBuscarV.Name = "bBuscarV"
        Me.bBuscarV.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarV.TabIndex = 12
        Me.bBuscarV.Text = " Buscar"
        Me.bBuscarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarV.UseVisualStyleBackColor = False
        '
        'bBuscarC
        '
        Me.bBuscarC.BackColor = System.Drawing.Color.White
        Me.bBuscarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarC.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarC.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarC.Location = New System.Drawing.Point(864, 19)
        Me.bBuscarC.Name = "bBuscarC"
        Me.bBuscarC.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarC.TabIndex = 11
        Me.bBuscarC.Text = " Buscar"
        Me.bBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarC.UseVisualStyleBackColor = False
        '
        'xNombreV
        '
        Me.xNombreV.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreV.Location = New System.Drawing.Point(190, 51)
        Me.xNombreV.Name = "xNombreV"
        Me.xNombreV.ReadOnly = True
        Me.xNombreV.Size = New System.Drawing.Size(668, 21)
        Me.xNombreV.TabIndex = 208
        '
        'xNombreC
        '
        Me.xNombreC.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreC.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreC.Location = New System.Drawing.Point(190, 23)
        Me.xNombreC.Name = "xNombreC"
        Me.xNombreC.ReadOnly = True
        Me.xNombreC.Size = New System.Drawing.Size(668, 21)
        Me.xNombreC.TabIndex = 207
        '
        'xVendedor
        '
        Me.xVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVendedor.Location = New System.Drawing.Point(86, 51)
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(100, 21)
        Me.xVendedor.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Vendedor"
        '
        'xCliente
        '
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.Location = New System.Drawing.Point(86, 23)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(100, 21)
        Me.xCliente.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Cliente"
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 521)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(88, 36)
        Me.bLimpiar.TabIndex = 1
        Me.bLimpiar.Text = " Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(948, 521)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(136, 36)
        Me.bImprimir.TabIndex = 2
        Me.bImprimir.Text = " Imprimir informe"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(1090, 521)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(99, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = " Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(950, 16)
        Me.Label11.TabIndex = 220
        Me.Label11.Text = "Documento"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(950, 16)
        Me.Label12.TabIndex = 238
        Me.Label12.Text = "Filtros"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xArticulo)
        Me.GroupBox2.Controls.Add(Me.xCliente)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.bBuscarA)
        Me.GroupBox2.Controls.Add(Me.xNombreC)
        Me.GroupBox2.Controls.Add(Me.bBuscarC)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.xDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.xVendedor)
        Me.GroupBox2.Controls.Add(Me.xNombreV)
        Me.GroupBox2.Controls.Add(Me.bBuscarV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(950, 114)
        Me.GroupBox2.TabIndex = 239
        Me.GroupBox2.TabStop = False
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
        Me.xArticulo.Location = New System.Drawing.Point(86, 79)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(100, 22)
        Me.xArticulo.TabIndex = 216
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!)
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(968, 226)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(106, 36)
        Me.bConsultar.TabIndex = 244
        Me.bConsultar.Text = " Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'xSubTotal
        '
        Me.xSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.xSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xSubTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xSubTotal.Location = New System.Drawing.Point(87, 20)
        Me.xSubTotal.MaxLength = 18
        Me.xSubTotal.Name = "xSubTotal"
        Me.xSubTotal.ReadOnly = True
        Me.xSubTotal.Size = New System.Drawing.Size(128, 26)
        Me.xSubTotal.TabIndex = 248
        Me.xSubTotal.TabStop = False
        Me.xSubTotal.Text = "0"
        Me.xSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(968, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(221, 16)
        Me.Label13.TabIndex = 249
        Me.Label13.Text = "Totales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.xTotal)
        Me.GroupBox3.Controls.Add(Me.xImpuesto)
        Me.GroupBox3.Controls.Add(Me.xNeto)
        Me.GroupBox3.Controls.Add(Me.xDescuento)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.xSubTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(968, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 164)
        Me.GroupBox3.TabIndex = 250
        Me.GroupBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Location = New System.Drawing.Point(5, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(82, 26)
        Me.Panel1.TabIndex = 341
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(1, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 16)
        Me.Label18.TabIndex = 256
        Me.Label18.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(6, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 16)
        Me.Label17.TabIndex = 255
        Me.Label17.Text = "IVA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(6, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 16)
        Me.Label16.TabIndex = 254
        Me.Label16.Text = "Neto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(6, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 253
        Me.Label15.Text = "Descuento"
        '
        'xTotal
        '
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(87, 132)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(128, 26)
        Me.xTotal.TabIndex = 252
        Me.xTotal.TabStop = False
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xImpuesto
        '
        Me.xImpuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xImpuesto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.xImpuesto.Location = New System.Drawing.Point(87, 104)
        Me.xImpuesto.MaxLength = 18
        Me.xImpuesto.Name = "xImpuesto"
        Me.xImpuesto.ReadOnly = True
        Me.xImpuesto.Size = New System.Drawing.Size(128, 26)
        Me.xImpuesto.TabIndex = 251
        Me.xImpuesto.TabStop = False
        Me.xImpuesto.Text = "0"
        Me.xImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xNeto
        '
        Me.xNeto.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNeto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNeto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.xNeto.Location = New System.Drawing.Point(87, 76)
        Me.xNeto.MaxLength = 18
        Me.xNeto.Name = "xNeto"
        Me.xNeto.ReadOnly = True
        Me.xNeto.Size = New System.Drawing.Size(128, 26)
        Me.xNeto.TabIndex = 250
        Me.xNeto.TabStop = False
        Me.xNeto.Text = "0"
        Me.xNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xDescuento
        '
        Me.xDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.xDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescuento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xDescuento.Location = New System.Drawing.Point(87, 48)
        Me.xDescuento.MaxLength = 18
        Me.xDescuento.Name = "xDescuento"
        Me.xDescuento.ReadOnly = True
        Me.xDescuento.Size = New System.Drawing.Size(128, 26)
        Me.xDescuento.TabIndex = 249
        Me.xDescuento.TabStop = False
        Me.xDescuento.Text = "0"
        Me.xDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(6, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 213
        Me.Label14.Text = "Sub-Total"
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
        Me.WinDeco1.Size = New System.Drawing.Size(1201, 50)
        Me.WinDeco1.TabIndex = 251
        Me.WinDeco1.TituloVentana = "Consulta de Documentos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bPortapapeles
        '
        Me.bPortapapeles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bPortapapeles.BackColor = System.Drawing.Color.White
        Me.bPortapapeles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPortapapeles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPortapapeles.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bPortapapeles.Image = Global.Rebusco.My.Resources.Resources.clipboard_copy
        Me.bPortapapeles.Location = New System.Drawing.Point(606, 521)
        Me.bPortapapeles.Name = "bPortapapeles"
        Me.bPortapapeles.Size = New System.Drawing.Size(147, 37)
        Me.bPortapapeles.TabIndex = 288
        Me.bPortapapeles.Text = " Copiar resultado"
        Me.bPortapapeles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPortapapeles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bPortapapeles.UseVisualStyleBackColor = False
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        Me.xTabla.AllowUserToResizeRows = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.AutoGenerateColumns = False
        Me.xTabla.BackgroundColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xTabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocalDataGridViewTextBoxColumn, Me.TipoDocDataGridViewTextBoxColumn, Me.DocumentoDataGridViewTextBoxColumn, Me.Ticket, Me.FechaDataGridViewTextBoxColumn, Me.Rut, Me.NombreClienteDataGridViewTextBoxColumn, Me.DescFPagoDataGridViewTextBoxColumn, Me.VendedorDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.NetoDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.xTabla.DataSource = Me.sDocumentos
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xTabla.DefaultCellStyle = DataGridViewCellStyle10
        Me.xTabla.Location = New System.Drawing.Point(12, 268)
        Me.xTabla.MultiSelect = False
        Me.xTabla.Name = "xTabla"
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.Size = New System.Drawing.Size(1177, 223)
        Me.xTabla.TabIndex = 337
        '
        'LocalDataGridViewTextBoxColumn
        '
        Me.LocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LocalDataGridViewTextBoxColumn.DataPropertyName = "Local"
        Me.LocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.LocalDataGridViewTextBoxColumn.Name = "LocalDataGridViewTextBoxColumn"
        Me.LocalDataGridViewTextBoxColumn.Width = 63
        '
        'TipoDocDataGridViewTextBoxColumn
        '
        Me.TipoDocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoDocDataGridViewTextBoxColumn.DataPropertyName = "DescTipoDoc"
        Me.TipoDocDataGridViewTextBoxColumn.HeaderText = "Tipo Doc."
        Me.TipoDocDataGridViewTextBoxColumn.Name = "TipoDocDataGridViewTextBoxColumn"
        Me.TipoDocDataGridViewTextBoxColumn.Width = 89
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "Documento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DocumentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        Me.DocumentoDataGridViewTextBoxColumn.Width = 81
        '
        'Ticket
        '
        Me.Ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ticket.DataPropertyName = "Ticket"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.Ticket.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ticket.HeaderText = "Ticket"
        Me.Ticket.Name = "Ticket"
        Me.Ticket.Width = 66
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 66
        '
        'Rut
        '
        Me.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rut.DataPropertyName = "Rut"
        Me.Rut.HeaderText = "Rut"
        Me.Rut.Name = "Rut"
        Me.Rut.Width = 52
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        Me.NombreClienteDataGridViewTextBoxColumn.Width = 120
        '
        'DescFPagoDataGridViewTextBoxColumn
        '
        Me.DescFPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescFPagoDataGridViewTextBoxColumn.DataPropertyName = "DescFPago"
        Me.DescFPagoDataGridViewTextBoxColumn.HeaderText = "F.Pago"
        Me.DescFPagoDataGridViewTextBoxColumn.Name = "DescFPagoDataGridViewTextBoxColumn"
        Me.DescFPagoDataGridViewTextBoxColumn.Width = 72
        '
        'VendedorDataGridViewTextBoxColumn
        '
        Me.VendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.Name = "VendedorDataGridViewTextBoxColumn"
        Me.VendedorDataGridViewTextBoxColumn.Width = 120
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle5.Format = "N0"
        Me.SubTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "Sub-Total"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.Width = 88
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle6.Format = "N0"
        Me.DescuentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.Width = 94
        '
        'NetoDataGridViewTextBoxColumn
        '
        Me.NetoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NetoDataGridViewTextBoxColumn.DataPropertyName = "Neto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle7.Format = "N0"
        Me.NetoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.NetoDataGridViewTextBoxColumn.HeaderText = "Neto"
        Me.NetoDataGridViewTextBoxColumn.Name = "NetoDataGridViewTextBoxColumn"
        Me.NetoDataGridViewTextBoxColumn.Width = 62
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle8.Format = "N0"
        Me.IvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.Width = 51
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle9.Format = "N0"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 61
        '
        'sDocumentos
        '
        Me.sDocumentos.DataSource = GetType(Rebusco.DocumentoListado)
        '
        'lTotal
        '
        Me.lTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lTotal.AutoSize = True
        Me.lTotal.BackColor = System.Drawing.Color.Transparent
        Me.lTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.Color.White
        Me.lTotal.Location = New System.Drawing.Point(229, 531)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(15, 16)
        Me.lTotal.TabIndex = 339
        Me.lTotal.Text = "0"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(106, 531)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 340
        Me.Label19.Text = "Total documentos"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ticket"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ticket"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'oDetalle
        '
        Me.oDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oDetalle.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDetalle.BackColor = System.Drawing.Color.White
        Me.oDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oDetalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.oDetalle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDetalle.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oDetalle.ForeColor = System.Drawing.Color.Black
        Me.oDetalle.Image = CType(resources.GetObject("oDetalle.Image"), System.Drawing.Image)
        Me.oDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDetalle.Location = New System.Drawing.Point(850, 525)
        Me.oDetalle.Name = "oDetalle"
        Me.oDetalle.Size = New System.Drawing.Size(92, 29)
        Me.oDetalle.TabIndex = 342
        Me.oDetalle.Text = " Detallado"
        Me.oDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDetalle.UseVisualStyleBackColor = False
        '
        'oGeneral
        '
        Me.oGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oGeneral.Appearance = System.Windows.Forms.Appearance.Button
        Me.oGeneral.BackColor = System.Drawing.Color.White
        Me.oGeneral.Checked = True
        Me.oGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oGeneral.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.oGeneral.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oGeneral.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oGeneral.ForeColor = System.Drawing.Color.White
        Me.oGeneral.Image = CType(resources.GetObject("oGeneral.Image"), System.Drawing.Image)
        Me.oGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oGeneral.Location = New System.Drawing.Point(759, 525)
        Me.oGeneral.Name = "oGeneral"
        Me.oGeneral.Size = New System.Drawing.Size(85, 29)
        Me.oGeneral.TabIndex = 341
        Me.oGeneral.TabStop = True
        Me.oGeneral.Text = " General"
        Me.oGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oGeneral.UseVisualStyleBackColor = False
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.BackColor = System.Drawing.Color.White
        Me.bExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExportar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bExportar.Image = Global.Rebusco.My.Resources.Resources.excel24
        Me.bExportar.Location = New System.Drawing.Point(453, 521)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(147, 37)
        Me.bExportar.TabIndex = 288
        Me.bExportar.Text = " Exportar resultado"
        Me.bExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bExportar.UseVisualStyleBackColor = False
        '
        'fDialogo
        '
        Me.fDialogo.FileName = "Listado Documentos"
        Me.fDialogo.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm"
        Me.fDialogo.Title = "Exportar listado de documentos"
        '
        'ConsultaDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 573)
        Me.Controls.Add(Me.oDetalle)
        Me.Controls.Add(Me.oGeneral)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.bExportar)
        Me.Controls.Add(Me.bPortapapeles)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bBuscarA As Button
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label4 As Label
    Public WithEvents bBuscarV As Button
    Public WithEvents bBuscarC As Button
    Friend WithEvents xNombreV As TextBox
    Friend WithEvents xNombreC As TextBox
    Friend WithEvents cFormaPago As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xTicket As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents xNumdoc As TextBox
    Friend WithEvents Label10 As Label
    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button

    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents bConsultar As Button
    Friend WithEvents xSubTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents xDescuento As TextBox
    Friend WithEvents xNeto As TextBox
    Friend WithEvents xImpuesto As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents xTotal As TextBox
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents xArticulo As TextBoxAutoComple
    Public WithEvents bPortapapeles As Button
    Friend WithEvents xTabla As DataGridView
    Friend WithEvents sDocumentos As BindingSource
    Friend WithEvents lTotal As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ticket As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescFPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents oSoloVentas As CustomCheck
    Friend WithEvents oDetalle As CustomRadio
    Friend WithEvents oGeneral As CustomRadio
    Public WithEvents bExportar As Button
    Friend WithEvents fDialogo As SaveFileDialog
End Class
