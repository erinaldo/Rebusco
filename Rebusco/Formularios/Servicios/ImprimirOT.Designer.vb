<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirOT))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oAutomatico = New Rebusco.CustomCheck()
        Me.xOT = New System.Windows.Forms.TextBox()
        Me.bImprimirRepuestos = New System.Windows.Forms.Button()
        Me.bImprimirRevision = New System.Windows.Forms.Button()
        Me.bImprimirOT = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.oAutomatico)
        Me.GroupBox1.Controls.Add(Me.xOT)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 56)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'oAutomatico
        '
        Me.oAutomatico.Appearance = System.Windows.Forms.Appearance.Button
        Me.oAutomatico.BackColor = System.Drawing.Color.White
        Me.oAutomatico.Checked = True
        Me.oAutomatico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oAutomatico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAutomatico.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oAutomatico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oAutomatico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oAutomatico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oAutomatico.ForeColor = System.Drawing.Color.White
        Me.oAutomatico.Image = CType(resources.GetObject("oAutomatico.Image"), System.Drawing.Image)
        Me.oAutomatico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oAutomatico.Location = New System.Drawing.Point(196, 22)
        Me.oAutomatico.Name = "oAutomatico"
        Me.oAutomatico.Size = New System.Drawing.Size(187, 28)
        Me.oAutomatico.TabIndex = 323
        Me.oAutomatico.Text = "Imprimir Autómaticamente"
        Me.oAutomatico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oAutomatico.UseVisualStyleBackColor = False
        '
        'xOT
        '
        Me.xOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xOT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOT.Location = New System.Drawing.Point(6, 21)
        Me.xOT.Name = "xOT"
        Me.xOT.Size = New System.Drawing.Size(184, 29)
        Me.xOT.TabIndex = 1
        Me.xOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bImprimirRepuestos
        '
        Me.bImprimirRepuestos.BackColor = System.Drawing.Color.White
        Me.bImprimirRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimirRepuestos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimirRepuestos.Image = Global.Rebusco.My.Resources.Resources.print32
        Me.bImprimirRepuestos.Location = New System.Drawing.Point(276, 118)
        Me.bImprimirRepuestos.Name = "bImprimirRepuestos"
        Me.bImprimirRepuestos.Size = New System.Drawing.Size(130, 72)
        Me.bImprimirRepuestos.TabIndex = 64
        Me.bImprimirRepuestos.Text = "Imprimir Repuestos Faltantes"
        Me.bImprimirRepuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bImprimirRepuestos.UseVisualStyleBackColor = False
        '
        'bImprimirRevision
        '
        Me.bImprimirRevision.BackColor = System.Drawing.Color.White
        Me.bImprimirRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimirRevision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimirRevision.Image = Global.Rebusco.My.Resources.Resources.print32
        Me.bImprimirRevision.Location = New System.Drawing.Point(144, 118)
        Me.bImprimirRevision.Name = "bImprimirRevision"
        Me.bImprimirRevision.Size = New System.Drawing.Size(130, 72)
        Me.bImprimirRevision.TabIndex = 63
        Me.bImprimirRevision.Text = "Imprimir Revisión de Servicio"
        Me.bImprimirRevision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bImprimirRevision.UseVisualStyleBackColor = False
        '
        'bImprimirOT
        '
        Me.bImprimirOT.BackColor = System.Drawing.Color.White
        Me.bImprimirOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimirOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimirOT.Image = Global.Rebusco.My.Resources.Resources.print32
        Me.bImprimirOT.Location = New System.Drawing.Point(12, 118)
        Me.bImprimirOT.Name = "bImprimirOT"
        Me.bImprimirOT.Size = New System.Drawing.Size(130, 72)
        Me.bImprimirOT.TabIndex = 62
        Me.bImprimirOT.Text = "Imprimir OT"
        Me.bImprimirOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bImprimirOT.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(310, 213)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(96, 36)
        Me.bCancelar.TabIndex = 243
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(394, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Número de OT"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WinDeco1.Size = New System.Drawing.Size(414, 50)
        Me.WinDeco1.TabIndex = 244
        Me.WinDeco1.TituloVentana = "Imprimir OT"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ImprimirOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bCancelar
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bImprimirRepuestos)
        Me.Controls.Add(Me.bImprimirRevision)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bImprimirOT)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ImprimirOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir OT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bImprimirRepuestos As Button
    Public WithEvents bImprimirRevision As Button
    Public WithEvents bImprimirOT As Button
    
    Public WithEvents bCancelar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents xOT As TextBox
    Friend WithEvents oAutomatico As CustomCheck
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
