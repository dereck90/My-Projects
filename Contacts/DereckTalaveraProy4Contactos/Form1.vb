Imports System.IO
Public Class frmContactInf
    Dim lector As StreamReader
    Dim escritor As StreamWriter

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click
        Dim phone As String
        Dim name As String
        cdlOpenFile.ShowDialog()
        lector = New System.IO.StreamReader(cdlOpenFile.FileName)
        phone = lector.ReadLine()
        name = lector.ReadLine()
        mtbPhoneNumber.Text = phone
        tbName.Text = name
        lector.Close()
    End Sub

    Private Sub frmContactInf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        cdlSaveFile.ShowDialog()
        escritor = New System.IO.StreamWriter(cdlSaveFile.FileName, True)
        escritor.WriteLine(mtbPhoneNumber.Text)
        escritor.WriteLine(tbName.Text)
        escritor.Close()
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub cdlSaveFile_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles cdlSaveFile.FileOk

    End Sub

    Private Sub btnErase_Click(sender As System.Object, e As System.EventArgs) Handles btnErase.Click
        mtbPhoneNumber.Clear()
        tbName.Clear()
    End Sub
End Class
