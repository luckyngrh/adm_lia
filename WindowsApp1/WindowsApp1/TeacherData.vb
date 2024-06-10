Imports System.Data.Odbc
Public Class TeacherData
    Private Sub TeacherData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilGuru()
        Call aturDGV()
    End Sub

    Sub tampilGuru()

        Call Koneksi()
        Da = New OdbcDataAdapter("select * from guru", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "guru")
        dgvSearchGuru.DataSource = Ds.Tables("guru")

    End Sub

    Sub aturDGV()
        Try
            dgvSearchGuru.Columns(0).Width = 50
            dgvSearchGuru.Columns(1).Width = 150
            dgvSearchGuru.Columns(2).Width = 150
            dgvSearchGuru.Columns(3).Width = 150
            dgvSearchGuru.Columns(0).HeaderText = "ID Pengajar"
            dgvSearchGuru.Columns(1).HeaderText = "Nama"
            dgvSearchGuru.Columns(2).HeaderText = "Alamat"
            dgvSearchGuru.Columns(3).HeaderText = "Hari Mengajar"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from guru where id_pengajar LIKE '%" & TextBox1.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        dgvSearchGuru.DataSource = Ds.Tables(0)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from guru where Nama like '%" & TextBox2.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        dgvSearchGuru.DataSource = Ds.Tables(0)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from guru where Alamat like '%" & TextBox3.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        dgvSearchGuru.DataSource = Ds.Tables(0)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from guru where Hari_Mengajar = '" & ComboBox1.SelectedItem & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        dgvSearchGuru.DataSource = Ds.Tables(0)

        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.ResetText()
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox1.Clear()
        TextBox3.Clear()
        ComboBox1.ResetText()
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.ResetText()
    End Sub
End Class