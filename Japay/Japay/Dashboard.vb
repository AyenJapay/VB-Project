Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Dashboard
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public Sub searchedrec(ByRef SQLSTATEMENT As String)
        SQLCONN.ConnectionString = con
        SQLCONN.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim MyCommand As New MySqlCommand(SQLSTATEMENT, SQLCONN)
        Dim myDataAdapter As New MySqlDataAdapter(SQLSTATEMENT, SQLCONN)
        myDataAdapter.Fill(dt)
        Dim count As Integer = dt.Rows.Count
        If count = 0 Then

            SQLCONN.Close()
            SQLCONN.Dispose()
            DataGridView1.DataSource = Nothing
            Exit Sub
        Else
            myDataAdapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)


            SQLCONN.Close()
            SQLCONN.Dispose()


        End If

        SQLCONN.Close()
        SQLCONN.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SQLSTATAMENT As String = "SELECT * FROM `user`"
        searchedrec(SQLSTATAMENT)
    End Sub
End Class