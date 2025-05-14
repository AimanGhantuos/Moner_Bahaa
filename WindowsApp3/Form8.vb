Public Class Form8

    Public WidthVAL As Integer = 0
    Public SelectedPic As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim count As Integer = CInt(InputBox("כמות יחידות מטבח"))

        Dim currentLeft As Integer = 20 ' Starting position from the left
        Dim totalWidth As Integer = 0 ' To calculate total width for the combined image
        Dim maxHeight As Integer = 0 ' To track the maximum height of all PictureBoxes

        ' Store all PictureBoxes for later use
        Dim pictureBoxes As New List(Of PictureBox)()

        ' Loop to create PictureBoxes
        For i As Integer = 1 To count
            ' Show Form9 to let the user select a picture
            Form9.ShowDialog()

            ' Set width and height for each PictureBox
            Dim width As Integer = CInt(WidthVAL)
            Dim height As Integer = 400 ' Fixed height for all PictureBoxes

            ' Create a new PictureBox
            Dim pb As New PictureBox()
            pb.Width = width
            pb.Height = height
            pb.BorderStyle = BorderStyle.FixedSingle
            pb.BackColor = Color.DarkGray
            pb.SizeMode = PictureBoxSizeMode.StretchImage ' Resize the image to fit the PictureBox

            ' Set the position of the PictureBox
            pb.Left = currentLeft
            pb.Top = 50 ' Place it near the top
            currentLeft += width ' Move to the next position for the next PictureBox

            ' Assign the image based on the selected value from Form9
            Select Case SelectedPic
                Case 1
                    pb.Image = Form9.PictureBox1.Image
                Case 2
                    pb.Image = Form9.PictureBox2.Image
                Case 3
                    pb.Image = Form9.PictureBox3.Image
                Case 4
                    pb.Image = Form9.PictureBox4.Image
                Case 5
                    pb.Image = Form9.PictureBox5.Image
                Case 6
                    pb.Image = Form9.PictureBox6.Image
                Case 7
                    pb.Image = Form9.PictureBox7.Image
            End Select

            ' Add the new PictureBox to the form
            Me.Controls.Add(pb)

            ' Add PictureBox to the list for later image combination
            pictureBoxes.Add(pb)

            ' Update the total width and max height for the combined image
            totalWidth += pb.Width
            maxHeight = Math.Max(maxHeight, pb.Height)
        Next

        ' Create a Bitmap large enough to hold all images
        Dim combinedImage As New Bitmap(totalWidth, maxHeight)

        ' Create a Graphics object to draw on the Bitmap
        Using g As Graphics = Graphics.FromImage(combinedImage)
            g.Clear(Color.White) ' Set the background color to white

            ' Draw each PictureBox's image onto the Bitmap
            Dim currentX As Integer = 0 ' Starting x position to draw images
            For Each pb As PictureBox In pictureBoxes
                If pb.Image IsNot Nothing Then
                    g.DrawImage(pb.Image, currentX, 0, pb.Width, pb.Height)
                    currentX += pb.Width ' Move to the next position
                End If
            Next
        End Using

        ' Save the combined image to a file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp"
        saveFileDialog.Title = "Save Combined Image"

        'If saveFileDialog.ShowDialog() = DialogResult.OK Then
        '    combinedImage.Save(saveFileDialog.FileName) ' Save the combined image
        '    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        PictureBox1.Image = combinedImage

    End Sub


End Class