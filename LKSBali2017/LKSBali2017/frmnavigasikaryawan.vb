﻿Public Class frmnavigasikaryawan
    ' Point
    ' 1. Pastikan nama terisi dengan benar

    Private Sub formnavigasikaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = bacadb("select nama from tabkaryawan inner join tabuser on tabuser.username = tabkaryawan.id where tabuser.role = '3' and tabkaryawan.id = '" & frmlogin.tbusername.Text & "'")

        lbwelcome.Text = "Selamat datang, " & dt.Rows(0).Item(0) & "!"
    End Sub

    Private Sub frmnavigasikaryawan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmlogin.cls()
        frmlogin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btmanajemenkaryawan.Click
        Me.Hide()
        frmmanajemenkaryawan.Show()
    End Sub

    Private Sub btmanajemenjurusan_Click(sender As Object, e As EventArgs) Handles btmanajemenjurusan.Click
        Me.Hide()
        frmmanajemenjurusan.Show()
    End Sub

    Private Sub btmanajemensiswa_Click(sender As Object, e As EventArgs) Handles btmanajemensiswa.Click
        Me.Hide()
        frmmanajemensiswa.Show()
    End Sub
End Class