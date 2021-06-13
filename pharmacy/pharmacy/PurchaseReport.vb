Imports System.Data.SqlClient
Imports System.Data
Public Class PurchaseReport
    Dim cn As SqlConnection
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim count As Integer
    Dim cmd As SqlCommand
    Dim n As Integer = 0
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PurchaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select med_id,med_name,med_qty,cmpny,dt_of_prchse,tot_amt from purchase", cn)
        ds = New DataSet
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
        'TODO: This line of code loads data into the 'PharmaDataSet10.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.PharmaDataSet10.purchase)
        count = ds.Tables(0).Rows.Count
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class