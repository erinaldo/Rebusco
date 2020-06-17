Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports MarketONE

Public Class GenerarEtiquetas
    Implements iFormulario

    Private Sub Generar_Etiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cLocal.LoadItemsObj("Locales", "Local", "NombreLocal", " ORDER BY NombreLocal")
        cLocal.Text = BuscarCampo("Locales", "NombreLocal", "Local", G_LOCALACTUAL.ToString)

        If cLocal.Items.Count = 2 Then
            cLocal.SelectedIndex = 1
        End If

        xArriba.Text = "0"
        xDerecha.Text = "0"
        xColumnas.Text = "1"
        xSepara.Text = "0"

        If G_IDCLIENTE = Clientes.Multibike Then
            xArriba.Text = "20"
            xDerecha.Text = "20"
            xColumnas.Text = "2"
            xSepara.Text = "350"
        End If
        If G_IDCLIENTE = Clientes.Bikemonkey Then
            xArriba.Text = "1"
            xDerecha.Text = "240"
            xColumnas.Text = "1"
            xSepara.Text = "0"
            oPrecio.Checked = True
        End If

        xOscuridad.Text = "25"

        If UsuarioActual = "PED" Then VerZPL.Visible = True
    End Sub

    Private Sub Impresora_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Impresora.PrintPage
        Dim Font_Imprimir As System.Drawing.Font = New Font("consolas", 12)
        Dim Salto As Single, Altura As Single, Columna As Single, qZPL As String, Matriz() As String


        Salto = 1      'Numero de linea en la impresion
        Altura = 12    'Altura de cada linea en la impresion
        Columna = 1

        Dim Impresion = e.Graphics

        qZPL = Generar_ZPL()

        Matriz = qZPL.Split(Chr(13))
        For Each xLinea As String In Matriz
            xLinea = xLinea.Trim()
            If InStr(xLinea, "^GFA") > 0 Then
                Columna += 50
            End If
            Impresion.DrawString(xLinea, Font_Imprimir, Brushes.Black, Columna, Salto)

            Salto += Altura
        Next

        'Al salir de esta funcion se imprime
    End Sub

    Function Generar_ZPL() As String
        Dim wZPL As String
        Dim Columna As Decimal

        wZPL = ""
        xZPL.Text = ""

        wZPL &= "^XA" & vbCrLf

        wZPL &= "^FOI" & vbCrLf
        wZPL &= "^PRD" & vbCrLf
        wZPL &= "^LH" & xDerecha.Text.Trim & "," & xArriba.Text.Trim & vbCrLf
        wZPL &= "^PQ" & xCantidad.Text.Trim & vbCrLf
        wZPL &= "~SD" & xOscuridad.Text.Trim & vbCrLf

        Columna = 0
        For i = 1 To Val(xColumnas.Text)
            wZPL &= "^A0N,30,30" & vbCrLf
            wZPL &= "^FO" & (0 + Columna) & ",115" & vbCrLf
            If G_IDCLIENTE = Clientes.Wikets Or G_IDCLIENTE = Clientes.Multibike Then
                wZPL &= "^A0N,25,20" & vbCrLf
                wZPL &= "^FO" & (0 + Columna) & ",115" & vbCrLf
            Else
                wZPL &= "^A0N,30,30" & vbCrLf
                wZPL &= "^FO" & (0 + Columna) & ",115" & vbCrLf
            End If
            wZPL &= "^FDCODIGO: " & xArticulo.Text.Trim & "^FS" & vbCrLf
            wZPL &= "^BY1.8:1" & vbCrLf
            wZPL &= "^B3N,N,55,N,N" & vbCrLf
            wZPL &= "^FO" & (0 + Columna) & ",145" & vbCrLf
            wZPL &= "^FD" & xArticulo.Text.Trim & "^FS" & vbCrLf
            wZPL &= "^A0N,20,20" & vbCrLf
            wZPL &= "^FO" & (0 + Columna) & ",210" & vbCrLf
            wZPL &= "^FD" & xDescripcion.Text.Trim & "^FS" & vbCrLf

            If oPrecio.Checked Then
                If G_IDCLIENTE = Clientes.Wikets Or G_IDCLIENTE = Clientes.Multibike Then
                    wZPL &= "^A0N,25,20" & vbCrLf
                    'wZPL &= "^FO" & (200 + Columna) & ",115,1" & vbCrLf  'Ajustado a la derecha
                    wZPL &= "^FO" & (200 + Columna) & ",115" & vbCrLf
                    wZPL &= "^FD" & "$ " & xPrecio.Text & "^FS" & vbCrLf
                Else
                    wZPL &= "^A0N,30,30" & vbCrLf
                    'wZPL &= "^FO" & (200 + Columna) & ",115,1" & vbCrLf  'Ajustado a la derecha
                    wZPL &= "^FO" & (200 + Columna) & ",60" & vbCrLf
                    wZPL &= "^FD" & "$ " & xPrecio.Text & "^FS" & vbCrLf
                End If
            End If

            If i < 3 Then
                'Logo (Reemplazar esta sección por el logo de la empresa)
                If (G_IDCLIENTE = Clientes.Wikets Or G_IDCLIENTE = "") Then
                    'Imprimir Logo por Defecto de Wikets
                    wZPL &= "^FO" & (0 + Columna) & ",20" & vbCrLf
                    wZPL &= "^GFA,1760,1760,22,hH08,hG0F8,gY01FF,gX01FFE,gW03IFC,gV07JF8," & vbCrLf
                    wZPL &= "gU07KF,gT0LFE,gS0MFC,gQ01NF8,M01FE7F9KFEQ03OF,M010380E020602" & vbCrLf
                    wZPL &= "P03OFE,M0101806020202K03FE07PFC,M0101806020202K02027JF0LF8,M" & vbCrLf
                    wZPL &= "0101806060602001F0203JFC03KF,M010180407FE03FC7FC603F87F8F1KF" & vbCrLf
                    wZPL &= ",M010100406020204C03C01C01F139JFE,M010100406020205001C00800F" & vbCrLf
                    wZPL &= "20CJFC,M01810040602020EI0C018006644JF8,M01810040602020EI0C01" & vbCrLf
                    wZPL &= "I0660CJF,M01810040602I0C040603030260CIFE,N0810040602I0C04060" & vbCrLf
                    wZPL &= "3030264CIFC,N0810040602001C040603030326CIF8,N0810040602001C0" & vbCrLf
                    wZPL &= "4060301FF1F9IF,N0810040E02001CI0603007F863FFE,N08I040E02001C" & vbCrLf
                    wZPL &= "I0603801FE07FFE,N08K0E02001CI0603800FFDIFC,N0C00800C02001C07" & vbCrLf
                    wZPL &= "FE03E007KF8,N0C00800C02I0C07FE03F003KF,N0C00800C02I0C060603F" & vbCrLf
                    wZPL &= "C03JFE,M07C00800C02I0C0606030203JFC,L07FC00C00C02I0C06060303" & vbCrLf
                    wZPL &= "03JF8,K0IFC00C00C0202040606030303JF,I01JFC00C01C020204040603" & vbCrLf
                    wZPL &= "0303IFE,001KFC00C01C020206I0EK03IFC,03LFC01C01C020206I0E0080" & vbCrLf
                    wZPL &= "07IF8,7MFC01C01C020203001F00C00JF8,3MFC01C01E060303C03F80E01" & vbCrLf
                    wZPL &= "JF,07gQFE,01gQFC,003gPF8,I0KFE07gHF,I03JF801KFC07SFE,J0JFI0K" & vbCrLf
                    wZPL &= "F807SFC,J01FFEI07JF00407QF8,K07FEI07JF00C07QF307E,K01FE0207F" & vbCrLf
                    wZPL &= "03F03C0E1EDE9F81FC1D9C78,L07C0603C00EL0C0C0E007808A00C,M0C06" & vbCrLf
                    wZPL &= "038006L0C0C0C003800C006,M040603I06L0C0C080018008002,M02037FI" & vbCrLf
                    wZPL &= "02L0C0C080018008001,M0201FF030301C0E0C0C081018008181,M02007E" & vbCrLf
                    wZPL &= "030301C0E0C0C181818008181,M03003E030301C060C0C181818008181,M" & vbCrLf
                    wZPL &= "01I0E030301C060C0418101807I018,N0C006030301C06040019E0180FI0" & vbCrLf
                    wZPL &= "18,N06006030301C06J01F801809I018,N07002030301C06J01C001809I0" & vbCrLf
                    wZPL &= "18,M03FC02030301C06J01800180901FF,M020602030301C06J018181809" & vbCrLf
                    wZPL &= "0181,M020202030301C06J0181818090181,M020602030301C07J0101818" & vbCrLf
                    wZPL &= "090181,M020602030301C0700403010180901818,M020603030301C0F004" & vbCrLf
                    wZPL &= "0301818098181,M02I03020301C070040301018088181,M02I03I0301C01" & vbCrLf
                    wZPL &= "00C0380018088001,M01I07800501C0100C038001808C002,M01800CC00D" & vbCrLf
                    wZPL &= "01E0180C0380018086006,N06038703983F8381E07E1C3818381C,N03FE0" & vbCrLf
                    wZPL &= "1FE0FF1QF7F00FF,Y07LFC,Y01LF8,g07KF,gG0JFE,gG03IFC,gH0IF8,gH" & vbCrLf
                    wZPL &= "03FF,gI0FE,gI01C,,^FS" & vbCrLf
                End If
                'Logo MultiBike
                If G_IDCLIENTE = Clientes.Multibike Then
                    wZPL &= "^FO" & (0 + Columna) & ",20" & vbCrLf
                    wZPL &= "^GFA,2430,2430,30,,::::::gP0E,gO01F,gO03F8,gO07FC,gO0FFE,gN0" & vbCrLf
                    wZPL &= "1IF,gN03IF,gN03F1F8,gN07E0FC,gN0FC07E,gK0401FC03F004,gK0C03F" & vbCrLf
                    wZPL &= "801F806,gJ01C07F001FC07,gJ03E0FEI0FE0F8,gJ07E1FCI07F0FC,gJ0F" & vbCrLf
                    wZPL &= "E3F8I03F8FE,gI01FE7FJ01FCFF,gI03IFEK0JF8,gI07IFCK07IFC,gI0JF" & vbCrLf
                    wZPL &= "8K03IFE,gH01FDFFL01FF7F,gH03F8FEM0FE3F8,gH07F0FCM07E1FC,gH0F" & vbCrLf
                    wZPL &= "E0F8M03E0FE,gG01FC07N01C07F,gG03F806O0C03F8,g01FFT01FF,V01KF" & vbCrLf
                    wZPL &= "EU0LF,R01OFCU07OF,N01SF8U03SF,J03WFV01WF8,,:::::::I01EJ03E03" & vbCrLf
                    wZPL &= "8I0380FI07JFE0E07JF001FE07F00FF87JFC,I01FJ07E038I0780EI0KFE0" & vbCrLf
                    wZPL &= "E07JFC01FC07F01FF07JFC,I03FJ0FC038I0780EI0KFE1E07JFE01FC0FF0" & vbCrLf
                    wZPL &= "3FE07JFC,I03F8I0FC038I0700EK038001C07KF01FC0FF07FC07JFC,I03F" & vbCrLf
                    wZPL &= "8001FC078I0700EK078001C07KF03FC0FF0FF80KF8,I03BC003DC07J0701" & vbCrLf
                    wZPL &= "EK078001C0LF03FC0FE1FF00KF8,I039C007BC07J0701CK07I01C0FF00FF" & vbCrLf
                    wZPL &= "03FC0FE3FE00FF,I039E00F3807J0F01CK07I03C0FE007F03F80FE7FC00F" & vbCrLf
                    wZPL &= "E,I078E01E3807J0E01CK07I03C0FE007F03F81FEFF800FE,I078F03C380" & vbCrLf
                    wZPL &= "7J0E01CK07I0380FE00FF03F81JFI0FE,I0707038380FJ0E01CK0FI0380F" & vbCrLf
                    wZPL &= "E01FE07F81IFE001FE,I0707878380EJ0E03CK0EI0381KFC07F81IFC001J" & vbCrLf
                    wZPL &= "FE,I07038F0780EJ0E038K0EI0381KF807F01IF8001JFE,I0703DE0700EI" & vbCrLf
                    wZPL &= "01E038K0EI0781KF807F01IFI01JFE,I0F01FC0700EI01C038K0EI0701KF" & vbCrLf
                    wZPL &= "C07F03IFI01JFE,I0E01F80700EI01C038K0EI0701KFC0FF03IF8003JFE," & vbCrLf
                    wZPL &= "I0E00F00701EI01C078J01EI0703FC03FE0FF03IF8003JFE,I0E00E00701" & vbCrLf
                    wZPL &= "CI01C078J01CI0703FC01FE0FF03IFC003FC,I0E00400F01CI03C07K01CI" & vbCrLf
                    wZPL &= "0703FC00FE0FE03FBFE003F8,001EK0E01CI03807K01CI0F03F800FE0FE0" & vbCrLf
                    wZPL &= "7F9FF003F8,001EK0E01CI07807K01CI0E03F801FE0FE07F9FF003F8,001" & vbCrLf
                    wZPL &= "CK0E01EI07007K01CI0E03F803FE1FE07F8FF807JFE,001CK0E01EI0F00F" & vbCrLf
                    wZPL &= "K03CI0E07KFC1FE07F0FFC07JFE,001CJ01E00F001E00FK038I0E07KFC1F" & vbCrLf
                    wZPL &= "E07F07FE07JFE,001CJ01C00F807C00EK038001E07KF81FC07F03FE07JFE" & vbCrLf
                    wZPL &= ",003CJ01C007IF800JFE038001E07KF01FC0FF03FF07JFE,003CJ01C003I" & vbCrLf
                    wZPL &= "FI0JFC038001C07JFC01FC0FF01FF87JFE,0038J01CI0FFC001JFC078001" & vbCrLf
                    wZPL &= "C0JFC003FC0FF00FF8KFC,,::::::^FS" & vbCrLf
                End If
                'Logo BikeMonkey
                If G_IDCLIENTE = Clientes.Bikemonkey Then
                    wZPL &= "^FO" & (0 + Columna) & ",20" & vbCrLf
                    wZPL &= "^GFA,1617,1617,21,00CgP0F8,00C4gN03FC,00A4gN0F82,00A6gM01E02" & vbCrLf
                    wZPL &= ",00961BFFCgH03806,004D7JFEgG0F006,004DLFCY01E00E,0044MFY03C0" & vbCrLf
                    wZPL &= "1C,00E2DJF3FCX07803C,00E25JF07ET06I070078,00D15JF03FS0FF800E" & vbCrLf
                    wZPL &= "00F,01E89JF81F8Q07C0C01E01E,03F0LF3FCP01F00E03C03C,03PFCP078" & vbCrLf
                    wZPL &= "00C038078,07PFEO01E181C0701F,07MF7FFEO0783C1C0F03E,0MFE07FEN" & vbCrLf
                    wZPL &= "01E038380E078,0FFE0IFE03FEN03C070781E1F,0FF80IFE03FFN0780E07" & vbCrLf
                    wZPL &= "03C7C,1FF81JFE3FFM01E01E0E3B9F8,1FF8OFM03C03C1C3BBE,1RFM0780" & vbCrLf
                    wZPL &= "383867F8J03C,1LF003IFM0E007078CFCJ01FF,1IFEL0FFL01C00F0F0FEK" & vbCrLf
                    wZPL &= "03C1,1FF807JFCFFL01801E3C10E60380F01,1FC1IF03FF7FL03003C7839" & vbCrLf
                    wZPL &= "DF0FC1E03,1FDFFK03FFL0600F9FC71EE1CC3803,1FFC2K01FFL0401FFEC" & vbCrLf
                    wZPL &= "63CE3987006,1FF3D8K0FFL0C03FF9CE39C360F00E,1FE034I01FFEK0180" & vbCrLf
                    wZPL &= "FF638C3F8781E01C,1FE0DAI060FEK0183FE071C7E0E01C038,1FF104I08" & vbCrLf
                    wZPL &= "0FFCJ010FDE0E1CF61C0B807,7FF002041B8FF6J01FF1C1C19673C3700F," & vbCrLf
                    wZPL &= "CFF01E44300F83J01F81E381EE3C86F03C,87F03E09I0F9DM01C7018C18F" & vbCrLf
                    wZPL &= "8E078,B3F23E619E0731N09EI040061C0F,39FF18005F0779N03CM03C3E," & vbCrLf
                    wZPL &= "1DF04D805E0701L010FN038F8,85F7FL0783L021EN073E,81F0198100A7E" & vbCrLf
                    wZPL &= "6L06F8N0778,63E00FC00307FCL07E02M0FE,3FE002CJ07FM0200FL0DF,3" & vbCrLf
                    wZPL &= "FEJ03A001F8M0C3FL0FC,7FC3I03C385F8L03E7E0078671DC1E31,FFC460" & vbCrLf
                    wZPL &= "0800C3FCL0E4CC38E86F1BC3B738,1F801I0643FFCK01CD9C7CEFF73DC72" & vbCrLf
                    wZPL &= "67,3F83EJ013FFCK039B38F9F8EE3B86CE7,3F8618J09FFCK07F673F199C" & vbCrLf
                    wZPL &= "E370F0CE,0F8386J05FFCK07CCE77399DC7E1C1CE,0F8641CI05FBCK0FB8" & vbCrLf
                    wZPL &= "IE3139CEC383DE8,1E86587I05FBCJ01E71CDCI3996E705BD,1E42679C00" & vbCrLf
                    wZPL &= "1FBCJ03CE399C2631EC7919DE,1E42665F001E3CJ0F8C3B383C308C31E1D" & vbCrLf
                    wZPL &= "C,1E437E67C01F3CI03F1876301M080380E,3E217FE2601F3CI0FE307C7Q" & vbCrLf
                    wZPL &= "03JF,3F217FFE30393C003DE60F87Q0FI038,3F30JF7838FC00F3CC0F0EP" & vbCrLf
                    wZPL &= "07FJ0C,3F107F7FF8787801E3981E0EO01C6J0C,3F18B8C1F850F8078798" & vbCrLf
                    wZPL &= "1E1CO070EJ0C,3F0A7101F8B1F00F07303C1CO0C0CJ08,1F05E007F921E0" & vbCrLf
                    wZPL &= "3C0E60383CN0381CI01,1F87C00FF203E0780EC01838N06018,1F83800FF" & vbCrLf
                    wZPL &= "407C0F01C8I038N0C038,1F83001FF80F81E01D8I038M01807,0F83001AE" & vbCrLf
                    wZPL &= "01F83C03BJ038M03006,0F820015C03F03803EJ01N0600E,0F860031007E" & vbCrLf
                    wZPL &= "07007CS0E01C,07841063007E070078S0C038,I0C2066007C020078R0180" & vbCrLf
                    wZPL &= "7,001840CCK03003S0180E,00308198K038U0101C,006003FgI01038,00C" & vbCrLf
                    wZPL &= "00FCgI010E,00403CgJ01F8,003FE,I0C,,^FS" & vbCrLf
                End If
            End If
            Columna += xSepara.Text.ToDecimal
        Next i

        wZPL &= "^XZ" & vbCrLf
        wZPL &= " " & vbCrLf
        xZPL.Text = wZPL

        Return (wZPL)
    End Function

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If Val(xCantidad.Text) = 0 Then
            MsgError("Cantidad Incorrecta")
            xCantidad.Focus()
            Exit Sub
        End If
        If Val(xColumnas.Text) = 0 Or Val(xColumnas.Text) > 3 Then
            MsgError("Columna Incorrecta")
            xColumnas.Focus()
            Exit Sub
        End If

        If Trim(xArticulo.Text) = "" Or Trim(xDescripcion.Text) = "" Then
            MsgError("Falta Artículo")
            xArticulo.Focus()
            Exit Sub
        End If

        Impresora.Print()

        Mensaje("Listo")
    End Sub

    Private Sub xArticulo_TextChanged(sender As Object, e As EventArgs) Handles xArticulo.TextChanged

    End Sub

    Private Sub xArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xArticulo.KeyPress
        e.NextControl(xCantidad)
    End Sub

    Private Sub xArticulo_Validating(sender As Object, e As CancelEventArgs) Handles xArticulo.Validating
        If xArticulo.Text.Trim <> "" Then
            xArticulo.Text = ObtenerArticulo(xArticulo.Text)
            Dim wArt = SQL("SELECT DESCRIPCION,PVENTA FROM Articulos WHERE Articulo = '" & xArticulo.Text.ToDecimal & "'").Top
            If wArt IsNot Nothing Then
                xDescripcion.Text = wArt.GetText("Descripcion")
                xPrecio.Text = Format(wArt.GetNum("PVenta"), "###,###,###")
                xCantidad.Focus()
            Else
                MsgError("Artículo no encontrado")
                xArticulo.Clear()
                xDescripcion.Clear()
                xPrecio.Clear()
                xArticulo.Focus()
            End If
        End If
    End Sub

    Private Sub VerZPL_Click(sender As Object, e As EventArgs) Handles VerZPL.Click
        If xZPL.Visible Then
            xZPL.Visible = False
            gDatos.Visible = True
        Else
            xZPL.Visible = True
            gDatos.Visible = False
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim wBuscador = New BuscadorArticulo
        wBuscador.Configurar(Me, xArticulo)
        wBuscador.ShowDialog()
    End Sub

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    'Public Sub CargarRegistro(wControl As Control, wValor As String) Implements iFormulario.CargarRegistro
    '    Throw New NotImplementedException()
    'End Sub

    Private Sub oPrecio_CheckedChanged(sender As Object, e As EventArgs) Handles oPrecio.CheckedChanged
        xPrecio.Visible = oPrecio.Checked
    End Sub
End Class