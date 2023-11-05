Public Class Customer

    Sub kondisiawal()
        pnl_order.Visible = False
        pnl_logout.Visible = False
        OrderForm1.Visible = False
    End Sub
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        pnl_logout.Visible = True
        pnl_order.Visible = False
        OrderForm1.Visible = False
        pnl_logout.Visible = False
        Dim pesan As String
        pesan = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If pesan = DialogResult.No Then
            Exit Sub
        Else
            Login.txt_uname.Text = ""
            Login.txt_pass.Text = ""
            Login.Show()
            Me.Hide()
            Login.txt_uname.Focus()
        End If
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        pnl_order.Visible = True
        OrderForm1.Visible = True
        pnl_logout.Visible = False
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub
End Class