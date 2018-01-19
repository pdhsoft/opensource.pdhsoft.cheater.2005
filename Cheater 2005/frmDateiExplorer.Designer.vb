<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmDateiExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDateiExplorer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.tsmiDatei = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiClose = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHilfe = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHilfeIndex = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSuche = New System.Windows.Forms.ComboBox
        Me.cmsGrafik = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiSpeichernUnterGrafik = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDrucken = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsProgs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAusführen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiOeffnen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEntpacken = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSpeichernUnterProg = New System.Windows.Forms.ToolStripMenuItem
        Me.sfdGrafik = New System.Windows.Forms.SaveFileDialog
        Me.sfdProg = New System.Windows.Forms.SaveFileDialog
        Me.tbProg = New System.Windows.Forms.TextBox
        Me.pbPicture = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.wbPicture = New System.Windows.Forms.WebBrowser
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbDatum = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbKat = New System.Windows.Forms.TextBox
        Me.tbSystem = New System.Windows.Forms.TextBox
        Me.tbSystemTyp = New System.Windows.Forms.TextBox
        Me.tbAuthor = New System.Windows.Forms.TextBox
        Me.tbSpieleTitel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbTyp = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbDatei = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.cmsGrafik.SuspendLayout()
        Me.cmsProgs.SuspendLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDatei, Me.tsmiHilfe})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiDatei
        '
        Me.tsmiDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClose})
        Me.tsmiDatei.Name = "tsmiDatei"
        Me.tsmiDatei.Text = "Datei"
        '
        'tsmiClose
        '
        Me.tsmiClose.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__43_
        Me.tsmiClose.Name = "tsmiClose"
        Me.tsmiClose.Text = "Fenster schließen"
        '
        'tsmiHilfe
        '
        Me.tsmiHilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiHilfeIndex})
        Me.tsmiHilfe.Name = "tsmiHilfe"
        Me.tsmiHilfe.Text = "?"
        '
        'tsmiHilfeIndex
        '
        Me.tsmiHilfeIndex.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__240_
        Me.tsmiHilfeIndex.Name = "tsmiHilfeIndex"
        Me.tsmiHilfeIndex.Text = "Hilfe"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.GreenYellow
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "PDHSoft Cheater 2005"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Suchergebnisse:"
        '
        'cbSuche
        '
        Me.cbSuche.BackColor = System.Drawing.Color.White
        Me.cbSuche.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSuche.FormattingEnabled = True
        Me.cbSuche.Location = New System.Drawing.Point(12, 45)
        Me.cbSuche.Name = "cbSuche"
        Me.cbSuche.Size = New System.Drawing.Size(758, 20)
        Me.cbSuche.Sorted = True
        Me.cbSuche.TabIndex = 23
        Me.cbSuche.Text = "Bitte wählen Sie ein Suchergebnis zum Anzeigen aus..."
        '
        'cmsGrafik
        '
        Me.cmsGrafik.BackColor = System.Drawing.Color.GreenYellow
        Me.cmsGrafik.Enabled = True
        Me.cmsGrafik.GripMargin = New System.Windows.Forms.Padding(2)
        Me.cmsGrafik.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeichernUnterGrafik, Me.tsmiDrucken})
        Me.cmsGrafik.Location = New System.Drawing.Point(24, 82)
        Me.cmsGrafik.Name = "cmsGrafik"
        Me.cmsGrafik.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmsGrafik.Size = New System.Drawing.Size(152, 48)
        '
        'tsmiSpeichernUnterGrafik
        '
        Me.tsmiSpeichernUnterGrafik.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__176_
        Me.tsmiSpeichernUnterGrafik.Name = "tsmiSpeichernUnterGrafik"
        Me.tsmiSpeichernUnterGrafik.Text = "Speichern unter..."
        Me.tsmiSpeichernUnterGrafik.ToolTipText = "Grafik in einem anderen Ordner Speichern..."
        '
        'tsmiDrucken
        '
        Me.tsmiDrucken.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__54_
        Me.tsmiDrucken.Name = "tsmiDrucken"
        Me.tsmiDrucken.Text = "Drucken..."
        Me.tsmiDrucken.ToolTipText = "Grafik ausdrucken..."
        '
        'cmsProgs
        '
        Me.cmsProgs.BackColor = System.Drawing.Color.GreenYellow
        Me.cmsProgs.Enabled = True
        Me.cmsProgs.GripMargin = New System.Windows.Forms.Padding(2)
        Me.cmsProgs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAusführen, Me.tsmiOeffnen, Me.tsmiEntpacken, Me.tsmiSpeichernUnterProg})
        Me.cmsProgs.Location = New System.Drawing.Point(24, 82)
        Me.cmsProgs.Name = "cmsProgs"
        Me.cmsProgs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmsProgs.Size = New System.Drawing.Size(152, 92)
        '
        'tsmiAusführen
        '
        Me.tsmiAusführen.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__140_
        Me.tsmiAusführen.Name = "tsmiAusführen"
        Me.tsmiAusführen.Text = "Ausführen..."
        '
        'tsmiOeffnen
        '
        Me.tsmiOeffnen.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__167_
        Me.tsmiOeffnen.Name = "tsmiOeffnen"
        Me.tsmiOeffnen.Text = "Öffnen..."
        '
        'tsmiEntpacken
        '
        Me.tsmiEntpacken.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__153_
        Me.tsmiEntpacken.Name = "tsmiEntpacken"
        Me.tsmiEntpacken.Text = "Entpacken..."
        '
        'tsmiSpeichernUnterProg
        '
        Me.tsmiSpeichernUnterProg.Image = Cheater_2005.My.Resources.Resources.Icons_16_8__176_
        Me.tsmiSpeichernUnterProg.Name = "tsmiSpeichernUnterProg"
        Me.tsmiSpeichernUnterProg.Text = "Speichern unter..."
        '
        'sfdGrafik
        '
        '
        'sfdProg
        '
        '
        'tbProg
        '
        Me.tbProg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbProg.BackColor = System.Drawing.Color.Chartreuse
        Me.tbProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbProg.ContextMenuStrip = Me.cmsProgs
        Me.tbProg.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbProg.Location = New System.Drawing.Point(13, 325)
        Me.tbProg.Multiline = True
        Me.tbProg.Name = "tbProg"
        Me.tbProg.ReadOnly = True
        Me.tbProg.Size = New System.Drawing.Size(757, 53)
        Me.tbProg.TabIndex = 24
        '
        'pbPicture
        '
        Me.pbPicture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPicture.BackColor = System.Drawing.Color.GreenYellow
        Me.pbPicture.ContextMenuStrip = Me.cmsGrafik
        Me.pbPicture.Location = New System.Drawing.Point(13, 255)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(757, 371)
        Me.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPicture.TabIndex = 22
        Me.pbPicture.TabStop = False
        Me.pbPicture.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(87, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 55)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Wählen Sie oben eine Datei und klicken Sie anschließend unten mit der rechten Mau" & _
            "staste auf das abgesetzte Feld um weitere Funktionen zu dem Dateityp zu erhalten" & _
            "."
        '
        'wbPicture
        '
        Me.wbPicture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbPicture.Location = New System.Drawing.Point(14, 459)
        Me.wbPicture.Name = "wbPicture"
        Me.wbPicture.Size = New System.Drawing.Size(756, 167)
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(756, 74)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'tbDatum
        '
        Me.tbDatum.BackColor = System.Drawing.Color.GreenYellow
        Me.tbDatum.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbDatum.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDatum.Location = New System.Drawing.Point(99, 216)
        Me.tbDatum.Name = "tbDatum"
        Me.tbDatum.ReadOnly = True
        Me.tbDatum.ShortcutsEnabled = False
        Me.tbDatum.Size = New System.Drawing.Size(144, 23)
        Me.tbDatum.TabIndex = 88
        Me.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Erstellt am:"
        '
        'tbKat
        '
        Me.tbKat.BackColor = System.Drawing.Color.GreenYellow
        Me.tbKat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbKat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKat.Location = New System.Drawing.Point(99, 158)
        Me.tbKat.Name = "tbKat"
        Me.tbKat.ReadOnly = True
        Me.tbKat.Size = New System.Drawing.Size(671, 23)
        Me.tbKat.TabIndex = 86
        '
        'tbSystem
        '
        Me.tbSystem.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSystem.Location = New System.Drawing.Point(99, 129)
        Me.tbSystem.Name = "tbSystem"
        Me.tbSystem.ReadOnly = True
        Me.tbSystem.Size = New System.Drawing.Size(671, 23)
        Me.tbSystem.TabIndex = 85
        '
        'tbSystemTyp
        '
        Me.tbSystemTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystemTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystemTyp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSystemTyp.Location = New System.Drawing.Point(99, 100)
        Me.tbSystemTyp.Name = "tbSystemTyp"
        Me.tbSystemTyp.ReadOnly = True
        Me.tbSystemTyp.Size = New System.Drawing.Size(671, 23)
        Me.tbSystemTyp.TabIndex = 84
        '
        'tbAuthor
        '
        Me.tbAuthor.BackColor = System.Drawing.Color.GreenYellow
        Me.tbAuthor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbAuthor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAuthor.Location = New System.Drawing.Point(99, 187)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.ReadOnly = True
        Me.tbAuthor.Size = New System.Drawing.Size(671, 23)
        Me.tbAuthor.TabIndex = 83
        '
        'tbSpieleTitel
        '
        Me.tbSpieleTitel.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSpieleTitel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSpieleTitel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSpieleTitel.Location = New System.Drawing.Point(99, 71)
        Me.tbSpieleTitel.Name = "tbSpieleTitel"
        Me.tbSpieleTitel.ReadOnly = True
        Me.tbSpieleTitel.Size = New System.Drawing.Size(671, 23)
        Me.tbSpieleTitel.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Author:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Kategorie:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "System:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "System Typ:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Spiele Titel:"
        '
        'tbTyp
        '
        Me.tbTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbTyp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTyp.Location = New System.Drawing.Point(321, 216)
        Me.tbTyp.Name = "tbTyp"
        Me.tbTyp.ReadOnly = True
        Me.tbTyp.ShortcutsEnabled = False
        Me.tbTyp.Size = New System.Drawing.Size(57, 23)
        Me.tbTyp.TabIndex = 91
        Me.tbTyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(249, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Dateityp:"
        '
        'tbDatei
        '
        Me.tbDatei.Location = New System.Drawing.Point(89, 279)
        Me.tbDatei.Name = "tbDatei"
        Me.tbDatei.Size = New System.Drawing.Size(640, 23)
        Me.tbDatei.TabIndex = 92
        Me.tbDatei.Visible = False
        '
        'frmDateiExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(782, 638)
        Me.Controls.Add(Me.tbTyp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbDatum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbKat)
        Me.Controls.Add(Me.tbSystem)
        Me.Controls.Add(Me.tbSystemTyp)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbSpieleTitel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbSuche)
        Me.Controls.Add(Me.pbPicture)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbProg)
        Me.Controls.Add(Me.wbPicture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDatei)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frmDateiExplorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft Cheater 2005 | Datei Explorer"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.cmsGrafik.ResumeLayout(False)
        Me.cmsProgs.ResumeLayout(False)
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiDatei As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHilfe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSuche As System.Windows.Forms.ComboBox
    Friend WithEvents cmsGrafik As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsProgs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents sfdGrafik As System.Windows.Forms.SaveFileDialog
    Friend WithEvents sfdProg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tbProg As System.Windows.Forms.TextBox
    Friend WithEvents tsmiClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHilfeIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSpeichernUnterGrafik As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDrucken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAusführen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOeffnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEntpacken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSpeichernUnterProg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wbPicture As System.Windows.Forms.WebBrowser
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDatum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbKat As System.Windows.Forms.TextBox
    Friend WithEvents tbSystem As System.Windows.Forms.TextBox
    Friend WithEvents tbSystemTyp As System.Windows.Forms.TextBox
    Friend WithEvents tbAuthor As System.Windows.Forms.TextBox
    Friend WithEvents tbSpieleTitel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbTyp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbDatei As System.Windows.Forms.TextBox
End Class
