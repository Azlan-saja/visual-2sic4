﻿Public Class Form_Menu_Utama

    Private Sub AritmatikaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AritmatikaToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub PerbandinganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerbandinganToolStripMenuItem.Click
        Form_Operator_Perbandingan.MdiParent = Me
        Form_Operator_Perbandingan.Show()
    End Sub

    Private Sub LogikaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogikaToolStripMenuItem.Click
        Form_Operator_Logika.MdiParent = Me
        Form_Operator_Logika.Show()
    End Sub
End Class