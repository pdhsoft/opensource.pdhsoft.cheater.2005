Public Class frmTutNew

    Private Sub frmTutNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox3.Enabled = False
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Sie müssen ein System auswählen.", MsgBoxStyle.Critical, My.Application.Info.Title)
        Else
            If ComboBox2.SelectedItem = "" Then
                MsgBox("Sie müssen eine Kategorie auswählen.", MsgBoxStyle.Critical, My.Application.Info.Title)
            Else
                If ComboBox2.SelectedItem = "Savegames" Then
                    If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Or ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Or ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Or ComboBox1.SelectedItem = "Nokia(NGadge)" Or ComboBox1.SelectedItem = "Sega ???" Or ComboBox1.SelectedItem = "Sega(DreamCast)" Or ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Then
                        MsgBox("Die Ausgewählte Kategorie ist in Verbindung mit dem gewählten System nicht Verwendbar!(", MsgBoxStyle.Critical, My.Application.Info.Title)
                        Exit Sub
                    Else
                        frmNewFIle.tbSystemTyp.Text = lbSystemTyp.Text
                        frmNewFIle.tbSystem.Text = lbSystem.Text
                        frmNewFIle.tbKat.Text = lbKat.Text
                        frmNewFIle.ShowDialog()
                        Me.Close()
                    End If

                Else
                    If ComboBox2.SelectedItem = "Tools" Then
                        If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Or ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Or ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Or ComboBox1.SelectedItem = "Nintendo(GameCube)" Or ComboBox1.SelectedItem = "Nintendo(Revolution)" Or ComboBox1.SelectedItem = "Nokia(NGadge)" Or ComboBox1.SelectedItem = "Sega ???" Or ComboBox1.SelectedItem = "Playstation, PS One, PS 2, PS Two, PS 3, PSP" Or ComboBox1.SelectedItem = "Sega(DreamCast)" Or ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Or ComboBox1.SelectedItem = "Xbox, Xbox 2" Then
                            MsgBox("Die Ausgewählte Kategorie ist in Verbindung mit dem gewählten System nicht Verwendbar!(", MsgBoxStyle.Critical, My.Application.Info.Title)
                            Exit Sub
                        Else
                            frmNewFIle.tbSystemTyp.Text = lbSystemTyp.Text
                            frmNewFIle.tbSystem.Text = lbSystem.Text
                            frmNewFIle.tbKat.Text = lbKat.Text
                            frmNewFIle.ShowDialog()
                            Me.Close()
                        End If
                    Else
                        If ComboBox2.SelectedItem = "Trainer" Then
                            If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...) " Or ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Or ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Or ComboBox1.SelectedItem = "Nintendo(GameCube)" Or ComboBox1.SelectedItem = "Nintendo(Revolution)" Or ComboBox1.SelectedItem = "Nokia(NGadge)" Or ComboBox1.SelectedItem = "Sega ???" Or ComboBox1.SelectedItem = "Playstation, PS One, PS 2, PS Two, PS 3, PSP" Or ComboBox1.SelectedItem = "Sega(DreamCast)" Or ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Or ComboBox1.SelectedItem = "Xbox, Xbox 2" Then
                                MsgBox("Die Ausgewählte Kategorie ist in Verbindung mit dem gewählten System nicht Verwendbar!(", MsgBoxStyle.Critical, My.Application.Info.Title)
                                Exit Sub
                            Else
                                frmNewFIle.tbSystemTyp.Text = lbSystemTyp.Text
                                frmNewFIle.tbSystem.Text = lbSystem.Text
                                frmNewFIle.tbKat.Text = lbKat.Text
                                frmNewFIle.ShowDialog()
                                Me.Close()
                            End If
                        Else
                            If ComboBox2.SelectedItem = "Patches" Then
                                If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...) " Or ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Or ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Or ComboBox1.SelectedItem = "Nintendo(GameCube)" Or ComboBox1.SelectedItem = "Nintendo(Revolution)" Or ComboBox1.SelectedItem = "Nokia(NGadge)" Or ComboBox1.SelectedItem = "Sega ???" Or ComboBox1.SelectedItem = "Playstation, PS One, PS 2, PS Two, PS 3, PSP" Or ComboBox1.SelectedItem = "Sega(DreamCast)" Or ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Or ComboBox1.SelectedItem = "Xbox, Xbox 2" Then
                                    MsgBox("Die Ausgewählte Kategorie ist in Verbindung mit dem gewählten System nicht Verwendbar!(", MsgBoxStyle.Critical, My.Application.Info.Title)
                                    Exit Sub
                                Else
                                    frmNewFIle.tbSystemTyp.Text = lbSystemTyp.Text
                                    frmNewFIle.tbSystem.Text = lbSystem.Text
                                    frmNewFIle.tbKat.Text = lbKat.Text
                                    frmNewFIle.ShowDialog()
                                    Me.Close()
                                End If
                            Else
                                If ComboBox2.SelectedItem = "Updates" Then
                                    If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...) " Or ComboBox1.SelectedItem = "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS" Or ComboBox1.SelectedItem = "Nintendo Entertainment System (NES)" Or ComboBox1.SelectedItem = "Nintendo(GameCube)" Or ComboBox1.SelectedItem = "Nintendo(Revolution)" Or ComboBox1.SelectedItem = "Nokia(NGadge)" Or ComboBox1.SelectedItem = "Sega ???" Or ComboBox1.SelectedItem = "Playstation, PS One, PS 2, PS Two, PS 3, PSP" Or ComboBox1.SelectedItem = "Sega(DreamCast)" Or ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Or ComboBox1.SelectedItem = "Xbox, Xbox 2" Then
                                        MsgBox("Die Ausgewählte Kategorie ist in Verbindung mit dem gewählten System nicht Verwendbar!(", MsgBoxStyle.Critical, My.Application.Info.Title)
                                        Exit Sub
                                    Else
                                        frmNewFIle.tbSystemTyp.Text = lbSystemTyp.Text
                                        frmNewFIle.tbSystem.Text = lbSystem.Text
                                        frmNewFIle.tbKat.Text = lbKat.Text
                                        frmNewFIle.ShowDialog()
                                        Me.Close()
                                    End If
                                Else
                                    If ComboBox2.SelectedItem = "Grafiken" Then
                                        frmNewFIle.tbSystemTyp.Text = lbSystemTyp.Text
                                        frmNewFIle.tbSystem.Text = lbSystem.Text
                                        frmNewFIle.tbKat.Text = lbKat.Text
                                        frmNewFIle.ShowDialog()
                                        Me.Close()
                                    Else
                                        frmNeuerCheat.tbSystemTyp.Text = lbSystemTyp.Text
                                        frmNeuerCheat.tbSystem.Text = lbSystem.Text
                                        frmNeuerCheat.tbKat.Text = lbKat.Text
                                        frmNeuerCheat.lbCheatText.Text = "Text für " & lbKat.Text & " hier eingeben:"
                                        frmNeuerCheat.ShowDialog()
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

    Private Sub btBearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBearbeiten.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Sie müssen ein System auswählen.", MsgBoxStyle.Critical, My.Application.Info.Title)
        Else
            If ComboBox2.SelectedItem = "" Then
                MsgBox("Sie müssen eine Kategorie auswählen.", MsgBoxStyle.Critical, My.Application.Info.Title)
            Else
                If ComboBox2.SelectedItem = "Savegames" Then
                    MsgBox("Diese Kategorie kann nicht Bearbeitet werden!", MsgBoxStyle.Critical, My.Application.Info.Title)
                    Exit Sub
                Else
                    If ComboBox2.SelectedItem = "Tools" Then
                        MsgBox("Diese Kategorie kann nicht Bearbeitet werden!", MsgBoxStyle.Critical, My.Application.Info.Title)
                        Exit Sub
                    Else
                        If ComboBox2.SelectedItem = "Trainer" Then
                            MsgBox("Diese Kategorie kann nicht Bearbeitet werden!", MsgBoxStyle.Critical, My.Application.Info.Title)
                            Exit Sub
                        Else
                            If ComboBox2.SelectedItem = "Grafiken" Then
                                MsgBox("Diese Kategorie kann nicht Bearbeitet werden!", MsgBoxStyle.Critical, My.Application.Info.Title)
                                Exit Sub
                            Else
                                frmEdit.tbSystemTyp.Text = lbSystemTyp.Text
                                frmEdit.tbSystem.Text = lbSystem.Text
                                frmEdit.tbKat.Text = lbKat.Text
                                frmEdit.lbCheatText.Text = "Text für " & lbKat.Text & " hier eingeben:"
                                frmEdit.ShowDialog()
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        lbSystemTyp.Text = ComboBox1.SelectedItem
        If ComboBox1.SelectedItem = "Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Tools, Trainer, Grafiken, Savegames"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox2.Items.Add("Tools")
            ComboBox2.Items.Add("Trainer")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
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
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Nintendo(GameCube)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken, Savegames"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Nintendo(Revolution)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken, Savegames"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Savegames")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Nokia(NGadge)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "PC - Personal Computer" Then
            tbInfo.Text = "Cheats, (Hex)Codes, Patches, Tools, Updates, Trainer, Savegames, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
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
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
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
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Sega(DreamCast)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
        End If
        If ComboBox1.SelectedItem = "Super Nintendo  Entertainment System (SNES)" Then
            tbInfo.Text = "Cheats, Codes, Lösungen, Tipps & Tricks, Grafiken"
            ComboBox3.Enabled = False
            ComboBox3.Items.Clear()
            lbSystem.Text = ComboBox1.SelectedItem
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheats")
            ComboBox2.Items.Add("Codes")
            ComboBox2.Items.Add("Grafiken")
            ComboBox2.Items.Add("Lösungen")
            ComboBox2.Items.Add("Tipps")
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("")
            ComboBox3.SelectedItem = ""
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

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        lbSystem.Text = ComboBox3.SelectedItem
        
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        lbKat.Text = ComboBox2.SelectedItem
    End Sub

End Class
