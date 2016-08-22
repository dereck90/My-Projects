Public Class frmTuitionCalc
    Dim InState(4) As Integer
    Dim OutState(4) As Integer
    Dim International(4) As Integer
    Dim Hours As Integer

    Private Sub frmTuitionCalc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InState(1) = 850
        InState(2) = 1000
        InState(3) = 1300
        InState(4) = 1500

        OutState(1) = 1250
        OutState(2) = 1500
        OutState(3) = 2000
        OutState(4) = 2300

        International(1) = 1700
        International(2) = 2000
        International(3) = 2700
        International(4) = 3200
    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim numero As Integer
        Hours = tbHoursTaken.Text
        If Hours >= 1 And Hours <= 5 Then
            numero = 1
        Else
            If Hours >= 6 And Hours <= 8 Then
                numero = 2
            Else
                If Hours >= 9 And Hours <= 11 Then
                    numero = 3
                Else
                    numero = 4
                End If
            End If
        End If
        Select Case numero
            Case 1
                If rbInState.Checked = True Then
                    tbYourTuition.Text = InState(1)
                Else
                    If rbOutState.Checked = True Then
                        tbYourTuition.Text = OutState(1)
                    Else
                        If rbInternational.Checked = True Then
                            tbYourTuition.Text = International(1)
                        End If
                    End If
                End If
            Case 2
                If rbInState.Checked = True Then
                    tbYourTuition.Text = InState(2)
                Else
                    If rbOutState.Checked = True Then
                        tbYourTuition.Text = OutState(2)
                    Else
                        If rbInternational.Checked = True Then
                            tbYourTuition.Text = International(2)
                        End If
                    End If
                End If
            Case 3
                If rbInState.Checked = True Then
                    tbYourTuition.Text = InState(3)
                Else
                    If rbOutState.Checked = True Then
                        tbYourTuition.Text = OutState(3)
                    Else
                        If rbInternational.Checked = True Then
                            tbYourTuition.Text = International(3)
                        End If
                    End If
                End If
            Case 4
                If rbInState.Checked = True Then
                    tbYourTuition.Text = InState(4)
                Else
                    If rbOutState.Checked = True Then
                        tbYourTuition.Text = OutState(4)
                    Else
                        If rbInternational.Checked = True Then
                            tbYourTuition.Text = International(4)
                        End If
                    End If
                End If
            Case Else
                'Salida
        End Select
    End Sub
End Class
