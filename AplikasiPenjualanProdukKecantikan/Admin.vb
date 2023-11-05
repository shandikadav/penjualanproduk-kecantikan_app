Public Class Admin

    Sub kondisiawal()
        pnl_manajemen.Visible = False
        pnl_logout.Visible = False
        ManajemenBarang1.Visible = False
    End Sub
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        pnl_logout.Visible = True
        pnl_manajemen.Visible = False
        ManajemenBarang1.Visible = False
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

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Private Sub btn_manajemen_Click(sender As Object, e As EventArgs) Handles btn_manajemen.Click
        pnl_manajemen.Visible = True
        ManajemenBarang1.Visible = True
        pnl_logout.Visible = False
    End Sub
End Class