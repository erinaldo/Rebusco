Imports WinDecoX.WinDeco
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CargarImagenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargarImagenes))
        Me.bCargarImagen = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.oCargarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.lAdjuntos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VistaPrevia = New System.Windows.Forms.PictureBox()
        Me.VistaImagenes = New System.Windows.Forms.ListView()
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.mMenuTabla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.bVerImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.bEliminarImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.bEliminarSel = New System.Windows.Forms.Button()
        Me.lRuta = New System.Windows.Forms.Label()
        CType(Me.VistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mMenuTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'bCargarImagen
        '
        Me.bCargarImagen.BackColor = System.Drawing.Color.White
        Me.bCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCargarImagen.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bCargarImagen.Image = Global.Rebusco.My.Resources.Resources.load24
        Me.bCargarImagen.Location = New System.Drawing.Point(12, 55)
        Me.bCargarImagen.Name = "bCargarImagen"
        Me.bCargarImagen.Size = New System.Drawing.Size(130, 35)
        Me.bCargarImagen.TabIndex = 251
        Me.bCargarImagen.Text = "Cargar Imagen"
        Me.bCargarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCargarImagen.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAceptar.BackColor = System.Drawing.Color.White
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bAceptar.Image = Global.Rebusco.My.Resources.Resources.ok24
        Me.bAceptar.Location = New System.Drawing.Point(1088, 394)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(100, 36)
        Me.bAceptar.TabIndex = 252
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'oCargarImagen
        '
        Me.oCargarImagen.FileName = "OpenFileDialog1"
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
        Me.WinDeco1.Size = New System.Drawing.Size(1200, 50)
        Me.WinDeco1.TabIndex = 253
        Me.WinDeco1.TituloVentana = "Cargar Imágenes"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'lAdjuntos
        '
        Me.lAdjuntos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lAdjuntos.AutoSize = True
        Me.lAdjuntos.BackColor = System.Drawing.Color.Transparent
        Me.lAdjuntos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAdjuntos.ForeColor = System.Drawing.Color.White
        Me.lAdjuntos.Location = New System.Drawing.Point(119, 389)
        Me.lAdjuntos.Name = "lAdjuntos"
        Me.lAdjuntos.Size = New System.Drawing.Size(15, 16)
        Me.lAdjuntos.TabIndex = 284
        Me.lAdjuntos.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Total imágenes"
        '
        'VistaPrevia
        '
        Me.VistaPrevia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VistaPrevia.BackColor = System.Drawing.Color.SlateGray
        Me.VistaPrevia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VistaPrevia.Location = New System.Drawing.Point(805, 93)
        Me.VistaPrevia.Name = "VistaPrevia"
        Me.VistaPrevia.Size = New System.Drawing.Size(383, 275)
        Me.VistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VistaPrevia.TabIndex = 283
        Me.VistaPrevia.TabStop = False
        '
        'VistaImagenes
        '
        Me.VistaImagenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VistaImagenes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VistaImagenes.HideSelection = False
        Me.VistaImagenes.Location = New System.Drawing.Point(12, 94)
        Me.VistaImagenes.MultiSelect = False
        Me.VistaImagenes.Name = "VistaImagenes"
        Me.VistaImagenes.Size = New System.Drawing.Size(787, 274)
        Me.VistaImagenes.TabIndex = 282
        Me.VistaImagenes.UseCompatibleStateImageBehavior = False
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ListaImagenes.ImageSize = New System.Drawing.Size(96, 96)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        '
        'mMenuTabla
        '
        Me.mMenuTabla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bVerImagen, Me.bEliminarImagen})
        Me.mMenuTabla.Name = "mMenuTabla"
        Me.mMenuTabla.Size = New System.Drawing.Size(162, 64)
        '
        'bVerImagen
        '
        Me.bVerImagen.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVerImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.bVerImagen.Image = Global.Rebusco.My.Resources.Resources.image24
        Me.bVerImagen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bVerImagen.Name = "bVerImagen"
        Me.bVerImagen.Size = New System.Drawing.Size(161, 30)
        Me.bVerImagen.Text = "Ver imagen"
        '
        'bEliminarImagen
        '
        Me.bEliminarImagen.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminarImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bEliminarImagen.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bEliminarImagen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bEliminarImagen.Name = "bEliminarImagen"
        Me.bEliminarImagen.Size = New System.Drawing.Size(161, 30)
        Me.bEliminarImagen.Text = "Eliminar"
        '
        'bEliminarSel
        '
        Me.bEliminarSel.BackColor = System.Drawing.Color.White
        Me.bEliminarSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminarSel.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bEliminarSel.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bEliminarSel.Location = New System.Drawing.Point(145, 55)
        Me.bEliminarSel.Name = "bEliminarSel"
        Me.bEliminarSel.Size = New System.Drawing.Size(176, 36)
        Me.bEliminarSel.TabIndex = 251
        Me.bEliminarSel.Text = " Eliminar seleccionada"
        Me.bEliminarSel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bEliminarSel.UseVisualStyleBackColor = False
        '
        'lRuta
        '
        Me.lRuta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lRuta.AutoSize = True
        Me.lRuta.BackColor = System.Drawing.Color.Transparent
        Me.lRuta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRuta.ForeColor = System.Drawing.Color.White
        Me.lRuta.Location = New System.Drawing.Point(14, 414)
        Me.lRuta.Name = "lRuta"
        Me.lRuta.Size = New System.Drawing.Size(45, 16)
        Me.lRuta.TabIndex = 286
        Me.lRuta.Text = "Ruta: "
        '
        'CargarImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 442)
        Me.Controls.Add(Me.lRuta)
        Me.Controls.Add(Me.lAdjuntos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VistaPrevia)
        Me.Controls.Add(Me.VistaImagenes)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bEliminarSel)
        Me.Controls.Add(Me.bCargarImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "CargarImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cargar Imágenes"
        CType(Me.VistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mMenuTabla.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents bCargarImagen As Button
    Public WithEvents bAceptar As Button
    Friend WithEvents oCargarImagen As OpenFileDialog
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents lAdjuntos As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VistaPrevia As PictureBox
    Friend WithEvents VistaImagenes As ListView
    Friend WithEvents ListaImagenes As ImageList
    Friend WithEvents mMenuTabla As ContextMenuStrip
    Friend WithEvents bEliminarImagen As ToolStripMenuItem
    Friend WithEvents bVerImagen As ToolStripMenuItem
    Public WithEvents bEliminarSel As Button
    Friend WithEvents lRuta As Label
End Class
