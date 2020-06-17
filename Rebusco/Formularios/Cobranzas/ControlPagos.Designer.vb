<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPagos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bBuscarV = New System.Windows.Forms.Button()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bBuscarA = New System.Windows.Forms.Button()
        Me.xVNombre = New System.Windows.Forms.TextBox()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xVendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xCantSeleccionado = New System.Windows.Forms.TextBox()
        Me.xTotalSeleccionado = New System.Windows.Forms.TextBox()
        Me.xNeto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xIva = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.xRegistro = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bConsultaMes = New System.Windows.Forms.Button()
        Me.bDeudas = New System.Windows.Forms.Button()
        Me.bMostrar = New System.Windows.Forms.Button()
        Me.bDirectorio = New System.Windows.Forms.Button()
        Me.bCopiar = New System.Windows.Forms.Button()
        Me.bListado = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.sBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.bBuscarV)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.bBuscarA)
        Me.GroupBox1.Controls.Add(Me.xVNombre)
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xVendedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cEstado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xCliente)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 234)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bBuscarV
        '
        Me.bBuscarV.BackColor = System.Drawing.Color.White
        Me.bBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarV.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarV.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarV.Location = New System.Drawing.Point(674, 165)
        Me.bBuscarV.Name = "bBuscarV"
        Me.bBuscarV.Size = New System.Drawing.Size(84, 27)
        Me.bBuscarV.TabIndex = 236
        Me.bBuscarV.Text = "Buscar"
        Me.bBuscarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarV.UseVisualStyleBackColor = False
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(122, 135)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(214, 23)
        Me.cLocal.TabIndex = 119
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Forma de Pago"
        '
        'cFormaPago
        '
        Me.cFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFormaPago.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cFormaPago.FormattingEnabled = True
        Me.cFormaPago.Location = New System.Drawing.Point(122, 75)
        Me.cFormaPago.Name = "cFormaPago"
        Me.cFormaPago.Size = New System.Drawing.Size(214, 23)
        Me.cFormaPago.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(12, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Local"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.dHasta)
        Me.GroupBox4.Controls.Add(Me.dDesde)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(530, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(234, 55)
        Me.GroupBox4.TabIndex = 235
        Me.GroupBox4.TabStop = False
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(124, 23)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(92, 21)
        Me.dHasta.TabIndex = 4
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(6, 23)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(92, 21)
        Me.dDesde.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(104, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "al"
        '
        'bBuscarA
        '
        Me.bBuscarA.BackColor = System.Drawing.Color.White
        Me.bBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarA.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarA.Location = New System.Drawing.Point(674, 193)
        Me.bBuscarA.Name = "bBuscarA"
        Me.bBuscarA.Size = New System.Drawing.Size(84, 27)
        Me.bBuscarA.TabIndex = 42
        Me.bBuscarA.Text = "Buscar"
        Me.bBuscarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarA.UseVisualStyleBackColor = False
        '
        'xVNombre
        '
        Me.xVNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xVNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVNombre.Location = New System.Drawing.Point(234, 167)
        Me.xVNombre.Name = "xVNombre"
        Me.xVNombre.ReadOnly = True
        Me.xVNombre.Size = New System.Drawing.Size(434, 21)
        Me.xVNombre.TabIndex = 115
        Me.xVNombre.TabStop = False
        '
        'cTipoDoc
        '
        Me.cTipoDoc.BackColor = System.Drawing.Color.White
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(122, 17)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(214, 23)
        Me.cTipoDoc.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Vendedor"
        '
        'xVendedor
        '
        Me.xVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xVendedor.Location = New System.Drawing.Point(122, 167)
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(106, 21)
        Me.xVendedor.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N° Documento"
        '
        'cEstado
        '
        Me.cEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstado.FormattingEnabled = True
        Me.cEstado.Location = New System.Drawing.Point(122, 105)
        Me.cEstado.Name = "cEstado"
        Me.cEstado.Size = New System.Drawing.Size(214, 23)
        Me.cEstado.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cliente"
        '
        'xNumero
        '
        Me.xNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumero.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNumero.Location = New System.Drawing.Point(122, 47)
        Me.xNumero.Name = "xNumero"
        Me.xNumero.Size = New System.Drawing.Size(106, 21)
        Me.xNumero.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Documento"
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xCliente.Location = New System.Drawing.Point(122, 196)
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(106, 21)
        Me.xCliente.TabIndex = 0
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombre.Location = New System.Drawing.Point(234, 196)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(434, 21)
        Me.xNombre.TabIndex = 23
        Me.xNombre.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(539, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rango de Fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xCantSeleccionado)
        Me.GroupBox2.Controls.Add(Me.xTotalSeleccionado)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 62)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        '
        'xCantSeleccionado
        '
        Me.xCantSeleccionado.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xCantSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCantSeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCantSeleccionado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCantSeleccionado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xCantSeleccionado.Location = New System.Drawing.Point(5, 23)
        Me.xCantSeleccionado.Name = "xCantSeleccionado"
        Me.xCantSeleccionado.ReadOnly = True
        Me.xCantSeleccionado.Size = New System.Drawing.Size(44, 21)
        Me.xCantSeleccionado.TabIndex = 20
        Me.xCantSeleccionado.Text = "0"
        Me.xCantSeleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xTotalSeleccionado
        '
        Me.xTotalSeleccionado.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xTotalSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotalSeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTotalSeleccionado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTotalSeleccionado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xTotalSeleccionado.Location = New System.Drawing.Point(55, 23)
        Me.xTotalSeleccionado.Name = "xTotalSeleccionado"
        Me.xTotalSeleccionado.ReadOnly = True
        Me.xTotalSeleccionado.Size = New System.Drawing.Size(195, 21)
        Me.xTotalSeleccionado.TabIndex = 22
        Me.xTotalSeleccionado.Text = "0"
        Me.xTotalSeleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xNeto
        '
        Me.xNeto.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNeto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNeto.Location = New System.Drawing.Point(77, 27)
        Me.xNeto.Name = "xNeto"
        Me.xNeto.ReadOnly = True
        Me.xNeto.Size = New System.Drawing.Size(173, 21)
        Me.xNeto.TabIndex = 107
        Me.xNeto.Text = "0"
        Me.xNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(8, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 15)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Neto"
        '
        'xIva
        '
        Me.xIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xIva.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xIva.Location = New System.Drawing.Point(77, 55)
        Me.xIva.Name = "xIva"
        Me.xIva.ReadOnly = True
        Me.xIva.Size = New System.Drawing.Size(173, 21)
        Me.xIva.TabIndex = 109
        Me.xIva.Text = "0"
        Me.xIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(8, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 15)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Iva"
        '
        'xTotal
        '
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTotal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTotal.Location = New System.Drawing.Point(77, 83)
        Me.xTotal.Name = "xTotal"
        Me.xTotal.ReadOnly = True
        Me.xTotal.Size = New System.Drawing.Size(173, 21)
        Me.xTotal.TabIndex = 111
        Me.xTotal.Text = "0"
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(8, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 15)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Total"
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Location = New System.Drawing.Point(1167, 583)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(57, 20)
        Me.TextBox10.TabIndex = 113
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(8, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 15)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Registros"
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
        Me.xTabla.Location = New System.Drawing.Point(9, 286)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(1137, 284)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 115
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'xRegistro
        '
        Me.xRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.xRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xRegistro.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xRegistro.Location = New System.Drawing.Point(189, 114)
        Me.xRegistro.Name = "xRegistro"
        Me.xRegistro.ReadOnly = True
        Me.xRegistro.Size = New System.Drawing.Size(61, 21)
        Me.xRegistro.TabIndex = 116
        Me.xRegistro.Text = "0"
        Me.xRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.xRegistro)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.xNeto)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.xIva)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.xTotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(779, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 227)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(-1, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(263, 16)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "Total Seleccionado"
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(1046, 580)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 3
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bConsultaMes
        '
        Me.bConsultaMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultaMes.BackColor = System.Drawing.Color.White
        Me.bConsultaMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultaMes.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultaMes.Image = Global.Rebusco.My.Resources.Resources.pagos24
        Me.bConsultaMes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bConsultaMes.Location = New System.Drawing.Point(1046, 134)
        Me.bConsultaMes.Name = "bConsultaMes"
        Me.bConsultaMes.Size = New System.Drawing.Size(96, 69)
        Me.bConsultaMes.TabIndex = 238
        Me.bConsultaMes.Tag = "Mes"
        Me.bConsultaMes.Text = "Consulta Mes Actual"
        Me.bConsultaMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bConsultaMes.UseVisualStyleBackColor = False
        '
        'bDeudas
        '
        Me.bDeudas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDeudas.BackColor = System.Drawing.Color.White
        Me.bDeudas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDeudas.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bDeudas.Image = Global.Rebusco.My.Resources.Resources.adeudado24
        Me.bDeudas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bDeudas.Location = New System.Drawing.Point(1046, 56)
        Me.bDeudas.Name = "bDeudas"
        Me.bDeudas.Size = New System.Drawing.Size(96, 68)
        Me.bDeudas.TabIndex = 236
        Me.bDeudas.Tag = "Adeudado"
        Me.bDeudas.Text = "Adeudado"
        Me.bDeudas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bDeudas.UseVisualStyleBackColor = False
        '
        'bMostrar
        '
        Me.bMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMostrar.BackColor = System.Drawing.Color.White
        Me.bMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMostrar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bMostrar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bMostrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bMostrar.Location = New System.Drawing.Point(1047, 213)
        Me.bMostrar.Name = "bMostrar"
        Me.bMostrar.Size = New System.Drawing.Size(96, 68)
        Me.bMostrar.TabIndex = 235
        Me.bMostrar.Tag = "Todos"
        Me.bMostrar.Text = "Consultar"
        Me.bMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bMostrar.UseVisualStyleBackColor = False
        '
        'bDirectorio
        '
        Me.bDirectorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDirectorio.BackColor = System.Drawing.Color.White
        Me.bDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDirectorio.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bDirectorio.Image = Global.Rebusco.My.Resources.Resources.folder_open
        Me.bDirectorio.Location = New System.Drawing.Point(197, 580)
        Me.bDirectorio.Name = "bDirectorio"
        Me.bDirectorio.Size = New System.Drawing.Size(212, 36)
        Me.bDirectorio.TabIndex = 119
        Me.bDirectorio.Text = " Abrir Directorio Facturas"
        Me.bDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bDirectorio.UseVisualStyleBackColor = False
        '
        'bCopiar
        '
        Me.bCopiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bCopiar.BackColor = System.Drawing.Color.White
        Me.bCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCopiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCopiar.Image = Global.Rebusco.My.Resources.Resources.clipboard_copy
        Me.bCopiar.Location = New System.Drawing.Point(103, 580)
        Me.bCopiar.Name = "bCopiar"
        Me.bCopiar.Size = New System.Drawing.Size(88, 36)
        Me.bCopiar.TabIndex = 118
        Me.bCopiar.Text = " Copiar"
        Me.bCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCopiar.UseVisualStyleBackColor = False
        '
        'bListado
        '
        Me.bListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bListado.BackColor = System.Drawing.Color.White
        Me.bListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bListado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bListado.Image = Global.Rebusco.My.Resources.Resources.Payment241
        Me.bListado.Location = New System.Drawing.Point(415, 580)
        Me.bListado.Name = "bListado"
        Me.bListado.Size = New System.Drawing.Size(150, 36)
        Me.bListado.TabIndex = 46
        Me.bListado.Text = " Listado de Pagos"
        Me.bListado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bListado.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save
        Me.bGuardar.Location = New System.Drawing.Point(907, 580)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(128, 36)
        Me.bGuardar.TabIndex = 47
        Me.bGuardar.Text = "Grabar Pagos"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(9, 581)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(88, 36)
        Me.bLimpiar.TabIndex = 4
        Me.bLimpiar.Text = " Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso})
        Me.sBarra.Location = New System.Drawing.Point(0, 619)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(1155, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 239
        Me.sBarra.Text = "StatusStrip1"
        '
        'tMensajeBarra
        '
        Me.tMensajeBarra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tMensajeBarra.ForeColor = System.Drawing.Color.White
        Me.tMensajeBarra.Name = "tMensajeBarra"
        Me.tMensajeBarra.Size = New System.Drawing.Size(206, 17)
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
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(779, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(262, 16)
        Me.Label15.TabIndex = 240
        Me.Label15.Text = "Total Documentos"
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
        Me.WinDeco1.Size = New System.Drawing.Size(1155, 50)
        Me.WinDeco1.TabIndex = 241
        Me.WinDeco1.TituloVentana = "Control de Pagos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ControlPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 641)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.sBarra)
        Me.Controls.Add(Me.bConsultaMes)
        Me.Controls.Add(Me.bDeudas)
        Me.Controls.Add(Me.bMostrar)
        Me.Controls.Add(Me.bDirectorio)
        Me.Controls.Add(Me.bCopiar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.bListado)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ControlPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.sBarra.ResumeLayout(False)
        Me.sBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents xNumero As TextBox
    Friend WithEvents xTotalSeleccionado As TextBox
    Friend WithEvents xCantSeleccionado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents cEstado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cFormaPago As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents xCliente As TextBox
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Public WithEvents bBuscarA As Button
    Public WithEvents bListado As Button
    Public WithEvents bGuardar As Button
    Friend WithEvents xNeto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents xIva As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents xTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xVNombre As TextBox
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents xRegistro As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cLocal As ComboBox
    Public WithEvents bCopiar As Button
    Public WithEvents bDirectorio As Button
    
    Friend WithEvents GroupBox4 As GroupBox
    Public WithEvents bBuscarV As Button
    Public WithEvents bMostrar As Button
    Public WithEvents bDeudas As Button
    Public WithEvents bConsultaMes As Button
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
