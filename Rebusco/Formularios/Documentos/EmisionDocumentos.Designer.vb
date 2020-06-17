<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmisionDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmisionDocumentos))
        Me.xTipoDocRef = New System.Windows.Forms.TextBox()
        Me.lMotivo = New System.Windows.Forms.Label()
        Me.cMotivo = New System.Windows.Forms.ComboBox()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xNomVen = New System.Windows.Forms.TextBox()
        Me.xVendedor = New System.Windows.Forms.TextBox()
        Me.cFPago = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fDetalles = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.bQuitar = New System.Windows.Forms.Button()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bLimpiarArt = New System.Windows.Forms.Button()
        Me.BuscarArt = New System.Windows.Forms.Button()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nLineas = New System.Windows.Forms.TextBox()
        Me.lLineas = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.fObservaciones = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.xObs = New System.Windows.Forms.TextBox()
        Me.fTotales = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xTotal = New System.Windows.Forms.TextBox()
        Me.xImpuestos = New System.Windows.Forms.TextBox()
        Me.xIVA = New System.Windows.Forms.TextBox()
        Me.xNeto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.xDescuento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xSubTotal = New System.Windows.Forms.TextBox()
        Me.fImpuestos = New System.Windows.Forms.GroupBox()
        Me.xFEP = New System.Windows.Forms.TextBox()
        Me.Tabacos = New System.Windows.Forms.Label()
        Me.xTAB = New System.Windows.Forms.TextBox()
        Me.xHAR = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.xCAR = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.xLIC = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.xVIN = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.xCER = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.xBEB = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.xMIN = New System.Windows.Forms.TextBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.gExtra = New System.Windows.Forms.GroupBox()
        Me.bProcesarDoc = New System.Windows.Forms.Button()
        Me.xFechaDocRef = New System.Windows.Forms.DateTimePicker()
        Me.xNumDocRef = New System.Windows.Forms.TextBox()
        Me.cTipoDocRef = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xDireccion = New System.Windows.Forms.TextBox()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.bBuscarCli = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xCiudad = New System.Windows.Forms.TextBox()
        Me.xComuna = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bCrearCli = New System.Windows.Forms.Button()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.xNumDoc = New System.Windows.Forms.TextBox()
        Me.xRut = New System.Windows.Forms.MaskedTextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.fGeneral = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.xCambiarPOS = New System.Windows.Forms.Button()
        Me.xPOS = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.oElectronico = New Rebusco.CustomCheck()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.xFantasia = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.bDirectorio = New System.Windows.Forms.Button()
        Me.fDetalles.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fObservaciones.SuspendLayout()
        Me.fTotales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.fImpuestos.SuspendLayout()
        Me.gExtra.SuspendLayout()
        Me.fGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'xTipoDocRef
        '
        Me.xTipoDocRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xTipoDocRef.Location = New System.Drawing.Point(413, 16)
        Me.xTipoDocRef.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xTipoDocRef.Name = "xTipoDocRef"
        Me.xTipoDocRef.ReadOnly = True
        Me.xTipoDocRef.Size = New System.Drawing.Size(29, 22)
        Me.xTipoDocRef.TabIndex = 129
        Me.xTipoDocRef.TabStop = False
        Me.xTipoDocRef.Visible = False
        '
        'lMotivo
        '
        Me.lMotivo.AutoSize = True
        Me.lMotivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMotivo.Location = New System.Drawing.Point(981, 149)
        Me.lMotivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lMotivo.Name = "lMotivo"
        Me.lMotivo.Size = New System.Drawing.Size(124, 17)
        Me.lMotivo.TabIndex = 125
        Me.lMotivo.Text = "Motivo de emisión"
        '
        'cMotivo
        '
        Me.cMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMotivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cMotivo.FormattingEnabled = True
        Me.cMotivo.Location = New System.Drawing.Point(1133, 144)
        Me.cMotivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cMotivo.Name = "cMotivo"
        Me.cMotivo.Size = New System.Drawing.Size(200, 25)
        Me.cMotivo.TabIndex = 124
        '
        'xLocal
        '
        Me.xLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xLocal.Location = New System.Drawing.Point(637, 14)
        Me.xLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xLocal.Name = "xLocal"
        Me.xLocal.ReadOnly = True
        Me.xLocal.Size = New System.Drawing.Size(205, 25)
        Me.xLocal.TabIndex = 121
        Me.xLocal.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(560, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Local"
        Me.Label9.Visible = False
        '
        'xFecha
        '
        Me.xFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xFecha.Location = New System.Drawing.Point(143, 15)
        Me.xFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xFecha.Name = "xFecha"
        Me.xFecha.Size = New System.Drawing.Size(200, 23)
        Me.xFecha.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 48)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Forma de Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Fecha Emisión"
        '
        'xNomVen
        '
        Me.xNomVen.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNomVen.Location = New System.Drawing.Point(143, 76)
        Me.xNomVen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xNomVen.Name = "xNomVen"
        Me.xNomVen.ReadOnly = True
        Me.xNomVen.Size = New System.Drawing.Size(200, 23)
        Me.xNomVen.TabIndex = 104
        Me.xNomVen.TabStop = False
        '
        'xVendedor
        '
        Me.xVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xVendedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xVendedor.Location = New System.Drawing.Point(92, 76)
        Me.xVendedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xVendedor.MaxLength = 18
        Me.xVendedor.Name = "xVendedor"
        Me.xVendedor.Size = New System.Drawing.Size(45, 23)
        Me.xVendedor.TabIndex = 10
        Me.xVendedor.Visible = False
        '
        'cFPago
        '
        Me.cFPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cFPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cFPago.FormattingEnabled = True
        Me.cFPago.Location = New System.Drawing.Point(143, 43)
        Me.cFPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cFPago.Name = "cFPago"
        Me.cFPago.Size = New System.Drawing.Size(200, 24)
        Me.cFPago.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 80)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Vendedor"
        '
        'fDetalles
        '
        Me.fDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fDetalles.BackColor = System.Drawing.Color.Transparent
        Me.fDetalles.Controls.Add(Me.Label31)
        Me.fDetalles.Controls.Add(Me.xArticulo)
        Me.fDetalles.Controls.Add(Me.bQuitar)
        Me.fDetalles.Controls.Add(Me.xTabla)
        Me.fDetalles.Controls.Add(Me.bLimpiarArt)
        Me.fDetalles.Controls.Add(Me.BuscarArt)
        Me.fDetalles.Controls.Add(Me.bAgregar)
        Me.fDetalles.Controls.Add(Me.Label13)
        Me.fDetalles.Controls.Add(Me.Label12)
        Me.fDetalles.Controls.Add(Me.nLineas)
        Me.fDetalles.Controls.Add(Me.lLineas)
        Me.fDetalles.Controls.Add(Me.xDescripcion)
        Me.fDetalles.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fDetalles.Location = New System.Drawing.Point(16, 244)
        Me.fDetalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fDetalles.Name = "fDetalles"
        Me.fDetalles.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fDetalles.Size = New System.Drawing.Size(1347, 246)
        Me.fDetalles.TabIndex = 100
        Me.fDetalles.TabStop = False
        Me.fDetalles.Text = "Detalles"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(-4, 0)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(132, 20)
        Me.Label31.TabIndex = 252
        Me.Label31.Text = " Detalles"
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 800
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = "SKU"
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = ""
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(175, 17)
        Me.xArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(189, 26)
        Me.xArticulo.TabIndex = 117
        Me.xArticulo.TablaBusqueda = "BuscadorAutocompletar"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bQuitar
        '
        Me.bQuitar.BackColor = System.Drawing.Color.White
        Me.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bQuitar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bQuitar.Image = Global.Rebusco.My.Resources.Resources.null
        Me.bQuitar.Location = New System.Drawing.Point(621, 14)
        Me.bQuitar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bQuitar.Name = "bQuitar"
        Me.bQuitar.Size = New System.Drawing.Size(116, 34)
        Me.bQuitar.TabIndex = 116
        Me.bQuitar.Text = "Quitar"
        Me.bQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bQuitar.UseVisualStyleBackColor = False
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = resources.GetString("xTabla.ColumnInfo")
        Me.xTabla.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xTabla.Location = New System.Drawing.Point(12, 81)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 24
        Me.xTabla.Size = New System.Drawing.Size(1325, 160)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 115
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bLimpiarArt
        '
        Me.bLimpiarArt.BackColor = System.Drawing.Color.White
        Me.bLimpiarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiarArt.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiarArt.Image = Global.Rebusco.My.Resources.Resources.clean16
        Me.bLimpiarArt.Location = New System.Drawing.Point(863, 14)
        Me.bLimpiarArt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bLimpiarArt.Name = "bLimpiarArt"
        Me.bLimpiarArt.Size = New System.Drawing.Size(116, 34)
        Me.bLimpiarArt.TabIndex = 113
        Me.bLimpiarArt.Text = "Limpiar"
        Me.bLimpiarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiarArt.UseVisualStyleBackColor = False
        '
        'BuscarArt
        '
        Me.BuscarArt.BackColor = System.Drawing.Color.White
        Me.BuscarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarArt.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.BuscarArt.Image = CType(resources.GetObject("BuscarArt.Image"), System.Drawing.Image)
        Me.BuscarArt.Location = New System.Drawing.Point(497, 14)
        Me.BuscarArt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuscarArt.Name = "BuscarArt"
        Me.BuscarArt.Size = New System.Drawing.Size(116, 34)
        Me.BuscarArt.TabIndex = 111
        Me.BuscarArt.Text = "Buscar"
        Me.BuscarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BuscarArt.UseVisualStyleBackColor = False
        '
        'bAgregar
        '
        Me.bAgregar.BackColor = System.Drawing.Color.White
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregar.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bAgregar.Location = New System.Drawing.Point(373, 14)
        Me.bAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(116, 34)
        Me.bAgregar.TabIndex = 109
        Me.bAgregar.Text = "Agregar"
        Me.bAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 55)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Descripción"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Artículo"
        '
        'nLineas
        '
        Me.nLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nLineas.BackColor = System.Drawing.Color.Yellow
        Me.nLineas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nLineas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nLineas.ForeColor = System.Drawing.Color.Black
        Me.nLineas.Location = New System.Drawing.Point(1212, 18)
        Me.nLineas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nLineas.MaxLength = 18
        Me.nLineas.Name = "nLineas"
        Me.nLineas.Size = New System.Drawing.Size(122, 23)
        Me.nLineas.TabIndex = 108
        Me.nLineas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lLineas
        '
        Me.lLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lLineas.BackColor = System.Drawing.Color.Transparent
        Me.lLineas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLineas.ForeColor = System.Drawing.Color.Black
        Me.lLineas.Location = New System.Drawing.Point(1129, 20)
        Me.lLineas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lLineas.Name = "lLineas"
        Me.lLineas.Size = New System.Drawing.Size(81, 27)
        Me.lLineas.TabIndex = 111
        Me.lLineas.Text = "N° Líneas"
        Me.lLineas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xDescripcion
        '
        Me.xDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescripcion.Location = New System.Drawing.Point(175, 52)
        Me.xDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(1161, 23)
        Me.xDescripcion.TabIndex = 106
        Me.xDescripcion.TabStop = False
        '
        'fObservaciones
        '
        Me.fObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.fObservaciones.Controls.Add(Me.Label28)
        Me.fObservaciones.Controls.Add(Me.xObs)
        Me.fObservaciones.Location = New System.Drawing.Point(16, 492)
        Me.fObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fObservaciones.Name = "fObservaciones"
        Me.fObservaciones.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fObservaciones.Size = New System.Drawing.Size(467, 191)
        Me.fObservaciones.TabIndex = 101
        Me.fObservaciones.TabStop = False
        Me.fObservaciones.Text = "Observaciones"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(0, 0)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(467, 20)
        Me.Label28.TabIndex = 251
        Me.Label28.Text = "Observaciones"
        '
        'xObs
        '
        Me.xObs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xObs.Location = New System.Drawing.Point(15, 23)
        Me.xObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xObs.MaxLength = 4000
        Me.xObs.Multiline = True
        Me.xObs.Name = "xObs"
        Me.xObs.Size = New System.Drawing.Size(436, 155)
        Me.xObs.TabIndex = 11
        '
        'fTotales
        '
        Me.fTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fTotales.BackColor = System.Drawing.Color.Transparent
        Me.fTotales.Controls.Add(Me.Panel1)
        Me.fTotales.Controls.Add(Me.Label10)
        Me.fTotales.Controls.Add(Me.Label19)
        Me.fTotales.Controls.Add(Me.Label18)
        Me.fTotales.Controls.Add(Me.Label17)
        Me.fTotales.Controls.Add(Me.xTotal)
        Me.fTotales.Controls.Add(Me.xImpuestos)
        Me.fTotales.Controls.Add(Me.xIVA)
        Me.fTotales.Controls.Add(Me.xNeto)
        Me.fTotales.Controls.Add(Me.Label16)
        Me.fTotales.Controls.Add(Me.xDescuento)
        Me.fTotales.Controls.Add(Me.Label14)
        Me.fTotales.Controls.Add(Me.xSubTotal)
        Me.fTotales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.fTotales.Location = New System.Drawing.Point(989, 494)
        Me.fTotales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fTotales.Name = "fTotales"
        Me.fTotales.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fTotales.Size = New System.Drawing.Size(373, 198)
        Me.fTotales.TabIndex = 102
        Me.fTotales.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Location = New System.Drawing.Point(24, 162)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 31)
        Me.Panel1.TabIndex = 342
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(1, 7)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 19)
        Me.Label20.TabIndex = 256
        Me.Label20.Text = "TOTAL"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-3, -1)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(375, 20)
        Me.Label10.TabIndex = 250
        Me.Label10.Text = "Totales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(25, 139)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(140, 19)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "Otros Impuestos"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(25, 110)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 19)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "IVA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(25, 81)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 19)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Neto"
        '
        'xTotal
        '
        Me.xTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.xTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(176, 166)
        Me.xTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xTotal.MaxLength = 18
        Me.xTotal.Name = "xTotal"
        Me.xTotal.Size = New System.Drawing.Size(187, 29)
        Me.xTotal.TabIndex = 128
        Me.xTotal.TabStop = False
        Me.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xImpuestos
        '
        Me.xImpuestos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xImpuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xImpuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xImpuestos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xImpuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.xImpuestos.Location = New System.Drawing.Point(176, 133)
        Me.xImpuestos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xImpuestos.MaxLength = 18
        Me.xImpuestos.Name = "xImpuestos"
        Me.xImpuestos.Size = New System.Drawing.Size(187, 26)
        Me.xImpuestos.TabIndex = 127
        Me.xImpuestos.TabStop = False
        Me.xImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xIVA
        '
        Me.xIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xIVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.xIVA.Location = New System.Drawing.Point(176, 105)
        Me.xIVA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xIVA.MaxLength = 18
        Me.xIVA.Name = "xIVA"
        Me.xIVA.Size = New System.Drawing.Size(187, 26)
        Me.xIVA.TabIndex = 126
        Me.xIVA.TabStop = False
        Me.xIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xNeto
        '
        Me.xNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xNeto.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNeto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNeto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.xNeto.Location = New System.Drawing.Point(176, 76)
        Me.xNeto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xNeto.MaxLength = 18
        Me.xNeto.Name = "xNeto"
        Me.xNeto.Size = New System.Drawing.Size(187, 26)
        Me.xNeto.TabIndex = 125
        Me.xNeto.TabStop = False
        Me.xNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(25, 53)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 19)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Descuentos"
        '
        'xDescuento
        '
        Me.xDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.xDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xDescuento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescuento.ForeColor = System.Drawing.Color.Olive
        Me.xDescuento.Location = New System.Drawing.Point(176, 48)
        Me.xDescuento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xDescuento.MaxLength = 18
        Me.xDescuento.Name = "xDescuento"
        Me.xDescuento.Size = New System.Drawing.Size(187, 26)
        Me.xDescuento.TabIndex = 124
        Me.xDescuento.TabStop = False
        Me.xDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(25, 25)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 19)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Sub Total"
        '
        'xSubTotal
        '
        Me.xSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.xSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xSubTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xSubTotal.Location = New System.Drawing.Point(176, 20)
        Me.xSubTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xSubTotal.MaxLength = 18
        Me.xSubTotal.Name = "xSubTotal"
        Me.xSubTotal.Size = New System.Drawing.Size(187, 26)
        Me.xSubTotal.TabIndex = 123
        Me.xSubTotal.TabStop = False
        Me.xSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fImpuestos
        '
        Me.fImpuestos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fImpuestos.BackColor = System.Drawing.Color.Transparent
        Me.fImpuestos.Controls.Add(Me.xFEP)
        Me.fImpuestos.Controls.Add(Me.Tabacos)
        Me.fImpuestos.Controls.Add(Me.xTAB)
        Me.fImpuestos.Controls.Add(Me.xHAR)
        Me.fImpuestos.Controls.Add(Me.Label27)
        Me.fImpuestos.Controls.Add(Me.xCAR)
        Me.fImpuestos.Controls.Add(Me.Label26)
        Me.fImpuestos.Controls.Add(Me.xLIC)
        Me.fImpuestos.Controls.Add(Me.Label25)
        Me.fImpuestos.Controls.Add(Me.xVIN)
        Me.fImpuestos.Controls.Add(Me.Label24)
        Me.fImpuestos.Controls.Add(Me.xCER)
        Me.fImpuestos.Controls.Add(Me.Label23)
        Me.fImpuestos.Controls.Add(Me.xBEB)
        Me.fImpuestos.Controls.Add(Me.Label22)
        Me.fImpuestos.Controls.Add(Me.Label21)
        Me.fImpuestos.Controls.Add(Me.Label15)
        Me.fImpuestos.Controls.Add(Me.xMIN)
        Me.fImpuestos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.fImpuestos.Location = New System.Drawing.Point(496, 489)
        Me.fImpuestos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fImpuestos.Name = "fImpuestos"
        Me.fImpuestos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fImpuestos.Size = New System.Drawing.Size(483, 215)
        Me.fImpuestos.TabIndex = 103
        Me.fImpuestos.TabStop = False
        Me.fImpuestos.Text = "Impuestos"
        Me.fImpuestos.Visible = False
        '
        'xFEP
        '
        Me.xFEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFEP.Location = New System.Drawing.Point(369, 183)
        Me.xFEP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xFEP.MaxLength = 18
        Me.xFEP.Name = "xFEP"
        Me.xFEP.Size = New System.Drawing.Size(99, 20)
        Me.xFEP.TabIndex = 100
        Me.xFEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tabacos
        '
        Me.Tabacos.AutoSize = True
        Me.Tabacos.BackColor = System.Drawing.Color.Transparent
        Me.Tabacos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabacos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Tabacos.Location = New System.Drawing.Point(8, 165)
        Me.Tabacos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Tabacos.Name = "Tabacos"
        Me.Tabacos.Size = New System.Drawing.Size(65, 16)
        Me.Tabacos.TabIndex = 115
        Me.Tabacos.Text = "Tabacos"
        '
        'xTAB
        '
        Me.xTAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTAB.Location = New System.Drawing.Point(369, 162)
        Me.xTAB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xTAB.MaxLength = 18
        Me.xTAB.Name = "xTAB"
        Me.xTAB.Size = New System.Drawing.Size(99, 20)
        Me.xTAB.TabIndex = 108
        Me.xTAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xHAR
        '
        Me.xHAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xHAR.Location = New System.Drawing.Point(369, 142)
        Me.xHAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xHAR.MaxLength = 18
        Me.xHAR.Name = "xHAR"
        Me.xHAR.Size = New System.Drawing.Size(99, 20)
        Me.xHAR.TabIndex = 107
        Me.xHAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(8, 144)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 16)
        Me.Label27.TabIndex = 112
        Me.Label27.Text = "Harinas"
        '
        'xCAR
        '
        Me.xCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCAR.Location = New System.Drawing.Point(369, 121)
        Me.xCAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xCAR.MaxLength = 18
        Me.xCAR.Name = "xCAR"
        Me.xCAR.Size = New System.Drawing.Size(99, 20)
        Me.xCAR.TabIndex = 106
        Me.xCAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(8, 123)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 16)
        Me.Label26.TabIndex = 110
        Me.Label26.Text = "Carnes"
        '
        'xLIC
        '
        Me.xLIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xLIC.Location = New System.Drawing.Point(369, 100)
        Me.xLIC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xLIC.MaxLength = 18
        Me.xLIC.Name = "xLIC"
        Me.xLIC.Size = New System.Drawing.Size(99, 20)
        Me.xLIC.TabIndex = 105
        Me.xLIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(8, 102)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(305, 16)
        Me.Label25.TabIndex = 108
        Me.Label25.Text = "Licores, Piscos, Whisky y otras alcohólicas"
        '
        'xVIN
        '
        Me.xVIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xVIN.Location = New System.Drawing.Point(369, 79)
        Me.xVIN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xVIN.MaxLength = 18
        Me.xVIN.Name = "xVIN"
        Me.xVIN.Size = New System.Drawing.Size(99, 20)
        Me.xVIN.TabIndex = 104
        Me.xVIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 81)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(148, 16)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "Vinos y espumantes"
        '
        'xCER
        '
        Me.xCER.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCER.Location = New System.Drawing.Point(369, 58)
        Me.xCER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xCER.MaxLength = 18
        Me.xCER.Name = "xCER"
        Me.xCER.Size = New System.Drawing.Size(99, 20)
        Me.xCER.TabIndex = 103
        Me.xCER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(8, 63)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(229, 16)
        Me.Label23.TabIndex = 104
        Me.Label23.Text = "Cervezas y Bebidas Alcohólicas"
        '
        'xBEB
        '
        Me.xBEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xBEB.Location = New System.Drawing.Point(369, 37)
        Me.xBEB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xBEB.MaxLength = 18
        Me.xBEB.Name = "xBEB"
        Me.xBEB.Size = New System.Drawing.Size(99, 20)
        Me.xBEB.TabIndex = 102
        Me.xBEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(8, 39)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(206, 16)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "Bebidas, Jugos e Isotónicos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(8, 18)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(299, 16)
        Me.Label21.TabIndex = 100
        Me.Label21.Text = "Bebidas analcohólicas, aguas y minerales"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(9, 186)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "Combustibles"
        '
        'xMIN
        '
        Me.xMIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xMIN.Location = New System.Drawing.Point(369, 16)
        Me.xMIN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xMIN.MaxLength = 18
        Me.xMIN.Name = "xMIN"
        Me.xMIN.Size = New System.Drawing.Size(99, 20)
        Me.xMIN.TabIndex = 101
        Me.xMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.Color.White
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.Location = New System.Drawing.Point(1235, 714)
        Me.Salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(128, 44)
        Me.Salir.TabIndex = 104
        Me.Salir.Text = "Cancelar"
        Me.Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Aceptar
        '
        Me.Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aceptar.BackColor = System.Drawing.Color.White
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Aceptar.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.Aceptar.Location = New System.Drawing.Point(1007, 714)
        Me.Aceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(220, 44)
        Me.Aceptar.TabIndex = 105
        Me.Aceptar.Text = " Emitir Documento"
        Me.Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(16, 714)
        Me.bLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(128, 44)
        Me.bLimpiar.TabIndex = 106
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'gExtra
        '
        Me.gExtra.BackColor = System.Drawing.Color.Transparent
        Me.gExtra.Controls.Add(Me.cFPago)
        Me.gExtra.Controls.Add(Me.Label6)
        Me.gExtra.Controls.Add(Me.Label5)
        Me.gExtra.Controls.Add(Me.xFecha)
        Me.gExtra.Controls.Add(Me.xVendedor)
        Me.gExtra.Controls.Add(Me.xNomVen)
        Me.gExtra.Controls.Add(Me.Label11)
        Me.gExtra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gExtra.Location = New System.Drawing.Point(1007, 63)
        Me.gExtra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gExtra.Name = "gExtra"
        Me.gExtra.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gExtra.Size = New System.Drawing.Size(356, 110)
        Me.gExtra.TabIndex = 130
        Me.gExtra.TabStop = False
        '
        'bProcesarDoc
        '
        Me.bProcesarDoc.BackColor = System.Drawing.Color.White
        Me.bProcesarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bProcesarDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProcesarDoc.Image = Global.Rebusco.My.Resources.Resources.execute16
        Me.bProcesarDoc.Location = New System.Drawing.Point(675, 144)
        Me.bProcesarDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bProcesarDoc.Name = "bProcesarDoc"
        Me.bProcesarDoc.Size = New System.Drawing.Size(301, 30)
        Me.bProcesarDoc.TabIndex = 323
        Me.bProcesarDoc.Text = "Procesar Documento Referencia"
        Me.bProcesarDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bProcesarDoc.UseVisualStyleBackColor = False
        '
        'xFechaDocRef
        '
        Me.xFechaDocRef.Enabled = False
        Me.xFechaDocRef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFechaDocRef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xFechaDocRef.Location = New System.Drawing.Point(545, 145)
        Me.xFechaDocRef.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xFechaDocRef.Name = "xFechaDocRef"
        Me.xFechaDocRef.Size = New System.Drawing.Size(119, 25)
        Me.xFechaDocRef.TabIndex = 128
        Me.xFechaDocRef.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'xNumDocRef
        '
        Me.xNumDocRef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xNumDocRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xNumDocRef.Location = New System.Drawing.Point(436, 145)
        Me.xNumDocRef.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xNumDocRef.MaxLength = 18
        Me.xNumDocRef.Name = "xNumDocRef"
        Me.xNumDocRef.Size = New System.Drawing.Size(100, 25)
        Me.xNumDocRef.TabIndex = 7
        '
        'cTipoDocRef
        '
        Me.cTipoDocRef.BackColor = System.Drawing.Color.White
        Me.cTipoDocRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDocRef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoDocRef.FormattingEnabled = True
        Me.cTipoDocRef.Location = New System.Drawing.Point(175, 144)
        Me.cTipoDocRef.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cTipoDocRef.Name = "cTipoDocRef"
        Me.cTipoDocRef.Size = New System.Drawing.Size(252, 25)
        Me.cTipoDocRef.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Tipo de Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Número Documento"
        '
        'xDireccion
        '
        Me.xDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xDireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDireccion.Location = New System.Drawing.Point(175, 112)
        Me.xDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xDireccion.MaxLength = 50
        Me.xDireccion.Name = "xDireccion"
        Me.xDireccion.ReadOnly = True
        Me.xDireccion.Size = New System.Drawing.Size(715, 25)
        Me.xDireccion.TabIndex = 2
        '
        'cTipoDoc
        '
        Me.cTipoDoc.BackColor = System.Drawing.Color.White
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(175, 14)
        Me.cTipoDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(361, 25)
        Me.cTipoDoc.TabIndex = 0
        '
        'bBuscarCli
        '
        Me.bBuscarCli.BackColor = System.Drawing.Color.White
        Me.bBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarCli.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarCli.Image = CType(resources.GetObject("bBuscarCli.Image"), System.Drawing.Image)
        Me.bBuscarCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bBuscarCli.Location = New System.Drawing.Point(897, 74)
        Me.bBuscarCli.Margin = New System.Windows.Forms.Padding(0)
        Me.bBuscarCli.Name = "bBuscarCli"
        Me.bBuscarCli.Size = New System.Drawing.Size(37, 34)
        Me.bBuscarCli.TabIndex = 105
        Me.bBuscarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarCli.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 116)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Dirección"
        '
        'xCiudad
        '
        Me.xCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCiudad.Location = New System.Drawing.Point(991, 112)
        Me.xCiudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xCiudad.MaxLength = 50
        Me.xCiudad.Name = "xCiudad"
        Me.xCiudad.ReadOnly = True
        Me.xCiudad.Size = New System.Drawing.Size(129, 23)
        Me.xCiudad.TabIndex = 106
        '
        'xComuna
        '
        Me.xComuna.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xComuna.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xComuna.Location = New System.Drawing.Point(1199, 112)
        Me.xComuna.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xComuna.MaxLength = 50
        Me.xComuna.Name = "xComuna"
        Me.xComuna.ReadOnly = True
        Me.xComuna.Size = New System.Drawing.Size(135, 23)
        Me.xComuna.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(923, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1124, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Comuna"
        '
        'bCrearCli
        '
        Me.bCrearCli.BackColor = System.Drawing.Color.White
        Me.bCrearCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrearCli.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCrearCli.Image = Global.Rebusco.My.Resources.Resources._new
        Me.bCrearCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bCrearCli.Location = New System.Drawing.Point(941, 74)
        Me.bCrearCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bCrearCli.Name = "bCrearCli"
        Me.bCrearCli.Size = New System.Drawing.Size(37, 34)
        Me.bCrearCli.TabIndex = 116
        Me.bCrearCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCrearCli.UseVisualStyleBackColor = False
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCliente.ForeColor = System.Drawing.Color.Black
        Me.xCliente.Location = New System.Drawing.Point(175, 80)
        Me.xCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xCliente.MaxLength = 18
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Size = New System.Drawing.Size(120, 25)
        Me.xCliente.TabIndex = 2
        Me.xCliente.TabStop = False
        Me.xCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xNumDoc
        '
        Me.xNumDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.xNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNumDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNumDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xNumDoc.Location = New System.Drawing.Point(175, 49)
        Me.xNumDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xNumDoc.MaxLength = 18
        Me.xNumDoc.Name = "xNumDoc"
        Me.xNumDoc.ReadOnly = True
        Me.xNumDoc.Size = New System.Drawing.Size(120, 25)
        Me.xNumDoc.TabIndex = 1
        Me.xNumDoc.TabStop = False
        Me.xNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xRut
        '
        Me.xRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRut.Location = New System.Drawing.Point(307, 80)
        Me.xRut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xRut.Mask = "##,###,###-A"
        Me.xRut.Name = "xRut"
        Me.xRut.ReadOnly = True
        Me.xRut.Size = New System.Drawing.Size(120, 25)
        Me.xRut.TabIndex = 3
        '
        'xNombre
        '
        Me.xNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombre.Location = New System.Drawing.Point(436, 80)
        Me.xNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xNombre.MaxLength = 50
        Me.xNombre.Name = "xNombre"
        Me.xNombre.ReadOnly = True
        Me.xNombre.Size = New System.Drawing.Size(453, 25)
        Me.xNombre.TabIndex = 127
        '
        'fGeneral
        '
        Me.fGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fGeneral.BackColor = System.Drawing.Color.Transparent
        Me.fGeneral.Controls.Add(Me.Label32)
        Me.fGeneral.Controls.Add(Me.xCambiarPOS)
        Me.fGeneral.Controls.Add(Me.xPOS)
        Me.fGeneral.Controls.Add(Me.Label33)
        Me.fGeneral.Controls.Add(Me.oElectronico)
        Me.fGeneral.Controls.Add(Me.cMotivo)
        Me.fGeneral.Controls.Add(Me.Label30)
        Me.fGeneral.Controls.Add(Me.lMotivo)
        Me.fGeneral.Controls.Add(Me.xFantasia)
        Me.fGeneral.Controls.Add(Me.Label29)
        Me.fGeneral.Controls.Add(Me.bProcesarDoc)
        Me.fGeneral.Controls.Add(Me.xLocal)
        Me.fGeneral.Controls.Add(Me.xFechaDocRef)
        Me.fGeneral.Controls.Add(Me.xNumDocRef)
        Me.fGeneral.Controls.Add(Me.Label9)
        Me.fGeneral.Controls.Add(Me.xNombre)
        Me.fGeneral.Controls.Add(Me.cTipoDocRef)
        Me.fGeneral.Controls.Add(Me.xRut)
        Me.fGeneral.Controls.Add(Me.xNumDoc)
        Me.fGeneral.Controls.Add(Me.xCliente)
        Me.fGeneral.Controls.Add(Me.bCrearCli)
        Me.fGeneral.Controls.Add(Me.Label3)
        Me.fGeneral.Controls.Add(Me.Label2)
        Me.fGeneral.Controls.Add(Me.xComuna)
        Me.fGeneral.Controls.Add(Me.xCiudad)
        Me.fGeneral.Controls.Add(Me.Label8)
        Me.fGeneral.Controls.Add(Me.bBuscarCli)
        Me.fGeneral.Controls.Add(Me.cTipoDoc)
        Me.fGeneral.Controls.Add(Me.xDireccion)
        Me.fGeneral.Controls.Add(Me.Label7)
        Me.fGeneral.Controls.Add(Me.Label4)
        Me.fGeneral.Controls.Add(Me.Label1)
        Me.fGeneral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fGeneral.Location = New System.Drawing.Point(16, 63)
        Me.fGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fGeneral.Name = "fGeneral"
        Me.fGeneral.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fGeneral.Size = New System.Drawing.Size(1347, 181)
        Me.fGeneral.TabIndex = 98
        Me.fGeneral.TabStop = False
        Me.fGeneral.Text = "Datos Generales"
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(1, 0)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(127, 20)
        Me.Label32.TabIndex = 345
        Me.Label32.Text = " General"
        '
        'xCambiarPOS
        '
        Me.xCambiarPOS.BackColor = System.Drawing.Color.White
        Me.xCambiarPOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xCambiarPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xCambiarPOS.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCambiarPOS.Image = Global.Rebusco.My.Resources.Resources.refresh_update24
        Me.xCambiarPOS.Location = New System.Drawing.Point(931, 16)
        Me.xCambiarPOS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xCambiarPOS.Name = "xCambiarPOS"
        Me.xCambiarPOS.Size = New System.Drawing.Size(52, 49)
        Me.xCambiarPOS.TabIndex = 117
        Me.xCambiarPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xCambiarPOS.UseVisualStyleBackColor = False
        '
        'xPOS
        '
        Me.xPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.xPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xPOS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xPOS.ForeColor = System.Drawing.Color.Black
        Me.xPOS.Location = New System.Drawing.Point(859, 39)
        Me.xPOS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xPOS.MaxLength = 18
        Me.xPOS.Name = "xPOS"
        Me.xPOS.ReadOnly = True
        Me.xPOS.Size = New System.Drawing.Size(70, 25)
        Me.xPOS.TabIndex = 344
        Me.xPOS.TabStop = False
        Me.xPOS.Text = "0"
        Me.xPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(859, 16)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 22)
        Me.Label33.TabIndex = 343
        Me.Label33.Text = "POS"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'oElectronico
        '
        Me.oElectronico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oElectronico.Appearance = System.Windows.Forms.Appearance.Button
        Me.oElectronico.AutoCheck = False
        Me.oElectronico.BackColor = System.Drawing.Color.White
        Me.oElectronico.Checked = True
        Me.oElectronico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oElectronico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oElectronico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oElectronico.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oElectronico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oElectronico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oElectronico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oElectronico.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oElectronico.ForeColor = System.Drawing.Color.White
        Me.oElectronico.Image = CType(resources.GetObject("oElectronico.Image"), System.Drawing.Image)
        Me.oElectronico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oElectronico.Location = New System.Drawing.Point(304, 46)
        Me.oElectronico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oElectronico.Name = "oElectronico"
        Me.oElectronico.Size = New System.Drawing.Size(148, 31)
        Me.oElectronico.TabIndex = 342
        Me.oElectronico.Text = " Electrónico"
        Me.oElectronico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oElectronico.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 148)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 17)
        Me.Label30.TabIndex = 327
        Me.Label30.Text = "Doc. Referencia"
        '
        'xFantasia
        '
        Me.xFantasia.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xFantasia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFantasia.Location = New System.Drawing.Point(637, 43)
        Me.xFantasia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xFantasia.MaxLength = 50
        Me.xFantasia.Name = "xFantasia"
        Me.xFantasia.ReadOnly = True
        Me.xFantasia.Size = New System.Drawing.Size(205, 25)
        Me.xFantasia.TabIndex = 326
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(560, 48)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 17)
        Me.Label29.TabIndex = 325
        Me.Label29.Text = "Fantasía"
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 75
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
        Me.WinDeco1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WinDeco1.MuestraBordeExterior = -1
        Me.WinDeco1.Name = "WinDeco1"
        Me.WinDeco1.SiempreVisible = False
        Me.WinDeco1.Size = New System.Drawing.Size(1379, 50)
        Me.WinDeco1.TabIndex = 133
        Me.WinDeco1.TituloVentana = "Generar Documentos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'bDirectorio
        '
        Me.bDirectorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDirectorio.BackColor = System.Drawing.Color.White
        Me.bDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDirectorio.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bDirectorio.Image = Global.Rebusco.My.Resources.Resources.folder_open
        Me.bDirectorio.Location = New System.Drawing.Point(152, 714)
        Me.bDirectorio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bDirectorio.Name = "bDirectorio"
        Me.bDirectorio.Size = New System.Drawing.Size(283, 44)
        Me.bDirectorio.TabIndex = 134
        Me.bDirectorio.Text = " Abrir Directorio Facturas"
        Me.bDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bDirectorio.UseVisualStyleBackColor = False
        '
        'EmisionDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.bDirectorio)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.fImpuestos)
        Me.Controls.Add(Me.gExtra)
        Me.Controls.Add(Me.xTipoDocRef)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.fTotales)
        Me.Controls.Add(Me.fObservaciones)
        Me.Controls.Add(Me.fDetalles)
        Me.Controls.Add(Me.fGeneral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1653, 945)
        Me.Name = "EmisionDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Documentos"
        Me.fDetalles.ResumeLayout(False)
        Me.fDetalles.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fObservaciones.ResumeLayout(False)
        Me.fObservaciones.PerformLayout()
        Me.fTotales.ResumeLayout(False)
        Me.fTotales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.fImpuestos.ResumeLayout(False)
        Me.fImpuestos.PerformLayout()
        Me.gExtra.ResumeLayout(False)
        Me.gExtra.PerformLayout()
        Me.fGeneral.ResumeLayout(False)
        Me.fGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xNomVen As TextBox
    Friend WithEvents xVendedor As TextBox
    Friend WithEvents cFPago As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents xFecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents fDetalles As GroupBox
    Friend WithEvents xLocal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents xDescripcion As TextBox
    Public WithEvents bAgregar As Button
    Public WithEvents BuscarArt As Button
    Public WithEvents bLimpiarArt As Button
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents lMotivo As Label
    Friend WithEvents cMotivo As ComboBox
    Friend WithEvents fObservaciones As GroupBox
    Friend WithEvents xObs As TextBox
    Friend WithEvents fTotales As GroupBox
    Friend WithEvents fImpuestos As GroupBox
    Friend WithEvents Label15 As Label
    Public WithEvents Salir As Button
    Public WithEvents Aceptar As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents xTotal As TextBox
    Friend WithEvents xImpuestos As TextBox
    Friend WithEvents xIVA As TextBox
    Friend WithEvents xNeto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents xDescuento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Tabacos As Label
    Friend WithEvents xTAB As TextBox
    Friend WithEvents xHAR As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents xCAR As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents xLIC As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents xVIN As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents xCER As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents xBEB As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents xMIN As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents xFEP As TextBox
    Friend WithEvents nLineas As TextBox
    Friend WithEvents lLineas As Label
    Friend WithEvents xSubTotal As TextBox
    Friend WithEvents xTipoDocRef As TextBox

    Friend WithEvents gExtra As GroupBox
    Public WithEvents bProcesarDoc As Button
    Friend WithEvents xFechaDocRef As DateTimePicker
    Friend WithEvents xNumDocRef As TextBox
    Friend WithEvents cTipoDocRef As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents xDireccion As TextBox
    Friend WithEvents cTipoDoc As ComboBox
    Public WithEvents bBuscarCli As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents xCiudad As TextBox
    Friend WithEvents xComuna As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents bCrearCli As Button
    Friend WithEvents xCliente As TextBox
    Friend WithEvents xNumDoc As TextBox
    Friend WithEvents xRut As MaskedTextBox
    Friend WithEvents xNombre As TextBox
    Friend WithEvents fGeneral As GroupBox
    Friend WithEvents xFantasia As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Public WithEvents bQuitar As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents oElectronico As CustomCheck
    Friend WithEvents xPOS As TextBox
    Friend WithEvents Label33 As Label
    Public WithEvents xCambiarPOS As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Public WithEvents bDirectorio As Button
End Class
