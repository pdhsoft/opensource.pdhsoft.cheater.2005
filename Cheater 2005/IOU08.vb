Public Class IOU08

    Public procID As Integer
    Public Function IUO_2008()

        ' Für den IOU 2008
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\PDHSoft\OnlineUpdater6\PDHSoftOnlineUpdater6.exe") Then
            My.Forms.tsmiOnlineUpdate.Enabled = False
            My.Forms.tsmiUpdateOptions.Enabled = False
            If Not My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\DontUseUpdater") Then
                Dim MsgResult As MsgBoxResult
                MsgResult = MsgBox("Der PDHSoft Intelligent OnlineUpdater 2008 v 6.0 ist nicht Installiert!" & vbCr & "Dieser wird benötigt um Programm Updates herunterladen zu können." & vbCr & "Wollen Sie ihn herunterladen und installieren?", MsgBoxStyle.YesNo, My.Application.Info.Title)

                If MsgResult = MsgBoxResult.Yes Then
                    Process.Start("http://www.PDHSoft.de/?Seite=downloads&Out=0&Lang=DE&LinkTitel=PDHSoft Intelligent OnlineUpdater 2008 v 6.0 Download&DownloadStart=1&DLID=34")
                Else
                    My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath & "\DontUseUpdater", True)
                End If
            End If
        Else
            My.Forms.tsmiOnlineUpdate.Enabled = True
            My.Forms.tsmiUpdateOptions.Enabled = True
            procID = Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\PDHSoft\OnlineUpdater6\ProgrammAdd.exe /a 38 " & My.Application.Info.Version.ToString & " deutsch 25 """ & My.Application.Info.Title & """ """ & My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe""", AppWinStyle.NormalFocus, True)
        End If
    End Function

End Class
