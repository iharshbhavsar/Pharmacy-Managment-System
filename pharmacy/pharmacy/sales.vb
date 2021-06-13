Imports System.Data.SqlClient
Public Class sales
    Dim cn As New SqlConnection
    Dim ad As SqlDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Dim cmd As SqlCommand
    Dim n As Integer = 0


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub

    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from sales", cn)
        ds = New DataSet
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
        'ad = New SqlDataAdapter("select * from sales", cn)
        'count = ds.Tables(0).Rows.Count
        'DataGridView1.DataSource = ds
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim update As String
        update = "update sales set petient_name=@petient_name,med_dose=@med_dose,med_name=@med_name,dt_of_sale=@dt_of_sale,med_price=@med_price where bill_id=@bill_id"
        cmd = New SqlCommand(update, cn)
        cmd.Parameters.AddWithValue("@bill_id", TextBox1.Text)
        cmd.Parameters.AddWithValue("@petient_name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@med_dose", TextBox3.Text)
        cmd.Parameters.AddWithValue("@med_name", TextBox4.Text)
        cmd.Parameters.AddWithValue("@dt_of_sale", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@med_price", TextBox5.Text)
        cmd.ExecuteNonQuery()
        MsgBox("updated Successfully")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim add As String
        add = "insert into sales (petient_name,med_dose,med_name,dt_of_sale,med_price) values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DateTimePicker1.Value + "','" + TextBox5.Text + "')"
        cmd = New SqlCommand(add, cn)

        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Successfully Added.!")
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'delete
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from sales", cn)
        ds = New DataSet
        ad.Fill(ds)
        count = ds.Tables(0).Rows.Count
        Dim del As String
        del = "delete from sales where petient_name='" + TextBox2.Text + "'"
        cmd = New SqlCommand(del, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Deleted")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'first button
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from sales", cn)
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


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'last button
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from sales", cn)
        ds = New DataSet
        ad.Fill(ds)
        count = ds.Tables(0).Rows.Count
        TextBox1.Text = ds.Tables(0).Rows(count - 1).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(count - 1).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(count - 1).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(count - 1).Item(3)
        DateTimePicker1.Value = ds.Tables(0).Rows(count - 1).Item(4)
        TextBox5.Text = ds.Tables(0).Rows(count - 1).Item(5)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        'cn.Open()
        'ad = New SqlDataAdapter("select * from sales", cn)
        'ds = New DataSet
        'ad.Fill(ds)
        'count = ds.Tables(0).Rows.Count
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from sales", cn)
        ds = New DataSet
        ad.Fill(ds)
        count = ds.Tables(0).Rows.Count
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        'cn.Open()
        'ad = New SqlDataAdapter("select * from sales", cn)
        'ds = New DataSet
        'ad.Fill(ds)
        'count = ds.Tables(0).Rows.Count


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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'search
        Dim query As String
        Dim count As Integer
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim ds As New DataSet
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        query = "select * from sales where bill_id=@bill_id"
        cmd = New SqlCommand(query, cn)
        adp = New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@bill_id", TextBox1.Text)
        cmd.ExecuteScalar()
        adp.Fill(ds)
        If (ds.Tables(0).Rows.Count >= 1) Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Text = True
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

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FillallToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SalesTableAdapter6.fillall(Me.PharmaDataSet16.sales)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SalesTableAdapter.FillBy(Me.PharmaDataSet1.sales)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.SalesTableAdapter6.FillBy(Me.PharmaDataSet16.sales)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class