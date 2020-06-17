<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoTomaInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoTomaInventario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cFamilia = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.oStock = New System.Windows.Forms.CheckBox()
        Me.rDes = New Rebusco.CustomRadio()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cOrdenar = New System.Windows.Forms.ComboBox()
        Me.rAsc = New Rebusco.CustomRadio()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cBodega = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.oExistencia = New Rebusco.CustomCheck()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cFamilia)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(390, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cFamilia
        '
        Me.cFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cFamilia.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cFamilia.FormattingEnabled = True
        Me.cFamilia.Location = New System.Drawing.Point(9, 31)
        Me.cFamilia.Name = "cFamilia"
        Me.cFamilia.Size = New System.Drawing.Size(357, 24)
        Me.cFamilia.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(372, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Familia"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.oStock)
        Me.GroupBox2.Controls.Add(Me.rDes)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cOrdenar)
        Me.GroupBox2.Controls.Add(Me.rAsc)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(390, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 99)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'oStock
        '
        Me.oStock.AutoSize = True
        Me.oStock.Location = New System.Drawing.Point(11, 68)
        Me.oStock.Name = "oStock"
        Me.oStock.Size = New System.Drawing.Size(114, 20)
        Me.oStock.TabIndex = 138
        Me.oStock.Text = "Mostrar Stock"
        Me.oStock.UseVisualStyleBackColor = True
        '
        'rDes
        '
        Me.rDes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rDes.BackColor = System.Drawing.Color.White
        Me.rDes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rDes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rDes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.rDes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.rDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rDes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rDes.ForeColor = System.Drawing.Color.Black
        Me.rDes.Image = CType(resources.GetObject("rDes.Image"), System.Drawing.Image)
        Me.rDes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rDes.Location = New System.Drawing.Point(256, 59)
        Me.rDes.Name = "rDes"
        Me.rDes.Size = New System.Drawing.Size(110, 30)
        Me.rDes.TabIndex = 137
        Me.rDes.Text = "Descendente"
        Me.rDes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rDes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 16)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Ordenar Por"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cOrdenar
        '
        Me.cOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cOrdenar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cOrdenar.FormattingEnabled = True
        Me.cOrdenar.Items.AddRange(New Object() {"Seleccionar", "Artículo", "Descripción", "Barra", "Familia/SubFamiia"})
        Me.cOrdenar.Location = New System.Drawing.Point(9, 28)
        Me.cOrdenar.Name = "cOrdenar"
        Me.cOrdenar.Size = New System.Drawing.Size(357, 24)
        Me.cOrdenar.TabIndex = 1
        '
        'rAsc
        '
        Me.rAsc.Appearance = System.Windows.Forms.Appearance.Button
        Me.rAsc.BackColor = System.Drawing.Color.White
        Me.rAsc.Checked = True
        Me.rAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rAsc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.rAsc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.rAsc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.rAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rAsc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rAsc.ForeColor = System.Drawing.Color.White
        Me.rAsc.Image = CType(resources.GetObject("rAsc.Image"), System.Drawing.Image)
        Me.rAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rAsc.Location = New System.Drawing.Point(140, 59)
        Me.rAsc.Name = "rAsc"
        Me.rAsc.Size = New System.Drawing.Size(110, 30)
        Me.rAsc.TabIndex = 136
        Me.rAsc.TabStop = True
        Me.rAsc.Text = "Ascendente"
        Me.rAsc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rAsc.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(556, 245)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 62
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 245)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 61
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
        Me.bCancelar.Location = New System.Drawing.Point(662, 245)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 60
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(775, 50)
        Me.WinDeco1.TabIndex = 136
        Me.WinDeco1.TituloVentana = "Listado Toma de Inventario"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = False
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cLocal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 65)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(9, 31)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(357, 24)
        Me.cLocal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 16)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Local"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cBodega)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 65)
        Me.GroupBox4.TabIndex = 136
        Me.GroupBox4.TabStop = False
        '
        'cBodega
        '
        Me.cBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBodega.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cBodega.FormattingEnabled = True
        Me.cBodega.Location = New System.Drawing.Point(9, 31)
        Me.cBodega.Name = "cBodega"
        Me.cBodega.Size = New System.Drawing.Size(357, 24)
        Me.cBodega.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(372, 16)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Bodega"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oExistencia
        '
        Me.oExistencia.Appearance = System.Windows.Forms.Appearance.Button
        Me.oExistencia.BackColor = System.Drawing.Color.White
        Me.oExistencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oExistencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oExistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oExistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oExistencia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oExistencia.ForeColor = System.Drawing.Color.Black
        Me.oExistencia.Image = CType(resources.GetObject("oExistencia.Image"), System.Drawing.Image)
        Me.oExistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oExistencia.Location = New System.Drawing.Point(12, 191)
        Me.oExistencia.Name = "oExistencia"
        Me.oExistencia.Size = New System.Drawing.Size(151, 30)
        Me.oExistencia.TabIndex = 137
        Me.oExistencia.Text = "Solo Existencia"
        Me.oExistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oExistencia.UseVisualStyleBackColor = False
        '
        'ListadoTomaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 293)
        Me.Controls.Add(Me.oExistencia)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ListadoTomaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Toma de Inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cFamilia As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cOrdenar As ComboBox
    Public WithEvents bImprimir As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bCancelar As Button
    
    Friend WithEvents rDes As CustomRadio
    Friend WithEvents rAsc As CustomRadio
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cBodega As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents oStock As CheckBox
    Friend WithEvents oExistencia As CustomCheck
End Class
