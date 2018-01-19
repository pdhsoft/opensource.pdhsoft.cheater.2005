<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSuche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuche))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.tbSuchen = New System.Windows.Forms.TextBox
        Me.btSuchen = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbInfo = New System.Windows.Forms.TextBox
        Me.gbWait = New System.Windows.Forms.GroupBox
        Me.pgWait = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbWait.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(542, 156)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bitte wählen Sie ein System Typ, ein System und eine Kategorie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "System Typ:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(114, 70)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.MaxDropDownItems = 4
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(413, 24)
        Me.ComboBox3.Sorted = True
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.Text = "Bitte wählen Sie ein System..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "System:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cheats", "Codes", "Grafiken", "Lösungen", "Savegames", "Tipps", "Tools", "Trainer"})
        Me.ComboBox2.Location = New System.Drawing.Point(114, 107)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.MaxDropDownItems = 9
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(413, 24)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.Text = "Bitte wählen Sie eine Kategorie..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Kategorie:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ältere bzw Andere Computer (z.B. Apple, Comodore, Amiga, etc...)", "Ältere bzw Andere Spiele Consolen (z.B. Sega, Phillips, etc...)", "Nintedo GameBoy, GameBoy Color, GameBoy Advance, DS", "Nintendo Entertainment System (NES)", "Nintendo(GameCube)", "Nintendo(Revolution)", "Nokia(NGadge)", "PC - Personal Computer", "Playstation, PS One, PS 2, PS Two, PS 3, PSP", "Sega ???", "Sega(DreamCast)", "Super Nintendo  Entertainment System (SNES)", "Xbox, Xbox 2"})
        Me.ComboBox1.Location = New System.Drawing.Point(114, 33)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.MaxDropDownItems = 13
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(413, 24)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Bitte wählen Sie einen System Typ..."
        '
        'tbSuchen
        '
        Me.tbSuchen.Location = New System.Drawing.Point(104, 249)
        Me.tbSuchen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbSuchen.Name = "tbSuchen"
        Me.tbSuchen.Size = New System.Drawing.Size(351, 23)
        Me.tbSuchen.TabIndex = 4
        Me.tbSuchen.Text = "Geben Sie hier den Spiele Titel ein"
        '
        'btSuchen
        '
        Me.btSuchen.BackColor = System.Drawing.Color.Transparent
        Me.btSuchen.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__239_
        Me.btSuchen.Location = New System.Drawing.Point(16, 241)
        Me.btSuchen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btSuchen.Name = "btSuchen"
        Me.btSuchen.Size = New System.Drawing.Size(82, 39)
        Me.btSuchen.TabIndex = 5
        Me.btSuchen.Text = "Suchen"
        Me.btSuchen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSuchen.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__152_
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(462, 241)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(96, 39)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mögliche Kategorien:"
        '
        'tbInfo
        '
        Me.tbInfo.BackColor = System.Drawing.Color.GreenYellow
        Me.tbInfo.Location = New System.Drawing.Point(183, 178)
        Me.tbInfo.Multiline = True
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.ReadOnly = True
        Me.tbInfo.ShortcutsEnabled = False
        Me.tbInfo.Size = New System.Drawing.Size(360, 48)
        Me.tbInfo.TabIndex = 12
        '
        'gbWait
        '
        Me.gbWait.Controls.Add(Me.pgWait)
        Me.gbWait.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbWait.Location = New System.Drawing.Point(52, 112)
        Me.gbWait.Name = "gbWait"
        Me.gbWait.Size = New System.Drawing.Size(468, 68)
        Me.gbWait.TabIndex = 13
        Me.gbWait.TabStop = False
        Me.gbWait.Text = "Bitte warten..."
        Me.gbWait.UseWaitCursor = True
        Me.gbWait.Visible = False
        '
        'pgWait
        '
        Me.pgWait.Location = New System.Drawing.Point(6, 32)
        Me.pgWait.Name = "pgWait"
        Me.pgWait.Size = New System.Drawing.Size(456, 17)
        Me.pgWait.TabIndex = 0
        Me.pgWait.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'frmSuche
        '
        Me.AcceptButton = Me.btSuchen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(573, 292)
        Me.Controls.Add(Me.tbInfo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbSuchen)
        Me.Controls.Add(Me.btSuchen)
        Me.Controls.Add(Me.gbWait)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheat suchen..."
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbWait.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tbSuchen As System.Windows.Forms.TextBox
    Friend WithEvents btSuchen As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbInfo As System.Windows.Forms.TextBox
    Friend WithEvents gbWait As System.Windows.Forms.GroupBox
    Friend WithEvents pgWait As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
