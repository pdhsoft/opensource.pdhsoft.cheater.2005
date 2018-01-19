Public Class frmNeuerCheat
    Dim SpeicherOrt As Object
    Dim Dateiname As Object
    Dim fso As New Scripting.FileSystemObject
    Dim strm As Scripting.TextStream
    Dim StrVersion As String
    Private Sub frmNeuerCheat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbDatum.Text = My.Computer.Clock.LocalTime.Date
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If tbSpieleTitel.Text = "" Then
            MsgBox("Sie müssen einen SpieleTitel eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
            Exit Sub
        Else
            If tbAuthor.Text = "" Then
                MsgBox("Sie müssen einen Author eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
                Exit Sub
            Else
                If tbCheat.Text = "" Then
                    MsgBox("Sie müssen einen Cheat Text eingeben!", MsgBoxStyle.Critical, My.Application.Info.Title)
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
                    MsgBox("Cheat wurde erfolgreich gespeichert.", MsgBoxStyle.Information, My.Application.Info.Title)
                    Me.Close()
                End If
            End If
        End If

     

    End Sub

    Private Sub btDatum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDatum.Click
        If kalender.Visible = True Then
            kalender.Visible = False
        Else
            kalender.Visible = True
        End If
    End Sub

    Private Sub Kalender_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Kalender.DateSelected
        tbDatum.Text = Kalender.SelectionEnd.Date
        Kalender.Visible = False
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        tbAuthor.Text = ""
        tbSpieleTitel.Text = ""
        tbCheat.Text = ""
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

    Private Sub tbSpieleTitel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpieleTitel.TextChanged

    End Sub
End Class
