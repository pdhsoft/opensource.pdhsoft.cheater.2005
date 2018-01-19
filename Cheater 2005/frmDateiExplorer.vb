Public Class frmDateiExplorer
    Dim fso As New Scripting.FileSystemObject
    Dim strm As Scripting.TextStream
    Dim StrVersion As String
    Private Sub tsmiHilfeIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHilfeIndex.Click
        Dim Ergebnis As Integer
        On Error Resume Next
        Ergebnis = Shell(My.Application.Info.DirectoryPath & "\help\" & "PDHSoft Hilfe System 2005.exe", AppWinStyle.NormalFocus)

    End Sub

    Private Sub tsmiClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiClose.Click
        Me.Close()
    End Sub
    Private Sub cbSuche_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSuche.SelectedIndexChanged
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
End Class