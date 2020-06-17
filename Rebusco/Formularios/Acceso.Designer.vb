<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceso))
        Me.gServidores = New System.Windows.Forms.GroupBox()
        Me.oDemo = New Rebusco.CustomCheck()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lIP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cServidor = New System.Windows.Forms.ComboBox()
        Me.gCentroDistribucion = New System.Windows.Forms.GroupBox()
        Me.lEmpresa = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.gUsuario = New System.Windows.Forms.GroupBox()
        Me.xClave = New System.Windows.Forms.TextBox()
        Me.xUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.pbBanner = New System.Windows.Forms.PictureBox()
        Me.bConexion = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gServidores.SuspendLayout()
        Me.gCentroDistribucion.SuspendLayout()
        Me.gUsuario.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gServidores
        '
        Me.gServidores.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gServidores.Controls.Add(Me.oDemo)
        Me.gServidores.Controls.Add(Me.Label3)
        Me.gServidores.Controls.Add(Me.lIP)
        Me.gServidores.Controls.Add(Me.Label4)
        Me.gServidores.Controls.Add(Me.cServidor)
        Me.gServidores.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gServidores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.gServidores.Location = New System.Drawing.Point(12, 110)
        Me.gServidores.Name = "gServidores"
        Me.gServidores.Size = New System.Drawing.Size(349, 91)
        Me.gServidores.TabIndex = 18
        Me.gServidores.TabStop = False
        Me.gServidores.Visible = False
        '
        'oDemo
        '
        Me.oDemo.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDemo.BackColor = System.Drawing.Color.Transparent
        Me.oDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDemo.ForeColor = System.Drawing.Color.Black
        Me.oDemo.Image = CType(resources.GetObject("oDemo.Image"), System.Drawing.Image)
        Me.oDemo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDemo.Location = New System.Drawing.Point(235, 20)
        Me.oDemo.Margin = New System.Windows.Forms.Padding(4)
        Me.oDemo.Name = "oDemo"
        Me.oDemo.Size = New System.Drawing.Size(107, 26)
        Me.oDemo.TabIndex = 20
        Me.oDemo.Text = " DEMO"
        Me.oDemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDemo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Servidores"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lIP
        '
        Me.lIP.AutoSize = True
        Me.lIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lIP.Location = New System.Drawing.Point(91, 28)
        Me.lIP.Name = "lIP"
        Me.lIP.Size = New System.Drawing.Size(99, 18)
        Me.lIP.TabIndex = 3
        Me.lIP.Text = "192.168.10.11"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección :"
        '
        'cServidor
        '
        Me.cServidor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cServidor.BackColor = System.Drawing.Color.White
        Me.cServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cServidor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cServidor.FormattingEnabled = True
        Me.cServidor.Location = New System.Drawing.Point(9, 50)
        Me.cServidor.Margin = New System.Windows.Forms.Padding(4)
        Me.cServidor.Name = "cServidor"
        Me.cServidor.Size = New System.Drawing.Size(333, 26)
        Me.cServidor.TabIndex = 0
        '
        'gCentroDistribucion
        '
        Me.gCentroDistribucion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gCentroDistribucion.BackColor = System.Drawing.Color.White
        Me.gCentroDistribucion.Controls.Add(Me.lEmpresa)
        Me.gCentroDistribucion.Controls.Add(Me.Label5)
        Me.gCentroDistribucion.Controls.Add(Me.cLocal)
        Me.gCentroDistribucion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gCentroDistribucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.gCentroDistribucion.Location = New System.Drawing.Point(12, 208)
        Me.gCentroDistribucion.Margin = New System.Windows.Forms.Padding(4)
        Me.gCentroDistribucion.Name = "gCentroDistribucion"
        Me.gCentroDistribucion.Padding = New System.Windows.Forms.Padding(0)
        Me.gCentroDistribucion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gCentroDistribucion.Size = New System.Drawing.Size(348, 67)
        Me.gCentroDistribucion.TabIndex = 17
        Me.gCentroDistribucion.TabStop = False
        '
        'lEmpresa
        '
        Me.lEmpresa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lEmpresa.Location = New System.Drawing.Point(243, 13)
        Me.lEmpresa.Name = "lEmpresa"
        Me.lEmpresa.Size = New System.Drawing.Size(98, 13)
        Me.lEmpresa.TabIndex = 243
        Me.lEmpresa.Text = "Empresa"
        Me.lEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 243
        Me.Label5.Text = "Local"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cLocal
        '
        Me.cLocal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cLocal.BackColor = System.Drawing.Color.White
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(11, 29)
        Me.cLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(331, 26)
        Me.cLocal.TabIndex = 0
        '
        'gUsuario
        '
        Me.gUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gUsuario.BackColor = System.Drawing.Color.White
        Me.gUsuario.Controls.Add(Me.xClave)
        Me.gUsuario.Controls.Add(Me.xUsuario)
        Me.gUsuario.Controls.Add(Me.Label1)
        Me.gUsuario.Controls.Add(Me.Label2)
        Me.gUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gUsuario.Location = New System.Drawing.Point(12, 283)
        Me.gUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.gUsuario.Name = "gUsuario"
        Me.gUsuario.Padding = New System.Windows.Forms.Padding(0)
        Me.gUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gUsuario.Size = New System.Drawing.Size(348, 88)
        Me.gUsuario.TabIndex = 14
        Me.gUsuario.TabStop = False
        '
        'xClave
        '
        Me.xClave.AcceptsReturn = True
        Me.xClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.xClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xClave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.xClave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.xClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.xClave.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.xClave.Location = New System.Drawing.Point(176, 52)
        Me.xClave.Margin = New System.Windows.Forms.Padding(4)
        Me.xClave.MaxLength = 4
        Me.xClave.Name = "xClave"
        Me.xClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.xClave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xClave.Size = New System.Drawing.Size(166, 20)
        Me.xClave.TabIndex = 6
        '
        'xUsuario
        '
        Me.xUsuario.AcceptsReturn = True
        Me.xUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.xUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.xUsuario.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.xUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.xUsuario.Location = New System.Drawing.Point(176, 17)
        Me.xUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.xUsuario.MaxLength = 3
        Me.xUsuario.Name = "xUsuario"
        Me.xUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xUsuario.Size = New System.Drawing.Size(166, 20)
        Me.xUsuario.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave"
        '
        'bAceptar
        '
        Me.bAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.bAceptar.BackgroundImage = Global.Rebusco.My.Resources.Resources.back_blue2
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.ForeColor = System.Drawing.Color.White
        Me.bAceptar.Location = New System.Drawing.Point(12, 384)
        Me.bAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(168, 36)
        Me.bAceptar.TabIndex = 15
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Salir.BackgroundImage = Global.Rebusco.My.Resources.Resources.back_blue2
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Location = New System.Drawing.Point(188, 384)
        Me.Salir.Margin = New System.Windows.Forms.Padding(4)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(172, 36)
        Me.Salir.TabIndex = 16
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'pbBanner
        '
        Me.pbBanner.Image = Global.Rebusco.My.Resources.Resources.BannerAcceso
        Me.pbBanner.Location = New System.Drawing.Point(1, -3)
        Me.pbBanner.Margin = New System.Windows.Forms.Padding(4)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(371, 104)
        Me.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBanner.TabIndex = 13
        Me.pbBanner.TabStop = False
        '
        'Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(373, 433)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.gCentroDistribucion)
        Me.Controls.Add(Me.gUsuario)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.gServidores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.gServidores.ResumeLayout(False)
        Me.gServidores.PerformLayout()
        Me.gCentroDistribucion.ResumeLayout(False)
        Me.gUsuario.ResumeLayout(False)
        Me.gUsuario.PerformLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbBanner As PictureBox
    Friend WithEvents gServidores As GroupBox
    Friend WithEvents lIP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cServidor As ComboBox
    Friend WithEvents bAceptar As Button
    Friend WithEvents Salir As Button
    Public WithEvents gCentroDistribucion As GroupBox
    Friend WithEvents cLocal As ComboBox
    Public WithEvents gUsuario As GroupBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Public WithEvents xClave As TextBox
    Public WithEvents xUsuario As TextBox
    Friend WithEvents oDemo As CustomCheck
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bConexion As System.ComponentModel.BackgroundWorker
    Friend WithEvents lEmpresa As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
