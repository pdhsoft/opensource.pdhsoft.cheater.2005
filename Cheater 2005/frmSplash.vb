Public Class frmSplash

    
    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbVersion.Text = "Version: " & My.Application.Info.Version.ToString

    End Sub
End Class
