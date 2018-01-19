<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.tbCheat = New System.Windows.Forms.TextBox
        Me.tbDatum = New System.Windows.Forms.TextBox
        Me.lbCheatText = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tbCheat
        '
        Me.tbCheat.Location = New System.Drawing.Point(12, 190)
        Me.tbCheat.MaxLength = 2147483647
        Me.tbCheat.Multiline = True
        Me.tbCheat.Name = "tbCheat"
        Me.tbCheat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbCheat.Size = New System.Drawing.Size(555, 156)
        Me.tbCheat.TabIndex = 64
        '
        'tbDatum
        '
        Me.tbDatum.BackColor = System.Drawing.Color.GreenYellow
        Me.tbDatum.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbDatum.Location = New System.Drawing.Point(424, 160)
        Me.tbDatum.Name = "tbDatum"
        Me.tbDatum.ReadOnly = True
        Me.tbDatum.ShortcutsEnabled = False
        Me.tbDatum.Size = New System.Drawing.Size(144, 23)
        Me.tbDatum.TabIndex = 63
        Me.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCheatText
        '
        Me.lbCheatText.AutoSize = True
        Me.lbCheatText.Location = New System.Drawing.Point(12, 160)
        Me.lbCheatText.Name = "lbCheatText"
        Me.lbCheatText.Size = New System.Drawing.Size(88, 16)
        Me.lbCheatText.TabIndex = 62
        Me.lbCheatText.Text = "Cheat Text:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Erstellt am:"
        '
        'tbKat
        '
        Me.tbKat.BackColor = System.Drawing.Color.GreenYellow
        Me.tbKat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbKat.Location = New System.Drawing.Point(99, 96)
        Me.tbKat.Name = "tbKat"
        Me.tbKat.ReadOnly = True
        Me.tbKat.Size = New System.Drawing.Size(467, 23)
        Me.tbKat.TabIndex = 60
        '
        'tbSystem
        '
        Me.tbSystem.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystem.Location = New System.Drawing.Point(99, 67)
        Me.tbSystem.Name = "tbSystem"
        Me.tbSystem.ReadOnly = True
        Me.tbSystem.Size = New System.Drawing.Size(467, 23)
        Me.tbSystem.TabIndex = 59
        '
        'tbSystemTyp
        '
        Me.tbSystemTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystemTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystemTyp.Location = New System.Drawing.Point(99, 38)
        Me.tbSystemTyp.Name = "tbSystemTyp"
        Me.tbSystemTyp.ReadOnly = True
        Me.tbSystemTyp.Size = New System.Drawing.Size(467, 23)
        Me.tbSystemTyp.TabIndex = 58
        '
        'tbAuthor
        '
        Me.tbAuthor.BackColor = System.Drawing.Color.GreenYellow
        Me.tbAuthor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbAuthor.Location = New System.Drawing.Point(99, 125)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.ReadOnly = True
        Me.tbAuthor.Size = New System.Drawing.Size(467, 23)
        Me.tbAuthor.TabIndex = 57
        '
        'tbSpieleTitel
        '
        Me.tbSpieleTitel.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSpieleTitel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSpieleTitel.Location = New System.Drawing.Point(99, 9)
        Me.tbSpieleTitel.Name = "tbSpieleTitel"
        Me.tbSpieleTitel.ReadOnly = True
        Me.tbSpieleTitel.Size = New System.Drawing.Size(467, 23)
        Me.tbSpieleTitel.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Author:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Kategorie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "System:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "System Typ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Spiele Titel:"
        '
        'ofdOpen
        '
        Me.ofdOpen.Filter = "CheatDatei (*.cht)|*.cht"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.AutoSize = True
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__113_
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(349, 350)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(114, 28)
        Me.OK_Button.TabIndex = 49
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
        Me.Cancel_Button.Location = New System.Drawing.Point(467, 350)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(104, 28)
        Me.Cancel_Button.TabIndex = 50
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'frmEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(578, 386)
        Me.Controls.Add(Me.tbCheat)
        Me.Controls.Add(Me.tbDatum)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft Cheater 2005 | Cheat bearbeiten..."
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCheat As System.Windows.Forms.TextBox
    Friend WithEvents tbDatum As System.Windows.Forms.TextBox
    Friend WithEvents lbCheatText As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents ofdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
End Class
