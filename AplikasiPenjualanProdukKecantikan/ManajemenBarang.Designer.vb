<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenBarang
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_barang = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_idbarang = New System.Windows.Forms.TextBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_cari = New System.Windows.Forms.Button()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAJEMEN DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BARANG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dgv_barang
        '
        Me.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barang.Location = New System.Drawing.Point(8, 82)
        Me.dgv_barang.Name = "dgv_barang"
        Me.dgv_barang.Size = New System.Drawing.Size(702, 124)
        Me.dgv_barang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga"
        '
        'txt_idbarang
        '
        Me.txt_idbarang.Location = New System.Drawing.Point(282, 260)
        Me.txt_idbarang.Name = "txt_idbarang"
        Me.txt_idbarang.Size = New System.Drawing.Size(181, 20)
        Me.txt_idbarang.TabIndex = 0
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(282, 286)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(181, 20)
        Me.txt_namabarang.TabIndex = 1
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(282, 312)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(181, 20)
        Me.txt_harga.TabIndex = 2
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_simpan.Location = New System.Drawing.Point(60, 420)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(104, 32)
        Me.btn_simpan.TabIndex = 3
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_ubah.Location = New System.Drawing.Point(312, 420)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(104, 32)
        Me.btn_ubah.TabIndex = 4
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_hapus.Location = New System.Drawing.Point(554, 420)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(104, 32)
        Me.btn_hapus.TabIndex = 5
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_cari.FlatAppearance.BorderSize = 0
        Me.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cari.Location = New System.Drawing.Point(469, 258)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(59, 25)
        Me.btn_cari.TabIndex = 6
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'ManajemenBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.txt_namabarang)
        Me.Controls.Add(Me.txt_idbarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_barang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManajemenBarang"
        Me.Size = New System.Drawing.Size(724, 525)
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_barang As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_idbarang As TextBox
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_cari As Button
End Class
