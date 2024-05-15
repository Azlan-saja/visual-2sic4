Public Class Form1


    Private Sub B_Tambah_Click(sender As Object, e As EventArgs) Handles B_Tambah.Click
        Dim nilai1 As Integer
        nilai1 = Tb_Nilai1.Text

        Dim nilai2 As Integer
        nilai2 = Tb_Nilai2.Text

        Dim hasil As Integer
        hasil = nilai1 + nilai2

        Dim Pesan As String
        Pesan = nilai1 & " + " & nilai2 & " = " & hasil
        MsgBox(Pesan, MsgBoxStyle.Information, "Hasil Tambah")
    End Sub

    Private Sub B_Kurang_Click(sender As Object, e As EventArgs) Handles B_Kurang.Click

        Dim var_nilai_1 As Integer
        var_nilai_1 = Tb_Nilai1.Text

        Dim var_nilai_2 As Integer
        var_nilai_2 = Tb_Nilai2.Text

        Dim var_hasil As Integer
        var_hasil = var_nilai_1 - var_nilai_2

        Dim pesan As String
        pesan = var_nilai_1 & " - " & var_nilai_2 & " = " & var_hasil
        MsgBox(pesan, , "Hasil Kurang")

    End Sub

End Class
