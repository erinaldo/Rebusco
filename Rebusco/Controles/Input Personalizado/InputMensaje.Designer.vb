<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputMensaje))
        Me.lMensaje = New System.Windows.Forms.Label()
        Me.xTextoRecibido = New System.Windows.Forms.TextBox()
        Me.lResponse = New System.Windows.Forms.Label()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.SuspendLayout()
        '
        'lMensaje
        '
        Me.lMensaje.AutoSize = True
        Me.lMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lMensaje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMensaje.Location = New System.Drawing.Point(12, 58)
        Me.lMensaje.Name = "lMensaje"
        Me.lMensaje.Size = New System.Drawing.Size(144, 18)
        Me.lMensaje.TabIndex = 0
        Me.lMensaje.Text = "Mensaje de Prueba"
        '
        'xTextoRecibido
        '
        Me.xTextoRecibido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTextoRecibido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTextoRecibido.Location = New System.Drawing.Point(12, 79)
        Me.xTextoRecibido.Name = "xTextoRecibido"
        Me.xTextoRecibido.Size = New System.Drawing.Size(368, 26)
        Me.xTextoRecibido.TabIndex = 0
        '
        'lResponse
        '
        Me.lResponse.AutoSize = True
        Me.lResponse.Location = New System.Drawing.Point(12, 78)
        Me.lResponse.Name = "lResponse"
        Me.lResponse.Size = New System.Drawing.Size(0, 13)
        Me.lResponse.TabIndex = 0
        Me.lResponse.Visible = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.White
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bAceptar.Image = Global.Rebusco.My.Resources.Resources.ok
        Me.bAceptar.Location = New System.Drawing.Point(200, 117)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(87, 28)
        Me.bAceptar.TabIndex = 236
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel
        Me.bCancelar.Location = New System.Drawing.Point(293, 117)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(87, 28)
        Me.bCancelar.TabIndex = 237
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 40
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
        Me.WinDeco1.Size = New System.Drawing.Size(392, 50)
        Me.WinDeco1.TabIndex = 238
        Me.WinDeco1.TituloVentana = "Ingreso"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'InputMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 153)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.xTextoRecibido)
        Me.Controls.Add(Me.lResponse)
        Me.Controls.Add(Me.lMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "InputMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lMensaje As Label
    Friend WithEvents xTextoRecibido As TextBox
    Friend WithEvents lResponse As Label
    
    Public WithEvents bAceptar As Button
    Public WithEvents bCancelar As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
