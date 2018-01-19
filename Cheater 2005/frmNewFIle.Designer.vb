<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmNewFIle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewFIle))
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.tbAuthor = New System.Windows.Forms.TextBox
        Me.tbSpieleTitel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbSystemTyp = New System.Windows.Forms.TextBox
        Me.tbSystem = New System.Windows.Forms.TextBox
        Me.tbKat = New System.Windows.Forms.TextBox
        Me.sfdSave = New System.Windows.Forms.OpenFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.tbZusatz = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbDatum = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.AutoSize = True
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__113_
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(194, 227)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(265, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Datei der Datenbank Hinzufügen..."
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.AutoSize = True
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__152_
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(463, 227)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(104, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(101, 133)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.Size = New System.Drawing.Size(467, 23)
        Me.tbAuthor.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.tbAuthor, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'tbSpieleTitel
        '
        Me.tbSpieleTitel.Location = New System.Drawing.Point(101, 14)
        Me.tbSpieleTitel.Name = "tbSpieleTitel"
        Me.tbSpieleTitel.Size = New System.Drawing.Size(467, 23)
        Me.tbSpieleTitel.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.tbSpieleTitel, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Author:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Kategorie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "System:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "System Typ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Spiele Titel:"
        '
        'tbSystemTyp
        '
        Me.tbSystemTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystemTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystemTyp.Location = New System.Drawing.Point(101, 46)
        Me.tbSystemTyp.Name = "tbSystemTyp"
        Me.tbSystemTyp.ReadOnly = True
        Me.tbSystemTyp.Size = New System.Drawing.Size(467, 23)
        Me.tbSystemTyp.TabIndex = 32
        '
        'tbSystem
        '
        Me.tbSystem.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystem.Location = New System.Drawing.Point(101, 76)
        Me.tbSystem.Name = "tbSystem"
        Me.tbSystem.ReadOnly = True
        Me.tbSystem.Size = New System.Drawing.Size(467, 23)
        Me.tbSystem.TabIndex = 33
        '
        'tbKat
        '
        Me.tbKat.BackColor = System.Drawing.Color.GreenYellow
        Me.tbKat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbKat.Location = New System.Drawing.Point(101, 105)
        Me.tbKat.Name = "tbKat"
        Me.tbKat.ReadOnly = True
        Me.tbKat.Size = New System.Drawing.Size(467, 23)
        Me.tbKat.TabIndex = 34
        '
        'sfdSave
        '
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
        Me.ComboBox1.Items.AddRange(New Object() {".bmp", ".exe", ".gif", ".jpg", ".msi", ".wmf", ".zip"})
        Me.ComboBox1.Location = New System.Drawing.Point(141, 196)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(427, 24)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 35
        Me.ComboBox1.Text = "Datei erweiterung auswählen..."
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Sie müssen die Dateierweiterung der Datei auswählen... ")
        '
        'tbZusatz
        '
        Me.tbZusatz.Location = New System.Drawing.Point(100, 162)
        Me.tbZusatz.Name = "tbZusatz"
        Me.tbZusatz.Size = New System.Drawing.Size(467, 23)
        Me.tbZusatz.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.tbZusatz, "Text darf folgende Zeichen nicht enthalten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\/:*?""<>|")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Dateierweiterung:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Erstellt am:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 34)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Zusätzliche Bezeichnung:"
        '
        'tbDatum
        '
        Me.tbDatum.Location = New System.Drawing.Point(99, 230)
        Me.tbDatum.Mask = "##,##,####"
        Me.tbDatum.Name = "tbDatum"
        Me.tbDatum.Size = New System.Drawing.Size(88, 23)
        Me.tbDatum.TabIndex = 41
        Me.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmNewFIle
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 268)
        Me.Controls.Add(Me.tbDatum)
        Me.Controls.Add(Me.tbZusatz)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
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
        Me.Name = "frmNewFIle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft Cheater 2005 | Neue Datei der Datenbank hinzufügen"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents tbAuthor As System.Windows.Forms.TextBox
    Friend WithEvents tbSpieleTitel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSystemTyp As System.Windows.Forms.TextBox
    Friend WithEvents tbSystem As System.Windows.Forms.TextBox
    Friend WithEvents tbKat As System.Windows.Forms.TextBox
    Friend WithEvents sfdSave As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbZusatz As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbDatum As System.Windows.Forms.MaskedTextBox

End Class
