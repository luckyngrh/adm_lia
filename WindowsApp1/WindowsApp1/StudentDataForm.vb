Imports System.Data.Odbc
Public Class StudentDataForm
    Private Sub StudentDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilSiswa()
        Call aturDGV()
    End Sub
    Sub tampilSiswa()

        Call Koneksi()
        Da = New OdbcDataAdapter("select * from murid", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "murid")
        dgvMurid.DataSource = Ds.Tables("murid")

    End Sub

    Sub aturDGV()
        Try
            dgvMurid.Columns(0).Width = 70
            dgvMurid.Columns(1).Width = 130
            dgvMurid.Columns(2).Width = 100
            dgvMurid.Columns(3).Width = 50
            dgvMurid.Columns(4).Width = 150
            dgvMurid.Columns(5).Width = 150
            dgvMurid.Columns(0).HeaderText = "ID siswa"
            dgvMurid.Columns(1).HeaderText = "Name"
            dgvMurid.Columns(2).HeaderText = "Adress"
            dgvMurid.Columns(3).HeaderText = "Age"
            dgvMurid.Columns(4).HeaderText = "Phone"
            dgvMurid.Columns(5).HeaderText = "Grade"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameTBS.TextChanged
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from murid where Nama like '%" & NameTBS.Text & "%' AND Grade = '" & GradeCBS.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        dgvMurid.DataSource = Ds.Tables(0)
    End Sub

    Private Sub GradeCBS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeCBS.SelectedIndexChanged
        Call Koneksi()
        Da = New OdbcDataAdapter("select * from murid where Grade = '" & GradeCBS.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        dgvMurid.DataSource = Ds.Tables(0)

        Call aturDGV()
    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        Call Koneksi()
        Cmd = New OdbcCommand("UPDATE murid SET Grade = '" & GradeCBS.SelectedItem & "' where Nama LIKE '%" & NameTBS.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        Call tampilSiswa()
        Call aturDGV()

        NameTBS.Clear()
        GradeCBS.ResetText()
    End Sub

    Private Sub dgvMurid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMurid.CellMouseClick
        NameTBS.Text = dgvMurid.Rows(e.RowIndex).Cells(1).Value

        Call tampilSiswa()
        Call aturDGV()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GradeCBS.ResetText()
        NameTBS.Clear()

        Call tampilSiswa()
        Call aturDGV()
    End Sub
End Class