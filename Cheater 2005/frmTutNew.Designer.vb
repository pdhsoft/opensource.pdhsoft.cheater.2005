<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTutNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTutNew))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.tbInfo = New System.Windows.Forms.TextBox
        Me.btBearbeiten = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbSystemTyp = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbSystem = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbKat = New System.Windows.Forms.Label
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
        Me.ComboBox1.Location = New System.Drawing.Point(107, 6)
        Me.ComboBox1.MaxDropDownItems = 13
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(461, 24)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "Bitte wählen Sie einen System Typ..."
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Hier müssen Sie einen System Typ wählen...")
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cheats", "Codes", "Grafiken", "Lösungen", "Savegames", "Tipps", "Tools", "Trainer"})
        Me.ComboBox2.Location = New System.Drawing.Point(107, 66)
        Me.ComboBox2.MaxDropDownItems = 9
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(461, 24)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.Text = "Bitte wählen Sie eine Kategorie..."
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Hier müssen Sie eine Kategorie auswählen...")
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(107, 36)
        Me.ComboBox3.MaxDropDownItems = 4
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(461, 24)
        Me.ComboBox3.Sorted = True
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.Text = "Bitte wählen Sie ein System..."
        Me.ToolTip1.SetToolTip(Me.ComboBox3, "HIer müssen Sie ein System wählen...")
        '
        'tbInfo
        '
        Me.tbInfo.BackColor = System.Drawing.Color.GreenYellow
        Me.tbInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbInfo.Location = New System.Drawing.Point(208, 96)
        Me.tbInfo.Multiline = True
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.ReadOnly = True
        Me.tbInfo.Size = New System.Drawing.Size(359, 45)
        Me.tbInfo.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.tbInfo, "Hier stehen alle Möglichen Kategorien" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eines Systems")
        '
        'btBearbeiten
        '
        Me.btBearbeiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btBearbeiten.BackColor = System.Drawing.Color.Transparent
        Me.btBearbeiten.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__167_
        Me.btBearbeiten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBearbeiten.Location = New System.Drawing.Point(306, 267)
        Me.btBearbeiten.Margin = New System.Windows.Forms.Padding(4)
        Me.btBearbeiten.Name = "btBearbeiten"
        Me.btBearbeiten.Size = New System.Drawing.Size(158, 28)
        Me.btBearbeiten.TabIndex = 2
        Me.btBearbeiten.Text = "Cheat bearbeiten..."
        Me.btBearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btBearbeiten, "Einen existierenden Cheat in der" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datenbank bearbeiten")
        Me.btBearbeiten.UseVisualStyleBackColor = False
        Me.btBearbeiten.Visible = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__3_
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(306, 267)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(158, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Cheat hinzufügen..."
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.OK_Button, "Einen Cheat der Datenbank hinzufügen")
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__152_
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(472, 267)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(96, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Cancel_Button, "Abbrechen")
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "System Typ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "System:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kategorie:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Verfügbare Kategorien " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "des ausgewählten Systems:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ausgewählter System Typ:"
        '
        'lbSystemTyp
        '
        Me.lbSystemTyp.AutoSize = True
        Me.lbSystemTyp.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbSystemTyp.Location = New System.Drawing.Point(12, 173)
        Me.lbSystemTyp.Name = "lbSystemTyp"
        Me.lbSystemTyp.Size = New System.Drawing.Size(199, 16)
        Me.lbSystemTyp.TabIndex = 12
        Me.lbSystemTyp.Text = "Kein System Typ ausgewählt"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ausgewähltes System:"
        '
        'lbSystem
        '
        Me.lbSystem.AutoSize = True
        Me.lbSystem.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbSystem.Location = New System.Drawing.Point(12, 205)
        Me.lbSystem.Name = "lbSystem"
        Me.lbSystem.Size = New System.Drawing.Size(169, 16)
        Me.lbSystem.TabIndex = 14
        Me.lbSystem.Text = "Kein System ausgewählt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Ausgewählte Kategorie:"
        '
        'lbKat
        '
        Me.lbKat.AutoSize = True
        Me.lbKat.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbKat.Location = New System.Drawing.Point(12, 237)
        Me.lbKat.Name = "lbKat"
        Me.lbKat.Size = New System.Drawing.Size(190, 16)
        Me.lbKat.TabIndex = 16
        Me.lbKat.Text = "Keine Kategorie ausgewählt"
        '
        'frmTutNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(580, 310)
        Me.Controls.Add(Me.lbKat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbSystem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbSystemTyp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbInfo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btBearbeiten)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTutNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft Cheater 2005 | Tutorial Cheat hinzufügen / bearbeiten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btBearbeiten As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbSystemTyp As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbSystem As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbKat As System.Windows.Forms.Label

End Class
