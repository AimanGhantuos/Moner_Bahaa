Public Class Form9
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form8.SelectedPic = 2
        Form8.WidthVAL = 400
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form8.SelectedPic = 3
        Form8.WidthVAL = 300
        Me.Close()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form8.SelectedPic = 5
        Form8.WidthVAL = 300
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form8.SelectedPic = 6
        Form8.WidthVAL = 400
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form8.SelectedPic = 7
        Form8.WidthVAL = 300
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form8.SelectedPic = 3
        If RadioButton1.Checked = True Then
            Form8.WidthVAL = 300
        ElseIf RadioButton2.Checked = True Then
            Form8.WidthVAL = 400
        End If

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form8.SelectedPic = 1
        Form8.WidthVAL = 500
        Me.Close()

    End Sub
End Class