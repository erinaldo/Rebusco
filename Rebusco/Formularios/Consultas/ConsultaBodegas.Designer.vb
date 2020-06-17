<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaBodegas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaBodegas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.oPrincipal = New Rebusco.CustomCheck()
        Me.oDespacho = New Rebusco.CustomCheck()
        Me.oMovil = New Rebusco.CustomCheck()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.sBarra = New System.Windows.Forms.StatusStrip()
        Me.tMensajeBarra = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cLocal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 55)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 16)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Local"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(6, 24)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(405, 23)
        Me.cLocal.TabIndex = 123
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.oPrincipal)
        Me.GroupBox2.Controls.Add(Me.oDespacho)
        Me.GroupBox2.Controls.Add(Me.oMovil)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 64)
        Me.GroupBox2.TabIndex = 135
        Me.GroupBox2.TabStop = False
        '
        'oPrincipal
        '
        Me.oPrincipal.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPrincipal.BackColor = System.Drawing.Color.White
        Me.oPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPrincipal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPrincipal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oPrincipal.ForeColor = System.Drawing.Color.Black
        Me.oPrincipal.Image = CType(resources.GetObject("oPrincipal.Image"), System.Drawing.Image)
        Me.oPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPrincipal.Location = New System.Drawing.Point(6, 24)
        Me.oPrincipal.Name = "oPrincipal"
        Me.oPrincipal.Size = New System.Drawing.Size(105, 29)
        Me.oPrincipal.TabIndex = 128
        Me.oPrincipal.Text = "Principal"
        Me.oPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPrincipal.UseVisualStyleBackColor = False
        '
        'oDespacho
        '
        Me.oDespacho.Appearance = System.Windows.Forms.Appearance.Button
        Me.oDespacho.BackColor = System.Drawing.Color.White
        Me.oDespacho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDespacho.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oDespacho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oDespacho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oDespacho.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oDespacho.ForeColor = System.Drawing.Color.Black
        Me.oDespacho.Image = CType(resources.GetObject("oDespacho.Image"), System.Drawing.Image)
        Me.oDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oDespacho.Location = New System.Drawing.Point(117, 24)
        Me.oDespacho.Name = "oDespacho"
        Me.oDespacho.Size = New System.Drawing.Size(105, 29)
        Me.oDespacho.TabIndex = 129
        Me.oDespacho.Text = "Despacho"
        Me.oDespacho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oDespacho.UseVisualStyleBackColor = False
        '
        'oMovil
        '
        Me.oMovil.Appearance = System.Windows.Forms.Appearance.Button
        Me.oMovil.BackColor = System.Drawing.Color.White
        Me.oMovil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oMovil.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oMovil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oMovil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oMovil.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oMovil.ForeColor = System.Drawing.Color.Black
        Me.oMovil.Image = CType(resources.GetObject("oMovil.Image"), System.Drawing.Image)
        Me.oMovil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oMovil.Location = New System.Drawing.Point(228, 24)
        Me.oMovil.Name = "oMovil"
        Me.oMovil.Size = New System.Drawing.Size(105, 29)
        Me.oMovil.TabIndex = 134
        Me.oMovil.Text = "Móvil"
        Me.oMovil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oMovil.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(417, 16)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Tipo de Bodega"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xTabla
        '
        Me.xTabla.AllowDelete = True
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.xTabla.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(12, 188)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(576, 258)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 137
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(435, 149)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(99, 36)
        Me.bConsultar.TabIndex = 138
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 458)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 140
        Me.bLimpiar.Text = " Limpiar"
        Me.bLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(488, 458)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 141
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'sBarra
        '
        Me.sBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tMensajeBarra, Me.tBarraProgreso})
        Me.sBarra.Location = New System.Drawing.Point(0, 497)
        Me.sBarra.Name = "sBarra"
        Me.sBarra.Size = New System.Drawing.Size(600, 22)
        Me.sBarra.SizingGrip = False
        Me.sBarra.TabIndex = 241
        Me.sBarra.Text = "StatusStrip1"
        '
        'tMensajeBarra
        '
        Me.tMensajeBarra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tMensajeBarra.ForeColor = System.Drawing.Color.White
        Me.tMensajeBarra.Name = "tMensajeBarra"
        Me.tMensajeBarra.Size = New System.Drawing.Size(34, 17)
        Me.tMensajeBarra.Text = "Listo"
        '
        'tBarraProgreso
        '
        Me.tBarraProgreso.BackColor = System.Drawing.Color.White
        Me.tBarraProgreso.ForeColor = System.Drawing.Color.Black
        Me.tBarraProgreso.Name = "tBarraProgreso"
        Me.tBarraProgreso.Size = New System.Drawing.Size(100, 16)
        Me.tBarraProgreso.Step = 5
        Me.tBarraProgreso.Value = 70
        '
        'WinDeco1
        '
        Me.WinDeco1.AlturaFooter = 65
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
        Me.WinDeco1.Size = New System.Drawing.Size(600, 50)
        Me.WinDeco1.TabIndex = 242
        Me.WinDeco1.TituloVentana = "Consulta de Bodegas"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ConsultaBodegas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 519)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.sBarra)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ConsultaBodegas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Bodegas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sBarra.ResumeLayout(False)
        Me.sBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents oDespacho As CustomCheck
    Friend WithEvents oPrincipal As CustomCheck
    Friend WithEvents oMovil As CustomCheck
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bConsultar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents sBarra As StatusStrip
    Friend WithEvents tMensajeBarra As ToolStripStatusLabel
    Friend WithEvents tBarraProgreso As ToolStripProgressBar
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label1 As Label
End Class
