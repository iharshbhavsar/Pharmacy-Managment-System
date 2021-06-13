Imports System.Data.SqlClient
Imports System.Data
Public Class purchase
    Dim cn As SqlConnection
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim count As Integer
    Dim cmd As SqlCommand
    Dim n As Integer = 0
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub petient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select med_id,med_name,med_qty,cmpny,dt_of_prchse,tot_amt from purchase", cn)
        ds = New DataSet
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
        'TODO: This line of code loads data into the 'PharmaDataSet8.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter1.Fill(Me.PharmaDataSet8.purchase)
        'TODO: This line of code loads data into the 'PharmaDataSet.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.PharmaDataSet.purchase)
        
        count = ds.Tables(0).Rows.Count

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If n = 0 Then
            MsgBox("This is first record")
        Else
            n = n - 1
            TextBox1.Text = ds.Tables(0).Rows(n).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(n).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(n).Item(2)
            TextBox4.Text = ds.Tables(0).Rows(n).Item(3)
            DateTimePicker1.Value = ds.Tables(0).Rows(n).Item(4)
            TextBox5.Text = ds.Tables(0).Rows(n).Item(5)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Hide()
        MDIParent1.Show()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'first button
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from purchase", cn)
        ds = New DataSet
        ad.Fill(ds)
        count = ds.Tables(0).Rows.Count
        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)
        DateTimePicker1.Value = ds.Tables(0).Rows(0).Item(4)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(5)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If n = count - 1 Then
            MsgBox("This is last record")
        Else
            n = n + 1
            TextBox1.Text = ds.Tables(0).Rows(n).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(n).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(n).Item(2)
            TextBox4.Text = ds.Tables(0).Rows(n).Item(3)
            DateTimePicker1.Value = ds.Tables(0).Rows(n).Item(4)
            TextBox5.Text = ds.Tables(0).Rows(n).Item(5)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'delete
        Dim del As String
        del = "delete from purchase where med_name='" + TextBox2.Text + "'"
        cmd = New SqlCommand(del, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Deleted")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim add As String
        add = "insert into purchase (med_name,med_qty,cmpny,dt_of_prchse,tot_amt) values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DateTimePicker1.Value + "','" + TextBox5.Text + "')"
        cmd = New SqlCommand(add, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Added.!")

        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim update As String
        update = "update purchase set med_qty=@med_qty,cmpny=@cmpny,dt_of_prchse=@dt_of_prchse,tot_amt=@tot_amt where med_name=@med_name"
        cmd = New SqlCommand(update, cn)
        cmd.Parameters.AddWithValue("@med_name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@med_qty", TextBox3.Text)
        cmd.Parameters.AddWithValue("@cmpny", TextBox4.Text)
        cmd.Parameters.AddWithValue("@dt_of_prchse", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@tot_amt", TextBox5.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Updated successfully")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'last
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        TextBox1.Text = ds.Tables(0).Rows(count - 1).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(count - 1).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(count - 1).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(count - 1).Item(3)
        DateTimePicker1.Value = ds.Tables(0).Rows(count - 1).Item(4)
        TextBox5.Text = ds.Tables(0).Rows(count - 1).Item(5)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'search
        Dim query As String
        Dim count As Integer
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim ds As New DataSet
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        query = "select * from purchase where med_id=@med_id"
        cmd = New SqlCommand(query, cn)
        adp = New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@med_id", TextBox1.Text)
        cmd.ExecuteScalar()
        adp.Fill(ds)
        If (ds.Tables(0).Rows.Count >= 1) Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            DateTimePicker1.Visible = True
            TextBox5.Visible = True

            TextBox1.Text = ds.Tables(0).Rows(count).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(count).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(count).Item(2)
            TextBox4.Text = ds.Tables(0).Rows(count).Item(3)
            DateTimePicker1.Value = ds.Tables(0).Rows(count).Item(4)
            TextBox5.Text = ds.Tables(0).Rows(count).Item(5)

        End If
    End Sub
End Class