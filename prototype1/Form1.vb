Public Class Form1
    Private Sub picbuttonmenu_Click(sender As Object, e As EventArgs) Handles picbuttonmenu.Click
        If picbuttonmenu.Location.X = 128 Then
            Timer1menuhide.Start()
        Else
            Timer2menushow.Start()
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1menuhide.Tick
        menupanel.Location = New Point(menupanel.Location.X - 2, menupanel.Location.Y)
        picbuttonmenu.Location = New Point(picbuttonmenu.Location.X - 2, picbuttonmenu.Location.Y)
        While picbuttonmenu.Location.X = 0
            Timer1menuhide.Stop()
            Exit While
        End While
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2menushow.Tick
        menupanel.Location = New Point(menupanel.Location.X + 2, menupanel.Location.Y)
        picbuttonmenu.Location = New Point(picbuttonmenu.Location.X + 2, picbuttonmenu.Location.Y)
        While picbuttonmenu.Location.X = 128
            Timer2menushow.Stop()
            Exit While
        End While
    End Sub
End Class
