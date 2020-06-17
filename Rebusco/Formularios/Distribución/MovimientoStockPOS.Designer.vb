<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientoStockPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientoStockPOS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cPOS = New System.Windows.Forms.ComboBox()
        Me.bVisualizar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cBodegaDestino = New System.Windows.Forms.ComboBox()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cPOS)
        Me.GroupBox1.Controls.Add(Me.bVisualizar)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 52)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cPOS
        '
        Me.cPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPOS.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cPOS.FormattingEnabled = True
        Me.cPOS.Location = New System.Drawing.Point(6, 18)
        Me.cPOS.Name = "cPOS"
        Me.cPOS.Size = New System.Drawing.Size(189, 23)
        Me.cPOS.TabIndex = 56
        '
        'bVisualizar
        '
        Me.bVisualizar.BackColor = System.Drawing.Color.White
        Me.bVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVisualizar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bVisualizar.Image = Global.Rebusco.My.Resources.Resources.preview16
        Me.bVisualizar.Location = New System.Drawing.Point(201, 15)
        Me.bVisualizar.Name = "bVisualizar"
        Me.bVisualizar.Size = New System.Drawing.Size(205, 28)
        Me.bVisualizar.TabIndex = 53
        Me.bVisualizar.Text = "Visualizar Artículos de POS"
        Me.bVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bVisualizar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cBodegaDestino)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 45)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'cBodegaDestino
        '
        Me.cBodegaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodegaDestino.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cBodegaDestino.FormattingEnabled = True
        Me.cBodegaDestino.Location = New System.Drawing.Point(6, 16)
        Me.cBodegaDestino.Name = "cBodegaDestino"
        Me.cBodegaDestino.Size = New System.Drawing.Size(410, 23)
        Me.cBodegaDestino.TabIndex = 8
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(334, 192)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 87
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.execute24
        Me.bGuardar.Location = New System.Drawing.Point(218, 192)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(110, 36)
        Me.bGuardar.TabIndex = 86
        Me.bGuardar.Text = "Procesar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.bLimpiar.Location = New System.Drawing.Point(12, 192)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 85
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(422, 16)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "POS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 16)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Bodega Destino"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WinDeco1.Size = New System.Drawing.Size(446, 50)
        Me.WinDeco1.TabIndex = 137
        Me.WinDeco1.TituloVentana = "Movimiento de STOCK POS"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = False
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'MovimientoStockPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 240)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "MovimientoStockPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Stock desde POS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cPOS As ComboBox
    Public WithEvents bVisualizar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cBodegaDestino As ComboBox
    Public WithEvents bCancelar As Button
    Public WithEvents bGuardar As Button
    Public WithEvents bLimpiar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
