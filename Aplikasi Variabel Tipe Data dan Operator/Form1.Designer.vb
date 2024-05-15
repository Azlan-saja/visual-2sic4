<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Tambah = New System.Windows.Forms.Button()
        Me.Tb_Nilai1 = New System.Windows.Forms.TextBox()
        Me.Tb_Nilai2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_Kurang = New System.Windows.Forms.Button()
        Me.B_Kali = New System.Windows.Forms.Button()
        Me.B_Bagi = New System.Windows.Forms.Button()
        Me.B_Sisa_Bagi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Ke-1"
        '
        'B_Tambah
        '
        Me.B_Tambah.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.B_Tambah.Location = New System.Drawing.Point(340, 243)
        Me.B_Tambah.Name = "B_Tambah"
        Me.B_Tambah.Size = New System.Drawing.Size(150, 90)
        Me.B_Tambah.TabIndex = 1
        Me.B_Tambah.Text = "+"
        Me.B_Tambah.UseVisualStyleBackColor = True
        '
        'Tb_Nilai1
        '
        Me.Tb_Nilai1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Nilai1.Location = New System.Drawing.Point(340, 39)
        Me.Tb_Nilai1.Name = "Tb_Nilai1"
        Me.Tb_Nilai1.Size = New System.Drawing.Size(774, 77)
        Me.Tb_Nilai1.TabIndex = 2
        Me.Tb_Nilai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_Nilai2
        '
        Me.Tb_Nilai2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Nilai2.Location = New System.Drawing.Point(340, 146)
        Me.Tb_Nilai2.Name = "Tb_Nilai2"
        Me.Tb_Nilai2.Size = New System.Drawing.Size(774, 77)
        Me.Tb_Nilai2.TabIndex = 4
        Me.Tb_Nilai2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 64)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nilai Ke-2"
        '
        'B_Kurang
        '
        Me.B_Kurang.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.B_Kurang.Location = New System.Drawing.Point(496, 243)
        Me.B_Kurang.Name = "B_Kurang"
        Me.B_Kurang.Size = New System.Drawing.Size(150, 90)
        Me.B_Kurang.TabIndex = 5
        Me.B_Kurang.Text = "-"
        Me.B_Kurang.UseVisualStyleBackColor = True
        '
        'B_Kali
        '
        Me.B_Kali.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.B_Kali.Location = New System.Drawing.Point(652, 243)
        Me.B_Kali.Name = "B_Kali"
        Me.B_Kali.Size = New System.Drawing.Size(150, 90)
        Me.B_Kali.TabIndex = 6
        Me.B_Kali.Text = "x"
        Me.B_Kali.UseVisualStyleBackColor = True
        '
        'B_Bagi
        '
        Me.B_Bagi.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.B_Bagi.Location = New System.Drawing.Point(808, 243)
        Me.B_Bagi.Name = "B_Bagi"
        Me.B_Bagi.Size = New System.Drawing.Size(150, 90)
        Me.B_Bagi.TabIndex = 7
        Me.B_Bagi.Text = ":"
        Me.B_Bagi.UseVisualStyleBackColor = True
        '
        'B_Sisa_Bagi
        '
        Me.B_Sisa_Bagi.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.B_Sisa_Bagi.Location = New System.Drawing.Point(964, 243)
        Me.B_Sisa_Bagi.Name = "B_Sisa_Bagi"
        Me.B_Sisa_Bagi.Size = New System.Drawing.Size(150, 90)
        Me.B_Sisa_Bagi.TabIndex = 8
        Me.B_Sisa_Bagi.Text = "Mod"
        Me.B_Sisa_Bagi.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 359)
        Me.Controls.Add(Me.B_Sisa_Bagi)
        Me.Controls.Add(Me.B_Bagi)
        Me.Controls.Add(Me.B_Kali)
        Me.Controls.Add(Me.B_Kurang)
        Me.Controls.Add(Me.Tb_Nilai2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tb_Nilai1)
        Me.Controls.Add(Me.B_Tambah)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Variabel Tipe Data dan Operator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_Tambah As System.Windows.Forms.Button
    Friend WithEvents Tb_Nilai1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Nilai2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents B_Kurang As System.Windows.Forms.Button
    Friend WithEvents B_Kali As System.Windows.Forms.Button
    Friend WithEvents B_Bagi As System.Windows.Forms.Button
    Friend WithEvents B_Sisa_Bagi As System.Windows.Forms.Button

End Class
