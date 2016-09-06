<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAisle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnFinalise = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboAisle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'cboAisle
        '
        Me.cboAisle.FormattingEnabled = True
        Me.cboAisle.Location = New System.Drawing.Point(86, 35)
        Me.cboAisle.Name = "cboAisle"
        Me.cboAisle.Size = New System.Drawing.Size(121, 32)
        Me.cboAisle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aisle #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cost"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(281, 35)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 29)
        Me.txtCost.TabIndex = 4
        '
        'btnPurchase
        '
        Me.btnPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.Location = New System.Drawing.Point(13, 96)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(552, 41)
        Me.btnPurchase.TabIndex = 1
        Me.btnPurchase.Text = "Purchase Item"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnFinalise
        '
        Me.btnFinalise.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalise.Location = New System.Drawing.Point(12, 143)
        Me.btnFinalise.Name = "btnFinalise"
        Me.btnFinalise.Size = New System.Drawing.Size(553, 38)
        Me.btnFinalise.TabIndex = 2
        Me.btnFinalise.Text = "Finalise Shop"
        Me.btnFinalise.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(13, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Most Items - Aisle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Least Items - Aisle:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Average Cost Per Item:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Cost Of Shop:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "$0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(452, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "$0.00"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 305)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnFinalise)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Shopping List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboAisle As ComboBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnFinalise As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
