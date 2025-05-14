Public Class AddNewAccount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ChekMainAccount As New DataSet
        LoadDataSQL("SELECT * FROM [MainAccount] Where [MobileNumber]= '" & TextBox2.Text & "'", ChekMainAccount)
        If ChekMainAccount.Tables(0).Rows.Count > 0 Then
            MsgBox("משתמש נכבד הלקוח קיים בערכת לפי מס' טלפון", MsgBoxStyle.Information, "לקוח אותר במערכת")
            Me.Close()
        Else

            Dim ChekMainAccountID As New DataSet
            LoadDataSQL("SELECT * FROM [MainAccount] Where [AccountID]= '" & TextBox_AccountID.Text & "'", ChekMainAccountID)
            If ChekMainAccountID.Tables(0).Rows.Count > 0 Then
                MsgBox("משתמש נכבד הלקוח קיים בערכת לפי מס' ת.ז", MsgBoxStyle.Information, "לקוח אותר במערכת")
                Me.Close()
                Exit Sub
            End If

            Dim sql As String = "INSERT INTO [MainAccount] ([FullName],[MobileNumber],[Address],[AccountID]) values (@FullName,@MobileNumber,@Address,@AccountID)"
                Dim para1 As New Dictionary(Of String, Object) From {
                {"@FullName", TextBox1.Text},
                {"@MobileNumber", TextBox2.Text},
                {"@Address", TextBox3.Text},
                {"@AccountID", TextBox_AccountID.Text}
            }
                ExecuteSQL(sql, para1)

            End If

            MainAccount.LodCustmer()

        Me.Close()

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox_AccountID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_AccountID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_AccountID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_AccountID.TextChanged
        TextBox_AccountID.MaxLength = "9"
    End Sub
End Class