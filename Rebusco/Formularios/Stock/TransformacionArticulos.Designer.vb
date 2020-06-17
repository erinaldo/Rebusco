<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransformacionArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransformacionArticulos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xBodega = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cBodega = New System.Windows.Forms.ComboBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xStockS = New System.Windows.Forms.TextBox()
        Me.xCantidadS = New System.Windows.Forms.TextBox()
        Me.xDescripcionS = New System.Windows.Forms.TextBox()
        Me.xArticuloS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xStockEntrada = New System.Windows.Forms.TextBox()
        Me.xDescripcionE = New System.Windows.Forms.TextBox()
        Me.xArticuloE = New System.Windows.Forms.TextBox()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bProcesar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.oPropia = New Rebusco.CustomCheck()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bBuscarS = New Rebusco.SearchButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xBarra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xPaqueteS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchButton2 = New Rebusco.SearchButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bBuscarE = New Rebusco.SearchButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SearchButton1 = New Rebusco.SearchButton()
        Me.xCanidadE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.xCantidadEntrada = New System.Windows.Forms.TextBox()
        Me.xPaqueteE = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.xBodega)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xLocal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xBodega
        '
        Me.xBodega.BackColor = System.Drawing.Color.White
        Me.xBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xBodega.Location = New System.Drawing.Point(463, 24)
        Me.xBodega.Name = "xBodega"
        Me.xBodega.Size = New System.Drawing.Size(48, 21)
        Me.xBodega.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(405, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bodega"
        '
        'xLocal
        '
        Me.xLocal.BackColor = System.Drawing.Color.White
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xLocal.Location = New System.Drawing.Point(52, 24)
        Me.xLocal.Name = "xLocal"
        Me.xLocal.Size = New System.Drawing.Size(48, 21)
        Me.xLocal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local"
        '
        'cBodega
        '
        Me.cBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodega.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cBodega.FormattingEnabled = True
        Me.cBodega.Location = New System.Drawing.Point(529, 83)
        Me.cBodega.Name = "cBodega"
        Me.cBodega.Size = New System.Drawing.Size(293, 24)
        Me.cBodega.TabIndex = 3
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(118, 83)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(293, 24)
        Me.cLocal.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(6, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Stock"
        '
        'xStockS
        '
        Me.xStockS.BackColor = System.Drawing.Color.White
        Me.xStockS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xStockS.Location = New System.Drawing.Point(85, 83)
        Me.xStockS.Name = "xStockS"
        Me.xStockS.ReadOnly = True
        Me.xStockS.Size = New System.Drawing.Size(55, 22)
        Me.xStockS.TabIndex = 7
        '
        'xCantidadS
        '
        Me.xCantidadS.BackColor = System.Drawing.Color.White
        Me.xCantidadS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xCantidadS.Location = New System.Drawing.Point(68, 83)
        Me.xCantidadS.Name = "xCantidadS"
        Me.xCantidadS.Size = New System.Drawing.Size(58, 22)
        Me.xCantidadS.TabIndex = 1
        '
        'xDescripcionS
        '
        Me.xDescripcionS.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcionS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcionS.Location = New System.Drawing.Point(85, 55)
        Me.xDescripcionS.Name = "xDescripcionS"
        Me.xDescripcionS.ReadOnly = True
        Me.xDescripcionS.Size = New System.Drawing.Size(426, 22)
        Me.xDescripcionS.TabIndex = 5
        '
        'xArticuloS
        '
        Me.xArticuloS.BackColor = System.Drawing.Color.White
        Me.xArticuloS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticuloS.Location = New System.Drawing.Point(85, 27)
        Me.xArticuloS.Name = "xArticuloS"
        Me.xArticuloS.Size = New System.Drawing.Size(111, 22)
        Me.xArticuloS.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(6, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Salida"
        '
        'xStockEntrada
        '
        Me.xStockEntrada.BackColor = System.Drawing.Color.White
        Me.xStockEntrada.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xStockEntrada.Location = New System.Drawing.Point(85, 87)
        Me.xStockEntrada.Name = "xStockEntrada"
        Me.xStockEntrada.Size = New System.Drawing.Size(59, 21)
        Me.xStockEntrada.TabIndex = 2
        '
        'xDescripcionE
        '
        Me.xDescripcionE.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcionE.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcionE.Location = New System.Drawing.Point(85, 59)
        Me.xDescripcionE.Name = "xDescripcionE"
        Me.xDescripcionE.ReadOnly = True
        Me.xDescripcionE.Size = New System.Drawing.Size(426, 21)
        Me.xDescripcionE.TabIndex = 1
        '
        'xArticuloE
        '
        Me.xArticuloE.BackColor = System.Drawing.Color.White
        Me.xArticuloE.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xArticuloE.Location = New System.Drawing.Point(85, 28)
        Me.xArticuloE.Name = "xArticuloE"
        Me.xArticuloE.Size = New System.Drawing.Size(111, 21)
        Me.xArticuloE.TabIndex = 0
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 384)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 2
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(740, 384)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 4
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bProcesar
        '
        Me.bProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bProcesar.BackColor = System.Drawing.Color.White
        Me.bProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bProcesar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bProcesar.Image = Global.Rebusco.My.Resources.Resources.gears24
        Me.bProcesar.Location = New System.Drawing.Point(634, 384)
        Me.bProcesar.Name = "bProcesar"
        Me.bProcesar.Size = New System.Drawing.Size(100, 36)
        Me.bProcesar.TabIndex = 3
        Me.bProcesar.Text = "Procesar"
        Me.bProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bProcesar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(827, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Local / Bodega"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(521, 16)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Artículo Salida"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.oPropia)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.bBuscarS)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.xArticuloS)
        Me.GroupBox3.Controls.Add(Me.xDescripcionS)
        Me.GroupBox3.Controls.Add(Me.xStockS)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(521, 114)
        Me.GroupBox3.TabIndex = 138
        Me.GroupBox3.TabStop = False
        '
        'oPropia
        '
        Me.oPropia.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPropia.BackColor = System.Drawing.Color.White
        Me.oPropia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPropia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPropia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPropia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPropia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPropia.ForeColor = System.Drawing.Color.Black
        Me.oPropia.Image = CType(resources.GetObject("oPropia.Image"), System.Drawing.Image)
        Me.oPropia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPropia.Location = New System.Drawing.Point(386, 25)
        Me.oPropia.Name = "oPropia"
        Me.oPropia.Size = New System.Drawing.Size(125, 27)
        Me.oPropia.TabIndex = 150
        Me.oPropia.Text = "Producción Propia"
        Me.oPropia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPropia.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(6, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 15)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Descripción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 15)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Artículo"
        '
        'bBuscarS
        '
        Me.bBuscarS.CampoBuscar1 = "Descripcion"
        Me.bBuscarS.CampoBuscar2 = ""
        Me.bBuscarS.CamposAdicionales = ""
        Me.bBuscarS.ControlCarga = Me.xArticuloS
        Me.bBuscarS.ControlFocus = Me.xDescripcionS
        Me.bBuscarS.Filtro = ""
        Me.bBuscarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarS.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarS.IDBusqueda = "Articulo"
        Me.bBuscarS.Image = CType(resources.GetObject("bBuscarS.Image"), System.Drawing.Image)
        Me.bBuscarS.Location = New System.Drawing.Point(202, 24)
        Me.bBuscarS.Name = "bBuscarS"
        Me.bBuscarS.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarS.TabIndex = 138
        Me.bBuscarS.TablaBusqueda = "Articulos"
        Me.bBuscarS.Text = "Buscar"
        Me.bBuscarS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarS.Titulo = "Buscar Artículo"
        Me.bBuscarS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Artículo"
        '
        'xBarra
        '
        Me.xBarra.BackColor = System.Drawing.Color.White
        Me.xBarra.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xBarra.Location = New System.Drawing.Point(68, 27)
        Me.xBarra.Name = "xBarra"
        Me.xBarra.Size = New System.Drawing.Size(175, 22)
        Me.xBarra.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(6, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Paquete"
        '
        'xPaqueteS
        '
        Me.xPaqueteS.BackColor = System.Drawing.Color.White
        Me.xPaqueteS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xPaqueteS.Location = New System.Drawing.Point(68, 55)
        Me.xPaqueteS.Name = "xPaqueteS"
        Me.xPaqueteS.ReadOnly = True
        Me.xPaqueteS.Size = New System.Drawing.Size(76, 22)
        Me.xPaqueteS.TabIndex = 145
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "Barra"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(300, 16)
        Me.Label15.TabIndex = 149
        Me.Label15.Text = "Barra Salida"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SearchButton2)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.xBarra)
        Me.GroupBox2.Controls.Add(Me.xPaqueteS)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.xCantidadS)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(539, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 114)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        '
        'SearchButton2
        '
        Me.SearchButton2.CampoBuscar1 = "Articulo"
        Me.SearchButton2.CampoBuscar2 = "Unidades"
        Me.SearchButton2.CamposAdicionales = ""
        Me.SearchButton2.ControlCarga = Me.xBarra
        Me.SearchButton2.ControlFocus = Me.xCantidadS
        Me.SearchButton2.Filtro = "Articulo = xArticulo.text.trim"
        Me.SearchButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.SearchButton2.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton2.IDBusqueda = "Barra"
        Me.SearchButton2.Image = CType(resources.GetObject("SearchButton2.Image"), System.Drawing.Image)
        Me.SearchButton2.Location = New System.Drawing.Point(249, 24)
        Me.SearchButton2.Name = "SearchButton2"
        Me.SearchButton2.Size = New System.Drawing.Size(31, 31)
        Me.SearchButton2.TabIndex = 150
        Me.SearchButton2.TablaBusqueda = "Barras"
        Me.SearchButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton2.Titulo = "Buscar Artículo"
        Me.SearchButton2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.xArticuloE)
        Me.GroupBox4.Controls.Add(Me.bBuscarE)
        Me.GroupBox4.Controls.Add(Me.xDescripcionE)
        Me.GroupBox4.Controls.Add(Me.xStockEntrada)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(521, 116)
        Me.GroupBox4.TabIndex = 151
        Me.GroupBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(6, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 15)
        Me.Label17.TabIndex = 150
        Me.Label17.Text = "Descripción"
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(521, 16)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "Artículo Entrada"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bBuscarE
        '
        Me.bBuscarE.CampoBuscar1 = "Descripcion"
        Me.bBuscarE.CampoBuscar2 = ""
        Me.bBuscarE.CamposAdicionales = ""
        Me.bBuscarE.ControlCarga = Me.xArticuloS
        Me.bBuscarE.ControlFocus = Me.xDescripcionS
        Me.bBuscarE.Filtro = ""
        Me.bBuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarE.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bBuscarE.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarE.IDBusqueda = "Articulo"
        Me.bBuscarE.Image = CType(resources.GetObject("bBuscarE.Image"), System.Drawing.Image)
        Me.bBuscarE.Location = New System.Drawing.Point(202, 25)
        Me.bBuscarE.Name = "bBuscarE"
        Me.bBuscarE.Size = New System.Drawing.Size(80, 28)
        Me.bBuscarE.TabIndex = 141
        Me.bBuscarE.TablaBusqueda = "Articulos"
        Me.bBuscarE.Text = "Buscar"
        Me.bBuscarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarE.Titulo = "Buscar Artículo"
        Me.bBuscarE.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.SearchButton1)
        Me.GroupBox5.Controls.Add(Me.xCanidadE)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.xCantidadEntrada)
        Me.GroupBox5.Controls.Add(Me.xPaqueteE)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(539, 247)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(300, 116)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'SearchButton1
        '
        Me.SearchButton1.CampoBuscar1 = "Descripcion"
        Me.SearchButton1.CampoBuscar2 = ""
        Me.SearchButton1.CamposAdicionales = ""
        Me.SearchButton1.ControlCarga = Me.xArticuloS
        Me.SearchButton1.ControlFocus = Me.xDescripcionS
        Me.SearchButton1.Filtro = ""
        Me.SearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SearchButton1.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton1.IDBusqueda = "Articulo"
        Me.SearchButton1.Image = CType(resources.GetObject("SearchButton1.Image"), System.Drawing.Image)
        Me.SearchButton1.Location = New System.Drawing.Point(249, 24)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(31, 31)
        Me.SearchButton1.TabIndex = 152
        Me.SearchButton1.TablaBusqueda = "Articulos"
        Me.SearchButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton1.Titulo = "Buscar Artículo"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'xCanidadE
        '
        Me.xCanidadE.BackColor = System.Drawing.Color.White
        Me.xCanidadE.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCanidadE.Location = New System.Drawing.Point(68, 83)
        Me.xCanidadE.Name = "xCanidadE"
        Me.xCanidadE.Size = New System.Drawing.Size(58, 21)
        Me.xCanidadE.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Entrada"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(300, 16)
        Me.Label18.TabIndex = 149
        Me.Label18.Text = "Cantida Entrada"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(6, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 15)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Barra"
        '
        'xCantidadEntrada
        '
        Me.xCantidadEntrada.BackColor = System.Drawing.Color.White
        Me.xCantidadEntrada.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xCantidadEntrada.Location = New System.Drawing.Point(68, 27)
        Me.xCantidadEntrada.Name = "xCantidadEntrada"
        Me.xCantidadEntrada.Size = New System.Drawing.Size(175, 21)
        Me.xCantidadEntrada.TabIndex = 2
        '
        'xPaqueteE
        '
        Me.xPaqueteE.BackColor = System.Drawing.Color.White
        Me.xPaqueteE.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xPaqueteE.Location = New System.Drawing.Point(68, 55)
        Me.xPaqueteE.Name = "xPaqueteE"
        Me.xPaqueteE.Size = New System.Drawing.Size(76, 21)
        Me.xPaqueteE.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(6, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 15)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Paquete"
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
        Me.WinDeco1.Size = New System.Drawing.Size(852, 50)
        Me.WinDeco1.TabIndex = 152
        Me.WinDeco1.TituloVentana = "Tranformación de Artículo"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'TransformarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 432)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cBodega)
        Me.Controls.Add(Me.cLocal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bProcesar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "TransformarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tranformación de Artículo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents xStockS As TextBox
    Friend WithEvents xCantidadS As TextBox
    Friend WithEvents xDescripcionS As TextBox
    Friend WithEvents xArticuloS As TextBox
    Friend WithEvents xBodega As TextBox
    Friend WithEvents cBodega As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents xLocal As TextBox
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xStockEntrada As TextBox
    Friend WithEvents xDescripcionE As TextBox
    Friend WithEvents xArticuloE As TextBox
    Public WithEvents bLimpiar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bProcesar As Button
    Friend WithEvents Label7 As Label
    
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bBuscarS As SearchButton
    Friend WithEvents Label3 As Label
    Friend WithEvents bBuscarE As SearchButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents xBarra As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xPaqueteS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents xCantidadEntrada As TextBox
    Friend WithEvents xPaqueteE As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents oPropia As CustomCheck
    Friend WithEvents xCanidadE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SearchButton2 As SearchButton
    Friend WithEvents SearchButton1 As SearchButton
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
