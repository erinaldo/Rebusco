<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManFamilia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.SearchButton1 = New Rebusco.SearchButton()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xFamilia = New System.Windows.Forms.TextBox()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lFolios)
        Me.GroupBox1.Controls.Add(Me.SearchButton1)
        Me.GroupBox1.Controls.Add(Me.bNuevo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xFamilia)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lFolios
        '
        Me.lFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lFolios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lFolios.ForeColor = System.Drawing.Color.White
        Me.lFolios.Location = New System.Drawing.Point(0, 0)
        Me.lFolios.Name = "lFolios"
        Me.lFolios.Size = New System.Drawing.Size(444, 16)
        Me.lFolios.TabIndex = 136
        Me.lFolios.Text = "Familia"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SearchButton1
        '
        Me.SearchButton1.CampoBuscar1 = "DescFamilia"
        Me.SearchButton1.CampoBuscar2 = ""
        Me.SearchButton1.CamposAdicionales = ""
        Me.SearchButton1.ControlCarga = Me.xFamilia
        Me.SearchButton1.ControlFocus = Me.xDescripcion
        Me.SearchButton1.Filtro = ""
        Me.SearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SearchButton1.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.SearchButton1.IDBusqueda = "Familia"
        Me.SearchButton1.Image = CType(resources.GetObject("SearchButton1.Image"), System.Drawing.Image)
        Me.SearchButton1.Location = New System.Drawing.Point(250, 21)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(79, 27)
        Me.SearchButton1.TabIndex = 82
        Me.SearchButton1.TablaBusqueda = "Familias"
        Me.SearchButton1.Text = "Buscar"
        Me.SearchButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton1.Titulo = "Buscar Familia"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.White
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bNuevo.Image = Global.Rebusco.My.Resources.Resources._new
        Me.bNuevo.Location = New System.Drawing.Point(165, 21)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(79, 28)
        Me.bNuevo.TabIndex = 81
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'xDescripcion
        '
        Me.xDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(90, 55)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.Size = New System.Drawing.Size(348, 21)
        Me.xDescripcion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Familia"
        '
        'xFamilia
        '
        Me.xFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xFamilia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xFamilia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xFamilia.Location = New System.Drawing.Point(90, 26)
        Me.xFamilia.MaxLength = 10
        Me.xFamilia.Name = "xFamilia"
        Me.xFamilia.Size = New System.Drawing.Size(72, 22)
        Me.xFamilia.TabIndex = 0
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(144, 154)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bEliminar
        '
        Me.bEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEliminar.BackColor = System.Drawing.Color.White
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bEliminar.Image = Global.Rebusco.My.Resources.Resources.delete24
        Me.bEliminar.Location = New System.Drawing.Point(250, 154)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 36)
        Me.bEliminar.TabIndex = 1
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 154)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 3
        Me.bLimpiar.Text = "Limpiar"
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
        Me.bSalir.Location = New System.Drawing.Point(356, 154)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 2
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(468, 50)
        Me.WinDeco1.TabIndex = 133
        Me.WinDeco1.TituloVentana = "Mantenedor de Familias"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ManFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(468, 203)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Familias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bGuardar As Button
    Public WithEvents bEliminar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents xFamilia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents xDescripcion As TextBox
    Public WithEvents bNuevo As Button
    
    Friend WithEvents SearchButton1 As SearchButton
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents lFolios As Label
End Class
