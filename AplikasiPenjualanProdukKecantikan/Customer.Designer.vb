﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_logout = New System.Windows.Forms.Panel()
        Me.pnl_order = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderForm1 = New AplikasiPenjualanProdukKecantikan.OrderForm()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnl_logout)
        Me.Panel1.Controls.Add(Me.pnl_order)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_order)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 525)
        Me.Panel1.TabIndex = 0
        '
        'pnl_logout
        '
        Me.pnl_logout.BackColor = System.Drawing.Color.Orange
        Me.pnl_logout.Location = New System.Drawing.Point(16, 131)
        Me.pnl_logout.Name = "pnl_logout"
        Me.pnl_logout.Size = New System.Drawing.Size(12, 39)
        Me.pnl_logout.TabIndex = 2
        '
        'pnl_order
        '
        Me.pnl_order.BackColor = System.Drawing.Color.Orange
        Me.pnl_order.Location = New System.Drawing.Point(16, 77)
        Me.pnl_order.Name = "pnl_order"
        Me.pnl_order.Size = New System.Drawing.Size(12, 39)
        Me.pnl_order.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.Location = New System.Drawing.Point(16, 131)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(176, 39)
        Me.btn_logout.TabIndex = 1
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_order.Location = New System.Drawing.Point(16, 77)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(176, 39)
        Me.btn_order.TabIndex = 0
        Me.btn_order.Text = "Order Produk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENU CUSTOMER"
        '
        'OrderForm1
        '
        Me.OrderForm1.Location = New System.Drawing.Point(211, 0)
        Me.OrderForm1.Name = "OrderForm1"
        Me.OrderForm1.Size = New System.Drawing.Size(724, 525)
        Me.OrderForm1.TabIndex = 0
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 525)
        Me.Controls.Add(Me.OrderForm1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents OrderForm1 As OrderForm
    Friend WithEvents pnl_logout As Panel
    Friend WithEvents pnl_order As Panel
End Class
