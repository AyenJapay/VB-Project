Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub searcheduser(ByRef SQLSTATEMENT As String)
        SQLCONN.ConnectionString = con
        SQLCONN.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim MyCommand As New MySqlCommand(SQLSTATEMENT, SQLCONN)
        Dim myDataAdapter As New MySqlDataAdapter(SQLSTATEMENT, SQLCONN)
        myDataAdapter.Fill(dt)
        Dim count As Integer = dt.Rows.Count
        If count = 0 Then

            MsgBox("Access Denied!", vbCritical, "Invalid")
            SQLCONN.Close()
            SQLCONN.Dispose()

            Exit Sub
        Else

            Dim sqlrdr As MySqlDataReader
            sqlrdr = MyCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            While sqlrdr.Read()

                'level.Text = sqlrdr("level")
            End While
            SQLCONN.Close()
            SQLCONN.Dispose()



            myDataAdapter.Fill(ds)
            Me.Visible = False
            SQLCONN.Close()
            SQLCONN.Dispose()
            Dashboard.Show()
            ' Splash.Show()



        End If

        SQLCONN.Close()
        SQLCONN.Dispose()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If TextBox1.Text = "admin" And TextBox2.Text = "password" Then
        'Dashboard.Show()
        'Me.Visible = False
        ' Else
        'MsgBox("Wrong Credentials!!!!", vbExclamation, "ERROR")
        ' End If

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Complete Required Fields!")
        Else
            Dim SQLSTATEMENT As String = "SELECT * FROM user where uname = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "' "
            searcheduser(SQLSTATEMENT)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        RegistrationForm.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
