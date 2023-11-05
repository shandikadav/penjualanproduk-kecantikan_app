<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv_kecantikan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_idorder = New System.Windows.Forms.TextBox()
        Me.txt_namalengkap = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.cmb_namabarang = New System.Windows.Forms.ComboBox()
        Me.txt_hargabarang = New System.Windows.Forms.TextBox()
        Me.nud_jumlah = New System.Windows.Forms.NumericUpDown()
        Me.txt_totalharga = New System.Windows.Forms.TextBox()
        Me.txt_idakun = New System.Windows.Forms.TextBox()
        Me.txt_idbarang = New System.Windows.Forms.TextBox()
        Me.btn_order = New System.Windows.Forms.Button()
        CType(Me.dgv_kecantikan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_jumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_kecantikan
        '
        Me.dgv_kecantikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kecantikan.Location = New System.Drawing.Point(11, 83)
        Me.dgv_kecantikan.Name = "dgv_kecantikan"
        Me.dgv_kecantikan.Size = New System.Drawing.Size(702, 124)
        Me.dgv_kecantikan.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ORDER PRODUK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KECANTIKAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID Order"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nama Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Harga Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 424)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(89, 460)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ID Akun"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(89, 487)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "ID Barang"
        '
        'txt_idorder
        '
        Me.txt_idorder.Location = New System.Drawing.Point(267, 233)
        Me.txt_idorder.Name = "txt_idorder"
        Me.txt_idorder.Size = New System.Drawing.Size(210, 20)
        Me.txt_idorder.TabIndex = 0
        '
        'txt_namalengkap
        '
        Me.txt_namalengkap.Location = New System.Drawing.Point(267, 259)
        Me.txt_namalengkap.Name = "txt_namalengkap"
        Me.txt_namalengkap.Size = New System.Drawing.Size(210, 20)
        Me.txt_namalengkap.TabIndex = 1
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(267, 285)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(210, 52)
        Me.txt_alamat.TabIndex = 2
        '
        'cmb_namabarang
        '
        Me.cmb_namabarang.FormattingEnabled = True
        Me.cmb_namabarang.Location = New System.Drawing.Point(267, 344)
        Me.cmb_namabarang.Name = "cmb_namabarang"
        Me.cmb_namabarang.Size = New System.Drawing.Size(210, 21)
        Me.cmb_namabarang.TabIndex = 3
        '
        'txt_hargabarang
        '
        Me.txt_hargabarang.Location = New System.Drawing.Point(267, 371)
        Me.txt_hargabarang.Name = "txt_hargabarang"
        Me.txt_hargabarang.Size = New System.Drawing.Size(210, 20)
        Me.txt_hargabarang.TabIndex = 4
        '
        'nud_jumlah
        '
        Me.nud_jumlah.Location = New System.Drawing.Point(267, 398)
        Me.nud_jumlah.Name = "nud_jumlah"
        Me.nud_jumlah.Size = New System.Drawing.Size(210, 20)
        Me.nud_jumlah.TabIndex = 5
        '
        'txt_totalharga
        '
        Me.txt_totalharga.Location = New System.Drawing.Point(267, 424)
        Me.txt_totalharga.Name = "txt_totalharga"
        Me.txt_totalharga.Size = New System.Drawing.Size(210, 20)
        Me.txt_totalharga.TabIndex = 6
        '
        'txt_idakun
        '
        Me.txt_idakun.Location = New System.Drawing.Point(267, 457)
        Me.txt_idakun.Name = "txt_idakun"
        Me.txt_idakun.Size = New System.Drawing.Size(210, 20)
        Me.txt_idakun.TabIndex = 7
        '
        'txt_idbarang
        '
        Me.txt_idbarang.Location = New System.Drawing.Point(267, 488)
        Me.txt_idbarang.Name = "txt_idbarang"
        Me.txt_idbarang.Size = New System.Drawing.Size(210, 20)
        Me.txt_idbarang.TabIndex = 8
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_order.FlatAppearance.BorderSize = 0
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_order.Location = New System.Drawing.Point(511, 233)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(104, 32)
        Me.btn_order.TabIndex = 9
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.txt_idbarang)
        Me.Controls.Add(Me.txt_idakun)
        Me.Controls.Add(Me.nud_jumlah)
        Me.Controls.Add(Me.cmb_namabarang)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_totalharga)
        Me.Controls.Add(Me.txt_hargabarang)
        Me.Controls.Add(Me.txt_namalengkap)
        Me.Controls.Add(Me.txt_idorder)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_kecantikan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrderForm"
        Me.Size = New System.Drawing.Size(724, 525)
        CType(Me.dgv_kecantikan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_jumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_kecantikan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_idorder As TextBox
    Friend WithEvents txt_namalengkap As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents cmb_namabarang As ComboBox
    Friend WithEvents txt_hargabarang As TextBox
    Friend WithEvents nud_jumlah As NumericUpDown
    Friend WithEvents txt_totalharga As TextBox
    Friend WithEvents txt_idakun As TextBox
    Friend WithEvents txt_idbarang As TextBox
    Friend WithEvents btn_order As Button
End Class
