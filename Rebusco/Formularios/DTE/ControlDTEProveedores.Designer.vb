<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlDTEProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDTEProveedores))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gFiltro = New System.Windows.Forms.GroupBox()
        Me.bBuscarCli = New Rebusco.SearchButton()
        Me.xRut = New System.Windows.Forms.TextBox()
        Me.xNombre = New System.Windows.Forms.TextBox()
        Me.dHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cEstados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cTipoDoc = New System.Windows.Forms.ComboBox()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.oTodos = New Rebusco.CustomCheck()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bProcesar = New System.Windows.Forms.Button()
        Me.xCantDoc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.gFiltro.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(663, 16)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Filtros"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gFiltro
        '
        Me.gFiltro.BackColor = System.Drawing.Color.Transparent
        Me.gFiltro.Controls.Add(Me.bBuscarCli)
        Me.gFiltro.Controls.Add(Me.xNombre)
        Me.gFiltro.Controls.Add(Me.xRut)
        Me.gFiltro.Controls.Add(Me.dHasta)
        Me.gFiltro.Controls.Add(Me.Label4)
        Me.gFiltro.Controls.Add(Me.dDesde)
        Me.gFiltro.Controls.Add(Me.Label5)
        Me.gFiltro.Controls.Add(Me.cEstados)
        Me.gFiltro.Controls.Add(Me.Label3)
        Me.gFiltro.Controls.Add(Me.cLocal)
        Me.gFiltro.Controls.Add(Me.Label2)
        Me.gFiltro.Controls.Add(Me.Label1)
        Me.gFiltro.Controls.Add(Me.cTipoDoc)
        Me.gFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gFiltro.Location = New System.Drawing.Point(12, 58)
        Me.gFiltro.Name = "gFiltro"
        Me.gFiltro.Size = New System.Drawing.Size(663, 110)
        Me.gFiltro.TabIndex = 138
        Me.gFiltro.TabStop = False
        '
        'bBuscarCli
        '
        Me.bBuscarCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBuscarCli.CampoBuscar1 = "Nombre"
        Me.bBuscarCli.CampoBuscar2 = ""
        Me.bBuscarCli.CamposAdicionales = ""
        Me.bBuscarCli.ControlCarga = Me.xRut
        Me.bBuscarCli.ControlFocus = Me.xRut
        Me.bBuscarCli.Filtro = ""
        Me.bBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarCli.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bBuscarCli.IconSize = Rebusco.SearchButton.TamañoIcono.Size16
        Me.bBuscarCli.IDBusqueda = "Rut"
        Me.bBuscarCli.Image = CType(resources.GetObject("bBuscarCli.Image"), System.Drawing.Image)
        Me.bBuscarCli.Location = New System.Drawing.Point(629, 18)
        Me.bBuscarCli.Name = "bBuscarCli"
        Me.bBuscarCli.Size = New System.Drawing.Size(28, 27)
        Me.bBuscarCli.TabIndex = 14
        Me.bBuscarCli.TablaBusqueda = "Clientes"
        Me.bBuscarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarCli.Titulo = "Clientes"
        Me.bBuscarCli.UseVisualStyleBackColor = True
        Me.bBuscarCli.Visible = False
        '
        'xRut
        '
        Me.xRut.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xRut.Location = New System.Drawing.Point(20, 20)
        Me.xRut.Name = "xRut"
        Me.xRut.Size = New System.Drawing.Size(100, 21)
        Me.xRut.TabIndex = 12
        '
        'xNombre
        '
        Me.xNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xNombre.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombre.Location = New System.Drawing.Point(127, 20)
        Me.xNombre.Name = "xNombre"
        Me.xNombre.Size = New System.Drawing.Size(496, 21)
        Me.xNombre.TabIndex = 13
        '
        'dHasta
        '
        Me.dHasta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dHasta.Location = New System.Drawing.Point(254, 51)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Size = New System.Drawing.Size(97, 21)
        Me.dHasta.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(230, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "al"
        '
        'dDesde
        '
        Me.dDesde.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDesde.Location = New System.Drawing.Point(127, 51)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Size = New System.Drawing.Size(97, 21)
        Me.dDesde.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(11, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rango de Fechas"
        '
        'cEstados
        '
        Me.cEstados.BackColor = System.Drawing.Color.White
        Me.cEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cEstados.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cEstados.FormattingEnabled = True
        Me.cEstados.Location = New System.Drawing.Point(420, 81)
        Me.cEstados.Name = "cEstados"
        Me.cEstados.Size = New System.Drawing.Size(237, 23)
        Me.cEstados.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(363, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estado"
        '
        'cLocal
        '
        Me.cLocal.BackColor = System.Drawing.Color.White
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(420, 51)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(237, 23)
        Me.cLocal.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(363, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Local"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Documento"
        '
        'cTipoDoc
        '
        Me.cTipoDoc.BackColor = System.Drawing.Color.White
        Me.cTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cTipoDoc.FormattingEnabled = True
        Me.cTipoDoc.Location = New System.Drawing.Point(127, 79)
        Me.cTipoDoc.Name = "cTipoDoc"
        Me.cTipoDoc.Size = New System.Drawing.Size(224, 23)
        Me.cTipoDoc.TabIndex = 2
        '
        'bConsultar
        '
        Me.bConsultar.BackColor = System.Drawing.Color.White
        Me.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bConsultar.Image = Global.Rebusco.My.Resources.Resources.find24
        Me.bConsultar.Location = New System.Drawing.Point(681, 97)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(100, 36)
        Me.bConsultar.TabIndex = 140
        Me.bConsultar.Text = "Consultar"
        Me.bConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultar.UseVisualStyleBackColor = False
        '
        'oTodos
        '
        Me.oTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.oTodos.BackColor = System.Drawing.Color.White
        Me.oTodos.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.oTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.oTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.oTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.oTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oTodos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.oTodos.ForeColor = System.Drawing.Color.Black
        Me.oTodos.Image = CType(resources.GetObject("oTodos.Image"), System.Drawing.Image)
        Me.oTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.oTodos.Location = New System.Drawing.Point(681, 56)
        Me.oTodos.Name = "oTodos"
        Me.oTodos.Size = New System.Drawing.Size(285, 32)
        Me.oTodos.TabIndex = 142
        Me.oTodos.Text = "Mostrar todos los Documentos Electrónicos"
        Me.oTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.oTodos.UseVisualStyleBackColor = False
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
        Me.xTabla.Location = New System.Drawing.Point(11, 171)
        Me.xTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.xTabla.Size = New System.Drawing.Size(1020, 285)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 143
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(442, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(586, 34)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Seleccione los documentos a enviar a SII que no esten enviados o con algún error." &
    "  Si el documento esta aprobado con reparos, rechazado o ya fue enviado anterior" &
    "mente, SII  lo rechazará de nuevo. "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(928, 506)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 147
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(822, 506)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 148
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bProcesar
        '
        Me.bProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bProcesar.BackColor = System.Drawing.Color.White
        Me.bProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bProcesar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bProcesar.Image = Global.Rebusco.My.Resources.Resources.execute24
        Me.bProcesar.Location = New System.Drawing.Point(716, 506)
        Me.bProcesar.Name = "bProcesar"
        Me.bProcesar.Size = New System.Drawing.Size(100, 36)
        Me.bProcesar.TabIndex = 149
        Me.bProcesar.Text = "Procesar"
        Me.bProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bProcesar.UseVisualStyleBackColor = False
        Me.bProcesar.Visible = False
        '
        'xCantDoc
        '
        Me.xCantDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xCantDoc.Enabled = False
        Me.xCantDoc.Location = New System.Drawing.Point(171, 465)
        Me.xCantDoc.Name = "xCantDoc"
        Me.xCantDoc.Size = New System.Drawing.Size(41, 20)
        Me.xCantDoc.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 15)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Cantidad de Documentos"
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
        Me.WinDeco1.Size = New System.Drawing.Size(1040, 50)
        Me.WinDeco1.TabIndex = 153
        Me.WinDeco1.TituloVentana = "Control DTE Proveedores"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = True
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'ControlDTEProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 554)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.xCantDoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bProcesar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.oTodos)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ControlDTEProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control DTE Proveedores"
        Me.gFiltro.ResumeLayout(False)
        Me.gFiltro.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Label6 As Label
    Friend WithEvents gFiltro As GroupBox
    Friend WithEvents dHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dDesde As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cEstados As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cTipoDoc As ComboBox
    Friend WithEvents Label1 As Label
    Public WithEvents bConsultar As Button
    Friend WithEvents oTodos As CustomCheck
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label7 As Label
    Public WithEvents bCancelar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bProcesar As Button
    Friend WithEvents xCantDoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents bBuscarCli As SearchButton
    Friend WithEvents xRut As TextBox
    Friend WithEvents xNombre As TextBox
End Class
