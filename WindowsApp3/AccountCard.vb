Imports System.IO
Imports CrystalDecisions


Public Class AccountCard

    Private Sub AccountCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Load_QuotationHistory As New DataSet
        LoadDataSQL($"SELECT [QuotationNum]
      ,[QuotationDate]
      ,[StatusType].[StatusName]
       FROM [QuotationHistory] inner join [StatusType] On [QuotationHistory].[Status]=[StatusType].StatusID Where [QuotationHistory].[AccountNum] = {Val(Label5.Text)}", Load_QuotationHistory)
        DataGridView1.DataSource = Load_QuotationHistory.Tables(0)
        DataGridView1.ClearSelection()

    End Sub

    Private Sub הוספתהצעהחדשהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הוספתהצעהחדשהToolStripMenuItem.Click
        Quotation.Show()
    End Sub


    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.Title = "נא לבחור מיקום תומנה"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName = Nothing Then
        Else


            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName.ToString)

            Dim UserDS5 As New DataSet
            LoadDataSQL($"SELECT * FROM QuotationHistory Where [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", UserDS5)

            If UserDS5.Tables(0).Rows.Count <> 0 Then


                ' READING PICTURE
                Dim ms As New System.IO.MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim byt() As Byte = ms.ToArray


                Dim sql As String = $"Update QuotationHistory Set [Image] = @A1 Where [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}"
                Dim para1 As New Dictionary(Of String, Object)
                para1.Add("@A1", byt)
                ExecuteSQL(sql, para1)

            Else

                ' READING PICTURE
                Dim ms As New System.IO.MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim byt() As Byte = ms.ToArray

                Dim sql As String = $"insert Into QuotationHistory([Image])values(@A1) Where [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}"
                Dim para1 As New Dictionary(Of String, Object)
                para1.Add("@A1", byt)
                ExecuteSQL(sql, para1)

            End If

        End If
    End Sub



    Private Sub DataGridView2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick

        Quotation.Label8.Text = Val(Label5.Text)
        Quotation.DateTimePicker1.Value = CDate(DataGridView1.SelectedRows(0).Cells("QuotationDate").Value)
        Quotation.DateTimePicker1.Enabled = False
        Quotation.Label2.Text = DataGridView1.SelectedRows(0).Cells("QuotationNum").Value
        Quotation.Button2.Visible = False
        Quotation.TextBox1.Text = DataGridView2.SelectedRows(0).Cells("ProductName").Value
        Quotation.TextBox2.Text = DataGridView2.SelectedRows(0).Cells("Size").Value
        Quotation.TextBox3.Text = DataGridView2.SelectedRows(0).Cells("Model").Value
        Quotation.TextBox4.Text = DataGridView2.SelectedRows(0).Cells("Color").Value
        Quotation.TextBox5.Text = DataGridView2.SelectedRows(0).Cells("OriginalPrice").Value
        Quotation.TextBox6.Text = DataGridView2.SelectedRows(0).Cells("Note").Value
        Quotation.Button5.Text = "עדכן פריט"
        Quotation.TextBox7.Text = DataGridView2.SelectedRows(0).Cells("Type").Value
        Quotation.TextBox8.Text = DataGridView2.SelectedRows(0).Cells("DiscountPrice").Value
        Quotation.Label12.Visible = False
        Quotation.Label13.Visible = False
        Quotation.Label15.Visible = True
        Quotation.Label16.Visible = True
        Quotation.Label16.Text = DataGridView2.SelectedRows(0).Cells("LineID").Value
        Quotation.PictureBox1.Image = Me.PictureBox1.Image
        Quotation.Show()

    End Sub

    Private Sub הצעתמחירToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הצעתמחירToolStripMenuItem.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        ExecuteSqlStmtSQL($"Update [QuotationHistory] SET [Status] = 1 WHERE [QuotationNum] ={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}")

        Dim Load_QuotationHistory As New DataSet
        LoadDataSQL($"SELECT [QuotationNum]
      ,[QuotationDate]
      ,[StatusType].[StatusName]
       FROM [QuotationHistory] inner join [StatusType] On [QuotationHistory].[Status]=[StatusType].StatusID Where [QuotationHistory].[AccountNum] = {Val(Label5.Text)}", Load_QuotationHistory)
        DataGridView1.DataSource = Load_QuotationHistory.Tables(0)
        DataGridView1.ClearSelection()

    End Sub

    Private Sub הזמנהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הזמנהToolStripMenuItem.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ExecuteSqlStmtSQL($"Update [QuotationHistory] SET [Status] = 2 WHERE [QuotationNum] ={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}")

        Dim Load_QuotationHistory As New DataSet
        LoadDataSQL($"SELECT [QuotationNum]
      ,[QuotationDate]
      ,[StatusType].[StatusName]
       FROM [QuotationHistory] inner join [StatusType] On [QuotationHistory].[Status]=[StatusType].StatusID Where [QuotationHistory].[AccountNum] = {Val(Label5.Text)}", Load_QuotationHistory)
        DataGridView1.DataSource = Load_QuotationHistory.Tables(0)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub יצורToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles יצורToolStripMenuItem.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        ExecuteSqlStmtSQL($"Update [QuotationHistory] SET [Status] = 3 WHERE [QuotationNum] ={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}")

        Dim Load_QuotationHistory As New DataSet
        LoadDataSQL($"SELECT [QuotationNum]
      ,[QuotationDate]
      ,[StatusType].[StatusName]
       FROM [QuotationHistory] inner join [StatusType] On [QuotationHistory].[Status]=[StatusType].StatusID Where [QuotationHistory].[AccountNum] = {Val(Label5.Text)}", Load_QuotationHistory)
        DataGridView1.DataSource = Load_QuotationHistory.Tables(0)
        DataGridView1.ClearSelection()

    End Sub

    Private Sub הדפסהToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles הדפסהToolStripMenuItem1.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        Dim row As DataRow = Nothing
        Dim ds As New GivancoStore

        '---------------------------------------------------------------------------------------


        row = ds.AccountInfo.NewRow
        row("FullName") = TextBox1.Text
        row("MobileNumber") = TextBox2.Text
        row("IDNumber") = TextBox4.Text
        row("Address") = TextBox3.Text
        ds.AccountInfo.Rows.Add(row)


        For i As Integer = 0 To Me.DataGridView2.RowCount - 1
            row = ds.Quotation.NewRow
            row("QuotationNum") = DataGridView2.Rows(i).Cells("QuotationNum").Value
            row("ProductName") = DataGridView2.Rows(i).Cells("ProductName").Value
            row("Size") = DataGridView2.Rows(i).Cells("Size").Value
            row("Model") = DataGridView2.Rows(i).Cells("Model").Value
            row("OriginalPrice") = Format(DataGridView2.Rows(i).Cells("OriginalPrice").Value, "Currency")
            row("DiscountPrice") = Format(DataGridView2.Rows(i).Cells("DiscountPrice").Value, "Currency")
            row("Note") = DataGridView2.Rows(i).Cells("Note").Value
            ds.Quotation.Rows.Add(row)
        Next



        '------ חישוב ס"הכ מחיר מע"מ + כולל מע"מ --------
        row = ds.QuotationMore.NewRow
        row("QuotationDate") = DataGridView1.SelectedRows(0).Cells("QuotationDate").Value
        row("TotalQuotation") = Format(Label8.Text, "Currency")
        row("TotalQuotationTAX") = Format(TotalQuotation * (TaxVal), "Currency")

        '------ חישוב ס"הכ מחיר מטבח ללא מע"מ + כולל מע"מ --------
        Dim ToTalKitchen As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [Type]=1 and [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTalKitchen)
        row("TotalKitchen") = Format(FormatNumber(Val(ToTalKitchen.Tables(0).Rows(0)(0).ToString), , TriState.False), "Currency")

        Dim ToTalKitchenTax As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [Type]=1 and [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTalKitchenTax)
        row("TotalKitchenTax") = Format(FormatNumber(Val(ToTalKitchenTax.Tables(0).Rows(0)(0).ToString) * (TaxVal), , TriState.False), "Currency")


        '------ חישוב ס"הכ מחיר שיש ללא מע"מ + כולל מע"מ --------
        Dim ToTalMarble As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [Type]=3 and [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTalMarble)
        row("Marble") = Format(FormatNumber(Val(ToTalMarble.Tables(0).Rows(0)(0).ToString), , TriState.False), "Currency")

        Dim ToTalMarbleTax As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [Type]=3 and [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTalMarbleTax)
        row("MarbleTax") = Format(FormatNumber(Val(ToTalMarbleTax.Tables(0).Rows(0)(0).ToString) * (TaxVal), , TriState.False), "Currency")



        '------ חישוב ס"הכ מחיר אבזור ללא מע"מ + כולל מע"מ --------
        Dim ToTalColle As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [Type] = 2 and [QuotationNum] = {Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTalColle)
        row("Colle") = Format(FormatNumber(Val(ToTalColle.Tables(0).Rows(0)(0).ToString), , TriState.False), "Currency")

        Dim ToTalColleTax As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [Type] = 2 and [QuotationNum] = {Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTalColleTax)
        row("ColleTax") = Format(FormatNumber(Val(ToTalColleTax.Tables(0).Rows(0)(0).ToString) * (TaxVal), , TriState.False), "Currency")



        '' READING PICTURE
        'Dim ms As New System.IO.MemoryStream
        'Me.PictureBox1.Image.Save(ms, Me.PictureBox1.Image.RawFormat)
        'Dim byt() As Byte = ms.ToArray
        'row("Image") = byt


        ds.QuotationMore.Rows.Add(row)

        '----------------------------------------------------------------------------------------

        Dim rpt As New CrystalReport7
        rpt.SetDataSource(ds)
        Dim frm As New PrintPreview
        frm.CrystalReportViewer1.ReportSource = rpt
        frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql As String = "Update [MainAccount] SET [FullName]=@FullName,[MobileNumber]=@MobileNumber,[Address]=@Address,[AccountID]=@AccountID Where [ID]=@ID"
        Dim para1 As New Dictionary(Of String, Object) From {
        {"@FullName", TextBox1.Text},
        {"@MobileNumber", TextBox2.Text},
        {"@Address", TextBox3.Text},
        {"@AccountID", TextBox4.Text},
        {"@ID", Val(Label5.Text)}
    }
        ExecuteSQL(sql, para1)

        MainAccount.LodCustmer()

        MsgBox("Data Update", MsgBoxStyle.Information, "UpdateInfo")

    End Sub



    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

        TextBox4.MaxLength = "9"

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

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
       FROM [Quotation] Where [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", QuotationInfo)

        DataGridView2.DataSource = QuotationInfo.Tables(0)


        Dim ToTal As New DataSet
        LoadDataSQL($"SELECT SUM([DiscountPrice])
        FROM [Quotation] Where [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", ToTal)
        Label8.Text = Format(ToTal.Tables(0).Rows(0)(0).ToString, "Currency")
        TotalQuotation = ToTal.Tables(0).Rows(0)(0).ToString

        Dim QuotationImage As New DataSet
        LoadDataSQL($"SELECT [Image] FROM [QuotationHistory] WHERE [QuotationNum]={Val(DataGridView1.SelectedRows(0).Cells("QuotationNum").Value)}", QuotationImage)

        If QuotationImage.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(QuotationImage.Tables(0).Rows(0)(0)) Then
            Dim ImageByteArray As Byte() = CType(QuotationImage.Tables(0).Rows(0)(0), Byte())
            Using ImageMemoryStream As New IO.MemoryStream(ImageByteArray)
                PictureBox1.Image = Image.FromStream(ImageMemoryStream)
            End Using
        Else
            PictureBox1.Image = Nothing
        End If

    End Sub
End Class