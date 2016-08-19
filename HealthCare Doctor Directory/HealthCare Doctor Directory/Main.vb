Imports System.Data.OleDb

Public Class frmMain
    Dim cnn As OleDb.OleDbConnection
    Dim id As Integer = -1
    Public dr As OleDb.OleDbDataReader
    
    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dereck\Documents\Visual Studio 2013\Projects\HealthCare Doctor Directory\HealthCare Doctor Directory\HealthCare Doctor Directory.accdb"
        'Copy the following text to upper line when creating build: "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\HealthCare Doctor Directory.accdb"
        MessageBox.Show("Welcome to my HealthCare Doctor Directory! With this software you can add, search, modify and delete information about " & _
                        "the Doctors we support in our HealthCare. We hope that our software be a great help for all of you. Feel free to contact us at derecktalavera@gmail.com.", "Information")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text.Equals("") And txtCountry.Text.Equals("") And mtxtPhone.Text.Equals("(   )    -") And txtEmail.Text.Equals("") Then
            MessageBox.Show("Enter valid values in the fields!")
        Else
            cnn.Open()
            Dim comm As New OleDb.OleDbCommand
            comm.CommandText = "INSERT INTO Doctor (doctor_name, doctor_country, doctor_phone, doctor_email) " & _
                                "VALUES('" & txtName.Text & "','" & txtCountry.Text & "','" & mtxtPhone.Text & "','" & txtEmail.Text & "')"
            comm.Connection = cnn
            comm.ExecuteNonQuery()

            cnn.Close()
            MessageBox.Show("Information Saved!", "Done")

            txtName.Clear()
            txtCountry.Clear()
            mtxtPhone.Clear()
            txtEmail.Clear()
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtName.Clear()
        txtCountry.Clear()
        mtxtPhone.Clear()
        txtEmail.Clear()
        MessageBox.Show("Fields Cleared! Ready for more info", "Cleared")
    End Sub

    Private Sub rbtnFindPhone_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFindPhone.CheckedChanged
        mtxtFindP.Show()
        txtFindI.Hide()
        txtFindI.Clear()
        txtFindC.Hide()
        txtFindC.Clear()
    End Sub

    Private Sub rbtnFindI_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFindI.CheckedChanged
        txtFindI.Show()
        mtxtFindP.Hide()
        mtxtFindP.Clear()
        txtFindC.Hide()
        txtFindC.Clear()
    End Sub

    Private Sub rbtnFindC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFindC.CheckedChanged
        txtFindC.Show()
        mtxtFindP.Hide()
        mtxtFindP.Clear()
        txtFindI.Hide()
        txtFindI.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If rbtnFindC.Checked Then

            If txtFindC.Text.Equals("") Then
                MessageBox.Show("Enter a valid country!")
            Else
                cnn.Open()
                Dim comm As OleDbCommand = New OleDbCommand
                txtSName.Clear()
                txtSCountry.Clear()
                mtxtSPhone.Clear()
                txtSEmail.Clear()
                comm.CommandText = "SELECT * FROM Doctor WHERE doctor_country LIKE '" & txtFindC.Text & "'"
                comm.Connection = cnn
                dr = comm.ExecuteReader
                While dr.Read()
                    txtSName.Text = dr("doctor_name").ToString
                    txtSCountry.Text = dr("doctor_country").ToString
                    mtxtSPhone.Text = dr("doctor_phone").ToString
                    txtSEmail.Text = dr("doctor_email").ToString
                    id = CInt(dr("doctorID").ToString)
                End While
                cnn.Close()
                txtFindC.Clear()
            End If
        ElseIf rbtnFindI.Checked Then

            If txtFindI.Text.Equals("") Then
                MessageBox.Show("Enter a valid ID number!")
            Else
                cnn.Open()
                Dim comm As OleDbCommand = New OleDbCommand
                txtSName.Clear()
                txtSCountry.Clear()
                mtxtSPhone.Clear()
                txtSEmail.Clear()
                comm.CommandText = "SELECT * FROM Doctor WHERE doctorID = " & txtFindI.Text
                comm.Connection = cnn
                dr = comm.ExecuteReader
                While dr.Read()
                    txtSName.Text = dr("doctor_name").ToString
                    txtSCountry.Text = dr("doctor_country").ToString
                    mtxtSPhone.Text = dr("doctor_phone").ToString
                    txtSEmail.Text = dr("doctor_email").ToString
                    id = CInt(dr("doctorID").ToString)
                End While
                cnn.Close()
                txtFindI.Clear()
            End If
        ElseIf rbtnFindPhone.Checked Then

            If mtxtFindP.Text.Equals("(   )    -") Then
                MessageBox.Show("Enter a valid Phone Number!")
            Else
                cnn.Open()
                Dim comm As OleDbCommand = New OleDbCommand
                txtSName.Clear()
                txtSCountry.Clear()
                mtxtSPhone.Clear()
                txtSEmail.Clear()
                comm.CommandText = "SELECT * FROM Doctor WHERE doctor_phone LIKE '" & mtxtFindP.Text & "'"
                comm.Connection = cnn
                dr = comm.ExecuteReader
                While dr.Read()
                    txtSName.Text = dr("doctor_name").ToString
                    txtSCountry.Text = dr("doctor_country").ToString
                    mtxtSPhone.Text = dr("doctor_phone").ToString
                    txtSEmail.Text = dr("doctor_email").ToString
                    id = CInt(dr("doctorID").ToString)
                End While
                cnn.Close()
                mtxtFindP.Clear()
            End If
        End If
    End Sub

    Private Sub btnClrFields_Click(sender As Object, e As EventArgs) Handles btnClrFields.Click
        txtFindC.Clear()
        txtFindI.Clear()
        mtxtFindP.Clear()
        txtSName.Clear()
        txtSCountry.Clear()
        mtxtSPhone.Clear()
        txtSEmail.Clear()
        MessageBox.Show("Fields Cleared!", "Cleared")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cnn.Open()
        Dim comm As OleDbCommand = New OleDbCommand
        txtSName.Clear()
        txtSCountry.Clear()
        mtxtSPhone.Clear()
        txtSEmail.Clear()
        comm.CommandText = "DELETE * FROM Doctor WHERE doctorID = " & id
        comm.Connection = cnn
        comm.ExecuteNonQuery()

        MessageBox.Show("Record has been deleted!", "Attention")
        cnn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtSName.Text.Equals("") And txtSCountry.Text.Equals("") And mtxtSPhone.Text.Equals("(   )    -") And txtSEmail.Text.Equals("") Then
            MessageBox.Show("Search for a record and enter valid information!")
        Else
            cnn.Open()
            Dim comm As OleDbCommand = New OleDbCommand

            comm.CommandText = "UPDATE Doctor SET doctor_name = '" & txtSName.Text & "', doctor_country = '" & txtSCountry.Text & "', doctor_phone = '" & mtxtSPhone.Text & "', doctor_email = '" & txtSEmail.Text & "' WHERE doctorID = " & id
            comm.Connection = cnn
            comm.ExecuteNonQuery()
            MessageBox.Show("Information has been updated!")
            txtSName.Clear()
            txtSCountry.Clear()
            mtxtSPhone.Clear()
            txtSEmail.Clear()

            cnn.Close()
        End If
    End Sub
End Class