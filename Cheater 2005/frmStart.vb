Public Class frmStart
    Dim SpeicherOrt As Object
    Dim Dateiname As Object
    Dim fso As New Scripting.FileSystemObject
    Dim strm As Scripting.TextStream
    Dim StrVersion As String

    ' Willkommen bei der OpenSource Edition des PDHSoft Cheater 2005, da einige Teile des Original Cheater's 2005 neue Techniken, änderungen etc... enthält die nicht als OpenSource freigegeben werden können und dürfen, wurden diese hier entfernt und ersetzt! Die Änderungen betreffen insbesondere den OnlineUpdater, den ModInstaller, den ModDownloader und das Infofenster. 
    'Version 2005.2.1.2 -> Dies ist die erste Version er OpenSource Edition, diese ist weitesgehend noch NICHT dokumentiert / kommentiert, in einer späteren Version soll dieses eventuelle noch folgen, dies hängt weitesgehend von der Nachfrage und dem Kommentarierungsbedarf ab.

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SeiteEinrichtenToolStripMenuItem.Enabled = False
        DruckVorschauToolStripMenuItem.Enabled = False
        DruckenToolStripMenuItem.Enabled = False
        BearbeitenToolStripMenuItem.Enabled = False
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Start.wav", AudioPlayMode.Background)
    End Sub


    Private Sub DatenbankUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDataUpdate.Show()
    End Sub

   

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox(My.Application.Info.Trademark & vbCr & vbNewLine & My.Application.Info.Title & vbCrLf & vbNewLine & "Version " & My.Application.Info.Version.ToString & vbCrLf & vbNewLine & My.Application.Info.Copyright & vbCrLf & vbNewLine & "PDHSoft und Cheater 2005 sind weltweit urheberrechtlich geschützt." & vbCr & "Alle Rechte vorbehalten (siehe Hilfe)", MsgBoxStyle.Information, My.Application.Info.Title & " | Info...")
    End Sub

    Private Sub NeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        frmTutNew.Text = "PDHSoft Cheater 2005 | Assistent Cheat hinzufügen / erstellen..."
        frmTutNew.OK_Button.Visible = True
        frmTutNew.btBearbeiten.Visible = False
        frmTutNew.ShowDialog()
    End Sub

    Private Sub CheatSuchenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheatSuchenToolStripMenuItem.Click
        frmSuche.ShowDialog()
    End Sub

    Private Sub SeiteEinrichtenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeiteEinrichtenToolStripMenuItem.Click
        If rtfCheats.Text = "" Then
            MsgBox("Sie müssen erst ein Objekt auswählen...", MsgBoxStyle.Critical, My.Application.Info.Title)
        Else
            PageSetupDialog1.ShowDialog()
        End If
    End Sub

    Private Sub DruckVorschauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckVorschauToolStripMenuItem.Click
        If rtfCheats.Text = "" Then
            MsgBox("Sie müssen erst ein Objekt auswählen...", MsgBoxStyle.Critical, My.Application.Info.Title)
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub DruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripMenuItem.Click
        'PrintDialog1.(tbCheats.Text)
        'PrintDialog1.ShowDialog()
        If rtfCheats.Text = "" Then
            MsgBox("Sie müssen erst ein Objekt auswählen...", MsgBoxStyle.Critical, My.Application.Info.Title)
        Else
            If (PrintDialog1.ShowDialog = DialogResult.OK) Then
                PrintDocument1.Print()
            End If
        End If

    End Sub

    
    Private Sub AusschneidenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AusschneidenToolStripMenuItem.Click
        My.Computer.Clipboard.GetText(rtfCheats.SelectedText)
    End Sub

    Private Sub KopierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenToolStripMenuItem.Click
        If rtfCheats.Text = "" Then
        Else
            'My.Computer.Clipboard.GetText(rtfCheats.SelectedText)
            rtfCheats.Copy()
        End If

    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinfügenToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(rtfCheats.Text)
    End Sub

    Private Sub AllesMakierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllesMakierenToolStripMenuItem.Click
        rtfCheats.SelectAll()
    End Sub

    Private Sub addCHeatToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addCHeatToolStripButton.Click
        NeuToolStripMenuItem_Click(NeuToolStripMenuItem, New System.EventArgs)
    End Sub

    Private Sub DruckenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripButton.Click
        DruckenToolStripMenuItem_Click(DruckenToolStripMenuItem, New System.EventArgs)
    End Sub

    Private Sub CheatSuchenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheatSuchenToolStripButton.Click
        CheatSuchenToolStripMenuItem_Click(CheatSuchenToolStripMenuItem, New System.EventArgs)
    End Sub

    Private Sub btSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheatSuchenToolStripMenuItem_Click(CheatSuchenToolStripMenuItem, New System.EventArgs)
    End Sub
    Private Sub tsmiConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiConvert.Click
        frmConvert.ShowDialog()
    End Sub

    Private Sub tsbConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConvert.Click
        tsmiConvert_Click(tsmiConvert, New System.EventArgs)
    End Sub

    Private Sub cbSuche_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSuche.SelectedIndexChanged
        If cbSuche.SelectedItem = "" Or cbSuche.SelectedItem = "Noch keine Suche Gestartet..." Or cbSuche.SelectedItem = "Keine Ergebnisse zu ihrer Suche gefunden..." Then
            SeiteEinrichtenToolStripMenuItem.Enabled = False
            DruckVorschauToolStripMenuItem.Enabled = False
            DruckenToolStripMenuItem.Enabled = False
            BearbeitenToolStripMenuItem.Enabled = False
            MsgBox("Wählen Sie einen anderen Eintrag aus...", MsgBoxStyle.Critical, My.Application.Info.Title)
            Exit Sub
        Else
            If frmSuche.ComboBox2.SelectedItem = "Grafiken" Or frmSuche.ComboBox2.SelectedItem = "Tools" Or frmSuche.ComboBox2.SelectedItem = "Trainer" Or frmSuche.ComboBox2.SelectedItem = "Patches" Or frmSuche.ComboBox2.SelectedItem = "Updates" Or frmSuche.ComboBox2.SelectedItem = "Savegames" Then
                wbPicture.Navigate("about:blank")
                StrVersion = fso.BuildPath(cbSuche.SelectedItem, "")
                If fso.FileExists(StrVersion) Then
                    strm = fso.OpenTextFile(StrVersion)
                End If
                With strm
                    Do
                        tbSpieleTitel.Text = .ReadLine
                        tbSystemTyp.Text = .ReadLine
                        tbSystem.Text = .ReadLine
                        tbKat.Text = .ReadLine
                        tbAuthor.Text = .ReadLine
                        tbDatum.Text = .ReadLine
                        tbTyp.Text = .ReadLine
                        tbDatei.Text = .ReadLine
                    Loop Until .AtEndOfStream
                    .Close()
                End With
                If frmSuche.ComboBox2.SelectedItem = "Grafiken" Then
                    pbPicture.Load(My.Application.Info.DirectoryPath & tbDatei.Text)
                Else
                    tbProg.Text = My.Application.Info.DirectoryPath & tbDatei.Text
                End If
            Else
                SeiteEinrichtenToolStripMenuItem.Enabled = True
                DruckVorschauToolStripMenuItem.Enabled = True
                DruckenToolStripMenuItem.Enabled = True
                BearbeitenToolStripMenuItem.Enabled = True
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
                Dateiname = SpeicherOrt & "\" & tbKat.Text
                StrVersion = fso.BuildPath(cbSuche.SelectedItem, "")
                If fso.FileExists(StrVersion) Then
                    strm = fso.OpenTextFile(StrVersion)
                End If
                With strm
                    Do
                        tbSpieleTitel.Text = .ReadLine
                        tbSystemTyp.Text = .ReadLine
                        tbSystem.Text = .ReadLine
                        tbKat.Text = .ReadLine
                        tbAuthor.Text = .ReadLine
                        tbDatum.Text = .ReadLine
                        .ReadLine()
                        rtfCheats.Text = .ReadAll
                    Loop Until .AtEndOfStream
                    .Close()

                End With
                rtfDrucken.Text = "Titel: " & tbSpieleTitel.Text & vbCr & "System Typ: " & tbSystemTyp.Text & vbCr & "System: " & tbSystem.Text & vbCr & "Kategorie: " & tbKat.Text & vbCr & "Author: " & tbAuthor.Text & vbCr & "Erstellt am: " & tbDatum.Text & vbCr & "--------------------" & vbCr & "Cheat Text: " & vbCr & "---" & vbCr & rtfCheats.Text & vbCr & "--------------------" & vbCr & "PDHSoft Cheater 2005"
            End If
        End If
      
    End Sub
    Private m_nFirstCharOnPage As Integer
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' e.Graphics.DrawRectangle(System.Drawing.Pens.Blue, e.MarginBounds)
        m_nFirstCharOnPage = rtfDrucken.FormatRange(False, e, m_nFirstCharOnPage, rtfDrucken.TextLength)
        If (m_nFirstCharOnPage < rtfDrucken.TextLength) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
       
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        m_nFirstCharOnPage = 0
    End Sub

    Private Sub PrintDocument1_EndPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        rtfCheats.FormatRangeDone()
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(800, 600)
    End Sub

    Private Sub DruckenToolStripMenuItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripMenuItem.EnabledChanged
        DruckenToolStripButton.Enabled = DruckenToolStripMenuItem.Enabled
    End Sub

    Private Sub SchnellHilfeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchnellHilfeToolStripMenuItem.Click
        MsgBox("Wenn in einem Fenster ein 'INFO' Symbol (siehe links) ist." & vbCr & "Dann ist dort eine Schnell Hilfe Verfügbar." & vbCr & "Klicken Sie auf das Symbol um die Schnell Hilfe anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)
    End Sub
    Private Sub tsmiEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEdit.Click, EditToolStripButton.Click
        frmTutNew.Text = "PDHSoft Cheater 2005 | Cheat bearbeiten..."
        frmTutNew.OK_Button.Visible = False
        frmTutNew.btBearbeiten.Visible = True
        frmTutNew.ShowDialog()
    End Sub

    Private Sub tsbtSchnellsuche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtSchnellsuche.Click, CheatSchnellsucheToolStripMenuItem.Click, btSchnellsuche.Click
        Dim list As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        cbSuche.Items.Clear()
        list = My.Computer.FileSystem.FindInFiles(My.Application.Info.DirectoryPath & "\System.db", tstbSuche.Text, True, FileIO.SearchOption.SearchAllSubDirectories, "*.cht")
        For Each name As String In list
            cbSuche.Items.Add(name)
        Next
        If cbSuche.Items.ToString = "" Then
            cbSuche.Items.Add("Keine Ergebnisse zu ihrer Suche gefunden...")
        End If
        MsgBox("Suche nach ''" & tstbSuche.Text & "'' abgeschlossen." & vbCr & "Wählen Sie im Feld Suchergebnisse einen Eintrag aus," & vbCr & "um diesen anzuzeigen.", MsgBoxStyle.Information, My.Application.Info.Title)

    End Sub

    Private Sub tstbSuche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstbSuche.Click
        tstbSuche.SelectAll()
    End Sub

    Private Sub tsbtSchnellHilfeSuche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtSchnellHilfeSuche.Click
        MsgBox("Die Schnell Suche zeigt Ergebnisse von allen Systemen" & vbCr & "und den Kategorien: Cheats, Codes, Lösungen & Tipps." & vbCr & vbNewLine & "Mit der ''Detail Cheatsuche'' können Sie nach auswahl" & vbCr & "in System Typ / System / Kategorie - Ihre Cheats Suchen..." & vbCr & vbNewLine & "Mögliche Kategorien der Detail Cheatsuche: " & vbCr & "Cheats, Codes, Lösungen, Tipps, Grafiken, Tools, Trainer," & vbCr & "Updates, Patches & Savegames." & vbCr & vbNewLine & "Kategorien können nach System Typen Variieren.", MsgBoxStyle.Information, My.Application.Info.Title)
    End Sub

    Private Sub tstbSuche_KeyPress(ByVal eventSender As System.Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles tstbSuche.KeyPress
        Dim KeyAscii As Short = Asc(eventargs.KeyChar)
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
        If KeyAscii = &HD Or KeyAscii = &H6C Or KeyAscii = Keys.Enter Then
            tsbtSchnellsuche_Click(tsbtSchnellsuche, New System.EventArgs)
        End If
    End Sub
    Private Sub tsmiSpeichernUnterGrafik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSpeichernUnterGrafik.Click
        sfdGrafik.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        sfdGrafik.Title = "Grafik speichern unter..."
        sfdGrafik.DefaultExt = tbTyp.Text
        sfdGrafik.FileName = tbSpieleTitel.Text
        sfdGrafik.ShowDialog()
    End Sub

    Private Sub sfdGrafik_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sfdGrafik.FileOk
        My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & tbDatei.Text, sfdGrafik.FileName, True)
        MsgBox("Datei wurde erfolgreich gespeichert.", MsgBoxStyle.Information, My.Application.Info.Title)
    End Sub


    Private Sub tsmiSpeichernUnterProg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSpeichernUnterProg.Click
        sfdProg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        sfdProg.Title = frmSuche.ComboBox2.SelectedItem & " speichern unter..."
        sfdProg.DefaultExt = tbTyp.Text
        sfdProg.FileName = tbSpieleTitel.Text
        sfdProg.ShowDialog()
    End Sub

    Private Sub sfdProg_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sfdProg.FileOk
        My.Computer.FileSystem.CopyFile(tbProg.Text, sfdProg.FileName, True)
        MsgBox("Datei wurde erfolgreich gespeichert.", MsgBoxStyle.Information, My.Application.Info.Title)
    End Sub

    Private Sub tsmiDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDrucken.Click
        wbPicture.Navigate(My.Application.Info.DirectoryPath & tbDatei.Text)
        wbPicture.ShowPrintDialog()

    End Sub

    Private Sub tsmiAusführen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAusführen.Click
        Dim Ergebnis As Integer
        On Error Resume Next
        Ergebnis = Shell(tbProg.Text, AppWinStyle.NormalFocus)

    End Sub

    Private Sub tsmiEntpacken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEntpacken.Click
        wbPicture.Navigate(tbProg.Text)
    End Sub

    Private Sub tsmiOeffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiOeffnen.Click
        wbPicture.Navigate(tbProg.Text)
    End Sub

    Private Sub tbTyp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTyp.TextChanged
        If tbTyp.Text = ".bmp" Then
            sfdGrafik.Filter = "Bitmap Datei (*.bmp)|*.bmp"
        Else
            If tbTyp.Text = ".gif" Then
                sfdGrafik.Filter = "GIF Datei (*.gif)|*.gif"
            Else
                If tbTyp.Text = ".jpg" Then
                    sfdGrafik.Filter = "JPEG Datei (*.jpg)|*.jpg"
                Else
                    If tbTyp.Text = ".wmf" Then
                        sfdGrafik.Filter = "WMF Datei (*.wmf)|*.wmf"
                    Else
                        If tbTyp.Text = ".exe" Then
                            tsmiAusführen.Enabled = True
                            tsmiEntpacken.Enabled = False
                            tsmiOeffnen.Enabled = False
                            sfdProg.Filter = "Ausführbare Datei (*.exe)|*.exe"
                        Else
                            If tbTyp.Text = ".zip" Then
                                tsmiAusführen.Enabled = False
                                tsmiEntpacken.Enabled = True
                                tsmiOeffnen.Enabled = False
                                sfdProg.Filter = "Gepackte Datei (*.zip)|*.zip"
                            Else
                                If tbTyp.Text = ".msi" Then
                                    tsmiAusführen.Enabled = False
                                    tsmiEntpacken.Enabled = False
                                    tsmiOeffnen.Enabled = True
                                    sfdProg.Filter = "Windows Installer Datei (*.msi)|*.msi"
                                Else
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub tbKat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbKat.TextChanged
        If tbKat.Text = "Grafiken" Then
            pProg.SendToBack()
            pbPicture.BringToFront()
            rtfCheats.SendToBack()
        Else
            If tbKat.Text = "Tools" Then
                pProg.BringToFront()
                pbPicture.SendToBack()
                rtfCheats.SendToBack()
            Else
                If tbKat.Text = "Trainer" Then
                    pProg.BringToFront()
                    pbPicture.SendToBack()
                    rtfCheats.SendToBack()
                Else
                    If tbKat.Text = "Patches" Then
                        pProg.BringToFront()
                        pbPicture.SendToBack()
                        rtfCheats.SendToBack()
                    Else
                        If tbKat.Text = "Updates" Then
                            pProg.BringToFront()
                            pbPicture.SendToBack()
                            rtfCheats.SendToBack()
                        Else
                            If tbKat.Text = "Savegames" Then
                                pProg.BringToFront()
                                pbPicture.SendToBack()
                                rtfCheats.SendToBack()
                            Else
                                pProg.SendToBack()
                                pbPicture.SendToBack()
                                rtfCheats.BringToFront()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub OnlineUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineUpdatesToolStripMenuItem.Click

    End Sub
End Class
