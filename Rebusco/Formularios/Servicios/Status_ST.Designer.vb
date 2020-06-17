<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status_ST
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
        Me.WinDeco1 = New WinDeco.WinDeco()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xOTIngresadas = New System.Windows.Forms.TextBox()
        Me.xOTProceso = New System.Windows.Forms.TextBox()
        Me.xOTCerrada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bActualizar = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.xOTTecnicoAsignado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.WinDeco1.Size = New System.Drawing.Size(720, 50)
        Me.WinDeco1.TabIndex = 267
        Me.WinDeco1.TituloVentana = "Status Servicio Técnico"
        Me.WinDeco1.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco1.VerCerrar = True
        Me.WinDeco1.VerLogo = True
        Me.WinDeco1.VerMaximizar = False
        Me.WinDeco1.VerMinimizar = True
        Me.WinDeco1.VerTitulo = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(336, 18)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "OT Ingresadas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 18)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "OT en Proceso"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xOTIngresadas
        '
        Me.xOTIngresadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xOTIngresadas.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOTIngresadas.ForeColor = System.Drawing.Color.Maroon
        Me.xOTIngresadas.Location = New System.Drawing.Point(17, 116)
        Me.xOTIngresadas.MaxLength = 18
        Me.xOTIngresadas.Name = "xOTIngresadas"
        Me.xOTIngresadas.ReadOnly = True
        Me.xOTIngresadas.Size = New System.Drawing.Size(130, 39)
        Me.xOTIngresadas.TabIndex = 335
        Me.xOTIngresadas.TabStop = False
        Me.xOTIngresadas.Text = "0"
        Me.xOTIngresadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'xOTProceso
        '
        Me.xOTProceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xOTProceso.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOTProceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xOTProceso.Location = New System.Drawing.Point(16, 192)
        Me.xOTProceso.MaxLength = 18
        Me.xOTProceso.Name = "xOTProceso"
        Me.xOTProceso.ReadOnly = True
        Me.xOTProceso.Size = New System.Drawing.Size(130, 39)
        Me.xOTProceso.TabIndex = 336
        Me.xOTProceso.TabStop = False
        Me.xOTProceso.Text = "0"
        Me.xOTProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'xOTCerrada
        '
        Me.xOTCerrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xOTCerrada.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOTCerrada.ForeColor = System.Drawing.Color.Maroon
        Me.xOTCerrada.Location = New System.Drawing.Point(369, 192)
        Me.xOTCerrada.MaxLength = 18
        Me.xOTCerrada.Name = "xOTCerrada"
        Me.xOTCerrada.ReadOnly = True
        Me.xOTCerrada.Size = New System.Drawing.Size(130, 39)
        Me.xOTCerrada.TabIndex = 338
        Me.xOTCerrada.TabStop = False
        Me.xOTCerrada.Text = "0"
        Me.xOTCerrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(369, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 18)
        Me.Label2.TabIndex = 337
        Me.Label2.Text = "OT Cerradas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "no cobradas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bSalir.Image = Global.Rebusco.My.Resources.Resources.cancel24
        Me.bSalir.Location = New System.Drawing.Point(608, 263)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 36)
        Me.bSalir.TabIndex = 339
        Me.bSalir.Text = "Cancelar"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bActualizar
        '
        Me.bActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bActualizar.BackColor = System.Drawing.Color.White
        Me.bActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bActualizar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.bActualizar.Image = Global.Rebusco.My.Resources.Resources.refresh_update24
        Me.bActualizar.Location = New System.Drawing.Point(12, 263)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(100, 36)
        Me.bActualizar.TabIndex = 340
        Me.bActualizar.Text = "Actualizar"
        Me.bActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bActualizar.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 60000
        '
        'cLocal
        '
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(17, 58)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(335, 30)
        Me.cLocal.TabIndex = 341
        '
        'xOTTecnicoAsignado
        '
        Me.xOTTecnicoAsignado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xOTTecnicoAsignado.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xOTTecnicoAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xOTTecnicoAsignado.Location = New System.Drawing.Point(369, 116)
        Me.xOTTecnicoAsignado.MaxLength = 18
        Me.xOTTecnicoAsignado.Name = "xOTTecnicoAsignado"
        Me.xOTTecnicoAsignado.ReadOnly = True
        Me.xOTTecnicoAsignado.Size = New System.Drawing.Size(130, 39)
        Me.xOTTecnicoAsignado.TabIndex = 343
        Me.xOTTecnicoAsignado.TabStop = False
        Me.xOTTecnicoAsignado.Text = "0"
        Me.xOTTecnicoAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(369, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 18)
        Me.Label3.TabIndex = 342
        Me.Label3.Text = "OT Asignada a Técnico"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(146, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 39)
        Me.Label4.TabIndex = 344
        Me.Label4.Text = "OTs ingresadas sin técnico asignado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(498, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 39)
        Me.Label5.TabIndex = 345
        Me.Label5.Text = "OTs con técnico asignado pero sin servicio iniciado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(145, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 39)
        Me.Label6.TabIndex = 346
        Me.Label6.Text = "OTs con servicio iniciado por el técnico y no cerradas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(498, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 39)
        Me.Label7.TabIndex = 347
        Me.Label7.Text = "OTs Pendiente de cobro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Status_ST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 311)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.xOTTecnicoAsignado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cLocal)
        Me.Controls.Add(Me.bActualizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.xOTCerrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.xOTProceso)
        Me.Controls.Add(Me.xOTIngresadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WinDeco1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1536, 824)
        Me.Name = "Status_ST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Servicio Técnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinDeco1 As WinDeco.WinDeco
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents xOTIngresadas As TextBox
    Friend WithEvents xOTProceso As TextBox
    Friend WithEvents xOTCerrada As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents bSalir As Button
    Public WithEvents bActualizar As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents xOTTecnicoAsignado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
