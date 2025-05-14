Public Class MarbelTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql As String = "INSERT INTO [MarbleTable] ([BodyName],[Hight],[Wide],[Model],[Color],[Price],[Note])
            values (@BodyName,@Hight,@Wide,@Model,@Color,@Price,@Note)"
        Dim para1 As New Dictionary(Of String, Object) From {
            {"@BodyName", Trim(TextBox1.Text)},
            {"@Hight", Trim(TextBox2.Text)},
            {"@Wide", Trim(TextBox2.Text)},
            {"@Model", Trim(TextBox3.Text)},
            {"@Color", Trim(TextBox4.Text)},
            {"@Price", Val(TextBox5.Text)},
            {"@Note", Trim(TextBox6.Text)}
        }
        ExecuteSQL(sql, para1)

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        LoadBodykitchen()

    End Sub
End Class