Public Class Quotation
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button2.Enabled = False
        DateTimePicker1.Enabled = False

        Dim sql As String = "INSERT INTO [QuotationHistory] ([AccountNum],[QuotationDate],[Status]) values (@AccountNum,@QuotationDate,@Status)"
        Dim para1 As New Dictionary(Of String, Object) From {
            {"@AccountNum", Val(Label8.Text)},
            {"@QuotationDate", CDate(DateTimePicker1.Value)},
            {"@Status", 1}
        }
        ExecuteSQL(sql, para1)

        Dim Get_QuotationHistory_Num As New DataSet
        LoadDataSQL("SELECT MAX([QuotationNum]) AS QuotationNum FROM [QuotationHistory]", Get_QuotationHistory_Num)
        If Get_QuotationHistory_Num.Tables(0).Rows.Count > 0 Then
            Label2.Text = Val(Get_QuotationHistory_Num.Tables(0).Rows(0)(0).ToString)
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Button5.Text = "עדכן פריט" Then


            Dim sql2 As String = "Update [Quotation] SET 
[ProductName]=@ProductName,
[Size]=@Size,
[Model]=@Model,
[Color]=@Color,
[OriginalPrice]=@OriginalPrice,
[DiscountPrice]=@DiscountPrice,
[Note]=@Note,
[Type]=@Type
Where [LineID]=@LineID"
            Dim para12 As New Dictionary(Of String, Object) From {
            {"@ProductName", Trim(TextBox1.Text)},
            {"@Size", Trim(TextBox2.Text)},
            {"@Model", Trim(TextBox3.Text)},
            {"@Color", Trim(TextBox4.Text)},
            {"@OriginalPrice", Val(TextBox5.Text)},
            {"@DiscountPrice", Val(TextBox8.Text)},
            {"@Note", Trim(TextBox6.Text)},
            {"@Type", Trim(TextBox7.Text)},
            {"@LineID", Val(Label16.Text)}
        }
            ExecuteSQL(sql2, para12)

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""



            '---- Load 
            Dim REQuotationInfo As New DataSet
            LoadDataSQL($"SELECT [QuotationNum]
      ,[ProductName]
      ,[Size]
      ,[Model]
      ,[Color]
      ,[OriginalPrice]
      ,[DiscountPrice]
      ,[Note]
      ,[Type]
      ,[LineID]
       FROM [Quotation] Where [QuotationNum]={Val(AccountCard.DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", REQuotationInfo)

            AccountCard.DataGridView2.DataSource = REQuotationInfo.Tables(0)


            Dim REToTal As New DataSet
            LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [QuotationNum]={Val(AccountCard.DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", REToTal)
            AccountCard.Label8.Text = REToTal.Tables(0).Rows(0)(0).ToString


            Dim REQuotationImage As New DataSet
            LoadDataSQL($"SELECT [Image] FROM [QuotationHistory] WHERE [QuotationNum]={Val(AccountCard.DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", REQuotationImage)

            If REQuotationImage.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(REQuotationImage.Tables(0).Rows(0)(0)) Then
                Dim ImageByteArray As Byte() = CType(REQuotationImage.Tables(0).Rows(0)(0), Byte())
                Using ImageMemoryStream As New IO.MemoryStream(ImageByteArray)
                    AccountCard.PictureBox1.Image = Image.FromStream(ImageMemoryStream)
                End Using
            Else
                AccountCard.PictureBox1.Image = Nothing
            End If

            Me.Close()

            Exit Sub


        End If


        If Val(Label2.Text) = 0 Then
            MsgBox("משתמש נא לפתוח הצעה חדשה קודם", MsgBoxStyle.Critical, "שגיאת שימוש")
            Exit Sub
        End If


        If TextBox8.Text = "" Then
            MsgBox("משתמש נא נא להזין מחיר אחרי הנחה", MsgBoxStyle.Critical, "שגיאת שימוש")
            Exit Sub
        End If


        Dim sql As String = "INSERT INTO [Quotation] ([QuotationNum],[ProductName],[Size],[Model],[Color],[OriginalPrice],[DiscountPrice],[Note],[Type]) 
        Values (@QuotationNum,@ProductName,@Size,@Model,@Color,@OriginalPrice,@DiscountPrice,@Note,@Type)"
        Dim para1 As New Dictionary(Of String, Object) From {
            {"@QuotationNum", Val(Label2.Text)},
            {"@ProductName", Trim(TextBox1.Text)},
            {"@Size", Trim(TextBox2.Text)},
            {"@Model", Trim(TextBox3.Text)},
            {"@Color", Trim(TextBox4.Text)},
            {"@OriginalPrice", Val(TextBox5.Text)},
            {"@DiscountPrice", Val(TextBox8.Text)},
            {"@Note", Trim(TextBox6.Text)},
            {"@Type", Trim(TextBox7.Text)}
        }
        ExecuteSQL(sql, para1)


        Dim QuotationInfo As New DataSet
        LoadDataSQL($"SELECT [QuotationNum]
      ,[ProductName]
      ,[Size]
      ,[Model]
      ,[Color]
      ,[OriginalPrice]
      ,[DiscountPrice]
      ,[Note]
      ,[Type]
      ,[LineID]
       FROM [Quotation] Where [QuotationNum]={Val(Label2.Text)}", QuotationInfo)

        DataGridView1.DataSource = QuotationInfo.Tables(0)


        Dim ToTal As New DataSet
        LoadDataSQL($"Select SUM([DiscountPrice]) FROM [Quotation] Where [QuotationNum]={Val(Label2.Text)}", ToTal)
        Label13.Text = ToTal.Tables(0).Rows(0)(0).ToString

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = AccountCard.Label5.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim LoadProduct As New DataSet
        LoadDataSQL("SELECT [ProductId]
      ,[BodyName]
      ,[Size]
      ,[Model]
      ,[Color]
      ,[Price]
      ,[Note]
        FROM [Moner_Bahaa].[dbo].[Bodykitchen]", LoadProduct)

        Form1.DataGridView1.DataSource = LoadProduct.Tables(0)
        Form1.DataGridView1.ClearSelection()
        Form1.Show()

        Form1.ValClick = 1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim LoadProduct As New DataSet
        LoadDataSQL("SELECT [ProductId]
      ,[ProductName]
      ,[Size]
      ,[Model]
      ,[Color]
      ,[Price]
      ,[Note]
      FROM [Moner_Bahaa].[dbo].[ProductTable]", LoadProduct)

        Form1.DataGridView1.DataSource = LoadProduct.Tables(0)
        Form1.DataGridView1.ClearSelection()
        Form1.Show()

        Form1.ValClick = 2

    End Sub



    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick

        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.Title = "נא לבחור מיקום תומנה"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName = Nothing Then
        Else


            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName.ToString)

            Dim UserDS5 As New DataSet
            LoadDataSQL($"SELECT * FROM QuotationHistory Where [QuotationNum]={Val(Label2.Text)}", UserDS5)

            If UserDS5.Tables(0).Rows.Count <> 0 Then


                ' READING PICTURE
                Dim ms As New System.IO.MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim byt() As Byte = ms.ToArray


                Dim sql As String = $"Update QuotationHistory Set [Image] = @A1 Where [QuotationNum]={Val(Label2.Text)}"
                Dim para1 As New Dictionary(Of String, Object)
                para1.Add("@A1", byt)
                ExecuteSQL(sql, para1)

            Else

                ' READING PICTURE
                Dim ms As New System.IO.MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim byt() As Byte = ms.ToArray

                Dim sql As String = $"insert Into QuotationHistory([Image])values(@A1) Where [QuotationNum]={Val(Label2.Text)}"
                Dim para1 As New Dictionary(Of String, Object)
                para1.Add("@A1", byt)
                ExecuteSQL(sql, para1)

            End If

        End If

    End Sub

    Private Sub Quotation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If Button5.Text = "קליטה פריט" Then
            Dim Load_QuotationHistory As New DataSet
            LoadDataSQL($"SELECT [QuotationNum]
      ,[QuotationDate]
      ,[Status]
       FROM [QuotationHistory] Where [AccountNum] = {Val(AccountCard.Label5.Text)}", Load_QuotationHistory)
            AccountCard.DataGridView1.DataSource = Load_QuotationHistory.Tables(0)
            AccountCard.DataGridView1.ClearSelection()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim ORGP As Decimal = Val(TextBox5.Text)
        Dim DisP As Decimal = (Val(TextBox5.Text) * Val(TextBox9.Text)) / 100
        Dim FP As Decimal = ORGP - DisP
        Dim DD As Integer = CInt(Math.Round(FP))
        TextBox8.Text = DD

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox8.Text = TextBox5.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim LoadProduct As New DataSet
        LoadDataSQL("SELECT [ProductId]
      ,[MarbleName]
      ,[Size]
      ,[Model]
      ,[Color]
      ,[Price]
      ,[Note]
         FROM [Moner_Bahaa].[dbo].[Marble]", LoadProduct)

        Form1.DataGridView1.DataSource = LoadProduct.Tables(0)
        Form1.DataGridView1.ClearSelection()
        Form1.Show()

        Form1.ValClick = 3

    End Sub

End Class