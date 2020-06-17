<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManPOS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bBuscar = New Rebusco.SearchButton()
        Me.xPOS = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.oActivo = New Rebusco.CustomCheck()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xCaja = New System.Windows.Forms.TextBox()
        Me.dFechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cTipoPOS = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xNSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.oActivo)
        Me.GroupBox1.Controls.Add(Me.bNuevo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.xCaja)
        Me.GroupBox1.Controls.Add(Me.dFechaVenc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cTipoPOS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xNSerie)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xPOS)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 201)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bBuscar
        '
        Me.bBuscar.CampoBuscar1 = "NombrePOS"
        Me.bBuscar.CampoBuscar2 = ""
        Me.bBuscar.CamposAdicionales = ""
        Me.bBuscar.ControlCarga = Me.xPOS
        Me.bBuscar.ControlFocus = Me.xNombre
        Me.bBuscar.Filtro = ""
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscar.IDBusqueda = "POS"
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(273, 22)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(80, 27)
        Me.bBuscar.TabIndex = 329
        Me.bBuscar.TablaBusqueda = "POS"
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.Titulo = "Buscar POS"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'xPOS
        '
        Me.xPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xPOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xPOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xPOS.Location = New System.Drawing.Point(109, 25)
        Me.xPOS.MaxLength = 1
        Me.xPOS.Name = "xPOS"
        Me.xPOS.Size = New System.Drawing.Size(72, 22)
        Me.xPOS.TabIndex = 0
        '
        'xNombre
        '
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombre.Location = New System.Drawing.Point(109, 56)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(374, 21)
        Me.xNombre.TabIndex = 1
        '
        'oActivo
        '
        Me.oActivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.oActivo.BackColor = System.Drawing.Color.White
        Me.oActivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oActivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oActivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oActivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oActivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oActivo.ForeColor = System.Drawing.Color.Black
        Me.oActivo.Image = CType(resources.GetObject("oActivo.Image"), System.Drawing.Image)
        Me.oActivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oActivo.Location = New System.Drawing.Point(378, 166)
        Me.oActivo.Name = "oActivo"
        Me.oActivo.Size = New System.Drawing.Size(105, 29)
        Me.oActivo.TabIndex = 328
        Me.oActivo.Text = "Activo"
        Me.oActivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oActivo.UseVisualStyleBackColor = False
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.White
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = Global.Rebusco.My.Resources.Resources._new
        Me.bNuevo.Location = New System.Drawing.Point(187, 22)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 28)
        Me.bNuevo.TabIndex = 327
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "N° Caja"
        '
        'xCaja
        '
        Me.xCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCaja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCaja.Location = New System.Drawing.Point(109, 114)
        Me.xCaja.MaxLength = 1
        Me.xCaja.Name = "xCaja"
        Me.xCaja.Size = New System.Drawing.Size(72, 21)
        Me.xCaja.TabIndex = 48
        '
        'dFechaVenc
        '
        Me.dFechaVenc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFechaVenc.Location = New System.Drawing.Point(109, 170)
        Me.dFechaVenc.Name = "dFechaVenc"
        Me.dFechaVenc.Size = New System.Drawing.Size(100, 21)
        Me.dFechaVenc.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "F.Vencimiento"
        '
        'cTipoPOS
        '
        Me.cTipoPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoPOS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoPOS.FormattingEnabled = True
        Me.cTipoPOS.Location = New System.Drawing.Point(109, 84)
        Me.cTipoPOS.Name = "cTipoPOS"
        Me.cTipoPOS.Size = New System.Drawing.Size(158, 23)
        Me.cTipoPOS.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tipo POS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "N° Serie"
        '
        'xNSerie
        '
        Me.xNSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNSerie.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNSerie.Location = New System.Drawing.Point(109, 142)
        Me.xNSerie.MaxLength = 1
        Me.xNSerie.Name = "xNSerie"
        Me.xNSerie.Size = New System.Drawing.Size(158, 21)
        Me.xNSerie.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "POS"
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(189, 289)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 36)
        Me.bGuardar.TabIndex = 7
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
        Me.bEliminar.Location = New System.Drawing.Point(295, 289)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 36)
        Me.bEliminar.TabIndex = 8
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
        Me.bLimpiar.Location = New System.Drawing.Point(12, 289)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 6
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
        Me.bSalir.Location = New System.Drawing.Point(401, 289)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 9
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'lFolios
        '
        Me.lFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lFolios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lFolios.ForeColor = System.Drawing.Color.White
        Me.lFolios.Location = New System.Drawing.Point(12, 59)
        Me.lFolios.Name = "lFolios"
        Me.lFolios.Size = New System.Drawing.Size(489, 16)
        Me.lFolios.TabIndex = 133
        Me.lFolios.Text = "POS"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WinDeco1.Size = New System.Drawing.Size(513, 50)
        Me.WinDeco1.TabIndex = 134
        Me.WinDeco1.TituloVentana = "Mantenedor de POS"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ManPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(513, 338)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.lFolios)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de POS"
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
    Friend WithEvents xPOS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents xNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xNSerie As TextBox
    Friend WithEvents dFechaVenc As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cTipoPOS As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents xCaja As TextBox
    
    Public WithEvents bNuevo As Button
    Friend WithEvents bBuscar As SearchButton
    Friend WithEvents oActivo As CustomCheck
    Friend WithEvents lFolios As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
End Class
