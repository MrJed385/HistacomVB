﻿Public Class windowsvista
    Dim countdown As Integer
    Dim ampm As String
    Dim count As Integer
    Dim txtcount As Integer
    Dim usersave As String

    Private Sub startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        startmenu.Show()
    End Sub

    Private Sub windows98_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        startmenu.Hide()
    End Sub

    Private Sub vistaLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Resources.Windows_XP_Startup.CanRead Then
            Dim bStr(My.Resources.Windows_XP_Startup.Length) As Byte
            My.Resources.Windows_XP_Startup.Read(bStr, 0, My.Resources.Windows_XP_Startup.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
        startmenu.Hide()

        Timer1.Start()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Dim w, h As Integer
        w = Me.desktopicons.Width
        h = Me.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Me.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Me.BackgroundImage = bmp
        Me.desktopicons.BackgroundImage = bmp
        System.Windows.Forms.Application.VisualStyleState = VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled
        System.Windows.Forms.Application.EnableVisualStyles()
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opennotepad As New notepad
        opennotepad.Show()
        startmenu.Hide()
    End Sub

    Private Sub desktopicons_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles desktopicons.DoubleClick
        Dim objDrawingPoint As Drawing.Point
        Dim objListViewItem As ListViewItem

        objDrawingPoint = desktopicons.PointToClient(Cursor.Position)

        If Not IsNothing(objDrawingPoint) Then
            With objDrawingPoint
                objListViewItem = desktopicons.GetItemAt(.X, .Y)
            End With

            If Not IsNothing(objListViewItem) Then
                If objListViewItem.Text = "Internet Explorer" Then
                    Dim openinternet As New internet_explorer_5
                    openinternet.Show()
                End If
                If objListViewItem.Text = "Guess The Number 2 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Guess The Number 2"
                    openinstall.installimage.Image = My.Resources.Guess_the_Number__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Start Runner 98 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Start Runner 98"
                    openinstall.installimage.Image = My.Resources.start_run__install___white_with_programname_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Error Blaster 98 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Error Blaster 98"
                    openinstall.installimage.Image = My.Resources.error_blast__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Skindows 95 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Skindows 95"
                    openinstall.installimage.Image = My.Resources.skindows_95
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Web Chat Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Web Chat"
                    openinstall.installimage.Image = My.Resources.chat_big
                    openinstall.Show()
                End If
                If objListViewItem.Text = "hwcv.exe" Then
                    Dim openhwcv As New hwcv
                    openhwcv.Show()
                End If
                If objListViewItem.Text = "Time Distorter 0.3 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Time Distorter 0.3"
                    openinstall.installimage.Image = My.Resources.time_distorter__install_Black_
                    openinstall.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Desktop_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            rightclickbackproperties.Show()
            rightclickbackproperties.BringToFront()
            rightclickbackproperties.Location = MousePosition
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton.Click
        startmenu.Show()
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Dim oform As New formDisplayproperties
        oform.Show()
        startmenu.Hide()
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openinternetexplorer As New internet_explorer_5
        openinternetexplorer.Show()
        startmenu.Hide()
    End Sub

    Private Sub FolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderToolStripMenuItem.Click
        desktopicons.Items.Add("New Folder")
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desktopicons.MouseDown
        startmenu.Hide()
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseDown

    End Sub

    Private Sub turnoffcomputerbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turnoffcomputerbutton.Click
        Title_Screen.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Hour(Now) > 12 Then
            ampm = "PM"
        Else
            ampm = "AM"
        End If
        taskbartime.Text = Format(Now, "hh:mm") & " " & ampm
    End Sub

    Private Sub NotepadToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opennotepad As New notepad
        opennotepad.Show()
        startmenu.Hide()
    End Sub

    Private Sub InternetExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetExplorerToolStripMenuItem.Click
        Dim openinternet As New Internetexplorer62002damaged
        openinternet.Show()
        startmenu.Hide()
    End Sub

    Private Sub TimeDistorter03ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim timedistorter03 As New timedistorter032002xp
        timedistorter03.Show()
        startmenu.Hide()
    End Sub

    Private Sub taskbartime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click
        MsgBox("your savecode is: vistatest")
    End Sub

    Private Sub desktopicons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles desktopicons.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub startmenuitems_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles startmenuitems.ItemClicked

    End Sub
End Class