Public Class frmDataUpdate
    Dim NewUpdate As Boolean
    Dim UpdateVersion As Object
    Dim mb1nNavigieren As Boolean
    Dim b1nVorhanden As Boolean
    Dim AutoUpdate As Boolean

    Private Sub cmdAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub frmOnlineUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltodo.ForeColor = Color.Black
        Me.Text = My.Application.Info.Title & " | DatenbankUpdate..."
        lblAktuell.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PDHSoft\Cheater 2005\", "DatenBank Version", "")
        lblNeu1.Text = ("- Noch nicht Verfügbar -")
        txtProtokoll.Text = ("DatenbankUpdater wird Initialisiert...")
        txtProtokoll.Text = ("Bitte warten...") & vbCrLf & txtProtokoll.Text
        NewUpdate = False
        green.BackColor = Color.Black
        red.BackColor = Color.Black
        yellow.BackColor = Color.Yellow
        lbltodo.Text = ("Was nun? - Klicken sie auf Update Suchen -")
        webupdate.Navigate("http://downloads.pdhsoft.de/CHData05.txt")
        cmdSuchen.Enabled = False
        On Error GoTo Registry
        'CheckBox1.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PDHSoft\OnlineUpdater 2005\", "AutoUpdate", "")
        'If CheckBox1.Checked = True Then
        'AutoUpdate = True
        'Else
        'AutoUpdate = False
        'End If
        Exit Sub
Registry:
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PDHSoft\OnlineUpdater 2005\", "AutoUpdate", "False")

    End Sub

    Private Sub cmdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo.Click
        MsgBox("Ampel Status (Update Status)" & vbCrLf & vbNewLine & "Ist die Ampel gelb, wurde kein Update Gefunden bzw. noch nicht Gesucht." & vbCrLf & "Ist die Ampel rot, ist die Update Version Neuer (Höher) als die Programmversion" & vbCrLf & "Ist die Ampel grün, so haben Sie die Aktuellste Version" & vbCrLf & "Nun können Sie das Update über Update Herunterladen Downloaden" & vbCrLf & vbNewLine & "Im Feld -Was nun?- wird ihnen gesagt was Sie tun sollen.", MsgBoxStyle.Information, "PDHSoft Online Update Info...")
    End Sub

    Private Sub cmdSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuchen.Click
        lbltodo.ForeColor = Color.Black
        NewUpdate = True
        green.BackColor = Color.Black
        red.BackColor = Color.Black
        yellow.BackColor = Color.Yellow
        lblNeu1.Text = ("- Noch nicht Verfügbar -")
        txtProtokoll.Text = ("Verbindung zur " & My.Application.Info.ProductName & " DatenBank Updateliste herstellen...") & vbCrLf & txtProtokoll.Text
        txtProtokoll.Text = ("Bitte warten...") & vbCrLf & txtProtokoll.Text
        txtProtokoll.ScrollToCaret()
        webupdate.Navigate("http://downloads.pdhsoft.de/CHData05.txt")
        txtProtokoll.Text = ("Verbinde...") & vbCrLf & txtProtokoll.Text
        txtProtokoll.ScrollToCaret()
        On Error GoTo Fehler

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PDHSoft\Cheater 2005\", My.Application.Info.ProductName & " DatenBank", webupdate.Document.Body.InnerText)
        Exit Sub
