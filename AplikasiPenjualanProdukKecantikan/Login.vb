Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM account WHERE Username = '" + txt_uname.Text + "' AND Password = '" + txt_pass.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            If rd.Item(6).ToString = "1" Then
                MessageBox.Show("Login menuju Admin berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Admin.Show()
                Me.Hide()
            ElseIf rd.Item(6).ToString = "2" Then
                MessageBox.Show("Login menuju Customer berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Customer.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login gagal, silahkan periksa kembali Username dan Password!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        konek.Close()
        cmd.Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        register.Show()
        Me.Hide()
    End Sub
End Class
