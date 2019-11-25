Public Class frmGetCustomerInContext
    Private Sub GetCustomerInContext_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridView1.Rows.Add(New String() {"11/7/2019", "Wedding", "Anderson", "Clyde", "999-999-9999", "888-888-8888", "clyde@internet.com", "123 Oak St"})
        DataGridView1.Rows.Add(New String() {"11/8/2019", "Wedding", "Putz", "Jared", "999-999-9999", "888-888-8888", "jared@internet.com", "124 Oak St"})
        DataGridView1.Rows.Add(New String() {"11/9/2019", "Company Event", "Lovas", "Todd", "999-999-9999", "888-888-8888", "todd@internet.com", "125 Oak St"})

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub btnLoadClient_Click(sender As Object, e As EventArgs) Handles btnLoadClient.Click
        If (DataGridView1.CurrentRow.Selected) Then

            frmClient.txtCustomerName.Text = DataGridView1.SelectedCells(3).Value.ToString() + " " + DataGridView1.SelectedCells(2).Value.ToString()
            Me.Close()

        End If
    End Sub
End Class