<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.pBarra = New System.Windows.Forms.ProgressBar()
        Me.lCantidad = New System.Windows.Forms.Label()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.oDirectorio = New System.Windows.Forms.OpenFileDialog()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.oStockObligatorio = New Rebusco.CustomCheck()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Base64 to String <>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(853, 147)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Rebusco.My.Resources.Resources.RadioUncheck16
        Me.PictureBox1.Location = New System.Drawing.Point(829, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(166, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 35)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Actualizar Tabla Modulos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 35)
        Me.Button3.TabIndex = 115
        Me.Button3.Text = "Porta Papel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 35)
        Me.Button4.TabIndex = 116
        Me.Button4.Text = "Act. Comuna Cliente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(326, 102)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 35)
        Me.Button5.TabIndex = 117
        Me.Button5.Text = "Cambiar Comunas"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(326, 61)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(154, 35)
        Me.Button7.TabIndex = 120
        Me.Button7.Text = "Paso Articulo a SKU"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(166, 20)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(154, 35)
        Me.Button8.TabIndex = 121
        Me.Button8.Text = "PermisoAcceso"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(326, 20)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(154, 35)
        Me.Button9.TabIndex = 122
        Me.Button9.Text = "PermisoUsuario"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(677, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 124
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(677, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(146, 35)
        Me.Button6.TabIndex = 125
        Me.Button6.Text = "Cambiar impresora Predeterminada"
        Me.Button6.UseVisualStyleBackColor = True
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
        Me.WinDeco1.Size = New System.Drawing.Size(947, 50)
        Me.WinDeco1.TabIndex = 132
        Me.WinDeco1.TituloVentana = "Test"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(486, 61)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(154, 35)
        Me.Button11.TabIndex = 133
        Me.Button11.Text = "PermisoUsuario"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'pBarra
        '
        Me.pBarra.Location = New System.Drawing.Point(12, 486)
        Me.pBarra.Name = "pBarra"
        Me.pBarra.Size = New System.Drawing.Size(649, 23)
        Me.pBarra.TabIndex = 139
        '
        'lCantidad
        '
        Me.lCantidad.BackColor = System.Drawing.Color.DarkGreen
        Me.lCantidad.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCantidad.ForeColor = System.Drawing.Color.White
        Me.lCantidad.Location = New System.Drawing.Point(284, 490)
        Me.lCantidad.Name = "lCantidad"
        Me.lCantidad.Size = New System.Drawing.Size(100, 16)
        Me.lCantidad.TabIndex = 140
        Me.lCantidad.Text = "0/0"
        Me.lCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(486, 20)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(154, 35)
        Me.Button23.TabIndex = 149
        Me.Button23.Text = "Pasar Clientes"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(6, 24)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(154, 35)
        Me.Button24.TabIndex = 150
        Me.Button24.Text = "Buscador Articulos"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(6, 102)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(154, 35)
        Me.Button25.TabIndex = 151
        Me.Button25.Text = "Cambiar Clave Nuevo"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(486, 101)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(154, 36)
        Me.Button27.TabIndex = 153
        Me.Button27.Text = "insert Imagen Voucher"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'oDirectorio
        '
        Me.oDirectorio.FileName = "oDirectorio"
        '
        'Button29
        '
        Me.Button29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Location = New System.Drawing.Point(166, 102)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(154, 35)
        Me.Button29.TabIndex = 155
        Me.Button29.Text = "Crear Stock Tabla"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button28)
        Me.GroupBox2.Controls.Add(Me.Button24)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(637, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 193)
        Me.GroupBox2.TabIndex = 157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acceso Modulos Desarrollo"
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(6, 65)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(154, 35)
        Me.Button28.TabIndex = 151
        Me.Button28.Text = "Datos Bicicleta"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button30)
        Me.GroupBox3.Controls.Add(Me.Button26)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button27)
        Me.GroupBox3.Controls.Add(Me.Button29)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button25)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button23)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(658, 206)
        Me.GroupBox3.TabIndex = 158
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Procesos"
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(166, 143)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(154, 36)
        Me.Button30.TabIndex = 157
        Me.Button30.Text = "Generar trackin"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(6, 143)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(154, 36)
        Me.Button26.TabIndex = 156
        Me.Button26.Text = "Formatear Rut"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'oStockObligatorio
        '
        Me.oStockObligatorio.Appearance = System.Windows.Forms.Appearance.Button
        Me.oStockObligatorio.BackColor = System.Drawing.Color.White
        Me.oStockObligatorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockObligatorio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oStockObligatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oStockObligatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oStockObligatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oStockObligatorio.ForeColor = System.Drawing.Color.Black
        Me.oStockObligatorio.Image = CType(resources.GetObject("oStockObligatorio.Image"), System.Drawing.Image)
        Me.oStockObligatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oStockObligatorio.Location = New System.Drawing.Point(677, 169)
        Me.oStockObligatorio.Name = "oStockObligatorio"
        Me.oStockObligatorio.Size = New System.Drawing.Size(212, 30)
        Me.oStockObligatorio.TabIndex = 159
        Me.oStockObligatorio.Text = "Stock Obligatorio"
        Me.oStockObligatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oStockObligatorio.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(63, 292)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(154, 35)
        Me.Button10.TabIndex = 160
        Me.Button10.Text = "Paso MovGen Wikets"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(396, 291)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(154, 35)
        Me.Button12.TabIndex = 161
        Me.Button12.Text = "Buscador Articulos"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(415, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 162
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 578)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.oStockObligatorio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lCantidad)
        Me.Controls.Add(Me.pBarra)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Button11 As Button
    Friend WithEvents pBarra As ProgressBar
    Friend WithEvents lCantidad As Label
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents oDirectorio As OpenFileDialog
    Friend WithEvents Button29 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button26 As Button
    Friend WithEvents oStockObligatorio As CustomCheck
    Friend WithEvents Button28 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
