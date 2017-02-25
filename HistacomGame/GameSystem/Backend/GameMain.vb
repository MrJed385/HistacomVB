﻿Public Class GameMain
    Public Shared guessInstalled As Boolean
    Public Shared webChatInstalled As Boolean

    Public Shared Sub saveGame()

    End Sub
    Public Shared Sub OpenInstaller(ByVal toInstall As String, ByVal img As Image, ByVal license As String, ByVal progName As String, ByVal dwnSize As Integer)
        Dim Install As New NewInstaller
        Install.apptoinstall = toInstall
        Install.sideimg.Image = img
        Install.txtlicense.Text = license
        Install.Label3.Text = "You are currently installing: " & vbCrLf & progName
        Install.dwnSize = dwnSize
        Install.Progress.Maximum = dwnSize
        Install.Show()
    End Sub

    Public Shared Sub AddApp(ByVal appID As String)
        Select Case appID
            Case "guessNum"
                guessInstalled = True
                Windows95.GuessTheNumberToolStripMenuItem.Visible = True
                Windows98.GuessTheNumberToolStripMenuItem.Visible = True
                Windows2000.GuessTheNumberToolStripMenuItem.Visible = True
                Windows95.pnlGuess.Show()
            Case "webChat"
                webChatInstalled = True
                Windows95.WebChatToolStripMenuItem.Visible = True
                Windows98.WebChatToolStripMenuItem.Visible = True
                Windows2000.WebChatToolStripMenuItem.Visible = True
                Windows95.pnlWeb.Show()
        End Select
    End Sub

    Public Shared Sub OpenMsg(ByVal message As String)
        Dim msg As New createmsg
        msg.infomessage.Text = message
        msg.ShowDialog()
    End Sub
End Class
