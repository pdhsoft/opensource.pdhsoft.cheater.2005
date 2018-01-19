
Public Class frmConvert
    Dim fso As New Scripting.FileSystemObject
    Dim strm As Scripting.TextStream
    Dim StrVersion As String
    Dim SpeicherOrt As Object
    Dim Dateiname As Object

    Private Sub frmConvert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ofdOpen.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Programs & "PDHSoft\Patte's Cheater 2004\System" 'My.Computer.FileSystem.SpecialDirectories.MyDocuments"
        ofdOpen.ShowDialog()
        rtfCheat.ShortcutsEnabled = True
        rtfCheat.RichTextShortcutsEnabled = True
        tbDatum.Text = My.Computer.Clock.LocalTime.Date
    End Sub

    Private Sub ofdOpen_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdOpen.FileOk
        rtfCheat.LoadFile(ofdOpen.FileName)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        tbSpieleTitel.Text = rtfCheat.Lines.GetValue(0)
        tbAuthor.Text = rtfCheat.Lines.GetValue(1)
        tbCheat.Text = rtfCheat.Text.ToString
        MsgBox("Nach dem Konvertieren muß der Spiele Titel Editiert werden," & vbCr & "Es muß das System hinter dem Titel entfernt werden." & vbCr & vbNewLine & "Eventuelle müssen Author und Cheat Text bearbeitet werden." & vbCr & "Es müssen dann noch System Typ, System,  Kategorie und Datum hinzugefügt werden.", MsgBoxStyle.Information, My.Application.Info.Title)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If kalender.Visible = True Then
            kalender.Visible = False
        Else
            kalender.Visible = True
        End If
    End Sub
    Private Sub kalender_DateSelected_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles kalender.DateSelected
        tbDatum.Text = kalender.SelectionEnd.Date
        kalender.Visible = False
    End Sub

    Private Sub btSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSpeichern.Click
        If tbSpieleTitel.Text = "" Then
            MsgBox("Sie müssen einen Spiele Titel eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
            Exit Sub
        Else
            If tbAuthor.Text = "" Then
                MsgBox("Sie müssen einen Author eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                Exit Sub
            Else
                If tbDatum.Text = "" Then
                    MsgBox("Sie müssen ein Datum eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                    Exit Sub
                Else
                    If tbCheat.Text = "" Then
                        MsgBox("Sie müssen einen Cheat Text eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                        Exit Sub
                    Else
                        If ComboBox1.SelectedItem = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Or _
                        ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Or _
ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Or _
ComboBox1.SelectedItem = "Nintendo(GameCube)" Or _
ComboBox1.SelectedItem = "Nintendo(Revolution)" Or _
ComboBox1.SelectedItem = "Nokia(NGadge)" Or _
ComboBox1.SelectedItem = "PC - Personal Computer" Or _
ComboBox1.SelectedItem = "Sega ???" Or _
ComboBox1.SelectedItem = "Sega(DreamCast)" Or _
ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Then
                            If ComboBox2.SelectedItem = "" Then
                                MsgBox("Sie müssen eine Kategorie eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                                Exit Sub
                            Else
                                If tbSystem.Text = "GameBoy" Then
                                    SpeicherOrt = "\System.db\GameBoy\GameBoy\"
                                End If
                                If tbSystem.Text = "GameBoy Color" Then
                                    SpeicherOrt = "\System.db\GameBoy\Color\"
                                End If
                                If tbSystem.Text = "GameBoy Advance (auch SP)" Then
                                    SpeicherOrt = "\System.db\GameBoy\Advance\"
                                End If
                                If tbSystem.Text = "Nintendo DS" Then
                                    SpeicherOrt = "\System.db\GameBoy\DS\"
                                End If
                                If tbSystem.Text = "Playstation & PS One" Then
                                    SpeicherOrt = "\System.db\Sony\PS\"
                                End If
                                If tbSystem.Text = "PS 2 & PS Two" Then
                                    SpeicherOrt = "\System.db\Sony\PS2\"
                                End If
                                If tbSystem.Text = "PS 3 - Playstation 3" Then
                                    SpeicherOrt = "\System.db\Sony\PS3\"
                                End If
                                If tbSystem.Text = "PSP - Playstation Portable" Then
                                    SpeicherOrt = "\System.db\Sony\PSP\"
                                End If
                                If tbSystem.Text = "XBOX" Then
                                    SpeicherOrt = "\System.db\Microsoft\XBox\"
                                End If
                                If tbSystem.Text = "XBOX360" Then
                                    SpeicherOrt = "\System.db\Microsoft\Xbox360\"
                                End If
                                If tbSystemTyp.Text = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
                                    SpeicherOrt = "\System.db\OldComputer\"
                                End If
                                If tbSystemTyp.Text = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
                                    SpeicherOrt = "\System.db\OldConsole\"
                                End If
                                If tbSystemTyp.Text = "Nintendo Entertainment System (NES)" Then
                                    SpeicherOrt = "\System.db\NES\"
                                End If
                                If tbSystemTyp.Text = "Nintendo(GameCube)" Then
                                    SpeicherOrt = "\System.db\GameCube\"
                                End If
                                If tbSystemTyp.Text = "Nintendo(Revolution)" Then
                                    SpeicherOrt = "\System.db\Revolution\"
                                End If
                                If tbSystemTyp.Text = "Nokia(NGadge)" Then
                                    SpeicherOrt = "\System.db\NGadge\"
                                End If
                                If tbSystemTyp.Text = "PC - Personal Computer" Then
                                    SpeicherOrt = "\System.db\PC\"
                                End If
                                If tbSystemTyp.Text = "Sega ???" Then
                                    SpeicherOrt = "\System.db\Sega\"
                                End If
                                If tbSystemTyp.Text = "Sega(DreamCast)" Then
                                    SpeicherOrt = "\System.db\DreamCast\"
                                End If
                                If tbSystemTyp.Text = "Super Nintendo  Entertainment System (SNES)" Then
                                    SpeicherOrt = "\System.db\SNES\"
                                End If
                                Dateiname = tbSpieleTitel.Text & " " & tbKat.Text & " " & tbAuthor.Text & " " & tbDatum.Text & ".cht"
                                With fso
                                    StrVersion = .BuildPath(My.Application.Info.DirectoryPath & SpeicherOrt & tbKat.Text, Dateiname)
                                    If .FileExists(StrVersion) Then
                                        MsgBox("Die Datei Existiert bereits, bitte Verwenden Sie einen anderen Spiele Titel / Author.", MsgBoxStyle.Critical, My.Application.Info.Title)
                                        Exit Sub
                                    Else
                                        strm = .CreateTextFile(StrVersion, True)
                                    End If
                                End With
                                With strm
                                    .WriteLine(tbSpieleTitel.Text)
                                    .WriteLine(tbSystemTyp.Text)
                                    .WriteLine(tbSystem.Text)
                                    .WriteLine(tbKat.Text)
                                    .WriteLine(tbAuthor.Text)
                                    .WriteLine(tbDatum.Text)
                                    .WriteLine()
                                    .Write(tbCheat.Text)
                                    .Close()
                                End With

                                tbSpieleTitel.Text = ""
                                tbAuthor.Text = ""
                                tbCheat.Text = ""
                                tbDatum.Text = ""
                                rtfCheat.Text = ""
                                MsgBox("Cheat wurde erfolgreich gespeichert.", MsgBoxStyle.Information, My.Application.Info.Title)
                                Me.Close()
                            End If
                        Else
                            If ComboBox1.SelectedItem = "" Then
                                MsgBox("Sie müssen einen System Typ auswählen!", MsgBoxStyle.Critical, My.Application.Info.Title)
                                Exit Sub
                            Else
                                If ComboBox3.SelectedItem = "" Then
                                    MsgBox("Sie müssen ein System auswählen!", MsgBoxStyle.Critical, My.Application.Info.Title)
                                    Exit Sub
                                Else
                                    If ComboBox2.SelectedItem = "" Then
                                        MsgBox("Sie müssen eine Kategorie eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                                        Exit Sub
                                    Else
                                        If tbSystem.Text = "GameBoy" Then
                                            SpeicherOrt = "\System.db\GameBoy\GameBoy\"
                                        End If
                                        If tbSystem.Text = "GameBoy Color" Then
                                            SpeicherOrt = "\System.db\GameBoy\Color\"
                                        End If
                                        If tbSystem.Text = "GameBoy Advance (auch SP)" Then
                                            SpeicherOrt = "\System.db\GameBoy\Advance\"
                                        End If
                                        If tbSystem.Text = "Nintendo DS" Then
                                            SpeicherOrt = "\System.db\GameBoy\DS\"
                                        End If
                                        If tbSystem.Text = "Playstation & PS One" Then
                                            SpeicherOrt = "\System.db\Sony\PS\"
                                        End If
                                        If tbSystem.Text = "PS 2 & PS Two" Then
                                            SpeicherOrt = "\System.db\Sony\PS2\"
                                        End If
                                        If tbSystem.Text = "PS 3 - Playstation 3" Then
                                            SpeicherOrt = "\System.db\Sony\PS3\"
                                        End If
                                        If tbSystem.Text = "PSP - Playstation Portable" Then
                                            SpeicherOrt = "\System.db\Sony\PSP\"
                                        End If
                                        If tbSystem.Text = "XBOX" Then
                                            SpeicherOrt = "\System.db\Microsoft\XBox\"
                                        End If
                                        If tbSystem.Text = "XBOX360" Then
                                            SpeicherOrt = "\System.db\Microsoft\Xbox360\"
                                        End If
                                        If tbSystemTyp.Text = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
                                            SpeicherOrt = "\System.db\OldComputer\"
                                        End If
                                        If tbSystemTyp.Text = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
                                            SpeicherOrt = "\System.db\OldConsole\"
                                        End If
                                        If tbSystemTyp.Text = "Nintendo Entertainment System (NES)" Then
                                            SpeicherOrt = "\System.db\NES\"
                                        End If
                                        If tbSystemTyp.Text = "Nintendo(GameCube)" Then
                                            SpeicherOrt = "\System.db\GameCube\"
                                        End If
                                        If tbSystemTyp.Text = "Nintendo(Revolution)" Then
                                            SpeicherOrt = "\System.db\Revolution\"
                                        End If
                                        If tbSystemTyp.Text = "Nokia(NGadge)" Then
                                            SpeicherOrt = "\System.db\NGadge\"
                                        End If
                                        If tbSystemTyp.Text = "PC - Personal Computer" Then
                                            SpeicherOrt = "\System.db\PC\"
                                        End If
                                        If tbSystemTyp.Text = "Sega ???" Then
                                            SpeicherOrt = "\System.db\Sega\"
                                        End If
                                        If tbSystemTyp.Text = "Sega(DreamCast)" Then
                                            SpeicherOrt = "\System.db\DreamCast\"
                                        End If
                                        If tbSystemTyp.Text = "Super Nintendo  Entertainment System (SNES)" Then
                                            SpeicherOrt = "\System.db\SNES\"
                                        End If
                                        Dateiname = tbSpieleTitel.Text & " " & tbKat.Text & " " & tbAuthor.Text & " " & tbDatum.Text & ".cht"
                                        With fso
                                            StrVersion = .BuildPath(My.Application.Info.DirectoryPath & SpeicherOrt & tbKat.Text, Dateiname)
                                            If .FileExists(StrVersion) Then
                                                MsgBox("Die Datei Existiert bereits, bitte Verwenden Sie einen anderen Spiele Titel / Author.", MsgBoxStyle.Critical, My.Application.Info.Title)
                                                Exit Sub
                                            Else
                                                strm = .CreateTextFile(StrVersion, True)
                                            End If
                                        End With
                                        With strm
                                            .WriteLine(tbSpieleTitel.Text)
                                            .WriteLine(tbSystemTyp.Text)
                                            .WriteLine(tbSystem.Text)
                                            .WriteLine(tbKat.Text)
                                            .WriteLine(tbAuthor.Text)
                                            .WriteLine(tbDatum.Text)
                                            .WriteLine()
                                            .Write(tbCheat.Text)
                                            .Close()
                                        End With

                                        tbSpieleTitel.Text = ""
                                        tbAuthor.Text = ""
                                        tbCheat.Text = ""
                                        tbDatum.Text = ""
                                        rtfCheat.Text = ""
                                        MsgBox("Cheat wurde erfolgreich gespeichert.", MsgBoxStyle.Information, My.Application.Info.Title)
                                        Me.Close()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        tbSystemTyp.Text = ComboBox1.SelectedItem
        If ComboBox1.SelectedItem = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken, Tools, Trainer"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("GameBoy")
            ComboBox3.Items.Add("GameBoy Color")
            ComboBox3.Items.Add("GameBoy Advance (auch SP)")
            ComboBox3.Items.Add("Nintendo DS")
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Nintendo(GameCube)" Then
            'tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Nintendo(Revolution)" Then
            'tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Nokia(NGadge)" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "PC - Personal Computer" Then
            'tbInfo.Text = "Cheats, Patches, Tools, Updates, Trainer, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Playstation, PS One, PS 2, PS Two, PS 3, PSP" Then
            'tbInfo.Text = "Cheats, Codes, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Playstation & PS One")
            ComboBox3.Items.Add("PS 2 & PS Two")
            ComboBox3.Items.Add("PS 3 - Playstation 3")
            ComboBox3.Items.Add("PSP - Playstation Portable")
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")

        End If
        If ComboBox1.SelectedItem = "Sega ???" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Sega(DreamCast)" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Then
            'tbInfo.Text = "Cheats, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""

        End If
        If ComboBox1.SelectedItem = "Xbox, Xbox 2" Then
            'lbInfo.Text = "Cheats, Codes, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("XBOX")
            ComboBox3.Items.Add("XBOX 360")
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        tbSystem.Text = ComboBox3.SelectedItem
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        tbKat.Text = ComboBox2.SelectedItem
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        tbAuthor.Text = ""
        tbSpieleTitel.Text = ""
        tbCheat.Text = ""
        rtfCheat.Text = ""
        tbDatum.Text = ""
    End Sub

    Private Sub btInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInfo.Click
        MsgBox("Da beim schnellen Konvertieren der Text ebenfalls Editiert werden muß," & vbCr & "ist es auch möglich, den Text per 'Rechtsklick', 'Alles Makieren', 'Kopieren'," & vbCr & "'Rechtsklick' und 'Einfügen' möglich." & vbCr & vbNewLine & "Klicken Sie dafür mit der rechten Maustaste, in das untere Feld." & vbCr & "Klicken Sie nun auf 'Alles Makieren', anschließend klicken Sie," & vbCr & "wieder mit der rechten Maustaste in das untere Feld" & vbCr & "Diesesmal wählen Sie aber 'Kopieren'. Klicken Sie mit der rechten Maustaste" & vbCr & "in das obere Feld. Wählen Sie nun 'Einfügen'. Fertig..." & vbCr & "Alternativ können Sie für Kopieren die Tastenkombination STRG+C" & vbCr & "und für Einfügen die Tastenkombination STRG+V verwenden.", MsgBoxStyle.Information, My.Application.Info.Title)
    End Sub

    Private Sub rtfCheat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtfCheat.Click
        rtfCheat.SelectAll()
    End Sub

    Private Sub tbSpieleTitel_KeyPress(ByVal eventsender As System.Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles tbSpieleTitel.KeyPress
        Dim KeyAscii As Short = Asc(EventArgs.KeyChar)
        If KeyAscii = 92 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 47 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 58 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 42 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 63 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 34 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 60 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 62 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 124 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
    End Sub

    Private Sub tbAuthor_KeyPress(ByVal eventSender As System.Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles tbAuthor.KeyPress
        Dim KeyAscii As Short = Asc(EventArgs.KeyChar)
        If KeyAscii = 92 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 47 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 58 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 42 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 63 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 34 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 60 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 62 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
        If KeyAscii = 124 Then
            MsgBox("Dieses Feld darf folgende Zeichen nicht enthalten: " & vbCr & "\/:*?""<>|", MsgBoxStyle.Critical, My.Application.Info.Title)
        End If
    End Sub
End Class
