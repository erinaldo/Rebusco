<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManTipoDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManTipoDoc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lFolios = New System.Windows.Forms.Label()
        Me.bBuscar = New Rebusco.SearchButton()
        Me.xTipoDoc = New System.Windows.Forms.TextBox()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cDocAnula = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.xCODSII = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xFiltro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xModo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.oPagos = New Rebusco.CustomCheck()
        Me.oEmision = New Rebusco.CustomCheck()
        Me.oFacturable = New Rebusco.CustomCheck()
        Me.oContable = New Rebusco.CustomCheck()
        Me.oElectronica = New Rebusco.CustomCheck()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lFolios)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cDocAnula)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xNombre)
        Me.GroupBox1.Controls.Add(Me.xCODSII)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xFiltro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.xModo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xTipoDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 223)
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
        Me.lFolios.Size = New System.Drawing.Size(495, 16)
        Me.lFolios.TabIndex = 135
        Me.lFolios.Text = "Tipo Documento"
        Me.lFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bBuscar
        '
        Me.bBuscar.CampoBuscar1 = "DescTipoDoc"
        Me.bBuscar.CampoBuscar2 = ""
        Me.bBuscar.CamposAdicionales = ""
        Me.bBuscar.ControlCarga = Me.xTipoDoc
        Me.bBuscar.ControlFocus = Me.xDescripcion
        Me.bBuscar.Filtro = ""
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscar.IDBusqueda = "TipoDoc"
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(169, 21)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(81, 27)
        Me.bBuscar.TabIndex = 51
        Me.bBuscar.TablaBusqueda = "TipoDoc"
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscar.Titulo = "Buscar Tipo de Documento"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'xTipoDoc
        '
        Me.xTipoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTipoDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xTipoDoc.Location = New System.Drawing.Point(91, 23)
        Me.xTipoDoc.MaxLength = 2
        Me.xTipoDoc.Name = "xTipoDoc"
        Me.xTipoDoc.Size = New System.Drawing.Size(72, 21)
        Me.xTipoDoc.TabIndex = 0
        '
        'xDescripcion
        '
        Me.xDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDescripcion.Location = New System.Drawing.Point(91, 53)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.Size = New System.Drawing.Size(390, 21)
        Me.xDescripcion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Documento Anula"
        '
        'cDocAnula
        '
        Me.cDocAnula.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cDocAnula.FormattingEnabled = True
        Me.cDocAnula.Location = New System.Drawing.Point(122, 193)
        Me.cDocAnula.Name = "cDocAnula"
        Me.cDocAnula.Size = New System.Drawing.Size(208, 23)
        Me.cDocAnula.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nombre"
        '
        'xNombre
        '
        Me.xNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNombre.Location = New System.Drawing.Point(91, 81)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(390, 21)
        Me.xNombre.TabIndex = 47
        '
        'xCODSII
        '
        Me.xCODSII.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCODSII.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xCODSII.Location = New System.Drawing.Point(91, 165)
        Me.xCODSII.MaxLength = 1
        Me.xCODSII.Name = "xCODSII"
        Me.xCODSII.Size = New System.Drawing.Size(239, 21)
        Me.xCODSII.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Codigo SII"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Filtro"
        '
        'xFiltro
        '
        Me.xFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xFiltro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xFiltro.Location = New System.Drawing.Point(91, 137)
        Me.xFiltro.MaxLength = 1
        Me.xFiltro.Name = "xFiltro"
        Me.xFiltro.Size = New System.Drawing.Size(72, 21)
        Me.xFiltro.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modo"
        '
        'xModo
        '
        Me.xModo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xModo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xModo.Location = New System.Drawing.Point(91, 109)
        Me.xModo.MaxLength = 1
        Me.xModo.Name = "xModo"
        Me.xModo.Size = New System.Drawing.Size(72, 21)
        Me.xModo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(365, 300)
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
        Me.bEliminar.Location = New System.Drawing.Point(471, 300)
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
        Me.bLimpiar.Location = New System.Drawing.Point(12, 300)
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
        Me.bSalir.Location = New System.Drawing.Point(575, 300)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 2
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.oPagos)
        Me.GroupBox2.Controls.Add(Me.oEmision)
        Me.GroupBox2.Controls.Add(Me.oFacturable)
        Me.GroupBox2.Controls.Add(Me.oContable)
        Me.GroupBox2.Controls.Add(Me.oElectronica)
        Me.GroupBox2.Location = New System.Drawing.Point(513, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 222)
        Me.GroupBox2.TabIndex = 133
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 16)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Tratamiento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oPagos
        '
        Me.oPagos.Appearance = System.Windows.Forms.Appearance.Button
        Me.oPagos.BackColor = System.Drawing.Color.White
        Me.oPagos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPagos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oPagos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oPagos.ForeColor = System.Drawing.Color.Black
        Me.oPagos.Image = CType(resources.GetObject("oPagos.Image"), System.Drawing.Image)
        Me.oPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oPagos.Location = New System.Drawing.Point(6, 163)
        Me.oPagos.Name = "oPagos"
        Me.oPagos.Size = New System.Drawing.Size(150, 29)
        Me.oPagos.TabIndex = 60
        Me.oPagos.Text = "Pagos"
        Me.oPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oPagos.UseVisualStyleBackColor = False
        '
        'oEmision
        '
        Me.oEmision.Appearance = System.Windows.Forms.Appearance.Button
        Me.oEmision.BackColor = System.Drawing.Color.White
        Me.oEmision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oEmision.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oEmision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oEmision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oEmision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oEmision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oEmision.ForeColor = System.Drawing.Color.Black
        Me.oEmision.Image = CType(resources.GetObject("oEmision.Image"), System.Drawing.Image)
        Me.oEmision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oEmision.Location = New System.Drawing.Point(6, 128)
        Me.oEmision.Name = "oEmision"
        Me.oEmision.Size = New System.Drawing.Size(150, 29)
        Me.oEmision.TabIndex = 59
        Me.oEmision.Text = "Emisión"
        Me.oEmision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oEmision.UseVisualStyleBackColor = False
        '
        'oFacturable
        '
        Me.oFacturable.Appearance = System.Windows.Forms.Appearance.Button
        Me.oFacturable.BackColor = System.Drawing.Color.White
        Me.oFacturable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFacturable.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oFacturable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oFacturable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oFacturable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oFacturable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oFacturable.ForeColor = System.Drawing.Color.Black
        Me.oFacturable.Image = CType(resources.GetObject("oFacturable.Image"), System.Drawing.Image)
        Me.oFacturable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oFacturable.Location = New System.Drawing.Point(6, 93)
        Me.oFacturable.Name = "oFacturable"
        Me.oFacturable.Size = New System.Drawing.Size(150, 29)
        Me.oFacturable.TabIndex = 58
        Me.oFacturable.Text = "Facturable"
        Me.oFacturable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oFacturable.UseVisualStyleBackColor = False
        '
        'oContable
        '
        Me.oContable.Appearance = System.Windows.Forms.Appearance.Button
        Me.oContable.BackColor = System.Drawing.Color.White
        Me.oContable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oContable.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oContable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oContable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oContable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oContable.ForeColor = System.Drawing.Color.Black
        Me.oContable.Image = CType(resources.GetObject("oContable.Image"), System.Drawing.Image)
        Me.oContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oContable.Location = New System.Drawing.Point(6, 58)
        Me.oContable.Name = "oContable"
        Me.oContable.Size = New System.Drawing.Size(150, 29)
        Me.oContable.TabIndex = 57
        Me.oContable.Text = "Contable"
        Me.oContable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oContable.UseVisualStyleBackColor = False
        '
        'oElectronica
        '
        Me.oElectronica.Appearance = System.Windows.Forms.Appearance.Button
        Me.oElectronica.BackColor = System.Drawing.Color.White
        Me.oElectronica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oElectronica.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oElectronica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oElectronica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oElectronica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oElectronica.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oElectronica.ForeColor = System.Drawing.Color.Black
        Me.oElectronica.Image = CType(resources.GetObject("oElectronica.Image"), System.Drawing.Image)
        Me.oElectronica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oElectronica.Location = New System.Drawing.Point(6, 23)
        Me.oElectronica.Name = "oElectronica"
        Me.oElectronica.Size = New System.Drawing.Size(150, 29)
        Me.oElectronica.TabIndex = 56
        Me.oElectronica.Text = "Electronica"
        Me.oElectronica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oElectronica.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(687, 50)
        Me.WinDeco1.TabIndex = 134
        Me.WinDeco1.TituloVentana = "Mantenedor de Tipo de Documento"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ManTipoDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(687, 349)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ManTipoDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Tipo de Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents bGuardar As Button
    Public WithEvents bEliminar As Button
    Public WithEvents bLimpiar As Button
    Public WithEvents bSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents xTipoDoc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xModo As TextBox
    
    Friend WithEvents Label7 As Label
    Friend WithEvents cDocAnula As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents xNombre As TextBox
    Friend WithEvents xCODSII As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents xFiltro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents oPagos As CustomCheck
    Friend WithEvents oEmision As CustomCheck
    Friend WithEvents oFacturable As CustomCheck
    Friend WithEvents oContable As CustomCheck
    Friend WithEvents oElectronica As CustomCheck
    Friend WithEvents bBuscar As SearchButton
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents lFolios As Label
    Friend WithEvents Label8 As Label
End Class
