Public Class MainAccount


    Public Sub LodCustmer()

        Dim LoadAccount As New DataSet
        LoadDataSQL("Select * From MainAccount", LoadAccount)
        DataGridView1.DataSource = LoadAccount.Tables(0)
        DataGridView1.ClearSelection()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LodCustmer()
    End Sub

    Private Sub הוספתלקוחחדשToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הוספתלקוחחדשToolStripMenuItem.Click

        AddNewAccount.ShowDialog()

    End Sub

    Private Sub רשימתמוצריםToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles רשימתמוצריםToolStripMenuItem.Click
        ProductList.ShowDialog()
    End Sub

    Private Sub רשימתגופימטבחיםToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles רשימתגופימטבחיםToolStripMenuItem.Click
        Bodykitchen.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        AccountCard.TextBox1.Text = DataGridView1.SelectedRows(0).Cells("FullName").Value
        AccountCard.TextBox2.Text = DataGridView1.SelectedRows(0).Cells("MobileNumber").Value
        AccountCard.TextBox3.Text = DataGridView1.SelectedRows(0).Cells("Address").Value
        AccountCard.Label5.Text = DataGridView1.SelectedRows(0).Cells("ID").Value
        AccountCard.TextBox4.Text = DataGridView1.SelectedRows(0).Cells("AccountID").Value
        AccountCard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'If RadioButton1.Checked = True Then


        'ElseIf RadioButton2.Checked = True Then

        Dim str2 As String = TextBox2.Text
            Dim Res2 As String
            For Each c3 As Char In str2
                If IsNumeric(c3) Then
                    Res2 = Res2 & c3
                End If
            Next

            Dim FinalNumSearch As String = ""
            FinalNumSearch = Res2

            Dim UserDS300 As New DataSet
            Dim para10 As New Dictionary(Of String, String)
            para10.Add("@MobileNumber", "%" & FinalNumSearch & "%")

        SearchExecuteSQL("Select [ID]
            ,[FullName]
            ,[MobileNumber]
            ,[Address]
            ,[AccountID] FROM [MainAccount] where 
                Replace([MainAccount].[MobileNumber],'-','') like @MobileNumber", UserDS300, para10)

        DataGridView1.DataSource = UserDS300.Tables(0)
            DataGridView1.ClearSelection()

        'End If



    End Sub

    Private Sub רשימתשישToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles רשימתשישToolStripMenuItem.Click
        Marble.ShowDialog()
    End Sub
End Class