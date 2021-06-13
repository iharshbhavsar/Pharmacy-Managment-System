Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Public Class Login
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim query As String
    Dim n As Integer = 1
    Dim count As Integer
    Dim cnstr As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        adp = New SqlDataAdapter("select * from login", cn)
        ds = New DataSet
        adp.Fill(ds)
        'count = ds.Tables(0).Rows.Count

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.CommandText = "select count(*) from login where user_id=@user_id and password=@password"
        cmd.Parameters.AddWithValue("@user_id", TextBox1.Text)
        cmd.Parameters.AddWithValue("@password", TextBox2.Text)
        cmd.Connection = cn

        n = cmd.ExecuteScalar()

        If n > 0 Then

            Me.Hide()
            MDIParent1.Show()



        Else
            Label3.Text = "INVALID ID OR PASSWORD"

        End If
      End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class