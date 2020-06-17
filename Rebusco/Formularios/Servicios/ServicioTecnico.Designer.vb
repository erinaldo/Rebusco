<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicioTecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServicioTecnico))
        Dim Vs2010TabControlRenderer1 As Rebusco.Renderers.Vs2010TabControlRenderer = New Rebusco.Renderers.Vs2010TabControlRenderer()
        Dim Vs2010DefaultTabControlColorTable1 As Rebusco.ColorTables.Vs2010DefaultTabControlColorTable = New Rebusco.ColorTables.Vs2010DefaultTabControlColorTable()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bConsultarOT = New System.Windows.Forms.Button()
        Me.xOT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xEstado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gTecnico = New System.Windows.Forms.GroupBox()
        Me.xTecnico = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cTecnicos = New System.Windows.Forms.ComboBox()
        Me.gServicios = New System.Windows.Forms.GroupBox()
        Me.bBuscarServicio = New System.Windows.Forms.Button()
        Me.xServicio = New Rebusco.TextBoxAutoComple()
        Me.xTabla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bAgregarS = New System.Windows.Forms.Button()
        Me.xNombreServicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gArticulos = New System.Windows.Forms.GroupBox()
        Me.bBuscarArticulo = New System.Windows.Forms.Button()
        Me.xArticulo = New Rebusco.TextBoxAutoComple()
        Me.xTablaArticulos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bAgregarA = New System.Windows.Forms.Button()
        Me.xDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bConfirmar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cPlantilla = New System.Windows.Forms.ComboBox()
        Me.bIniciar = New System.Windows.Forms.Button()
        Me.bAgregarPlantilla = New System.Windows.Forms.Button()
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.tObservacion = New Rebusco.Controls.Vs2010TabControl()
        Me.ObsCli = New System.Windows.Forms.TabPage()
        Me.xObsCliente = New System.Windows.Forms.TextBox()
        Me.ObsTec = New System.Windows.Forms.TabPage()
        Me.xObsTecnico = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gTecnico.SuspendLayout()
        Me.gServicios.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gArticulos.SuspendLayout()
        CType(Me.xTablaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tObservacion.SuspendLayout()
        Me.ObsCli.SuspendLayout()
        Me.ObsTec.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.bConsultarOT)
        Me.GroupBox1.Controls.Add(Me.xOT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bConsultarOT
        '
        Me.bConsultarOT.BackColor = System.Drawing.Color.White
        Me.bConsultarOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConsultarOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bConsultarOT.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bConsultarOT.Location = New System.Drawing.Point(88, 23)
        Me.bConsultarOT.Name = "bConsultarOT"
        Me.bConsultarOT.Size = New System.Drawing.Size(94, 28)
        Me.bConsultarOT.TabIndex = 1
        Me.bConsultarOT.Text = "Cargar OT"
        Me.bConsultarOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConsultarOT.UseVisualStyleBackColor = False
        '
        'xOT
        '
        Me.xOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.xOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOT.Location = New System.Drawing.Point(6, 27)
        Me.xOT.Name = "xOT"
        Me.xOT.Size = New System.Drawing.Size(76, 21)
        Me.xOT.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OT"
        '
        'xEstado
        '
        Me.xEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xEstado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.xEstado.Location = New System.Drawing.Point(6, 15)
        Me.xEstado.Name = "xEstado"
        Me.xEstado.ReadOnly = True
        Me.xEstado.Size = New System.Drawing.Size(183, 21)
        Me.xEstado.TabIndex = 3
        Me.xEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(84, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado"
        '
        'gTecnico
        '
        Me.gTecnico.BackColor = System.Drawing.Color.Transparent
        Me.gTecnico.Controls.Add(Me.xTecnico)
        Me.gTecnico.Controls.Add(Me.Label8)
        Me.gTecnico.Controls.Add(Me.cTecnicos)
        Me.gTecnico.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.gTecnico.Location = New System.Drawing.Point(213, 67)
        Me.gTecnico.Name = "gTecnico"
        Me.gTecnico.Size = New System.Drawing.Size(405, 48)
        Me.gTecnico.TabIndex = 1
        Me.gTecnico.TabStop = False
        '
        'xTecnico
        '
        Me.xTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xTecnico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTecnico.Location = New System.Drawing.Point(6, 16)
        Me.xTecnico.Name = "xTecnico"
        Me.xTecnico.ReadOnly = True
        Me.xTecnico.Size = New System.Drawing.Size(58, 21)
        Me.xTecnico.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(11, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Técnico"
        '
        'cTecnicos
        '
        Me.cTecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTecnicos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTecnicos.FormattingEnabled = True
        Me.cTecnicos.Location = New System.Drawing.Point(70, 15)
        Me.cTecnicos.Name = "cTecnicos"
        Me.cTecnicos.Size = New System.Drawing.Size(329, 23)
        Me.cTecnicos.TabIndex = 1
        '
        'gServicios
        '
        Me.gServicios.BackColor = System.Drawing.Color.Transparent
        Me.gServicios.Controls.Add(Me.bBuscarServicio)
        Me.gServicios.Controls.Add(Me.xServicio)
        Me.gServicios.Controls.Add(Me.xTabla)
        Me.gServicios.Controls.Add(Me.bAgregarS)
        Me.gServicios.Controls.Add(Me.xNombreServicio)
        Me.gServicios.Controls.Add(Me.Label4)
        Me.gServicios.Location = New System.Drawing.Point(12, 126)
        Me.gServicios.Name = "gServicios"
        Me.gServicios.Size = New System.Drawing.Size(1046, 160)
        Me.gServicios.TabIndex = 3
        Me.gServicios.TabStop = False
        '
        'bBuscarServicio
        '
        Me.bBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarServicio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarServicio.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarServicio.Location = New System.Drawing.Point(759, 17)
        Me.bBuscarServicio.Name = "bBuscarServicio"
        Me.bBuscarServicio.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarServicio.TabIndex = 234
        Me.bBuscarServicio.Text = "Buscar"
        Me.bBuscarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarServicio.UseVisualStyleBackColor = True
        '
        'xServicio
        '
        Me.xServicio.AnchoLista = 700
        Me.xServicio.AutoCompletarActivo = True
        Me.xServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xServicio.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xServicio.DescBusqueda = "Descripcion"
        Me.xServicio.DescBusquedaAdicional = ""
        Me.xServicio.DescBusquedaAdicional2 = ""
        Me.xServicio.Filtro = "TipoArticulo = 'S'"
        Me.xServicio.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xServicio.IDBusqueda = "Articulo"
        Me.xServicio.IntervaloBusquedaNumeros = 1
        Me.xServicio.IntervaloBusquedaTexto = 3
        Me.xServicio.Location = New System.Drawing.Point(6, 19)
        Me.xServicio.Name = "xServicio"
        Me.xServicio.Size = New System.Drawing.Size(150, 21)
        Me.xServicio.TabIndex = 0
        Me.xServicio.TablaBusqueda = "Articulos"
        Me.xServicio.TextFont = New System.Drawing.Font("Arial", 9.0!)
        '
        'xTabla
        '
        Me.xTabla.AllowEditing = False
        Me.xTabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTabla.ColumnInfo = resources.GetString("xTabla.ColumnInfo")
        Me.xTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTabla.Location = New System.Drawing.Point(9, 50)
        Me.xTabla.Name = "xTabla"
        Me.xTabla.Rows.Count = 1
        Me.xTabla.Rows.DefaultSize = 19
        Me.xTabla.Size = New System.Drawing.Size(1031, 104)
        Me.xTabla.StyleInfo = resources.GetString("xTabla.StyleInfo")
        Me.xTabla.TabIndex = 233
        Me.xTabla.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bAgregarS
        '
        Me.bAgregarS.BackColor = System.Drawing.Color.White
        Me.bAgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarS.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregarS.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bAgregarS.Location = New System.Drawing.Point(844, 17)
        Me.bAgregarS.Name = "bAgregarS"
        Me.bAgregarS.Size = New System.Drawing.Size(79, 27)
        Me.bAgregarS.TabIndex = 2
        Me.bAgregarS.Text = "Cargar"
        Me.bAgregarS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregarS.UseVisualStyleBackColor = False
        '
        'xNombreServicio
        '
        Me.xNombreServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNombreServicio.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xNombreServicio.Location = New System.Drawing.Point(162, 19)
        Me.xNombreServicio.Name = "xNombreServicio"
        Me.xNombreServicio.ReadOnly = True
        Me.xNombreServicio.Size = New System.Drawing.Size(591, 21)
        Me.xNombreServicio.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Servicio"
        '
        'gArticulos
        '
        Me.gArticulos.BackColor = System.Drawing.Color.Transparent
        Me.gArticulos.Controls.Add(Me.bBuscarArticulo)
        Me.gArticulos.Controls.Add(Me.xArticulo)
        Me.gArticulos.Controls.Add(Me.xTablaArticulos)
        Me.gArticulos.Controls.Add(Me.bAgregarA)
        Me.gArticulos.Controls.Add(Me.xDescripcion)
        Me.gArticulos.Controls.Add(Me.Label5)
        Me.gArticulos.Location = New System.Drawing.Point(12, 305)
        Me.gArticulos.Name = "gArticulos"
        Me.gArticulos.Size = New System.Drawing.Size(1046, 151)
        Me.gArticulos.TabIndex = 4
        Me.gArticulos.TabStop = False
        '
        'bBuscarArticulo
        '
        Me.bBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscarArticulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscarArticulo.Image = Global.Rebusco.My.Resources.Resources.find
        Me.bBuscarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarArticulo.Location = New System.Drawing.Point(759, 9)
        Me.bBuscarArticulo.Name = "bBuscarArticulo"
        Me.bBuscarArticulo.Size = New System.Drawing.Size(79, 27)
        Me.bBuscarArticulo.TabIndex = 235
        Me.bBuscarArticulo.Text = "Buscar"
        Me.bBuscarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBuscarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBuscarArticulo.UseVisualStyleBackColor = True
        '
        'xArticulo
        '
        Me.xArticulo.AnchoLista = 700
        Me.xArticulo.AutoCompletarActivo = True
        Me.xArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xArticulo.CampoMostrar = Rebusco.TextBoxAutoComple.Campo.ID
        Me.xArticulo.DescBusqueda = "Descripcion"
        Me.xArticulo.DescBusquedaAdicional = ""
        Me.xArticulo.DescBusquedaAdicional2 = ""
        Me.xArticulo.Filtro = "TipoArticulo = 'P'"
        Me.xArticulo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xArticulo.IDBusqueda = "Articulo"
        Me.xArticulo.IntervaloBusquedaNumeros = 1
        Me.xArticulo.IntervaloBusquedaTexto = 3
        Me.xArticulo.Location = New System.Drawing.Point(6, 11)
        Me.xArticulo.Name = "xArticulo"
        Me.xArticulo.Size = New System.Drawing.Size(150, 21)
        Me.xArticulo.TabIndex = 0
        Me.xArticulo.TablaBusqueda = "Articulos"
        Me.xArticulo.TextFont = New System.Drawing.Font("Arial", 9.0!)
        '
        'xTablaArticulos
        '
        Me.xTablaArticulos.AllowEditing = False
        Me.xTablaArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xTablaArticulos.ColumnInfo = resources.GetString("xTablaArticulos.ColumnInfo")
        Me.xTablaArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xTablaArticulos.Location = New System.Drawing.Point(9, 41)
        Me.xTablaArticulos.Name = "xTablaArticulos"
        Me.xTablaArticulos.Rows.Count = 1
        Me.xTablaArticulos.Rows.DefaultSize = 19
        Me.xTablaArticulos.Size = New System.Drawing.Size(1031, 104)
        Me.xTablaArticulos.StyleInfo = resources.GetString("xTablaArticulos.StyleInfo")
        Me.xTablaArticulos.TabIndex = 233
        Me.xTablaArticulos.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'bAgregarA
        '
        Me.bAgregarA.BackColor = System.Drawing.Color.White
        Me.bAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarA.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bAgregarA.Image = Global.Rebusco.My.Resources.Resources.load
        Me.bAgregarA.Location = New System.Drawing.Point(844, 9)
        Me.bAgregarA.Name = "bAgregarA"
        Me.bAgregarA.Size = New System.Drawing.Size(79, 27)
        Me.bAgregarA.TabIndex = 2
        Me.bAgregarA.Text = "Cargar"
        Me.bAgregarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregarA.UseVisualStyleBackColor = False
        '
        'xDescripcion
        '
        Me.xDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDescripcion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xDescripcion.Location = New System.Drawing.Point(162, 11)
        Me.xDescripcion.Name = "xDescripcion"
        Me.xDescripcion.ReadOnly = True
        Me.xDescripcion.Size = New System.Drawing.Size(591, 21)
        Me.xDescripcion.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(7, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Artículo"
        '
        'bConfirmar
        '
        Me.bConfirmar.BackColor = System.Drawing.Color.White
        Me.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bConfirmar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bConfirmar.Image = Global.Rebusco.My.Resources.Resources.ok24
        Me.bConfirmar.Location = New System.Drawing.Point(581, 615)
        Me.bConfirmar.Name = "bConfirmar"
        Me.bConfirmar.Size = New System.Drawing.Size(158, 36)
        Me.bConfirmar.TabIndex = 9
        Me.bConfirmar.Text = " Confirmar Revisión"
        Me.bConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bConfirmar.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.BackColor = System.Drawing.Color.White
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Image = Global.Rebusco.My.Resources.Resources.save24
        Me.bGuardar.Location = New System.Drawing.Point(745, 615)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(101, 36)
        Me.bGuardar.TabIndex = 10
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.BackColor = System.Drawing.Color.White
        Me.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimir.Image = Global.Rebusco.My.Resources.Resources.print24
        Me.bImprimir.Location = New System.Drawing.Point(852, 615)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(100, 36)
        Me.bImprimir.TabIndex = 11
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bImprimir.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bCancelar.Location = New System.Drawing.Point(958, 615)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(100, 36)
        Me.bCancelar.TabIndex = 12
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.BackColor = System.Drawing.Color.White
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Image = Global.Rebusco.My.Resources.Resources.clean24
        Me.bLimpiar.Location = New System.Drawing.Point(12, 615)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.bLimpiar.TabIndex = 8
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
        Me.Label14.Location = New System.Drawing.Point(12, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 16)
        Me.Label14.TabIndex = 261
        Me.Label14.Text = "OT"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(213, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 16)
        Me.Label3.TabIndex = 262
        Me.Label3.Text = "Técnico"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(624, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 16)
        Me.Label6.TabIndex = 263
        Me.Label6.Text = "Estado OT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.xEstado)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(624, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 48)
        Me.GroupBox2.TabIndex = 264
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1046, 16)
        Me.Label7.TabIndex = 265
        Me.Label7.Text = "Servicio"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1046, 16)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "Artículo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(606, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 253
        Me.Label10.Text = "Plantilla"
        '
        'cPlantilla
        '
        Me.cPlantilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPlantilla.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cPlantilla.FormattingEnabled = True
        Me.cPlantilla.Location = New System.Drawing.Point(667, 464)
        Me.cPlantilla.Name = "cPlantilla"
        Me.cPlantilla.Size = New System.Drawing.Size(300, 23)
        Me.cPlantilla.TabIndex = 5
        '
        'bIniciar
        '
        Me.bIniciar.BackColor = System.Drawing.Color.White
        Me.bIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIniciar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIniciar.Image = Global.Rebusco.My.Resources.Resources.ok32
        Me.bIniciar.Location = New System.Drawing.Point(825, 58)
        Me.bIniciar.Name = "bIniciar"
        Me.bIniciar.Size = New System.Drawing.Size(114, 58)
        Me.bIniciar.TabIndex = 2
        Me.bIniciar.Text = "Iniciar Servicio"
        Me.bIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bIniciar.UseVisualStyleBackColor = False
        '
        'bAgregarPlantilla
        '
        Me.bAgregarPlantilla.BackColor = System.Drawing.Color.White
        Me.bAgregarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarPlantilla.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAgregarPlantilla.Image = CType(resources.GetObject("bAgregarPlantilla.Image"), System.Drawing.Image)
        Me.bAgregarPlantilla.Location = New System.Drawing.Point(972, 463)
        Me.bAgregarPlantilla.Name = "bAgregarPlantilla"
        Me.bAgregarPlantilla.Size = New System.Drawing.Size(79, 27)
        Me.bAgregarPlantilla.TabIndex = 6
        Me.bAgregarPlantilla.Text = "Cargar"
        Me.bAgregarPlantilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAgregarPlantilla.UseVisualStyleBackColor = False
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
        Me.WinDeco1.Size = New System.Drawing.Size(1070, 50)
        Me.WinDeco1.TabIndex = 268
        Me.WinDeco1.TituloVentana = "Servicio Técnico"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'tObservacion
        '
        Me.tObservacion.Controls.Add(Me.ObsCli)
        Me.tObservacion.Controls.Add(Me.ObsTec)
        Me.tObservacion.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tObservacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tObservacion.HotTrack = True
        Me.tObservacion.ItemSize = New System.Drawing.Size(0, 26)
        Me.tObservacion.Location = New System.Drawing.Point(12, 462)
        Me.tObservacion.Name = "tObservacion"
        Vs2010TabControlRenderer1.ColorTable = Vs2010DefaultTabControlColorTable1
        Me.tObservacion.Renderer = Vs2010TabControlRenderer1
        Me.tObservacion.SelectedIndex = 0
        Me.tObservacion.Size = New System.Drawing.Size(1046, 133)
        Me.tObservacion.TabIndex = 7
        '
        'ObsCli
        '
        Me.ObsCli.Controls.Add(Me.xObsCliente)
        Me.ObsCli.Location = New System.Drawing.Point(4, 30)
        Me.ObsCli.Name = "ObsCli"
        Me.ObsCli.Padding = New System.Windows.Forms.Padding(3)
        Me.ObsCli.Size = New System.Drawing.Size(1038, 99)
        Me.ObsCli.TabIndex = 0
        Me.ObsCli.Text = "Observación del Cliente"
        Me.ObsCli.UseVisualStyleBackColor = True
        '
        'xObsCliente
        '
        Me.xObsCliente.BackColor = System.Drawing.Color.White
        Me.xObsCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xObsCliente.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xObsCliente.Location = New System.Drawing.Point(3, 3)
        Me.xObsCliente.Multiline = True
        Me.xObsCliente.Name = "xObsCliente"
        Me.xObsCliente.Size = New System.Drawing.Size(1032, 93)
        Me.xObsCliente.TabIndex = 0
        '
        'ObsTec
        '
        Me.ObsTec.Controls.Add(Me.xObsTecnico)
        Me.ObsTec.Location = New System.Drawing.Point(4, 30)
        Me.ObsTec.Name = "ObsTec"
        Me.ObsTec.Padding = New System.Windows.Forms.Padding(3)
        Me.ObsTec.Size = New System.Drawing.Size(1038, 99)
        Me.ObsTec.TabIndex = 1
        Me.ObsTec.Text = "Observación del Técnico"
        Me.ObsTec.UseVisualStyleBackColor = True
        '
        'xObsTecnico
        '
        Me.xObsTecnico.BackColor = System.Drawing.Color.White
        Me.xObsTecnico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xObsTecnico.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.xObsTecnico.Location = New System.Drawing.Point(3, 3)
        Me.xObsTecnico.Multiline = True
        Me.xObsTecnico.Name = "xObsTecnico"
        Me.xObsTecnico.Size = New System.Drawing.Size(1032, 93)
        Me.xObsTecnico.TabIndex = 254
        '
        'ServicioTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 663)
        Me.Controls.Add(Me.WinDeco1)
        Me.Controls.Add(Me.bAgregarPlantilla)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cPlantilla)
        Me.Controls.Add(Me.bIniciar)
        Me.Controls.Add(Me.tObservacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bConfirmar)
        Me.Controls.Add(Me.gTecnico)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.gServicios)
        Me.Controls.Add(Me.gArticulos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1240, 768)
        Me.Name = "ServicioTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio Técnico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gTecnico.ResumeLayout(False)
        Me.gTecnico.PerformLayout()
        Me.gServicios.ResumeLayout(False)
        Me.gServicios.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gArticulos.ResumeLayout(False)
        Me.gArticulos.PerformLayout()
        CType(Me.xTablaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tObservacion.ResumeLayout(False)
        Me.ObsCli.ResumeLayout(False)
        Me.ObsCli.PerformLayout()
        Me.ObsTec.ResumeLayout(False)
        Me.ObsTec.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents bLimpiar As Button
    Public WithEvents bImprimir As Button
    Public WithEvents bCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents xOT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents xEstado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gServicios As GroupBox
    Friend WithEvents xNombreServicio As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents bAgregarS As Button
    Friend WithEvents xTabla As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gArticulos As GroupBox
    Friend WithEvents xTablaArticulos As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents bAgregarA As Button
    Friend WithEvents xDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents bGuardar As Button
    Friend WithEvents gTecnico As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cTecnicos As ComboBox
    Friend WithEvents xTecnico As TextBox
    
    Public WithEvents bConfirmar As Button
    Public WithEvents bConsultarOT As Button
    Friend WithEvents xServicio As TextBoxAutoComple
    Friend WithEvents xArticulo As TextBoxAutoComple
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tObservacion As Controls.Vs2010TabControl
    Friend WithEvents ObsCli As TabPage
    Friend WithEvents ObsTec As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents cPlantilla As ComboBox
    Friend WithEvents xObsCliente As TextBox
    Public WithEvents bIniciar As Button
    Friend WithEvents xObsTecnico As TextBox
    Public WithEvents bAgregarPlantilla As Button
    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents bBuscarServicio As Button
    Friend WithEvents bBuscarArticulo As Button
End Class
