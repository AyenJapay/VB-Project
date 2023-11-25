Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class RegistrationForm

    Public Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "") Then
            MsgBox("Please dont leave any field blank!, Thank You!", vbInformation)
        Else
            If Button1.Text = "" Then
                Dim SQLSTATEMENT As String = "INSERT INTO `user`(`fname`, `lname`, `mname`, `email`, `contact`, `uname`, `pass`, `conpass`) values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "','" & TextBox8.Text & "')"
                save(SQLSTATEMENT)
                MsgBox("User successfully saved!", vbInformation)
                clear()
            Else
                Dim SQLSTATEMENT As String = ""
                save(SQLSTATEMENT)
                MsgBox("User successfully edited!", vbInformation)
                clear()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
    End Sub
End Class