Partial Public Class frmDataUpdate
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataUpdate))
        Me.pgbStatus = New System.Windows.Forms.ProgressBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtProtokoll = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNeu1 = New System.Windows.Forms.Label
        Me.lbltodo = New System.Windows.Forms.Label
        Me.lblAktuell = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.red = New System.Windows.Forms.PictureBox
        Me.yellow = New System.Windows.Forms.PictureBox
        Me.green = New System.Windows.Forms.PictureBox
        Me.webupdate = New System.Windows.Forms.WebBrowser
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdInfo = New System.Windows.Forms.Button
        Me.cmdSuchen = New System.Windows.Forms.Button
        Me.cmdDownload = New System.Windows.Forms.Button
        Me.cmdAbbrechen = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgbStatus
        '
        Me.pgbStatus.Location = New System.Drawing.Point(13, 203)
        Me.pgbStatus.Name = "pgbStatus"
        Me.pgbStatus.Size = New System.Drawing.Size(390, 12)
        Me.pgbStatus.Step = 1
        Me.pgbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbStatus.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.pgbStatus, "Zeigt den such Prozess an...")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProtokoll)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 77)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Protokoll..."
        '
        'txtProtokoll
        '
        Me.txtProtokoll.BackColor = System.Drawing.Color.White
        Me.txtProtokoll.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtProtokoll.ForeColor = System.Drawing.Color.Black
        Me.txtProtokoll.Location = New System.Drawing.Point(7, 19)
        Me.txtProtokoll.Multiline = True
        Me.txtProtokoll.Name = "txtProtokoll"
        Me.txtProtokoll.ReadOnly = True
        Me.txtProtokoll.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtProtokoll.ShortcutsEnabled = False
        Me.txtProtokoll.Size = New System.Drawing.Size(376, 52)
        Me.txtProtokoll.TabIndex = 0
        Me.txtProtokoll.TabStop = False
        Me.ToolTip.SetToolTip(Me.txtProtokoll, "Hier wird der Protokoltext angezeigt...")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNeu1)
        Me.GroupBox2.Controls.Add(Me.lbltodo)
        Me.GroupBox2.Controls.Add(Me.lblAktuell)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 87)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Programm und Update info..."
        '
        'lblNeu1
        '
        Me.lblNeu1.AutoSize = True
        Me.lblNeu1.Location = New System.Drawing.Point(162, 41)
        Me.lblNeu1.Name = "lblNeu1"
        Me.lblNeu1.Size = New System.Drawing.Size(0, 13)
        Me.lblNeu1.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.lblNeu1, "Updateversion...")
        '
        'lbltodo
        '
        Me.lbltodo.AutoSize = True
        Me.lbltodo.ForeColor = System.Drawing.Color.Black
        Me.lbltodo.Location = New System.Drawing.Point(58, 61)
        Me.lbltodo.Name = "lbltodo"
        Me.lbltodo.Size = New System.Drawing.Size(56, 13)
        Me.lbltodo.TabIndex = 8
        Me.lbltodo.Text = "Was nun?"
        '
        'lblAktuell
        '
        Me.lblAktuell.AutoSize = True
        Me.lblAktuell.Location = New System.Drawing.Point(167, 20)
        Me.lblAktuell.Name = "lblAktuell"
        Me.lblAktuell.Size = New System.Drawing.Size(0, 13)
        Me.lblAktuell.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.lblAktuell, "Ihre Programmversion...")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(58, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Updateversion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Installierte Datenbank:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GreenYellow
        Me.GroupBox3.Controls.Add(Me.red)
        Me.GroupBox3.Controls.Add(Me.yellow)
        Me.GroupBox3.Controls.Add(Me.green)
        Me.GroupBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(30, 69)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'red
        '
        Me.red.BackColor = System.Drawing.Color.DarkRed
        Me.red.Location = New System.Drawing.Point(7, 10)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(16, 14)
        Me.red.TabIndex = 5
        Me.red.TabStop = False
        Me.ToolTip.SetToolTip(Me.red, "Neues Update vorhanden...")
        '
        'yellow
        '
        Me.yellow.BackColor = System.Drawing.Color.Yellow
        Me.yellow.Location = New System.Drawing.Point(7, 28)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(16, 14)
        Me.yellow.TabIndex = 4
        Me.yellow.TabStop = False
        Me.ToolTip.SetToolTip(Me.yellow, "Wartet / Fehler...")
        '
        'green
        '
        Me.green.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.green.Location = New System.Drawing.Point(7, 49)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(16, 14)
        Me.green.TabIndex = 3
        Me.green.TabStop = False
        Me.ToolTip.SetToolTip(Me.green, "Sie haben die Aktuellste Version...")
        '
        'webupdate
        '
        Me.webupdate.Location = New System.Drawing.Point(41, 88)
        Me.webupdate.Name = "webupdate"
        Me.webupdate.Size = New System.Drawing.Size(168, 75)
        Me.webupdate.TabIndex = 9
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 10000
        Me.ToolTip.BackColor = System.Drawing.Color.White
        Me.ToolTip.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "PDHSoft OnlineUpdater 2005"
        '
        'cmdInfo
        '
        Me.cmdInfo.BackColor = System.Drawing.Color.Transparent
        Me.cmdInfo.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__10_
        Me.cmdInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInfo.Location = New System.Drawing.Point(13, 222)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(54, 23)
        Me.cmdInfo.TabIndex = 8
        Me.cmdInfo.Text = "Info"
        Me.cmdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.cmdInfo, "OnlineUpdater Hilfe...")
        Me.cmdInfo.UseVisualStyleBackColor = False
        '
        'cmdSuchen
        '
        Me.cmdSuchen.AutoSize = True
        Me.cmdSuchen.BackColor = System.Drawing.Color.Transparent
        Me.cmdSuchen.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__239_
        Me.cmdSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSuchen.Location = New System.Drawing.Point(71, 222)
        Me.cmdSuchen.Name = "cmdSuchen"
        Me.cmdSuchen.Size = New System.Drawing.Size(103, 23)
        Me.cmdSuchen.TabIndex = 2
        Me.cmdSuchen.Text = "Update suchen"
        Me.cmdSuchen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.cmdSuchen, "Update suchen...")
        Me.cmdSuchen.UseVisualStyleBackColor = False
        '
        'cmdDownload
        '
        Me.cmdDownload.AutoSize = True
        Me.cmdDownload.BackColor = System.Drawing.Color.Transparent
        Me.cmdDownload.Enabled = False
        Me.cmdDownload.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__113_
        Me.cmdDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDownload.Location = New System.Drawing.Point(181, 222)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(134, 23)
        Me.cmdDownload.TabIndex = 1
        Me.cmdDownload.Text = "Update herunterladen"
        Me.cmdDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.cmdDownload, "Update Herunterladen...")
        Me.cmdDownload.UseVisualStyleBackColor = False
        '
        'cmdAbbrechen
        '
        Me.cmdAbbrechen.AutoSize = True
        Me.cmdAbbrechen.BackColor = System.Drawing.Color.Transparent
        Me.cmdAbbrechen.Image = Global.Cheater_2005.My.Resources.Resources.Icons_16_8__152_
        Me.cmdAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbbrechen.Location = New System.Drawing.Point(322, 222)
        Me.cmdAbbrechen.Name = "cmdAbbrechen"
        Me.cmdAbbrechen.Size = New System.Drawing.Size(81, 23)
        Me.cmdAbbrechen.TabIndex = 0
        Me.cmdAbbrechen.Text = "Abbrechen"
        Me.cmdAbbrechen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.cmdAbbrechen, "Abbrechen / Fenster schließen...")
        Me.cmdAbbrechen.UseVisualStyleBackColor = False
        '
        'frmDataUpdate
        '
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(417, 255)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pgbStatus)
        Me.Controls.Add(Me.cmdSuchen)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.cmdAbbrechen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.webupdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(423, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(423, 280)
        Me.Name = "frmDataUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDHSoft OnlineUpdater 2005 | Online Update..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAktuell As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents webupdate As System.Windows.Forms.WebBrowser
    Friend WithEvents lbltodo As System.Windows.Forms.Label
    Friend WithEvents lblNeu1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txtProtokoll As System.Windows.Forms.TextBox
    Friend WithEvents red As System.Windows.Forms.PictureBox
    Friend WithEvents yellow As System.Windows.Forms.PictureBox
    Friend WithEvents green As System.Windows.Forms.PictureBox
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents cmdSuchen As System.Windows.Forms.Button
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents cmdAbbrechen As System.Windows.Forms.Button
End Class
