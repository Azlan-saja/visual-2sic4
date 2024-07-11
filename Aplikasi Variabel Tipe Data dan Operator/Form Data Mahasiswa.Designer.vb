<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Mahasiswa
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
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.TbNIRM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BSimpan
        '
        Me.BSimpan.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BSimpan.Location = New System.Drawing.Point(254, 322)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(262, 90)
        Me.BSimpan.TabIndex = 26
        Me.BSimpan.Text = "Simpan"
        Me.BSimpan.UseVisualStyleBackColor = True
        '
        'TbNIRM
        '
        Me.TbNIRM.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNIRM.Location = New System.Drawing.Point(254, 16)
        Me.TbNIRM.Name = "TbNIRM"
        Me.TbNIRM.Size = New System.Drawing.Size(430, 77)
        Me.TbNIRM.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 64)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NIRM :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(254, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(884, 77)
        Me.TextBox1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 64)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(254, 226)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(296, 77)
        Me.TextBox2.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 64)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Kelas :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 439)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(982, 284)
        Me.ListView1.TabIndex = 33
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIRM"
        Me.ColumnHeader1.Width = 196
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 424
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kelas"
        Me.ColumnHeader3.Width = 271
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(997, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 141)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Hapus Terpilih"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(1000, 586)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 141)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Hapus Semua"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form_Data_Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 735)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbNIRM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BSimpan)
        Me.Name = "Form_Data_Mahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSimpan As System.Windows.Forms.Button
    Friend WithEvents TbNIRM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