Fehler:

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PDHSoft\Cheater 2005\", My.Application.Info.ProductName & " DatenBank", "Zur Zeit nicht Verfügbar")

    End Sub

    Private Sub cmdDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDownload.Click
        webupdate.Navigate("http://downloads.pdhsoft.de/CH05Data" & lblNeu1.Text & ".msi")
        cmdAbbrechen.Text = "Schließen"
    End Sub
    Private Sub webupdate_ProgressChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles webupdate.ProgressChanged
        Dim Progress As Integer = eventArgs.CurrentProgress
        Dim ProgressMax As Integer = eventArgs.MaximumProgress
        On Error Resume Next
        If Progress = -1 Then
            pgbStatus.Value = 0
        ElseIf ProgressMax = 0 Then
            cmdSuchen.Enabled = True
            pgbStatus.Value = 0
        Else
            pgbStatus.Value = (100 * Progress / ProgressMax)
            cmdSuchen.Enabled = False

        End If
    End Sub
    Private Sub webUpdate_Navigating(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles webupdate.Navigating
        Dim URL As Object = eventArgs.Url
        Dim TargetFrameName As String = eventArgs.TargetFrameName
        Dim Cancel As String = eventArgs.Cancel
        On Error Resume Next

    End Sub
    Private Sub webUpdate_Navigated(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles webupdate.Navigated
        Dim URL As Object = eventArgs.Url
        On Error Resume Next
        Dim b1nVorhanden As Boolean

        If b1nVorhanden Then
            mb1nNavigieren = True
            If NewUpdate = True Then
                webupdate_NeuesUpdate()
            End If
        End If
    End Sub
    Private Sub webupdate_NeuesUpdate()



        lblNeu1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PDHSoft\Cheater 2005\", My.Application.Info.ProductName & " DatenBank", "")

        If lblNeu1.Text > "2005_DATA_999999" Then
            GoTo Fehler
        Else
            If lblAktuell.Text < lblNeu1.Text Then
                txtProtokoll.Text = ("Verbindung hergestellt...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.Text = ("Prüfe Version...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.Text = ("Versionsprüfung abgeschlossen...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.ScrollToCaret()
                yellow.BackColor = Color.Black
                green.BackColor = Color.Black
                red.BackColor = Color.Red
                cmdDownload.Enabled = True
                lbltodo.Text = ("Neues DatenBank Update Vorhanden, Sie sollten es Downloaden.")
                AutoUpdate = False
            Else
                txtProtokoll.Text = ("Verbindung hergestellt...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.Text = ("Prüfe Version...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.Text = ("Versionsprüfung abgeschlossen...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.ScrollToCaret()
                yellow.BackColor = Color.Black
                green.BackColor = Color.Black
                red.BackColor = Color.Black
                cmdDownload.Enabled = False
                lbltodo.Text = ("Sie haben bereits die Aktuellste Version")
                AutoUpdate = False
                If lblNeu1.Text < "2005_DATA_000000" Then
                    GoTo Fehler
                Else
                    If lblNeu1.Text <= " " Then
                        GoTo Fehler
                    End If
                End If
            End If

        End If


        NewUpdate = False

        cmdAbbrechen.Text = "Schließen"
        Exit Sub
Fehler:
        green.BackColor = Color.Black
        red.BackColor = Color.Black
        yellow.BackColor = Color.Yellow
        lblNeu1.Text = ("Fehler...")
        txtProtokoll.Text = ("Kann keine Verbindung Herstellen...") & vbCrLf & txtProtokoll.Text
        txtProtokoll.ScrollToCaret()
        lbltodo.Text = ("Fehler: Bitte Prüfen sie ihre Internetverbindung.")
        lbltodo.ForeColor = Color.Red
        cmdAbbrechen.Text = "Schließen"
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PDHSoft\Cheater 2005\", My.Application.Info.ProductName & " DatenBank", "Zur Zeit nicht Verfügbar")
        AutoUpdate = False
    End Sub


    Private Sub webupdate_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webupdate.DocumentCompleted
        If NewUpdate = True Then
            webupdate_NeuesUpdate()
        Else

        End If
    End Sub



    Private Sub cmdSuchen_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuchen.EnabledChanged
        If cmdSuchen.Enabled = True Then
            If NewUpdate = False Then
                txtProtokoll.Text = ("Initialisierung abgeschlossen...") & vbCrLf & txtProtokoll.Text
                txtProtokoll.ScrollToCaret()
            End If
            If AutoUpdate = True Then
                cmdSuchen_Click(cmdSuchen, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub txtProtokoll_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProtokoll.TextChanged
        txtProtokoll.ScrollToCaret()
    End Sub
End Class

