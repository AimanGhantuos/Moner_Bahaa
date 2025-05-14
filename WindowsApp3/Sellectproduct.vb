Public Class Form1

    Public ValClick As Integer

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick


        If ValClick = 1 Then

            Quotation.TextBox1.Text = DataGridView1.SelectedRows(0).Cells("BodyName").Value
            Quotation.TextBox2.Text = DataGridView1.SelectedRows(0).Cells("Size").Value
            Quotation.TextBox3.Text = DataGridView1.SelectedRows(0).Cells("Model").Value
            Quotation.TextBox4.Text = DataGridView1.SelectedRows(0).Cells("Color").Value
            Quotation.TextBox5.Text = DataGridView1.SelectedRows(0).Cells("Price").Value
            Quotation.TextBox6.Text = DataGridView1.SelectedRows(0).Cells("Note").Value
            ' Quotation.TextBox8.Text = DataGridView1.SelectedRows(0).Cells("Price").Value
            Quotation.TextBox7.Text = 1

        ElseIf ValClick = 2 Then

            Quotation.TextBox1.Text = DataGridView1.SelectedRows(0).Cells("ProductName").Value
            Quotation.TextBox2.Text = DataGridView1.SelectedRows(0).Cells("Size").Value
            Quotation.TextBox3.Text = DataGridView1.SelectedRows(0).Cells("Model").Value
            Quotation.TextBox4.Text = DataGridView1.SelectedRows(0).Cells("Color").Value
            Quotation.TextBox5.Text = DataGridView1.SelectedRows(0).Cells("Price").Value
            Quotation.TextBox6.Text = DataGridView1.SelectedRows(0).Cells("Note").Value
            ' Quotation.TextBox8.Text = DataGridView1.SelectedRows(0).Cells("Price").Value
            Quotation.TextBox7.Text = 2

        ElseIf ValClick = 3 Then

            Quotation.TextBox1.Text = DataGridView1.SelectedRows(0).Cells("MarbleName").Value
            Quotation.TextBox2.Text = DataGridView1.SelectedRows(0).Cells("Size").Value
            Quotation.TextBox3.Text = DataGridView1.SelectedRows(0).Cells("Model").Value
            Quotation.TextBox4.Text = DataGridView1.SelectedRows(0).Cells("Color").Value
            Quotation.TextBox5.Text = DataGridView1.SelectedRows(0).Cells("Price").Value
            Quotation.TextBox6.Text = DataGridView1.SelectedRows(0).Cells("Note").Value
            ' Quotation.TextBox8.Text = DataGridView1.SelectedRows(0).Cells("Price").Value
            Quotation.TextBox7.Text = 3

        End If

        Me.Close()

    End Sub


End Class