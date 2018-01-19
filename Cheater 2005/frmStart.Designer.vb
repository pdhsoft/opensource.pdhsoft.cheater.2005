<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiConvert = New System.Windows.Forms.ToolStripMenuItem
        Me.CheatSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheatSchnellsucheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SeiteEinrichtenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DruckVorschauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AllesMakierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.SchnellHilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnlineUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.addCHeatToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.tsbConvert = New System.Windows.Forms.ToolStripButton
        Me.DruckenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CheatSuchenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tstbSuche = New System.Windows.Forms.ToolStripTextBox
        Me.tsbtSchnellsuche = New System.Windows.Forms.ToolStripButton
        Me.tsbtSchnellHilfeSuche = New System.Windows.Forms.ToolStripButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbSuche = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbDatum = New System.Windows.Forms.TextBox
        Me.lbCheatText = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbKat = New System.Windows.Forms.TextBox
        Me.tbSystem = New System.Windows.Forms.TextBox
        Me.tbSystemTyp = New System.Windows.Forms.TextBox
        Me.tbAuthor = New System.Windows.Forms.TextBox
        Me.tbSpieleTitel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.btSchnellsuche = New System.Windows.Forms.Button
        Me.rtfCheats = New RichTextBoxEx
        Me.rtfDrucken = New RichTextBoxEx
        Me.tbTyp = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.pbPicture = New System.Windows.Forms.PictureBox
        Me.cmsGrafik = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiSpeichernUnterGrafik = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDrucken = New System.Windows.Forms.ToolStripMenuItem
        Me.tbDatei = New System.Windows.Forms.TextBox
        Me.sfdGrafik = New System.Windows.Forms.SaveFileDialog
        Me.sfdProg = New System.Windows.Forms.SaveFileDialog
        Me.cmsProgs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAusführen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiOeffnen = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiEntpacken = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSpeichernUnterProg = New System.Windows.Forms.ToolStripMenuItem
        Me.pProg = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbProg = New System.Windows.Forms.TextBox
        Me.wbPicture = New System.Windows.Forms.WebBrowser
        Me.Label9 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGrafik.SuspendLayout()
        Me.cmsProgs.SuspendLayout()
        Me.pProg.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.tsmiEdit, Me.tsmiConvert, Me.CheatSuchenToolStripMenuItem, Me.CheatSchnellsucheToolStripMenuItem, Me.ToolStripSeparator2, Me.SeiteEinrichtenToolStripMenuItem, Me.DruckVorschauToolStripMenuItem, Me.DruckenToolStripMenuItem, Me.ToolStripSeparator3, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.cheater
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.NeuToolStripMenuItem.Text = "Neuen Cheat zur Datenbank hinzufügen"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__167_
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmiEdit.Size = New System.Drawing.Size(348, 22)
        Me.tsmiEdit.Text = "Einen Cheat in der Datenbank Bearbeiten"
        '
        'tsmiConvert
        '
        Me.tsmiConvert.Image = Global.Cheater_2005.My.Resources.Resources.x
        Me.tsmiConvert.Name = "tsmiConvert"
        Me.tsmiConvert.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.tsmiConvert.Size = New System.Drawing.Size(348, 22)
        Me.tsmiConvert.Text = "Pattes Cheater 2004 CheatDatei Konvertieren"
        '
        'CheatSuchenToolStripMenuItem
        '
        Me.CheatSuchenToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__84_
        Me.CheatSuchenToolStripMenuItem.Name = "CheatSuchenToolStripMenuItem"
        Me.CheatSuchenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CheatSuchenToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.CheatSuchenToolStripMenuItem.Text = "Detail Cheatsuche"
        '
        'CheatSchnellsucheToolStripMenuItem
        '
        Me.CheatSchnellsucheToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__106_
        Me.CheatSchnellsucheToolStripMenuItem.Name = "CheatSchnellsucheToolStripMenuItem"
        Me.CheatSchnellsucheToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CheatSchnellsucheToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.CheatSchnellsucheToolStripMenuItem.Text = "Cheat Schnellsuche"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(345, 6)
        '
        'SeiteEinrichtenToolStripMenuItem
        '
        Me.SeiteEinrichtenToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__3_
        Me.SeiteEinrichtenToolStripMenuItem.Name = "SeiteEinrichtenToolStripMenuItem"
        Me.SeiteEinrichtenToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.SeiteEinrichtenToolStripMenuItem.Text = "Seite einrichten..."
        '
        'DruckVorschauToolStripMenuItem
        '
        Me.DruckVorschauToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__106_
        Me.DruckVorschauToolStripMenuItem.Name = "DruckVorschauToolStripMenuItem"
        Me.DruckVorschauToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.DruckVorschauToolStripMenuItem.Text = "Druckvorschau..."
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__54_
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.DruckenToolStripMenuItem.Text = "Drucken..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(345, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__89_
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.ToolStripSeparator1, Me.AllesMakierenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        Me.AusschneidenToolStripMenuItem.Visible = False
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        Me.EinfügenToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'AllesMakierenToolStripMenuItem
        '
        Me.AllesMakierenToolStripMenuItem.Name = "AllesMakierenToolStripMenuItem"
        Me.AllesMakierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AllesMakierenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AllesMakierenToolStripMenuItem.Text = "Alles Makieren"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchnellHilfeToolStripMenuItem, Me.ToolStripSeparator5, Me.InfoToolStripMenuItem, Me.OnlineUpdatesToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem2.Text = "&?"
        '
        'SchnellHilfeToolStripMenuItem
        '
        Me.SchnellHilfeToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__240_
        Me.SchnellHilfeToolStripMenuItem.Name = "SchnellHilfeToolStripMenuItem"
        Me.SchnellHilfeToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SchnellHilfeToolStripMenuItem.Text = "Schnell Hilfe"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(155, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__10_
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'OnlineUpdatesToolStripMenuItem
        '
        Me.OnlineUpdatesToolStripMenuItem.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__47_
        Me.OnlineUpdatesToolStripMenuItem.Name = "OnlineUpdatesToolStripMenuItem"
        Me.OnlineUpdatesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.OnlineUpdatesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.OnlineUpdatesToolStripMenuItem.Text = "Datenbank Update"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addCHeatToolStripButton, Me.EditToolStripButton, Me.tsbConvert, Me.DruckenToolStripButton, Me.ToolStripSeparator4, Me.CheatSuchenToolStripButton, Me.ToolStripSeparator6, Me.tstbSuche, Me.tsbtSchnellsuche, Me.tsbtSchnellHilfeSuche})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'addCHeatToolStripButton
        '
        Me.addCHeatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.addCHeatToolStripButton.Image = Global.Cheater_2005.My.Resources.Resources.cheater
        Me.addCHeatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addCHeatToolStripButton.Name = "addCHeatToolStripButton"
        Me.addCHeatToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.addCHeatToolStripButton.Text = "Neuen Cheat hinzufügen"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__167_
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.EditToolStripButton.Text = "Einen Cheat in der Datenbank bearbeiten"
        '
        'tsbConvert
        '
        Me.tsbConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConvert.Image = Global.Cheater_2005.My.Resources.Resources.x
        Me.tsbConvert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConvert.Name = "tsbConvert"
        Me.tsbConvert.Size = New System.Drawing.Size(24, 24)
        Me.tsbConvert.Text = "Cheater 2004 CheatDatei Konvertieren"
        '
        'DruckenToolStripButton
        '
        Me.DruckenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DruckenToolStripButton.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__54_
        Me.DruckenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripButton.Name = "DruckenToolStripButton"
        Me.DruckenToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.DruckenToolStripButton.Text = "Cheat drucken"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'CheatSuchenToolStripButton
        '
        Me.CheatSuchenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheatSuchenToolStripButton.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__84_
        Me.CheatSuchenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheatSuchenToolStripButton.Name = "CheatSuchenToolStripButton"
        Me.CheatSuchenToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.CheatSuchenToolStripButton.Text = "Detail Cheatsuche"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'tstbSuche
        '
        Me.tstbSuche.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tstbSuche.Name = "tstbSuche"
        Me.tstbSuche.Size = New System.Drawing.Size(300, 27)
        Me.tstbSuche.Text = "Suchtext für Schnellsuche eingeben"
        '
        'tsbtSchnellsuche
        '
        Me.tsbtSchnellsuche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSchnellsuche.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__106_
        Me.tsbtSchnellsuche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtSchnellsuche.Name = "tsbtSchnellsuche"
        Me.tsbtSchnellsuche.Size = New System.Drawing.Size(24, 24)
        Me.tsbtSchnellsuche.Text = "Schnellsuche"
        '
        'tsbtSchnellHilfeSuche
        '
        Me.tsbtSchnellHilfeSuche.AutoToolTip = False
        Me.tsbtSchnellHilfeSuche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSchnellHilfeSuche.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__10_
        Me.tsbtSchnellHilfeSuche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtSchnellHilfeSuche.Name = "tsbtSchnellHilfeSuche"
        Me.tsbtSchnellHilfeSuche.Size = New System.Drawing.Size(24, 24)
        Me.tsbtSchnellHilfeSuche.Text = "Info"
        Me.tsbtSchnellHilfeSuche.ToolTipText = "Schnell Hilfe für Schnell Suche"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.GreenYellow
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "PDHSoft Cheater 2005"
        '
        'cbSuche
        '
        Me.cbSuche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSuche.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSuche.FormattingEnabled = True
        Me.cbSuche.Items.AddRange(New Object() {"Noch keine Suche Gestartet..."})
        Me.cbSuche.Location = New System.Drawing.Point(166, 63)
        Me.cbSuche.MaxDropDownItems = 15
        Me.cbSuche.Name = "cbSuche"
        Me.cbSuche.Size = New System.Drawing.Size(614, 20)
        Me.cbSuche.TabIndex = 16
        Me.cbSuche.Text = "Klicken Sie hier um ein Suchergebnis auszuwählen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Suchergebnisse:"
        '
        'tbDatum
        '
        Me.tbDatum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDatum.BackColor = System.Drawing.Color.GreenYellow
        Me.tbDatum.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbDatum.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDatum.Location = New System.Drawing.Point(636, 237)
        Me.tbDatum.Name = "tbDatum"
        Me.tbDatum.ReadOnly = True
        Me.tbDatum.ShortcutsEnabled = False
        Me.tbDatum.Size = New System.Drawing.Size(144, 23)
        Me.tbDatum.TabIndex = 76
        Me.tbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCheatText
        '
        Me.lbCheatText.AutoSize = True
        Me.lbCheatText.Location = New System.Drawing.Point(10, 240)
        Me.lbCheatText.Name = "lbCheatText"
        Me.lbCheatText.Size = New System.Drawing.Size(88, 16)
        Me.lbCheatText.TabIndex = 75
        Me.lbCheatText.Text = "Cheat Text:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(550, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Erstellt am:"
        '
        'tbKat
        '
        Me.tbKat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKat.BackColor = System.Drawing.Color.GreenYellow
        Me.tbKat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbKat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKat.Location = New System.Drawing.Point(99, 176)
        Me.tbKat.Name = "tbKat"
        Me.tbKat.ReadOnly = True
        Me.tbKat.Size = New System.Drawing.Size(681, 23)
        Me.tbKat.TabIndex = 73
        '
        'tbSystem
        '
        Me.tbSystem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSystem.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSystem.Location = New System.Drawing.Point(99, 147)
        Me.tbSystem.Name = "tbSystem"
        Me.tbSystem.ReadOnly = True
        Me.tbSystem.Size = New System.Drawing.Size(681, 23)
        Me.tbSystem.TabIndex = 72
        '
        'tbSystemTyp
        '
        Me.tbSystemTyp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSystemTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSystemTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSystemTyp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSystemTyp.Location = New System.Drawing.Point(99, 118)
        Me.tbSystemTyp.Name = "tbSystemTyp"
        Me.tbSystemTyp.ReadOnly = True
        Me.tbSystemTyp.Size = New System.Drawing.Size(681, 23)
        Me.tbSystemTyp.TabIndex = 71
        '
        'tbAuthor
        '
        Me.tbAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAuthor.BackColor = System.Drawing.Color.GreenYellow
        Me.tbAuthor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbAuthor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAuthor.Location = New System.Drawing.Point(99, 205)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.ReadOnly = True
        Me.tbAuthor.Size = New System.Drawing.Size(681, 23)
        Me.tbAuthor.TabIndex = 70
        '
        'tbSpieleTitel
        '
        Me.tbSpieleTitel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSpieleTitel.BackColor = System.Drawing.Color.GreenYellow
        Me.tbSpieleTitel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbSpieleTitel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSpieleTitel.Location = New System.Drawing.Point(99, 89)
        Me.tbSpieleTitel.Name = "tbSpieleTitel"
        Me.tbSpieleTitel.ReadOnly = True
        Me.tbSpieleTitel.Size = New System.Drawing.Size(681, 23)
        Me.tbSpieleTitel.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Author:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Kategorie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "System:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "System Typ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Spiele Titel:"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "PDHSoft Cheater 2005 CheatDatei"
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btSchnellsuche
        '
        Me.btSchnellsuche.Location = New System.Drawing.Point(36, 306)
        Me.btSchnellsuche.Name = "btSchnellsuche"
        Me.btSchnellsuche.Size = New System.Drawing.Size(75, 13)
        Me.btSchnellsuche.TabIndex = 80
        Me.btSchnellsuche.Text = "Schnellsuche"
        Me.btSchnellsuche.Visible = False
        '
        'rtfCheats
        '
        Me.rtfCheats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfCheats.BackColor = System.Drawing.Color.Chartreuse
        Me.rtfCheats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfCheats.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfCheats.Location = New System.Drawing.Point(12, 267)
        Me.rtfCheats.Name = "rtfCheats"
        Me.rtfCheats.ReadOnly = True
        Me.rtfCheats.RichTextShortcutsEnabled = False
        Me.rtfCheats.Size = New System.Drawing.Size(769, 301)
        Me.rtfCheats.TabIndex = 78
        Me.rtfCheats.Text = ""
        '
        'rtfDrucken
        '
        Me.rtfDrucken.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfDrucken.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfDrucken.Location = New System.Drawing.Point(36, 282)
        Me.rtfDrucken.Name = "rtfDrucken"
        Me.rtfDrucken.Size = New System.Drawing.Size(717, 255)
        Me.rtfDrucken.TabIndex = 81
        Me.rtfDrucken.Text = ""
        Me.rtfDrucken.Visible = False
        '
        'tbTyp
        '
        Me.tbTyp.BackColor = System.Drawing.Color.GreenYellow
        Me.tbTyp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbTyp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTyp.Location = New System.Drawing.Point(487, 237)
        Me.tbTyp.Name = "tbTyp"
        Me.tbTyp.ReadOnly = True
        Me.tbTyp.ShortcutsEnabled = False
        Me.tbTyp.Size = New System.Drawing.Size(57, 23)
        Me.tbTyp.TabIndex = 93
        Me.tbTyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbTyp.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(415, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Dateityp:"
        Me.Label10.Visible = False
        '
        'pbPicture
        '
        Me.pbPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPicture.BackColor = System.Drawing.Color.GreenYellow
        Me.pbPicture.ContextMenuStrip = Me.cmsGrafik
        Me.pbPicture.Location = New System.Drawing.Point(12, 267)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(768, 301)
        Me.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPicture.TabIndex = 95
        Me.pbPicture.TabStop = False
        '
        'cmsGrafik
        '
        Me.cmsGrafik.BackColor = System.Drawing.Color.GreenYellow
        Me.cmsGrafik.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeichernUnterGrafik, Me.tsmiDrucken})
        Me.cmsGrafik.Name = "cmsGrafik"
        Me.cmsGrafik.Size = New System.Drawing.Size(174, 48)
        '
        'tsmiSpeichernUnterGrafik
        '
        Me.tsmiSpeichernUnterGrafik.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__176_
        Me.tsmiSpeichernUnterGrafik.Name = "tsmiSpeichernUnterGrafik"
        Me.tsmiSpeichernUnterGrafik.Size = New System.Drawing.Size(173, 22)
        Me.tsmiSpeichernUnterGrafik.Text = "Speichern unter..."
        Me.tsmiSpeichernUnterGrafik.ToolTipText = "Grafik in einem anderen Ordner Speichern..."
        '
        'tsmiDrucken
        '
        Me.tsmiDrucken.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__54_
        Me.tsmiDrucken.Name = "tsmiDrucken"
        Me.tsmiDrucken.Size = New System.Drawing.Size(173, 22)
        Me.tsmiDrucken.Text = "Drucken..."
        Me.tsmiDrucken.ToolTipText = "Grafik ausdrucken..."
        '
        'tbDatei
        '
        Me.tbDatei.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDatei.Location = New System.Drawing.Point(90, 306)
        Me.tbDatei.Name = "tbDatei"
        Me.tbDatei.Size = New System.Drawing.Size(650, 23)
        Me.tbDatei.TabIndex = 99
        Me.tbDatei.Visible = False
        '
        'sfdGrafik
        '
        '
        'sfdProg
        '
        '
        'cmsProgs
        '
        Me.cmsProgs.BackColor = System.Drawing.Color.GreenYellow
        Me.cmsProgs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAusführen, Me.tsmiOeffnen, Me.tsmiEntpacken, Me.tsmiSpeichernUnterProg})
        Me.cmsProgs.Name = "cmsProgs"
        Me.cmsProgs.Size = New System.Drawing.Size(174, 92)
        '
        'tsmiAusführen
        '
        Me.tsmiAusführen.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__140_
        Me.tsmiAusführen.Name = "tsmiAusführen"
        Me.tsmiAusführen.Size = New System.Drawing.Size(173, 22)
        Me.tsmiAusführen.Text = "Ausführen..."
        '
        'tsmiOeffnen
        '
        Me.tsmiOeffnen.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__167_
        Me.tsmiOeffnen.Name = "tsmiOeffnen"
        Me.tsmiOeffnen.Size = New System.Drawing.Size(173, 22)
        Me.tsmiOeffnen.Text = "Öffnen..."
        '
        'tsmiEntpacken
        '
        Me.tsmiEntpacken.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__153_
        Me.tsmiEntpacken.Name = "tsmiEntpacken"
        Me.tsmiEntpacken.Size = New System.Drawing.Size(173, 22)
        Me.tsmiEntpacken.Text = "Entpacken..."
        '
        'tsmiSpeichernUnterProg
        '
        Me.tsmiSpeichernUnterProg.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__176_
        Me.tsmiSpeichernUnterProg.Name = "tsmiSpeichernUnterProg"
        Me.tsmiSpeichernUnterProg.Size = New System.Drawing.Size(173, 22)
        Me.tsmiSpeichernUnterProg.Text = "Speichern unter..."
        '
        'pProg
        '
        Me.pProg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pProg.ContextMenuStrip = Me.cmsProgs
        Me.pProg.Controls.Add(Me.Label8)
        Me.pProg.Controls.Add(Me.tbProg)
        Me.pProg.Controls.Add(Me.wbPicture)
        Me.pProg.Controls.Add(Me.Label9)
        Me.pProg.Location = New System.Drawing.Point(12, 266)
        Me.pProg.Name = "pProg"
        Me.pProg.Size = New System.Drawing.Size(768, 308)
        Me.pProg.TabIndex = 100
        Me.pProg.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(74, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(618, 29)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Wählen Sie oben eine Datei und klicken Sie anschließend unten mit der rechten Mau" & _
            "staste auf das abgesetzte Feld um weitere Funktionen zu dem Dateityp zu erhalten" & _
            "."
        '
        'tbProg
        '
        Me.tbProg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbProg.BackColor = System.Drawing.Color.Chartreuse
        Me.tbProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbProg.ContextMenuStrip = Me.cmsProgs
        Me.tbProg.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbProg.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProg.Location = New System.Drawing.Point(2, 48)
        Me.tbProg.Multiline = True
        Me.tbProg.Name = "tbProg"
        Me.tbProg.ReadOnly = True
        Me.tbProg.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbProg.Size = New System.Drawing.Size(766, 33)
        Me.tbProg.TabIndex = 102
        '
        'wbPicture
        '
        Me.wbPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbPicture.Location = New System.Drawing.Point(2, 162)
        Me.wbPicture.Name = "wbPicture"
        Me.wbPicture.Size = New System.Drawing.Size(766, 140)
        Me.wbPicture.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(0, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(765, 75)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Cheater_2005.Settings.Default.DefaultBackCOlor
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.rtfCheats)
        Me.Controls.Add(Me.tbTyp)
        Me.Controls.Add(Me.tbDatum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbCheatText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbKat)
        Me.Controls.Add(Me.tbSystem)
        Me.Controls.Add(Me.tbSystemTyp)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbSpieleTitel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSuche)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pbPicture)
        Me.Controls.Add(Me.rtfDrucken)
        Me.Controls.Add(Me.btSchnellsuche)
        Me.Controls.Add(Me.tbDatei)
        Me.Controls.Add(Me.pProg)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Cheater_2005.Settings.Default, "DefaultBackCOlor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft Cheater 2005 - OpenSource Edition"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGrafik.ResumeLayout(False)
        Me.cmsProgs.ResumeLayout(False)
        Me.pProg.ResumeLayout(False)
        Me.pProg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllesMakierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbSuche As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbDatum As System.Windows.Forms.TextBox
    Friend WithEvents lbCheatText As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbKat As System.Windows.Forms.TextBox
    Friend WithEvents tbSystem As System.Windows.Forms.TextBox
    Friend WithEvents tbSystemTyp As System.Windows.Forms.TextBox
    Friend WithEvents tbAuthor As System.Windows.Forms.TextBox
    Friend WithEvents tbSpieleTitel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstbSuche As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btSchnellsuche As System.Windows.Forms.Button
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiConvert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheatSuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheatSchnellsucheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeiteEinrichtenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruckVorschauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchnellHilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addCHeatToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbConvert As System.Windows.Forms.ToolStripButton
    Friend WithEvents DruckenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheatSuchenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtSchnellsuche As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtSchnellHilfeSuche As System.Windows.Forms.ToolStripButton
    Friend WithEvents rtfCheats As RichTextBoxEx
    Friend WithEvents rtfDrucken As RichTextBoxEx
    Friend WithEvents tbTyp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pbPicture As System.Windows.Forms.PictureBox
    Friend WithEvents tbDatei As System.Windows.Forms.TextBox
    Friend WithEvents sfdGrafik As System.Windows.Forms.SaveFileDialog
    Friend WithEvents sfdProg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmsGrafik As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiSpeichernUnterGrafik As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDrucken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProgs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAusführen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOeffnen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEntpacken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSpeichernUnterProg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pProg As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbProg As System.Windows.Forms.TextBox
    Friend WithEvents wbPicture As System.Windows.Forms.WebBrowser
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
