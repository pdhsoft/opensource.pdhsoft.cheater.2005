<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmNeuerCheat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNeuerCheat))
        Me.tbKat = New System.Windows.Forms.TextBox
        Me.tbSystem = New System.Windows.Forms.TextBox
        Me.tbSystemTyp = New System.Windows.Forms.TextBox
        Me.tbAuthor = New System.Windows.Forms.TextBox
        Me.tbSpieleTitel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbCheat = New System.Windows.Forms.TextBox
        Me.lbCheatText = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.btDatum = New System.Windows.Forms.Button
        Me.Kalender = New System.Windows.Forms.MonthCalendar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbDatum = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'tbKat
        '
        Me.tbKat.BackColor = System.Drawing.Color.GreenYellow
        Me.tbKat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbKat.Location = New System.Drawing.Point(99, 93)
        Me.tbKat.Name = "tbKat"
        Me.tbKat.ReadOnly = True
        Me.tbKat.Size = New System.Drawing.Size(467, 23)
        Me.tbKat.TabIndex = 44
        '
        'tbSystem
        '
        Me.tbSystem.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystem.Location = New System.Drawing.Point(99, 64)
        Me.tbSystem.Name = "tbSystem"
        Me.tbSystem.ReadOnly = True
        Me.tbSystem.Size = New System.Drawing.Size(467, 23)
        Me.tbSystem.TabIndex = 43
        '
        'tbSystemTyp
        '
        Me.tbSystemTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystemTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystemTyp.Location = New System.Drawing.Point(99, 35)
        Me.tbSystemTyp.Name = "tbSystemTyp"
        Me.tbSystemTyp.ReadOnly = True
        Me.tbSystemTyp.Size = New System.Drawing.Size(467, 23)
        Me.tbSystemTyp.TabIndex = 42
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(99, 122)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.Size = New System.Drawing.Size(467, 23)
        Me.tbAuthor.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.tbAuthor, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'tbSpieleTitel
        '
        Me.tbSpieleTitel.Location = New System.Drawing.Point(99, 6)
        Me.tbSpieleTitel.Name = "tbSpieleTitel"
        Me.tbSpieleTitel.Size = New System.Drawing.Size(467, 23)
        Me.tbSpieleTitel.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.tbSpieleTitel, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Author:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Kategorie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "System:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "System Typ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Spiele Titel:"
        '
        'tbCheat
        '
        Me.tbCheat.Location = New System.Drawing.Point(12, 187)
        Me.tbCheat.MaxLength = 2147483647
        Me.tbCheat.Multiline = True
        Me.tbCheat.Name = "tbCheat"
        Me.tbCheat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbCheat.Size = New System.Drawing.Size(555, 156)
        Me.tbCheat.TabIndex = 48
        '
        'lbCheatText
        '
        Me.lbCheatText.AutoSize = True
        Me.lbCheatText.Location = New System.Drawing.Point(12, 157)
        Me.lbCheatText.Name = "lbCheatText"
        Me.lbCheatText.Size = New System.Drawing.Size(88, 16)
        Me.lbCheatText.TabIndex = 46
        Me.lbCheatText.Text = "Cheat Text:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(329, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Erstellt am:"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.AutoSize = True
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__113_
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(349, 347)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(114, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Speichern..."
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.AutoSize = True
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__152_
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(467, 347)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(104, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'btDatum
        '
        Me.btDatum.BackColor = System.Drawing.Color.Transparent
        Me.btDatum.Image = Global.Cheater_2005.My.Resources.Resources.Kalender_32x32_XP
        Me.btDatum.Location = New System.Drawing.Point(101, 347)
        Me.btDatum.Name = "btDatum"
        Me.btDatum.Size = New System.Drawing.Size(241, 28)
        Me.btDatum.TabIndex = 49
        Me.btDatum.Text = "Erstellt am: Datum ändern..."
        Me.btDatum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btDatum.UseVisualStyleBackColor = False
        '
        'Kalender
        '
        Me.Kalender.BackColor = System.Drawing.Color.GreenYellow
        Me.Kalender.Location = New System.Drawing.Point(190, 93)
        Me.Kalender.Name = "Kalender"
        Me.Kalender.TabIndex = 50
        Me.Kalender.TitleBackColor = System.Drawing.Color.Lime
        Me.Kalender.TitleForeColor = System.Drawing.Color.OrangeRed
        Me.Kalender.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.GreenYellow
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "PDHSoft Cheater 2005"
        '
        'tbDatum
        '
        Me.tbDatum.Location = New System.Drawing.Point(415, 157)
        Me.tbDatum.Mask = "##,##,####"
        Me.tbDatum.Name = "tbDatum"
        Me.tbDatum.Size = New System.Drawing.Size(151, 23)
        Me.tbDatum.TabIndex = 51
        Me.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmNeuerCheat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 388)
        Me.Controls.Add(Me.tbDatum)
        Me.Controls.Add(Me.Kalender)
        Me.Controls.Add(Me.btDatum)
        Me.Controls.Add(Me.tbCheat)
        Me.Controls.Add(Me.lbCheatText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbKat)
        Me.Controls.Add(Me.tbSystem)
        Me.Controls.Add(Me.tbSystemTyp)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbSpieleTitel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNeuerCheat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft Cheater 2005 | Neuen Cheat hinzufügen..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbKat As System.Windows.Forms.TextBox
    Friend WithEvents tbSystem As System.Windows.Forms.TextBox
    Friend WithEvents tbSystemTyp As System.Windows.Forms.TextBox
    Friend WithEvents tbAuthor As System.Windows.Forms.TextBox
    Friend WithEvents tbSpieleTitel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCheat As System.Windows.Forms.TextBox
    Friend WithEvents lbCheatText As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btDatum As System.Windows.Forms.Button
    Friend WithEvents Kalender As System.Windows.Forms.MonthCalendar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbDatum As System.Windows.Forms.MaskedTextBox

End Class
