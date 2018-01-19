Public Class frmNewFIle
    Dim SpeicherOrt As Object
    Dim Dateiname As Object
    Dim Dateityp As String
    Dim fso As New Scripting.FileSystemObject
    Dim strm As Scripting.TextStream
    Dim StrVersion As String
    
    Private Sub sfdSave_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sfdSave.FileOk
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & tbKat.Text & "\" & Dateiname) Then
            MsgBox("Datei Existiert bereits. Sie müssen einen anderen SpieleTitel / Author wählen.", MsgBoxStyle.Critical, My.Application.Info.Title)
            Exit Sub
        Else
            My.Computer.FileSystem.CopyFile(sfdSave.FileName, My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & tbKat.Text & "\" & Dateiname)
            Me.Close()
            With fso
                StrVersion = .BuildPath(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & tbKat.Text, Dateiname & Dateityp)
                strm = .CreateTextFile(StrVersion, True)

            End With
            With strm
                .WriteLine(tbSpieleTitel.Text)
                .WriteLine(tbSystemTyp.Text)
                .WriteLine(tbSystem.Text)
                .WriteLine(tbKat.Text)
                .WriteLine(tbAuthor.Text)
                .WriteLine(tbDatum.Text)
                .WriteLine(ComboBox1.SelectedItem)
                .WriteLine("\System.db" & SpeicherOrt & tbKat.Text & "\" & Dateiname)
                .Close()
            End With
            tbAuthor.Text = ""
            tbSpieleTitel.Text = ""
            ComboBox1.SelectedText = "Datei erweiterung auswählen..."
            MsgBox("Datei wurde erfolgreich der Datenbank hinzugefügt.", MsgBoxStyle.Information, My.Application.Info.Title)
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Sie müssen eine Dateierweiterung auswählen.", MsgBoxStyle.Critical, My.Application.Info.Title)
            Exit Sub
        Else
            If tbSpieleTitel.Text = "" Then
                MsgBox("Sie müssen einen SpieleTitel eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                Exit Sub
            Else
                If tbAuthor.Text = "" Then
                    MsgBox("Sie müssen einen Author eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                    Exit Sub
                Else
                    If tbZusatz.Text = "" Then
                        MsgBox("Sie müssen eine Zusätzliche Bezeichnung eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                        Exit Sub
                    Else
                        If tbSystem.Text = "GameBoy" Then
                            SpeicherOrt = "\GameBoy\GameBoy\"
                        End If
                        If tbSystem.Text = "GameBoy Color" Then
                            SpeicherOrt = "\GameBoy\Color\"
                        End If
                        If tbSystem.Text = "GameBoy Advance (auch SP)" Then
                            SpeicherOrt = "\GameBoy\Advance\"
                        End If
                        If tbSystem.Text = "Nintendo DS" Then
                            SpeicherOrt = "\GameBoy\DS\"
                        End If
                        If tbSystem.Text = "Playstation & PS One" Then
                            SpeicherOrt = "\Sony\PS\"
                        End If
                        If tbSystem.Text = "PS 2 & PS Two" Then
                            SpeicherOrt = "\Sony\PS2\"
                        End If
                        If tbSystem.Text = "PS 3 - Playstation 3" Then
                            SpeicherOrt = "\Sony\PS3\"
                        End If
                        If tbSystem.Text = "PSP - Playstation Portable" Then
                            SpeicherOrt = "\Sony\PSP\"
                        End If
                        If tbSystem.Text = "XBOX" Then
                            SpeicherOrt = "\Microsoft\XBox\"
                        End If
                        If tbSystem.Text = "XBOX360" Then
                            SpeicherOrt = "\Microsoft\Xbox360\"
                        End If
                        If tbSystemTyp.Text = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
                            SpeicherOrt = "\OldComputer\"
                        End If
                        If tbSystemTyp.Text = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
                            SpeicherOrt = "\OldConsole\"
                        End If
                        If tbSystemTyp.Text = "Nintendo Entertainment System (NES)" Then
                            SpeicherOrt = "\NES\"
                        End If
                        If tbSystemTyp.Text = "Nintendo(GameCube)" Then
                            SpeicherOrt = "\GameCube\"
                        End If
                        If tbSystemTyp.Text = "Nintendo(Revolution)" Then
                            SpeicherOrt = "\Revolution\"
                        End If
                        If tbSystemTyp.Text = "Nokia(NGadge)" Then
                            SpeicherOrt = "\NGadge\"
                        End If
                        If tbSystemTyp.Text = "PC - Personal Computer" Then
                            SpeicherOrt = "\PC\"
                        End If
                        If tbSystemTyp.Text = "Sega ???" Then
                            SpeicherOrt = "\Sega\"
                        End If
                        If tbSystemTyp.Text = "Sega(DreamCast)" Then
                            SpeicherOrt = "\DreamCast\"
                        End If
                        If tbSystemTyp.Text = "Super Nintendo  Entertainment System (SNES)" Then
                            SpeicherOrt = "\SNES\"
                        End If
                        Dateiname = tbSpieleTitel.Text & " " & tbZusatz.Text & " " & tbKat.Text & " " & tbAuthor.Text & " " & tbDatum.Text & ComboBox1.SelectedItem
                        If tbKat.Text = "Savegames" Then
                            sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                            sfdSave.Title = "PDHSoft Cheater 2005 | Savegames hinzufügen"
                            sfdSave.DefaultExt = ComboBox1.SelectedItem
                            sfdSave.ShowDialog()
                        Else
                            If tbKat.Text = "Tools" Then
                                sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                                sfdSave.Title = "PDHSoft Cheater 2005 | Tools hinzufügen"
                                sfdSave.DefaultExt = ComboBox1.SelectedItem
                                sfdSave.ShowDialog()
                            Else
                                If tbKat.Text = "Trainer" Then
                                    sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                                    sfdSave.Title = "PDHSoft Cheater 2005 | Trainer hinzufügen"
                                    sfdSave.DefaultExt = ComboBox1.SelectedItem
                                    sfdSave.ShowDialog()
                                Else
                                    If tbKat.Text = "Grafiken" Then
                                        sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                                        sfdSave.Title = "PDHSoft Cheater 2005 | Grafiken hinzufügen"
                                        sfdSave.DefaultExt = ComboBox1.SelectedItem
                                        sfdSave.ShowDialog()
                                    Else
                                        If tbKat.Text = "Patches" Then
                                            sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                                            sfdSave.Title = "PDHSoft Cheater 2005 | Patches hinzufügen"
                                            sfdSave.DefaultExt = ComboBox1.SelectedItem
                                            sfdSave.ShowDialog()
                                        Else
                                            If tbKat.Text = "Savegames" Then
                                                sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                                                sfdSave.Title = "PDHSoft Cheater 2005 | Savegames hinzufügen"
                                                sfdSave.DefaultExt = ComboBox1.SelectedItem
                                                sfdSave.ShowDialog()
                                            Else
                                                If tbKat.Text = "Updates" Then
                                                    sfdSave.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                                                    sfdSave.Title = "PDHSoft Cheater 2005 | Updates hinzufügen"
                                                    sfdSave.DefaultExt = ComboBox1.SelectedItem
                                                    sfdSave.ShowDialog()
                                                Else

                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub frmNewFIle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbDatum.Text = My.Computer.Clock.LocalTime.Date
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        tbAuthor.Text = ""
        tbSpieleTitel.Text = ""
        tbZusatz.Text = ""
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

    Private Sub tbAuthor_KeyPress(ByVal eventsender As System.Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles tbAuthor.KeyPress
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

    Private Sub tbZusatz_KeyPress(ByVal eventsender As System.Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles tbZusatz.KeyPress
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = ".bmp" Or ComboBox1.SelectedItem = ".jpg" Or ComboBox1.SelectedItem = ".gif" Or ComboBox1.SelectedItem = ".wmf" Then
            Dateityp = ".grk"
        Else
            Dateityp = ".prg"
        End If
        If ComboBox1.SelectedItem = ".bmp" Then
            sfdSave.Filter = "Bitmap (*.bmp)|*.bmp"
        Else
            If ComboBox1.SelectedItem = ".jpg" Then
                sfdSave.Filter = "Jpeg (*.jpg)|*.jpg"
            Else
                If ComboBox1.SelectedItem = ".gif" Then
                    sfdSave.Filter = "GIF (*.gif)|*.gif"
                Else
                    If ComboBox1.SelectedItem = ".wmf" Then
                        sfdSave.Filter = "WMF (*.wmf)|*.wmf"
                    Else
                        If ComboBox1.SelectedItem = ".exe" Then
                            sfdSave.Filter = "Ausführbare Datei (*.exe)|*.exe"
                        Else
                            If ComboBox1.SelectedItem = ".msi" Then
                                sfdSave.Filter = "Windows Installer Datei (*.msi)|*.msi"
                            Else
                                If ComboBox1.SelectedItem = ".zip" Then
                                    sfdSave.Filter = "Gepackte Datei (*.zip)|*.zip"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
