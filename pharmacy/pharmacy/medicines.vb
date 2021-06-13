Imports System.Data.SqlClient
Imports System.Data
Public Class medicines
    Dim cn As New SqlConnection
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim count As Integer
    Dim cmd As SqlCommand
    Dim n As Integer = 0

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'first button
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from medicines", cn)
        ds = New DataSet
        ad.Fill(ds)
        count = ds.Tables(0).Rows.Count
        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox6.Text = ds.Tables(0).Rows(0).Item(5)
        TextBox7.Text = ds.Tables(0).Rows(0).Item(6)



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub

    Private Sub medicines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        ad = New SqlDataAdapter("select * from medicines", cn)
        ds = New DataSet
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
        'TODO: This line of code loads data into the 'PharmaDataSet7.medicines' table. You can move, or remove it, as needed.
        Me.MedicinesTableAdapter2.Fill(Me.PharmaDataSet7.medicines)
        'TODO: This line of code loads data into the 'PharmaDataSet6.medicines' table. You can move, or remove it, as needed.
        Me.MedicinesTableAdapter1.Fill(Me.PharmaDataSet6.medicines)
        'TODO: This line of code loads data into the 'PharmaDataSet2.medicines' table. You can move, or remove it, as needed.
        Me.MedicinesTableAdapter.Fill(Me.PharmaDataSet2.medicines)

        count = ds.Tables(0).Rows.Count

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'insert
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim add As String

        add = "insert into medicines (med_name,med_dose,med_price,med_qty,side_efcts,med_type) values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"
        cmd = New SqlCommand(add, cn)
        cmd.ExecuteNonQuery()

        ad = New SqlDataAdapter("select * from medicines", cn)
        ds = New DataSet
        ad.Fill(ds)

        MsgBox("Successfully Added.!")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'delete
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim del As String
        del = "delete from medicines where med_name='" + TextBox2.Text + "'"
        cmd = New SqlCommand(del, cn)
        cmd.ExecuteNonQuery()
        ad = New SqlDataAdapter("select * from medicines", cn)
        ds = New DataSet
        ad.Fill(ds)
        MsgBox("Successfully Deleted")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'update
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\TYBCA14\pharmacy\pharmacy\pharma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        Dim update As String
        update = "update medicines set med_dose=@med_dose,med_price=@med_price,med_qty=@med_qty,side_efcts=@side_efcts,med_type=@med_type where med_name=@med_name"
        cmd = New SqlCommand(update, cn)


        cmd.Parameters.AddWithValue("@med_name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@med_dose", TextBox3.Text)
        cmd.Parameters.AddWithValue("@med_price", TextBox4.Text)
        cmd.Parameters.AddWithValue("@med_qty", TextBox5.Text)
        cmd.Parameters.AddWithValue("@side_efcts", TextBox6.Text)
        cmd.Parameters.AddWithValue("@med_type", TextBox7.Text)
        cmd.ExecuteNonQuery()
        ad = New SqlDataAdapter("select * from medicines", cn)
        ds = New DataSet
        ad.Fill(ds)
        MsgBox("updated successfully")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'last
        TextBox1.Text = ds.Tables(0).Rows(count - 1).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(count - 1).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(count - 1).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(count - 1).Item(3)
        TextBox5.Text = ds.Tables(0).Rows(count - 1).Item(4)
        TextBox6.Text = ds.Tables(0).Rows(count - 1).Item(5)
        TextBox7.Text = ds.Tables(0).Rows(count - 1).Item(6)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If n = count - 1 Then
            MsgBox("This is last record")
        Else
            n = n + 1
            TextBox1.Text = ds.Tables(0).Rows(n).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(n).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(n).Item(2)
            TextBox4.Text = ds.Tables(0).Rows(n).Item(3)
            TextBox5.Text = ds.Tables(0).Rows(n).Item(4)
            TextBox6.Text = ds.Tables(0).Rows(n).Item(5)
            TextBox7.Text = ds.Tables(0).Rows(n).Item(6)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If n = 0 Then
            MsgBox("This is first record")
        Else
            n = n - 1
            TextBox1.Text = ds.Tables(0).Rows(n).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(n).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(n).Item(2)
            TextBox4.Text = ds.Tables(0).Rows(n).Item(3)
            TextBox5.Text = ds.Tables(0).Rows(n).Item(4)
            TextBox6.Text = ds.Tables(0).Rows(n).Item(5)
            TextBox7.Text = ds.Tables(0).Rows(n).Item(6)
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
        query = "select * from medicines where med_id=@med_id"
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
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox1.Text = ds.Tables(0).Rows(count).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(count).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(count).Item(2)
            TextBox4.Text = ds.Tables(0).Rows(count).Item(3)
            TextBox5.Text = ds.Tables(0).Rows(count).Item(4)
            TextBox6.Text = ds.Tables(0).Rows(count).Item(5)
            TextBox7.Text = ds.Tables(0).Rows(count).Item(6)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class