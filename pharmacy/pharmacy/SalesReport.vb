Imports System.Data.SqlClient
Public Class SalesReport
    Dim cn As New SqlConnection
    Dim ad As SqlDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Dim cmd As SqlCommand
    Dim n As Integer = 0
    Private Sub PrintPreviewControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("SELECT  bill_id, petient_name, med_dose, med_name, dt_of_sale, med_price FROM sales", cn)
        ds = New DataSet
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
       
        Me.SalesTableAdapter.Fill(Me.PharmaDataSet9.sales)
        count = ds.Tables(0).Rows.Count

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class