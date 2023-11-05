Imports System.Data.SqlClient
Public Class OrderForm

    Sub bersihkandata()
        txt_idorder.Text = ""
        txt_namalengkap.Text = ""
        txt_alamat.Text = ""
        txt_idakun.Text = ""
        txt_idbarang.Text = ""
        txt_totalharga.Text = ""
        txt_hargabarang.Text = ""
        cmb_namabarang.Text = ""
        nud_jumlah.Text = "0"
    End Sub

    Sub kondisiawal()
        txt_alamat.Enabled = False
        txt_hargabarang.Enabled = False
        txt_totalharga.Enabled = False
        txt_idakun.Visible = False
        txt_idbarang.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Sub tampilcomboboxbarang()
        konekdb()
        Dim cmd As New SqlCommand("SELECT NamaBarang FROM Barang", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            Do While rd.Read
                cmb_namabarang.Items.Add(rd.Item("NamaBarang"))
            Loop
        End If
    End Sub

    Sub tampilkandata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT OrderBarang.ID,account.NamaLengkap,account.Alamat,Barang.NamaBarang,Barang.Harga as HargaBarang,Qty as JumlahBarang,TotalHarga FROM OrderBarang,account,Barang WHERE account.AkunID = OrderBarang.AkunID And Barang.ID = OrderBarang.BarangID", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "OrderBarang")
        dgv_kecantikan.DataSource = ds.Tables("OrderBarang")
    End Sub
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
        tampilcomboboxbarang()
        kondisiawal()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_namalengkap.TextChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM account WHERE NamaLengkap = '" + txt_namalengkap.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_alamat.Text = rd.Item(1)
            txt_idakun.Text = rd.Item(7)
        End If
    End Sub

    Private Sub cmb_namabarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_namabarang.SelectedIndexChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM Barang WHERE NamaBarang = '" + cmb_namabarang.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_hargabarang.Text = rd.Item(2)
            txt_idbarang.Text = rd.Item(0)
        End If
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Dim pesan, sql As String
        If txt_idorder.Text = "" Or txt_namalengkap.Text = "" Or txt_alamat.Text = "" Or cmb_namabarang.Text = "" Then
            MessageBox.Show("Data belum lengkap, silahkan lengkapi data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_idorder.Focus()
        Else
            pesan = MessageBox.Show("Anda akan melakukan order, apakah data yang anda masukan sudah benar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO OrderBarang (ID,AkunID,BarangID,Qty,TotalHarga) VALUES ('" + txt_idorder.Text + "','" + txt_idakun.Text + "','" + txt_idbarang.Text + "','" + nud_jumlah.Value.ToString + "','" + txt_totalharga.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Order produk berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub nud_jumlah_ValueChanged(sender As Object, e As EventArgs) Handles nud_jumlah.ValueChanged
        Dim hitung As Double
        hitung = txt_hargabarang.Text * nud_jumlah.Value
        txt_totalharga.Text = hitung
    End Sub
End Class
