Imports System.Data.SqlClient
Public Class ManajemenBarang

    Sub bersihkandata()
        txt_idbarang.Text = ""
        txt_namabarang.Text = ""
        txt_harga.Text = ""
    End Sub

    Sub tampildata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM Barang", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "Barang")
        dgv_barang.DataSource = ds.Tables("Barang")

    End Sub
    Private Sub ManajemenBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_idbarang.Text = "" Or txt_namabarang.Text = "" Or txt_harga.Text = "" Then
            MessageBox.Show("Data belum lengkap, lengkapi data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idbarang.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
                txt_idbarang.Focus()
            End If
            sql = "INSERT INTO Barang VALUES ('" + txt_idbarang.Text + "','" + txt_namabarang.Text + "','" + txt_harga.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihkandata()
            txt_idbarang.Focus()
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_idbarang.Text = "" Or txt_namabarang.Text = "" Or txt_harga.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idbarang.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
                txt_idbarang.Focus()
            End If
            sql = "UPDATE Barang SET NamaBarang = '" + txt_namabarang.Text + "', Harga = '" + txt_harga.Text + "' WHERE ID = '" + txt_idbarang.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihkandata()
            txt_idbarang.Focus()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_idbarang.Text = "" Or txt_namabarang.Text = "" Or txt_harga.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan cari data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idbarang.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
                txt_idbarang.Focus()
            End If
            sql = "DELETE FROM Barang WHERE ID LIKE '" + txt_idbarang.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampildata()
            bersihkandata()
            txt_idbarang.Focus()
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM barang WHERE ID = '" + txt_idbarang.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_idbarang.Text = rd.Item(0)
            txt_namabarang.Text = rd.Item(1)
            txt_harga.Text = rd.Item(2)
        Else
            MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class