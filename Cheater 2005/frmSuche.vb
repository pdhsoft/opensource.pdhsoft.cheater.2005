Public Class frmSuche
    Dim SpeicherOrt As String
    Dim Dateiname As Object
    Dim fso As New Scripting.FileSystemObject
    Dim strm As Scripting.TextStream
    Dim StrVersion As String



    Private Sub btSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSuchen.Click
        Dim list As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        If tbSuchen.Text = "" Then
            MsgBox("Sie müssen einen SpieleTitel eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
            Exit Sub
        Else
            If ComboBox3.Enabled = True Then
                If ComboBox3.SelectedItem = "" Then
                    MsgBox("Sie müssen ein System auswählen!", MsgBoxStyle.Critical, My.Application.Info.Title)
                    Exit Sub
                Else
                    GoTo Suchen
                End If
            Else
                GoTo Suchen
            End If
        End If
        Exit Sub
Suchen:
        frmStart.cbSuche.Items.Clear()
        'gbWait.Visible = True
        'Timer1.Enabled = True
        If ComboBox3.SelectedItem = "GameBoy" Then
            SpeicherOrt = "\GameBoy\GameBoy\"
        End If
        If ComboBox3.SelectedItem = "GameBoy Color" Then
            SpeicherOrt = "\GameBoy\Color\"
        End If
        If ComboBox3.SelectedItem = "GameBoy Advance (auch SP)" Then
            SpeicherOrt = "\GameBoy\Advance\"
        End If
        If ComboBox3.SelectedItem = "Nintendo DS" Then
            SpeicherOrt = "\GameBoy\DS\"
        End If
        If ComboBox3.SelectedItem = "Playstation & PS One" Then
            SpeicherOrt = "\Sony\PS\"
        End If
        If ComboBox3.SelectedItem = "PS 2 & PS Two" Then
            SpeicherOrt = "\Sony\PS2\"
        End If
        If ComboBox3.SelectedItem = "PS 3 - Playstation 3" Then
            SpeicherOrt = "\Sony\PS3\"
        End If
        If ComboBox3.SelectedItem = "PSP - Playstation Portable" Then
            SpeicherOrt = "\Sony\PSP\"
        End If
        If ComboBox3.SelectedItem = "XBOX" Then
            SpeicherOrt = "\Microsoft\XBox\"
        End If
        If ComboBox3.SelectedItem = "XBOX360" Then
            SpeicherOrt = "\Microsoft\Xbox360\"
        End If
        If ComboBox1.SelectedItem = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
            SpeicherOrt = "\OldComputer\"
        End If
        If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
            SpeicherOrt = "\OldConsole\"
        End If
        If ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Then
            SpeicherOrt = "\NES\"
        End If
        If ComboBox1.SelectedItem = "Nintendo(GameCube)" Then
            SpeicherOrt = "\GameCube\"
        End If
        If ComboBox1.SelectedItem = "Nintendo(Revolution)" Then
            SpeicherOrt = "\Revolution\"
        End If
        If ComboBox1.SelectedItem = "Nokia(NGadge)" Then
            SpeicherOrt = "\NGadge\"
        End If
        If ComboBox1.SelectedItem = "PC - Personal Computer" Then
            SpeicherOrt = "\PC\"
        End If
        If ComboBox1.SelectedItem = "Sega ???" Then
            SpeicherOrt = "\Sega\"
        End If
        If ComboBox1.SelectedItem = "Sega(DreamCast)" Then
            SpeicherOrt = "\DreamCast\"
        End If
        If ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Then
            SpeicherOrt = "\SNES\"
        End If
        frmStart.cbSuche.Items.Clear()
        frmDateiExplorer.cbSuche.Items.Clear()
        If ComboBox2.SelectedItem = "Grafiken" Then
            list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.grk")
            For Each name As String In list
                frmStart.pProg.SendToBack()
                frmStart.pbPicture.BringToFront()
                frmStart.rtfCheats.SendToBack()
                frmStart.cbSuche.Items.Add(name)
            Next
            Me.Close()
            MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
        Else
            If ComboBox2.SelectedItem = "Tools" Then
                list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.prg")
                For Each name As String In list
                    frmStart.pProg.BringToFront()
                    frmStart.pbPicture.SendToBack()
                    frmStart.rtfCheats.SendToBack()
                    frmStart.cbSuche.Items.Add(name)
                Next
                Me.Close()
                MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
            Else
                If ComboBox2.SelectedItem = "Trainer" Then
                    list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.prg")
                    For Each name As String In list
                        frmStart.pProg.BringToFront()
                        frmStart.pbPicture.SendToBack()
                        frmStart.rtfCheats.SendToBack()
                        frmStart.cbSuche.Items.Add(name)
                    Next
                    Me.Close()
                    MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
                Else
                    If ComboBox2.SelectedItem = "Patches" Then
                        list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.prg")
                        For Each name As String In list
                            frmStart.pProg.BringToFront()
                            frmStart.pbPicture.SendToBack()
                            frmStart.rtfCheats.SendToBack()
                            frmStart.cbSuche.Items.Add(name)
                        Next
                        Me.Close()
                        MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
                    Else
                        If ComboBox2.SelectedItem = "Savegames" Then
                            list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.prg")
                            For Each name As String In list
                                frmStart.pProg.BringToFront()
                                frmStart.pbPicture.SendToBack()
                                frmStart.rtfCheats.SendToBack()
                                frmStart.cbSuche.Items.Add(name)
                            Next
                            Me.Close()
                            MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
                        Else
                            If ComboBox2.SelectedItem = "Updates" Then
                                list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.prg")
                                For Each name As String In list
                                    frmStart.pProg.BringToFront()
                                    frmStart.pbPicture.SendToBack()
                                    frmStart.rtfCheats.SendToBack()
                                    frmStart.cbSuche.Items.Add(name)
                                Next
                                Me.Close()
                                MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
                            Else
                                list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db" & SpeicherOrt & ComboBox2.SelectedItem, tbSuchen.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.cht")
                                For Each name As String In list
                                    frmStart.cbSuche.Items.Add(name)
                                    frmStart.pProg.SendToBack()
                                    frmStart.pbPicture.SendToBack()
                                    frmStart.rtfCheats.BringToFront()
                                Next
                                If frmStart.cbSuche.Items.ToString = "" Then
                                    frmStart.cbSuche.Items.Add("Keine Ergebnisse zu ihrer Suche gefunden...")
                                End If
                                Me.Close()
                                MsgBox("Suche nach ''" & tbSuchen.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
                            End If
                        End If
                    End If
                End If
            End If
        End If
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken, Tools, Trainer, Savegames"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox2.Items.Add("Tools")
            ComboBox2.Items.Add("Trainer")
        End If
        If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("GameBoy")
            ComboBox3.Items.Add("GameBoy Color")
            ComboBox3.Items.Add("GameBoy Advance (auch SP)")
            ComboBox3.Items.Add("Nintendo DS")
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Nintendo(GameCube)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken, Savegames"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox2.Items.Add("Savegames")
        End If
        If ComboBox1.SelectedItem = "Nintendo(Revolution)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken, Savegames"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox2.Items.Add("Savegames")
        End If
        If ComboBox1.SelectedItem = "Nokia(NGadge)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "PC - Personal Computer" Then
            tbInfo.Text = "Cheats, (HEX)Codes, Patches, Tools, Updates, Trainer, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Patches")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Tipps")
            ComboBox2.Items.Add("Tools")
            ComboBox2.Items.Add("Trainer")
            ComboBox2.Items.Add("Updates")
            ComboBox2.Items.Add("Codes")
        End If
        If ComboBox1.SelectedItem = "Playstation, PS One, PS 2, PS Two, PS 3, PSP" Then
            tbInfo.Text = "Cheats, Codes, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Playstation & PS One")
            ComboBox3.Items.Add("PS 2 & PS Two")
            ComboBox3.Items.Add("PS 3 - Playstation 3")
            ComboBox3.Items.Add("PSP - Playstation Portable")
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Tipps")
            
        End If
        If ComboBox1.SelectedItem = "Sega ???" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Sega(DreamCast)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
        End If
        If ComboBox1.SelectedItem = "Xbox, Xbox 2" Then
            tbInfo.Text = "Cheats, Codes, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("XBOX")
            ComboBox3.Items.Add("XBOX 360")
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Tipps")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "" Then
            btSuchen.Enabled = False
        Else
            btSuchen.Enabled = True
        End If
    End Sub

    Private Sub frmSuche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btSuchen.Enabled = False
    End Sub

    Private Sub tbSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSuchen.Click
        tbSuchen.SelectAll()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        gbWait.Visible = False
        pgWait.Value = 0
        Timer1.Enabled = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pgWait.Value < pgWait.Maximum Then
            pgWait.Value = pgWait.Value + 1
            Me.Text = ComboBox2.SelectedItem & " werden  gesucht...  " & pgWait.Value & " % abgeschlossen"
        End If
        If pgWait.Value = pgWait.Maximum Then
            gbWait.Visible = False
            Timer1.Enabled = False
            Me.Close()
            pgWait.Value = 0
        End If
    End Sub

  
    Private Sub tbSuchen_KeyPress(ByVal eventsender As System.Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles tbSuchen.KeyPress
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