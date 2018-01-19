<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmConvert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvert))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.rtfCheat = New System.Windows.Forms.RichTextBox
        Me.btInfo = New System.Windows.Forms.Button
        Me.tbSpieleTitel = New System.Windows.Forms.TextBox
        Me.tbAuthor = New System.Windows.Forms.TextBox
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbCheat = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.kalender = New System.Windows.Forms.MonthCalendar
        Me.Button1 = New System.Windows.Forms.Button
        Me.btSpeichern = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.tbSystemTyp = New System.Windows.Forms.TextBox
        Me.tbSystem = New System.Windows.Forms.TextBox
        Me.tbKat = New System.Windows.Forms.TextBox
        Me.tbDatum = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.GreenYellow
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "PDHSoft Cheater 2005"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)", "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)", "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS", "Nintendo Entertainment System (NES)", "Nintendo(GameCube)", "Nintendo(Revolution)", "Nokia(NGadge)", "PC - Personal Computer", "Playstation, PS One, PS 2, PS Two, PS 3, PSP", "Sega ???", "Sega(DreamCast)", "Super Nintendo  Entertainment System (SNES)", "Xbox, Xbox 2"})
        Me.ComboBox1.Location = New System.Drawing.Point(101, 35)
        Me.ComboBox1.MaxDropDownItems = 13
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(467, 24)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.Text = "Bitte wählen Sie einen System Typ..."
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Hier müssen Sie einen System Typ wählen...")
        '
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(101, 65)
        Me.ComboBox3.MaxDropDownItems = 4
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(467, 24)
        Me.ComboBox3.Sorted = True
        Me.ComboBox3.TabIndex = 16
        Me.ComboBox3.Text = "Bitte wählen Sie ein System..."
        Me.ToolTip1.SetToolTip(Me.ComboBox3, "HIer müssen Sie ein System wählen...")
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cheats", "Codes", "Lösungen", "Tipps"})
        Me.ComboBox2.Location = New System.Drawing.Point(101, 96)
        Me.ComboBox2.MaxDropDownItems = 10
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(467, 24)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 24
        Me.ComboBox2.Text = "Bitte wählen Sie eine Kategorie..."
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Hier müssen Sie eine Kategorie auswählen...")
        '
        'rtfCheat
        '
        Me.rtfCheat.BackColor = System.Drawing.Color.White
        Me.rtfCheat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfCheat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfCheat.Location = New System.Drawing.Point(12, 361)
        Me.rtfCheat.Name = "rtfCheat"
        Me.rtfCheat.ReadOnly = True
        Me.rtfCheat.Size = New System.Drawing.Size(555, 156)
        Me.rtfCheat.TabIndex = 19
        Me.rtfCheat.Text = ""
        Me.ToolTip1.SetToolTip(Me.rtfCheat, "Hier steht der Cheattext den Sie Konvertieren wollen")
        '
        'btInfo
        '
        Me.btInfo.BackColor = System.Drawing.Color.Transparent
        Me.btInfo.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__10_
        Me.btInfo.Location = New System.Drawing.Point(12, 524)
        Me.btInfo.Name = "btInfo"
        Me.btInfo.Size = New System.Drawing.Size(43, 28)
        Me.btInfo.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.btInfo, "Schnell Hilfe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Info zum Konvertieren")
        Me.btInfo.UseVisualStyleBackColor = False
        '
        'tbSpieleTitel
        '
        Me.tbSpieleTitel.Location = New System.Drawing.Point(101, 6)
        Me.tbSpieleTitel.Name = "tbSpieleTitel"
        Me.tbSpieleTitel.Size = New System.Drawing.Size(467, 23)
        Me.tbSpieleTitel.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.tbSpieleTitel, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(101, 125)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.Size = New System.Drawing.Size(467, 23)
        Me.tbAuthor.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.tbAuthor, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'ofdOpen
        '
        Me.ofdOpen.Filter = "PDHSoft Pattes Cheater 2004 CheatDatei (*.cheat)|*.cheat"
        Me.ofdOpen.Title = "PDHSoft Cheater 2005 | PDHSoft Cheater 2004 CheatDatei Convertieren"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Spiele Titel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "System Typ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "System:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kategorie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Erstellt am:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cheat Text:"
        '
        'tbCheat
        '
        Me.tbCheat.Location = New System.Drawing.Point(12, 184)
        Me.tbCheat.MaxLength = 2147483647
        Me.tbCheat.Multiline = True
        Me.tbCheat.Name = "tbCheat"
        Me.tbCheat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbCheat.Size = New System.Drawing.Size(555, 156)
        Me.tbCheat.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cheater Datei 2004 Text:"
        '
        'kalender
        '
        Me.kalender.BackColor = System.Drawing.Color.GreenYellow
        Me.kalender.Location = New System.Drawing.Point(198, 190)
        Me.kalender.Name = "kalender"
        Me.kalender.TabIndex = 23
        Me.kalender.TitleBackColor = System.Drawing.Color.LimeGreen
        Me.kalender.TitleForeColor = System.Drawing.Color.OrangeRed
        Me.kalender.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.Cheater_2005.My.Resources.Resources.Kalender_32x32_XP
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(62, 524)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Datum ändern..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btSpeichern
        '
        Me.btSpeichern.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSpeichern.BackColor = System.Drawing.Color.Transparent
        Me.btSpeichern.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__113_
        Me.btSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSpeichern.Location = New System.Drawing.Point(229, 524)
        Me.btSpeichern.Margin = New System.Windows.Forms.Padding(4)
        Me.btSpeichern.Name = "btSpeichern"
        Me.btSpeichern.Size = New System.Drawing.Size(108, 28)
        Me.btSpeichern.TabIndex = 21
        Me.btSpeichern.Text = "Speichern..."
        Me.btSpeichern.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSpeichern.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__152_
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(470, 524)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(98, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Image = Global.Cheater_2005.My.Resources.Resources.x
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(345, 524)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(114, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Konvertieren"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'tbSystemTyp
        '
        Me.tbSystemTyp.Location = New System.Drawing.Point(101, 35)
        Me.tbSystemTyp.Name = "tbSystemTyp"
        Me.tbSystemTyp.Size = New System.Drawing.Size(100, 23)
        Me.tbSystemTyp.TabIndex = 50
        '
        'tbSystem
        '
        Me.tbSystem.Location = New System.Drawing.Point(101, 66)
        Me.tbSystem.Name = "tbSystem"
        Me.tbSystem.Size = New System.Drawing.Size(100, 23)
        Me.tbSystem.TabIndex = 51
        '
        'tbKat
        '
        Me.tbKat.Location = New System.Drawing.Point(101, 97)
        Me.tbKat.Name = "tbKat"
        Me.tbKat.Size = New System.Drawing.Size(100, 23)
        Me.tbKat.TabIndex = 52
        '
        'tbDatum
        '
        Me.tbDatum.Location = New System.Drawing.Point(414, 155)
        Me.tbDatum.Mask = "##,##,####"
        Me.tbDatum.Name = "tbDatum"
        Me.tbDatum.Size = New System.Drawing.Size(153, 23)
        Me.tbDatum.TabIndex = 54
        Me.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(580, 565)
        Me.Controls.Add(Me.tbDatum)
        Me.Controls.Add(Me.btInfo)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.kalender)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btSpeichern)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rtfCheat)
        Me.Controls.Add(Me.tbCheat)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbSpieleTitel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.tbSystemTyp)
        Me.Controls.Add(Me.tbSystem)
        Me.Controls.Add(Me.tbKat)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConvert"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PDHSoft Cheater 2005 | PDHSoft Pattes Cheater 2004 Cheatdate Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ofdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbSpieleTitel As System.Windows.Forms.TextBox
    Friend WithEvents tbAuthor As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tbCheat As System.Windows.Forms.TextBox
    Friend WithEvents rtfCheat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btSpeichern As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents kalender As System.Windows.Forms.MonthCalendar
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents tbSystemTyp As System.Windows.Forms.TextBox
    Friend WithEvents tbSystem As System.Windows.Forms.TextBox
    Friend WithEvents tbKat As System.Windows.Forms.TextBox
    Friend WithEvents btInfo As System.Windows.Forms.Button
    Friend WithEvents tbDatum As System.Windows.Forms.MaskedTextBox

End Class
