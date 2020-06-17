<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockPorDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockPorDocumento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.bVisualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xBodega = New System.Windows.Forms.TextBox()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xNumDoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cBodegaIngreso = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cTipoDoc)
        Me.GroupBox1.Controls.Add(Me.bVisualizar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xBodega)
        Me.GroupBox1.Controls.Add(Me.xLocal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xNumDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 152)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cTipoDoc
        '
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Enabled = False
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(110, 26)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(296, 23)
        Me.cTipoDoc.TabIndex = 56
        '
        'bVisualizar
        '
        Me.bVisualizar.BackColor = System.Drawing.Color.White
        Me.bVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVisualizar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bVisualizar.Image = Global.Rebusco.My.Resources.Resources.preview16
        Me.bVisualizar.Location = New System.Drawing.Point(217, 56)
        Me.bVisualizar.Name = "bVisualizar"
        Me.bVisualizar.Size = New System.Drawing.Size(189, 28)
        Me.bVisualizar.TabIndex = 53
        Me.bVisualizar.Text = "Visualizar Documento"
        Me.bVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bVisualizar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Tipo Doc."
        '
        'xBodega
        '
        Me.xBodega.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xBodega.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xBodega.Location = New System.Drawing.Point(110, 119)
        Me.xBodega.Name = "xBodega"
        Me.xBodega.Size = New System.Drawing.Size(296, 21)
        Me.xBodega.TabIndex = 55
        '
        'xLocal
        '
        Me.xLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xLocal.Location = New System.Drawing.Point(110, 90)
        Me.xLocal.Name = "xLocal"
        Me.xLocal.Size = New System.Drawing.Size(296, 21)
        Me.xLocal.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(10, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Bodega Actual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(10, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Local"
        '
        'xNumDoc
        '
        Me.xNumDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNumDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNumDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xNumDoc.Location = New System.Drawing.Point(110, 59)
        Me.xNumDoc.Name = "xNumDoc"
        Me.xNumDoc.Size = New System.Drawing.Size(90, 21)
        Me.xNumDoc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Número Doc."
        '
        'cBodegaIngreso
        '
        Me.cBodegaIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodegaIngreso.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cBodegaIngreso.FormattingEnabled = True
        Me.cBodegaIngreso.Location = New System.Drawing.Point(6, 21)
        Me.cBodegaIngreso.Name = "cBodegaIngreso"
        Me.cBodegaIngreso.Size = New System.Drawing.Size(406, 24)
        Me.cBodegaIngreso.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cBodegaIngreso)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 53)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(328, 282)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 84
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
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.execute24
        Me.bGuardar.Location = New System.Drawing.Point(222, 282)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 83
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
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 282)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 52
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
        Me.Label14.Size = New System.Drawing.Size(419, 16)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Bodega Origen"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 16)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Bodega Destino"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WinDeco1.Size = New System.Drawing.Size(442, 50)
        Me.WinDeco1.TabIndex = 138
        Me.WinDeco1.TituloVentana = "Stock por Documento"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'StockPorDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 331)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "StockPorDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Stock por Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xNumDoc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cBodegaIngreso As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents bLimpiar As Button
    Public WithEvents bGuardar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bVisualizar As Button
    Friend WithEvents xBodega As TextBox
    Friend WithEvents xLocal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
