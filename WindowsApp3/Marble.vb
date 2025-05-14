Public Class Marble
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql As String = "INSERT INTO [Marble] ([MarbleName],[Size],[Model],[Color],[Price],[Note])
            values (@MarbleName,@Size,@Model,@Color,@Price,@Note)"
        Dim para1 As New Dictionary(Of String, Object) From {
            {"@MarbleName", Trim(TextBox1.Text)},
            {"@Size", Trim(TextBox2.Text)},
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

        LoadMarble()

    End Sub



    Private Sub LoadMarble()


        Dim LoadProduct As New DataSet
        LoadDataSQL("SELECT [ProductId]
      ,[MarbleName]
      ,[Size]
      ,[Model]
      ,[Color]
      ,[Price]
      ,[Note]
         FROM [Moner_Bahaa].[dbo].[Marble]", LoadProduct)
        DataGridView1.DataSource = LoadProduct.Tables(0)

        DataGridView1.ClearSelection()

    End Sub

    Private Sub Marble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMarble()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ExecuteSqlStmtSQL("DELETE FROM [dbo].[Marble] WHERE [ProductId]=" & Val(DataGridView1.SelectedRows(0).Cells("ProductId").Value))

        LoadMarble()

    End Sub

End Class