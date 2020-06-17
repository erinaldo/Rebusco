<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosBicicleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosBicicleta))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cFPago = New System.Windows.Forms.ComboBox()
        Me.cDesde = New System.Windows.Forms.DateTimePicker()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xDocumento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xAño = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xSerie = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xSKU = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xTalla = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xColor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xModelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xMarca = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.GroupBox()
        Me.cComuna = New System.Windows.Forms.ComboBox()
        Me.cCiudad = New System.Windows.Forms.ComboBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.xCorreo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.xTelefono = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.xDireccion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.xRut = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lCodigo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Label21.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cFPago)
        Me.GroupBox2.Controls.Add(Me.cDesde)
        Me.GroupBox2.Controls.Add(Me.cLocal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.xDocumento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 221)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 15)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Número Boleta / Voucher / Factura"
        '
        'cFPago
        '
        Me.cFPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPago.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cFPago.FormattingEnabled = True
        Me.cFPago.Location = New System.Drawing.Point(12, 134)
        Me.cFPago.Name = "cFPago"
        Me.cFPago.Size = New System.Drawing.Size(291, 23)
        Me.cFPago.TabIndex = 1
        '
        'cDesde
        '
        Me.cDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cDesde.Location = New System.Drawing.Point(12, 90)
        Me.cDesde.Name = "cDesde"
        Me.cDesde.Size = New System.Drawing.Size(94, 21)
        Me.cDesde.TabIndex = 245
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(12, 44)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(291, 23)
        Me.cLocal.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Local"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Forma de Pago"
        '
        'xDocumento
        '
        Me.xDocumento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDocumento.Location = New System.Drawing.Point(12, 180)
        Me.xDocumento.Name = "xDocumento"
        Me.xDocumento.ReadOnly = True
        Me.xDocumento.Size = New System.Drawing.Size(134, 21)
        Me.xDocumento.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(309, 16)
        Me.Label14.TabIndex = 240
        Me.Label14.Text = "Datos de Pagos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(327, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(522, 16)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Detalles de Artículo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.xAño)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.xSerie)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.xSKU)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.xTalla)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.xColor)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.xModelo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.xMarca)
        Me.GroupBox3.Location = New System.Drawing.Point(327, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(522, 221)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'xAño
        '
        Me.xAño.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xAño.Location = New System.Drawing.Point(102, 134)
        Me.xAño.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.xAño.Name = "xAño"
        Me.xAño.Size = New System.Drawing.Size(78, 21)
        Me.xAño.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(12, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Número Serie"
        '
        'xSerie
        '
        Me.xSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xSerie.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xSerie.Location = New System.Drawing.Point(102, 190)
        Me.xSerie.Name = "xSerie"
        Me.xSerie.Size = New System.Drawing.Size(414, 21)
        Me.xSerie.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(12, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Código / SKU"
        '
        'xSKU
        '
        Me.xSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xSKU.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xSKU.Location = New System.Drawing.Point(102, 162)
        Me.xSKU.Name = "xSKU"
        Me.xSKU.Size = New System.Drawing.Size(414, 21)
        Me.xSKU.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(12, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 15)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Año"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Talla"
        '
        'xTalla
        '
        Me.xTalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTalla.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTalla.Location = New System.Drawing.Point(102, 106)
        Me.xTalla.Name = "xTalla"
        Me.xTalla.Size = New System.Drawing.Size(414, 21)
        Me.xTalla.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(12, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Color"
        '
        'xColor
        '
        Me.xColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xColor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xColor.Location = New System.Drawing.Point(102, 78)
        Me.xColor.Name = "xColor"
        Me.xColor.Size = New System.Drawing.Size(414, 21)
        Me.xColor.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Modelo"
        '
        'xModelo
        '
        Me.xModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xModelo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xModelo.Location = New System.Drawing.Point(102, 50)
        Me.xModelo.Name = "xModelo"
        Me.xModelo.Size = New System.Drawing.Size(414, 21)
        Me.xModelo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Marca"
        '
        'xMarca
        '
        Me.xMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xMarca.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xMarca.Location = New System.Drawing.Point(102, 22)
        Me.xMarca.Name = "xMarca"
        Me.xMarca.Size = New System.Drawing.Size(414, 21)
        Me.xMarca.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Controls.Add(Me.cComuna)
        Me.Label21.Controls.Add(Me.cCiudad)
        Me.Label21.Controls.Add(Me.label23)
        Me.Label21.Controls.Add(Me.Label22)
        Me.Label21.Controls.Add(Me.xCorreo)
        Me.Label21.Controls.Add(Me.Label24)
        Me.Label21.Controls.Add(Me.xTelefono)
        Me.Label21.Controls.Add(Me.Label20)
        Me.Label21.Controls.Add(Me.xCliente)
        Me.Label21.Controls.Add(Me.Label19)
        Me.Label21.Controls.Add(Me.Label18)
        Me.Label21.Controls.Add(Me.xDireccion)
        Me.Label21.Controls.Add(Me.Label17)
        Me.Label21.Controls.Add(Me.xNombre)
        Me.Label21.Controls.Add(Me.Label16)
        Me.Label21.Controls.Add(Me.xRut)
        Me.Label21.Location = New System.Drawing.Point(12, 363)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(837, 146)
        Me.Label21.TabIndex = 2
        Me.Label21.TabStop = False
        '
        'cComuna
        '
        Me.cComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cComuna.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cComuna.FormattingEnabled = True
        Me.cComuna.Location = New System.Drawing.Point(634, 81)
        Me.cComuna.Name = "cComuna"
        Me.cComuna.Size = New System.Drawing.Size(197, 23)
        Me.cComuna.TabIndex = 255
        '
        'cCiudad
        '
        Me.cCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCiudad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCiudad.FormattingEnabled = True
        Me.cCiudad.Location = New System.Drawing.Point(634, 52)
        Me.cCiudad.Name = "cCiudad"
        Me.cCiudad.Size = New System.Drawing.Size(197, 23)
        Me.cCiudad.TabIndex = 256
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.label23.Location = New System.Drawing.Point(566, 55)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(55, 15)
        Me.label23.TabIndex = 21
        Me.label23.Text = "Comuna"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(566, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Correo"
        '
        'xCorreo
        '
        Me.xCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCorreo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCorreo.Location = New System.Drawing.Point(634, 25)
        Me.xCorreo.Name = "xCorreo"
        Me.xCorreo.Size = New System.Drawing.Size(197, 21)
        Me.xCorreo.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label24.Location = New System.Drawing.Point(9, 111)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 15)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Teléfono"
        '
        'xTelefono
        '
        Me.xTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTelefono.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTelefono.Location = New System.Drawing.Point(77, 108)
        Me.xTelefono.Name = "xTelefono"
        Me.xTelefono.Size = New System.Drawing.Size(197, 21)
        Me.xTelefono.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(365, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 15)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Cliente"
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.Location = New System.Drawing.Point(417, 22)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.ReadOnly = True
        Me.xCliente.Size = New System.Drawing.Size(121, 21)
        Me.xCliente.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(566, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Ciudad"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(9, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 15)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Dirección"
        '
        'xDireccion
        '
        Me.xDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xDireccion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDireccion.Location = New System.Drawing.Point(77, 81)
        Me.xDireccion.Name = "xDireccion"
        Me.xDireccion.Size = New System.Drawing.Size(470, 21)
        Me.xDireccion.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(9, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Nombre"
        '
        'xNombre
        '
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombre.Location = New System.Drawing.Point(77, 53)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(470, 21)
        Me.xNombre.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(9, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 15)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Rut"
        '
        'xRut
        '
        Me.xRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xRut.Location = New System.Drawing.Point(77, 25)
        Me.xRut.Name = "xRut"
        Me.xRut.ReadOnly = True
        Me.xRut.Size = New System.Drawing.Size(121, 21)
        Me.xRut.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(12, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(837, 16)
        Me.Label15.TabIndex = 244
        Me.Label15.Text = "Datos del Cliente"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(651, 537)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(96, 36)
        Me.bGuardar.TabIndex = 246
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.bSalir.Location = New System.Drawing.Point(753, 537)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(96, 36)
        Me.bSalir.TabIndex = 247
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 248
        Me.Label1.Text = "Descripción"
        '
        'lDescripcion
        '
        Me.lDescripcion.AutoSize = True
        Me.lDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lDescripcion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDescripcion.Location = New System.Drawing.Point(117, 46)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(12, 16)
        Me.lDescripcion.TabIndex = 249
        Me.lDescripcion.Text = "."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(11, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 16)
        Me.Label26.TabIndex = 250
        Me.Label26.Text = "Código"
        '
        'lCodigo
        '
        Me.lCodigo.AutoSize = True
        Me.lCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lCodigo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCodigo.Location = New System.Drawing.Point(117, 24)
        Me.lCodigo.Name = "lCodigo"
        Me.lCodigo.Size = New System.Drawing.Size(12, 16)
        Me.lCodigo.TabIndex = 251
        Me.lCodigo.Text = "."
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(12, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(837, 16)
        Me.Label25.TabIndex = 252
        Me.Label25.Text = "Artículo"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lDescripcion)
        Me.GroupBox1.Controls.Add(Me.lCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 69)
        Me.GroupBox1.TabIndex = 253
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
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
        Me.WinDeco1.Size = New System.Drawing.Size(861, 50)
        Me.WinDeco1.TabIndex = 254
        Me.WinDeco1.TituloVentana = "Datos de Bicicleta"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'DatosBicicleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 585)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "DatosBicicleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Bicicleta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.xAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Label21.ResumeLayout(False)
        Me.Label21.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents xDocumento As TextBox
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cFPago As ComboBox
    Friend WithEvents cDesde As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents xSerie As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents xSKU As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents xTalla As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xColor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xModelo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xMarca As TextBox
    Friend WithEvents Label21 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents xCorreo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents xTelefono As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents xCliente As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents xDireccion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents xNombre As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents xRut As TextBox
    Public WithEvents bGuardar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lDescripcion As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lCodigo As Label
    Friend WithEvents xAño As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents cComuna As ComboBox
    Friend WithEvents cCiudad As ComboBox
End Class
