<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerarEtiquetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarEtiquetas))
        Me.gDatos = New System.Windows.Forms.GroupBox()
        Me.xPrecio = New System.Windows.Forms.TextBox()
        Me.oPrecio = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.xOscuridad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xSepara = New System.Windows.Forms.TextBox()
        Me.xColumnas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xDerecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xArriba = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.xArticulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Impresora = New System.Drawing.Printing.PrintDocument()
        Me.VerZPL = New System.Windows.Forms.Button()
        Me.xZPL = New System.Windows.Forms.TextBox()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.gDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gDatos
        '
        Me.gDatos.BackColor = System.Drawing.Color.Transparent
        Me.gDatos.Controls.Add(Me.xPrecio)
        Me.gDatos.Controls.Add(Me.oPrecio)
        Me.gDatos.Controls.Add(Me.Label20)
        Me.gDatos.Controls.Add(Me.GroupBox2)
        Me.gDatos.Controls.Add(Me.xCantidad)
        Me.gDatos.Controls.Add(Me.Label2)
        Me.gDatos.Controls.Add(Me.Label3)
        Me.gDatos.Controls.Add(Me.xDescripcion)
        Me.gDatos.Controls.Add(Me.bBuscar)
        Me.gDatos.Controls.Add(Me.xArticulo)
        Me.gDatos.Controls.Add(Me.Label1)
        Me.gDatos.Controls.Add(Me.Label6)
        Me.gDatos.Controls.Add(Me.cLocal)
        Me.gDatos.Location = New System.Drawing.Point(16, 69)
        Me.gDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gDatos.Name = "gDatos"
        Me.gDatos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gDatos.Size = New System.Drawing.Size(707, 364)
        Me.gDatos.TabIndex = 238
        Me.gDatos.TabStop = False
        '
        'xPrecio
        '
        Me.xPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xPrecio.Location = New System.Drawing.Point(592, 141)
        Me.xPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xPrecio.Name = "xPrecio"
        Me.xPrecio.ReadOnly = True
        Me.xPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xPrecio.Size = New System.Drawing.Size(96, 22)
        Me.xPrecio.TabIndex = 252
        Me.xPrecio.Visible = False
        '
        'oPrecio
        '
        Me.oPrecio.AutoSize = True
        Me.oPrecio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oPrecio.Location = New System.Drawing.Point(417, 142)
        Me.oPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oPrecio.Name = "oPrecio"
        Me.oPrecio.Size = New System.Drawing.Size(167, 22)
        Me.oPrecio.TabIndex = 251
        Me.oPrecio.Text = "Incluir Precio Venta"
        Me.oPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.oPrecio.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(707, 20)
        Me.Label20.TabIndex = 250
        Me.Label20.Text = "Datos de la Etiqueta"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.xOscuridad)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.xSepara)
        Me.GroupBox2.Controls.Add(Me.xColumnas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.xDerecha)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.xArriba)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 229)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(664, 114)
        Me.GroupBox2.TabIndex = 242
        Me.GroupBox2.TabStop = False
        '
        'xOscuridad
        '
        Me.xOscuridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.xOscuridad.Location = New System.Drawing.Point(595, 34)
        Me.xOscuridad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xOscuridad.Name = "xOscuridad"
        Me.xOscuridad.Size = New System.Drawing.Size(47, 22)
        Me.xOscuridad.TabIndex = 253
        Me.xOscuridad.Text = "30"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(488, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 19)
        Me.Label10.TabIndex = 252
        Me.Label10.Text = "Oscuridad"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(673, 21)
        Me.Label9.TabIndex = 251
        Me.Label9.Text = "Configuración de la Impresión de la Etiqueta"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xSepara
        '
        Me.xSepara.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xSepara.Location = New System.Drawing.Point(291, 73)
        Me.xSepara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xSepara.Name = "xSepara"
        Me.xSepara.Size = New System.Drawing.Size(47, 22)
        Me.xSepara.TabIndex = 58
        Me.xSepara.Text = "0"
        '
        'xColumnas
        '
        Me.xColumnas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xColumnas.Location = New System.Drawing.Point(291, 34)
        Me.xColumnas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xColumnas.Name = "xColumnas"
        Me.xColumnas.Size = New System.Drawing.Size(47, 22)
        Me.xColumnas.TabIndex = 56
        Me.xColumnas.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(195, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Separación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(195, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Columnas"
        '
        'xDerecha
        '
        Me.xDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xDerecha.Location = New System.Drawing.Point(108, 74)
        Me.xDerecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xDerecha.Name = "xDerecha"
        Me.xDerecha.Size = New System.Drawing.Size(47, 22)
        Me.xDerecha.TabIndex = 56
        Me.xDerecha.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(9, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Derecha"
        '
        'xArriba
        '
        Me.xArriba.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xArriba.Location = New System.Drawing.Point(108, 36)
        Me.xArriba.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xArriba.Name = "xArriba"
        Me.xArriba.Size = New System.Drawing.Size(47, 22)
        Me.xArriba.TabIndex = 54
        Me.xArriba.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(8, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Arriba" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'xCantidad
        '
        Me.xCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.xCantidad.Location = New System.Drawing.Point(131, 142)
        Me.xCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xCantidad.Name = "xCantidad"
        Me.xCantidad.Size = New System.Drawing.Size(81, 22)
        Me.xCantidad.TabIndex = 54
        Me.xCantidad.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(21, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(21, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Descripción"
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xDescripcion.Location = New System.Drawing.Point(131, 107)
        Me.xDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(557, 26)
        Me.xDescripcion.TabIndex = 50
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.White
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(277, 65)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(107, 34)
        Me.bBuscar.TabIndex = 51
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'xArticulo
        '
        Me.xArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xArticulo.Location = New System.Drawing.Point(131, 69)
        Me.xArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(137, 26)
        Me.xArticulo.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Artículo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(21, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Local"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(131, 28)
        Me.cLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(356, 26)
        Me.cLocal.TabIndex = 45
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(453, 456)
        Me.bImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(128, 44)
        Me.bImprimir.TabIndex = 241
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(589, 456)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(133, 44)
        Me.bSalir.TabIndex = 240
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Impresora
        '
        '
        'VerZPL
        '
        Me.VerZPL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerZPL.BackColor = System.Drawing.Color.White
        Me.VerZPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerZPL.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.VerZPL.Image = CType(resources.GetObject("VerZPL.Image"), System.Drawing.Image)
        Me.VerZPL.Location = New System.Drawing.Point(16, 456)
        Me.VerZPL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VerZPL.Name = "VerZPL"
        Me.VerZPL.Size = New System.Drawing.Size(128, 44)
        Me.VerZPL.TabIndex = 242
        Me.VerZPL.Text = "Ver ZPL"
        Me.VerZPL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VerZPL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VerZPL.UseVisualStyleBackColor = False
        Me.VerZPL.Visible = False
        '
        'xZPL
        '
        Me.xZPL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xZPL.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xZPL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xZPL.Location = New System.Drawing.Point(24, 80)
        Me.xZPL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xZPL.Multiline = True
        Me.xZPL.Name = "xZPL"
        Me.xZPL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.xZPL.Size = New System.Drawing.Size(689, 277)
        Me.xZPL.TabIndex = 243
        Me.xZPL.Visible = False
        Me.xZPL.WordWrap = False
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 69
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
        Me.WinDeco1.Size = New System.Drawing.Size(739, 50)
        Me.WinDeco1.TabIndex = 244
        Me.WinDeco1.TituloVentana = "Generar Etiquetas"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'GenerarEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.gDatos)
        Me.Controls.Add(Me.xZPL)
        Me.Controls.Add(Me.VerZPL)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1653, 945)
        Me.Name = "GenerarEtiquetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Etiquetas"
        Me.gDatos.ResumeLayout(False)
        Me.gDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents gDatos As GroupBox
    Public WithEvents bImprimir As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents xCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents xDescripcion As TextBox
    Public WithEvents bBuscar As Button
    Friend WithEvents xArticulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xColumnas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents xSepara As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xDerecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents xArriba As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents VerZPL As Button
    Friend WithEvents xZPL As TextBox
    Friend WithEvents Impresora As Printing.PrintDocument
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label20 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents xOscuridad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents xPrecio As TextBox
    Friend WithEvents oPrecio As CheckBox
End Class
