<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirDocumentos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xNumDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.gCopias = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oCliente = New System.Windows.Forms.CheckBox()
        Me.oControlTributario = New System.Windows.Forms.CheckBox()
        Me.oCedible = New System.Windows.Forms.CheckBox()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.gCopias.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xNumDoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Local / Documento"
        '
        'xNumDoc
        '
        Me.xNumDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xNumDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xNumDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xNumDoc.Location = New System.Drawing.Point(133, 82)
        Me.xNumDoc.Name = "xNumDoc"
        Me.xNumDoc.Size = New System.Drawing.Size(134, 21)
        Me.xNumDoc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Número Documento"
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(133, 52)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(259, 23)
        Me.cTipoDoc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Documento"
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(134, 22)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(259, 23)
        Me.cLocal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local"
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 191)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 1
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(468, 191)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(362, 191)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 2
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'gCopias
        '
        Me.gCopias.BackColor = System.Drawing.Color.Transparent
        Me.gCopias.Controls.Add(Me.Label5)
        Me.gCopias.Controls.Add(Me.oCliente)
        Me.gCopias.Controls.Add(Me.oControlTributario)
        Me.gCopias.Controls.Add(Me.oCedible)
        Me.gCopias.Enabled = False
        Me.gCopias.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gCopias.Location = New System.Drawing.Point(420, 56)
        Me.gCopias.Name = "gCopias"
        Me.gCopias.Size = New System.Drawing.Size(149, 118)
        Me.gCopias.TabIndex = 115
        Me.gCopias.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 16)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Copias a Imprimir"
        '
        'oCliente
        '
        Me.oCliente.Appearance = System.Windows.Forms.Appearance.Button
        Me.oCliente.Checked = True
        Me.oCliente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.oCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oCliente.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oCliente.ForeColor = System.Drawing.Color.White
        Me.oCliente.Image = Global.Rebusco.My.Resources.Resources.check16true_b
        Me.oCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oCliente.Location = New System.Drawing.Point(6, 20)
        Me.oCliente.Name = "oCliente"
        Me.oCliente.Size = New System.Drawing.Size(129, 26)
        Me.oCliente.TabIndex = 79
        Me.oCliente.Text = "Cliente"
        Me.oCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.oCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oCliente.UseVisualStyleBackColor = True
        '
        'oControlTributario
        '
        Me.oControlTributario.Appearance = System.Windows.Forms.Appearance.Button
        Me.oControlTributario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oControlTributario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oControlTributario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oControlTributario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oControlTributario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oControlTributario.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oControlTributario.ForeColor = System.Drawing.Color.Black
        Me.oControlTributario.Image = CType(resources.GetObject("oControlTributario.Image"), System.Drawing.Image)
        Me.oControlTributario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oControlTributario.Location = New System.Drawing.Point(6, 52)
        Me.oControlTributario.Name = "oControlTributario"
        Me.oControlTributario.Size = New System.Drawing.Size(129, 26)
        Me.oControlTributario.TabIndex = 81
        Me.oControlTributario.Text = "Control Tributario"
        Me.oControlTributario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.oControlTributario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oControlTributario.UseVisualStyleBackColor = True
        '
        'oCedible
        '
        Me.oCedible.Appearance = System.Windows.Forms.Appearance.Button
        Me.oCedible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oCedible.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.oCedible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oCedible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oCedible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oCedible.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oCedible.ForeColor = System.Drawing.Color.Black
        Me.oCedible.Image = CType(resources.GetObject("oCedible.Image"), System.Drawing.Image)
        Me.oCedible.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oCedible.Location = New System.Drawing.Point(6, 84)
        Me.oCedible.Name = "oCedible"
        Me.oCedible.Size = New System.Drawing.Size(129, 26)
        Me.oCedible.TabIndex = 80
        Me.oCedible.Text = "Cedible"
        Me.oCedible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.oCedible.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oCedible.UseVisualStyleBackColor = True
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
        Me.WinDeco1.Size = New System.Drawing.Size(581, 50)
        Me.WinDeco1.TabIndex = 133
        Me.WinDeco1.TituloVentana = "Imprimir Documentos"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ImprimirDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 239)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.gCopias)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ImprimirDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gCopias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xNumDoc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label1 As Label
    Public WithEvents bLimpiar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bImprimir As Button
    
    Friend WithEvents gCopias As GroupBox
    Friend WithEvents oCliente As CheckBox
    Friend WithEvents oControlTributario As CheckBox
    Friend WithEvents oCedible As CheckBox
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
