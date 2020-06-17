<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloFPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloFPagos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xIDTipoDoc = New System.Windows.Forms.TextBox()
        Me.xNombreVendedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xVendedor = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xTipoDoc = New System.Windows.Forms.TextBox()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cFPago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xMonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xCantidadPagos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xObservacion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xTitular = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cEstado = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cBanco = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xCuenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xVouche = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.xTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.xFaltantePago = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xIDTipoDoc)
        Me.GroupBox1.Controls.Add(Me.xNombreVendedor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xVendedor)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xNumero)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xTipoDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 137)
        Me.GroupBox1.TabIndex = 239
        Me.GroupBox1.TabStop = False
        '
        'xIDTipoDoc
        '
        Me.xIDTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xIDTipoDoc.Location = New System.Drawing.Point(377, 51)
        Me.xIDTipoDoc.Name = "xIDTipoDoc"
        Me.xIDTipoDoc.Size = New System.Drawing.Size(57, 21)
        Me.xIDTipoDoc.TabIndex = 122
        Me.xIDTipoDoc.Visible = False
        '
        'xNombreVendedor
        '
        Me.xNombreVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreVendedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreVendedor.Location = New System.Drawing.Point(250, 107)
        Me.xNombreVendedor.Name = "xNombreVendedor"
        Me.xNombreVendedor.ReadOnly = True
        Me.xNombreVendedor.Size = New System.Drawing.Size(391, 21)
        Me.xNombreVendedor.TabIndex = 121
        Me.xNombreVendedor.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Vendedor"
        '
        'xVendedor
        '
        Me.xVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVendedor.Location = New System.Drawing.Point(138, 107)
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(106, 21)
        Me.xVendedor.TabIndex = 119
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombre.Location = New System.Drawing.Point(250, 79)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(391, 21)
        Me.xNombre.TabIndex = 116
        Me.xNombre.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cliente"
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.Location = New System.Drawing.Point(138, 79)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(106, 21)
        Me.xCliente.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Número"
        '
        'xNumero
        '
        Me.xNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumero.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNumero.Location = New System.Drawing.Point(138, 23)
        Me.xNumero.Name = "xNumero"
        Me.xNumero.Size = New System.Drawing.Size(144, 21)
        Me.xNumero.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de Documento"
        '
        'xTipoDoc
        '
        Me.xTipoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTipoDoc.Location = New System.Drawing.Point(138, 51)
        Me.xTipoDoc.Name = "xTipoDoc"
        Me.xTipoDoc.Size = New System.Drawing.Size(232, 21)
        Me.xTipoDoc.TabIndex = 4
        '
        'bAgregar
        '
        Me.bAgregar.BackColor = System.Drawing.Color.White
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregar.Image = Global.Rebusco.My.Resources.Resources.load24
        Me.bAgregar.Location = New System.Drawing.Point(787, 96)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(100, 36)
        Me.bAgregar.TabIndex = 238
        Me.bAgregar.Text = "Agregar"
        Me.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(219, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Forma de Pago"
        '
        'cFPago
        '
        Me.cFPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPago.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFPago.FormattingEnabled = True
        Me.cFPago.Location = New System.Drawing.Point(322, 25)
        Me.cFPago.Name = "cFPago"
        Me.cFPago.Size = New System.Drawing.Size(190, 23)
        Me.cFPago.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Monto"
        '
        'xMonto
        '
        Me.xMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xMonto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xMonto.Location = New System.Drawing.Point(97, 83)
        Me.xMonto.Name = "xMonto"
        Me.xMonto.Size = New System.Drawing.Size(116, 21)
        Me.xMonto.TabIndex = 117
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha"
        '
        'cFecha
        '
        Me.cFecha.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cFecha.Location = New System.Drawing.Point(97, 27)
        Me.cFecha.Name = "cFecha"
        Me.cFecha.Size = New System.Drawing.Size(116, 21)
        Me.cFecha.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(654, 16)
        Me.Label14.TabIndex = 241
        Me.Label14.Text = "Documento / Cliente"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.xTabla.Location = New System.Drawing.Point(12, 343)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(892, 165)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 242
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(698, 527)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 244
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(804, 527)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 243
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'xTotal
        '
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(104, 12)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(118, 21)
        Me.xTotal.TabIndex = 246
        Me.xTotal.TabStop = False
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(6, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Pagado"
        '
        'xCantidadPagos
        '
        Me.xCantidadPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xCantidadPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCantidadPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCantidadPagos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.xCantidadPagos.Location = New System.Drawing.Point(104, 99)
        Me.xCantidadPagos.MaxLength = 18
        Me.xCantidadPagos.Name = "xCantidadPagos"
        Me.xCantidadPagos.ReadOnly = True
        Me.xCantidadPagos.Size = New System.Drawing.Size(116, 21)
        Me.xCantidadPagos.TabIndex = 250
        Me.xCantidadPagos.TabStop = False
        Me.xCantidadPagos.Text = "0"
        Me.xCantidadPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cantidad Pagos"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(892, 19)
        Me.Label10.TabIndex = 247
        Me.Label10.Text = "Datos Pago"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xObservacion)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.xTitular)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cEstado)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cBanco)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.bAgregar)
        Me.GroupBox2.Controls.Add(Me.xCuenta)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.xVouche)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cFecha)
        Me.GroupBox2.Controls.Add(Me.xMonto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cFPago)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(892, 139)
        Me.GroupBox2.TabIndex = 248
        Me.GroupBox2.TabStop = False
        '
        'xObservacion
        '
        Me.xObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xObservacion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xObservacion.Location = New System.Drawing.Point(97, 111)
        Me.xObservacion.Name = "xObservacion"
        Me.xObservacion.Size = New System.Drawing.Size(679, 21)
        Me.xObservacion.TabIndex = 249
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(12, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 15)
        Me.Label17.TabIndex = 250
        Me.Label17.Text = "Observaciòn"
        '
        'xTitular
        '
        Me.xTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTitular.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTitular.Location = New System.Drawing.Point(572, 83)
        Me.xTitular.Name = "xTitular"
        Me.xTitular.Size = New System.Drawing.Size(204, 21)
        Me.xTitular.TabIndex = 247
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(517, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 15)
        Me.Label16.TabIndex = 248
        Me.Label16.Text = "Titular"
        '
        'cEstado
        '
        Me.cEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstado.FormattingEnabled = True
        Me.cEstado.Location = New System.Drawing.Point(322, 55)
        Me.cEstado.Name = "cEstado"
        Me.cEstado.Size = New System.Drawing.Size(190, 23)
        Me.cEstado.TabIndex = 245
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(219, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 15)
        Me.Label15.TabIndex = 246
        Me.Label15.Text = "Estado"
        '
        'cBanco
        '
        Me.cBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBanco.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cBanco.FormattingEnabled = True
        Me.cBanco.Location = New System.Drawing.Point(572, 25)
        Me.cBanco.Name = "cBanco"
        Me.cBanco.Size = New System.Drawing.Size(204, 23)
        Me.cBanco.TabIndex = 243
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(517, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 244
        Me.Label13.Text = "Banco"
        '
        'xCuenta
        '
        Me.xCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCuenta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCuenta.Location = New System.Drawing.Point(572, 55)
        Me.xCuenta.Name = "xCuenta"
        Me.xCuenta.Size = New System.Drawing.Size(204, 21)
        Me.xCuenta.TabIndex = 241
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(517, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 15)
        Me.Label12.TabIndex = 242
        Me.Label12.Text = "Cuenta"
        '
        'xVouche
        '
        Me.xVouche.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xVouche.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVouche.Location = New System.Drawing.Point(97, 55)
        Me.xVouche.Name = "xVouche"
        Me.xVouche.Size = New System.Drawing.Size(116, 21)
        Me.xVouche.TabIndex = 239
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(12, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 15)
        Me.Label11.TabIndex = 240
        Me.Label11.Text = "Numero Doc."
        '
        'xTotalPagar
        '
        Me.xTotalPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotalPagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTotalPagar.Location = New System.Drawing.Point(104, 65)
        Me.xTotalPagar.MaxLength = 18
        Me.xTotalPagar.Name = "xTotalPagar"
        Me.xTotalPagar.ReadOnly = True
        Me.xTotalPagar.Size = New System.Drawing.Size(118, 21)
        Me.xTotalPagar.TabIndex = 246
        Me.xTotalPagar.TabStop = False
        Me.xTotalPagar.Text = "0"
        Me.xTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(6, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Faltante"
        '
        'xFaltantePago
        '
        Me.xFaltantePago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xFaltantePago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xFaltantePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFaltantePago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xFaltantePago.Location = New System.Drawing.Point(104, 38)
        Me.xFaltantePago.MaxLength = 18
        Me.xFaltantePago.Name = "xFaltantePago"
        Me.xFaltantePago.ReadOnly = True
        Me.xFaltantePago.Size = New System.Drawing.Size(118, 21)
        Me.xFaltantePago.TabIndex = 246
        Me.xFaltantePago.TabStop = False
        Me.xFaltantePago.Text = "0"
        Me.xFaltantePago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(7, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 15)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Total a Pago"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(672, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(231, 16)
        Me.Label20.TabIndex = 249
        Me.Label20.Text = "Totales"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.xCantidadPagos)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.xTotalPagar)
        Me.GroupBox3.Controls.Add(Me.xTotal)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.xFaltantePago)
        Me.GroupBox3.Location = New System.Drawing.Point(672, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 128)
        Me.GroupBox3.TabIndex = 250
        Me.GroupBox3.TabStop = False
        '
        'bLimpiar
        '
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 527)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 251
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(916, 50)
        Me.WinDeco1.TabIndex = 252
        Me.WinDeco1.TituloVentana = "Formas de Pagos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ModuloFPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 575)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ModuloFPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas de Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents xTipoDoc As TextBox
    Friend WithEvents cFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents xNumero As TextBox
    Friend WithEvents cFPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xMonto As TextBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xNombreVendedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bGuardar As Button
    Public WithEvents bSalir As Button
    Public WithEvents bAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents xTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xCantidadPagos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xVouche As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cBanco As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents xCuenta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cEstado As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents xObservacion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents xTitular As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents xTotalPagar As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents xFaltantePago As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Public WithEvents bLimpiar As Button
    Friend WithEvents xIDTipoDoc As TextBox
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
