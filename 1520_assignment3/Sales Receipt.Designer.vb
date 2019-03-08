<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.ItemTxtBox = New System.Windows.Forms.TextBox()
        Me.PriceTxtBox = New System.Windows.Forms.TextBox()
        Me.ItemLbl = New System.Windows.Forms.Label()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.AddItemBtn = New System.Windows.Forms.Button()
        Me.ReceiptListBox = New System.Windows.Forms.ListBox()
        Me.CloseTransBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ReceiptLbl = New System.Windows.Forms.Label()
        Me.CheckOutBtn = New System.Windows.Forms.Button()
        Me.LogoPicBox = New System.Windows.Forms.PictureBox()
        Me.saleCmbBox = New System.Windows.Forms.ComboBox()
        Me.saleLbl = New System.Windows.Forms.Label()
        Me.saleButton = New System.Windows.Forms.Button()
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemTxtBox
        '
        Me.ItemTxtBox.Location = New System.Drawing.Point(531, 170)
        Me.ItemTxtBox.Name = "ItemTxtBox"
        Me.ItemTxtBox.Size = New System.Drawing.Size(141, 20)
        Me.ItemTxtBox.TabIndex = 0
        '
        'PriceTxtBox
        '
        Me.PriceTxtBox.Location = New System.Drawing.Point(531, 193)
        Me.PriceTxtBox.Name = "PriceTxtBox"
        Me.PriceTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTxtBox.TabIndex = 1
        '
        'ItemLbl
        '
        Me.ItemLbl.AutoSize = True
        Me.ItemLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemLbl.Location = New System.Drawing.Point(470, 168)
        Me.ItemLbl.Name = "ItemLbl"
        Me.ItemLbl.Size = New System.Drawing.Size(50, 20)
        Me.ItemLbl.TabIndex = 2
        Me.ItemLbl.Text = "Item:"
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLbl.Location = New System.Drawing.Point(470, 191)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(54, 20)
        Me.PriceLbl.TabIndex = 3
        Me.PriceLbl.Text = "Price:"
        '
        'AddItemBtn
        '
        Me.AddItemBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemBtn.Location = New System.Drawing.Point(512, 228)
        Me.AddItemBtn.Name = "AddItemBtn"
        Me.AddItemBtn.Size = New System.Drawing.Size(134, 36)
        Me.AddItemBtn.TabIndex = 4
        Me.AddItemBtn.Text = "&Add Item to Cart"
        Me.AddItemBtn.UseVisualStyleBackColor = True
        '
        'ReceiptListBox
        '
        Me.ReceiptListBox.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptListBox.FormatString = "          "
        Me.ReceiptListBox.FormattingEnabled = True
        Me.ReceiptListBox.ItemHeight = 17
        Me.ReceiptListBox.Location = New System.Drawing.Point(22, 47)
        Me.ReceiptListBox.Name = "ReceiptListBox"
        Me.ReceiptListBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReceiptListBox.Size = New System.Drawing.Size(404, 548)
        Me.ReceiptListBox.TabIndex = 5
        '
        'CloseTransBtn
        '
        Me.CloseTransBtn.Location = New System.Drawing.Point(132, 601)
        Me.CloseTransBtn.Name = "CloseTransBtn"
        Me.CloseTransBtn.Size = New System.Drawing.Size(166, 21)
        Me.CloseTransBtn.TabIndex = 6
        Me.CloseTransBtn.Text = "&Close Transaction"
        Me.CloseTransBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(637, 626)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 7
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'ReceiptLbl
        '
        Me.ReceiptLbl.AutoSize = True
        Me.ReceiptLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptLbl.ForeColor = System.Drawing.Color.Honeydew
        Me.ReceiptLbl.Location = New System.Drawing.Point(118, 24)
        Me.ReceiptLbl.Name = "ReceiptLbl"
        Me.ReceiptLbl.Size = New System.Drawing.Size(207, 20)
        Me.ReceiptLbl.TabIndex = 8
        Me.ReceiptLbl.Text = "Friendly's Sales Receipt:"
        '
        'CheckOutBtn
        '
        Me.CheckOutBtn.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutBtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.CheckOutBtn.Location = New System.Drawing.Point(453, 425)
        Me.CheckOutBtn.Name = "CheckOutBtn"
        Me.CheckOutBtn.Size = New System.Drawing.Size(250, 103)
        Me.CheckOutBtn.TabIndex = 9
        Me.CheckOutBtn.Text = "Check &Out"
        Me.CheckOutBtn.UseVisualStyleBackColor = True
        '
        'LogoPicBox
        '
        Me.LogoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPicBox.Image = CType(resources.GetObject("LogoPicBox.Image"), System.Drawing.Image)
        Me.LogoPicBox.Location = New System.Drawing.Point(475, 9)
        Me.LogoPicBox.Name = "LogoPicBox"
        Me.LogoPicBox.Size = New System.Drawing.Size(200, 135)
        Me.LogoPicBox.TabIndex = 10
        Me.LogoPicBox.TabStop = False
        '
        'saleCmbBox
        '
        Me.saleCmbBox.BackColor = System.Drawing.Color.YellowGreen
        Me.saleCmbBox.FormattingEnabled = True
        Me.saleCmbBox.Location = New System.Drawing.Point(515, 349)
        Me.saleCmbBox.Name = "saleCmbBox"
        Me.saleCmbBox.Size = New System.Drawing.Size(121, 21)
        Me.saleCmbBox.TabIndex = 11
        '
        'saleLbl
        '
        Me.saleLbl.AutoSize = True
        Me.saleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleLbl.Location = New System.Drawing.Point(502, 326)
        Me.saleLbl.Name = "saleLbl"
        Me.saleLbl.Size = New System.Drawing.Size(150, 20)
        Me.saleLbl.TabIndex = 12
        Me.saleLbl.Text = "$1.99 Sale Items:"
        '
        'saleButton
        '
        Me.saleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleButton.Location = New System.Drawing.Point(506, 376)
        Me.saleButton.Name = "saleButton"
        Me.saleButton.Size = New System.Drawing.Size(146, 23)
        Me.saleButton.TabIndex = 13
        Me.saleButton.Text = "Add Sale Item to Cart"
        Me.saleButton.UseVisualStyleBackColor = True
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(734, 661)
        Me.Controls.Add(Me.saleButton)
        Me.Controls.Add(Me.saleLbl)
        Me.Controls.Add(Me.saleCmbBox)
        Me.Controls.Add(Me.LogoPicBox)
        Me.Controls.Add(Me.CheckOutBtn)
        Me.Controls.Add(Me.ReceiptLbl)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CloseTransBtn)
        Me.Controls.Add(Me.ReceiptListBox)
        Me.Controls.Add(Me.AddItemBtn)
        Me.Controls.Add(Me.PriceLbl)
        Me.Controls.Add(Me.ItemLbl)
        Me.Controls.Add(Me.PriceTxtBox)
        Me.Controls.Add(Me.ItemTxtBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Receipt"
        Me.Text = "Sales Receipt"
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemTxtBox As TextBox
    Friend WithEvents PriceTxtBox As TextBox
    Friend WithEvents ItemLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents AddItemBtn As Button
    Friend WithEvents CloseTransBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ReceiptLbl As Label
    Friend WithEvents CheckOutBtn As Button
    Friend WithEvents ReceiptListBox As ListBox
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents saleCmbBox As ComboBox
    Friend WithEvents saleLbl As Label
    Friend WithEvents saleButton As Button
End Class
