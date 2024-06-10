Imports System.Data.Odbc
Public Class EditTeacherDataForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Or
           EditTeacherCB.Text = "" Then
            MessageBox.Show("Data Harus Terisi Lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("INSERT INTO `guru` (`id_pengajar`,`Nama`, `Alamat`, `Hari_Mengajar`)
            VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & EditTeacherCB.SelectedItem & "')", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            Call bersih()

            MessageBox.Show("Data Berhasil Di Input", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Call tampilGuru()
        Call aturDGV()
    End Sub

    Private Sub TeacherDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilGuru()
        Call aturDGV()
    End Sub

    Sub tampilGuru()

        Call Koneksi()
        Da = New OdbcDataAdapter("select * from guru", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "guru")
        dgvGuru.DataSource = Ds.Tables("guru")

    End Sub

    Sub aturDGV()
        Try
            dgvGuru.Columns(0).Width = 50
            dgvGuru.Columns(1).Width = 150
            dgvGuru.Columns(2).Width = 150
            dgvGuru.Columns(3).Width = 150
            dgvGuru.Columns(0).HeaderText = "ID_Pengajar"
            dgvGuru.Columns(1).HeaderText = "Nama"
            dgvGuru.Columns(2).HeaderText = "Alamat"
            dgvGuru.Columns(3).HeaderText = "Hari Mengajar"
        Catch ex As Exception
        End Try
    End Sub
    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        EditTeacherCB.ResetText()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGuru.CellMouseClick
        TextBox1.Text = dgvGuru.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dgvGuru.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dgvGuru.Rows(e.RowIndex).Cells(2).Value
        EditTeacherCB.Text = dgvGuru.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Or
           EditTeacherCB.Text = "" Then
            MessageBox.Show("Data Harus Terisi Lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo, "Pilihan!") = MsgBoxResult.Yes Then
                Call Koneksi()
                Cmd = New OdbcCommand("Delete From guru where id_pengajar ='" & TextBox1.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                Call tampilGuru()
                Call aturDGV()
                Call bersih()

            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call bersih()
        Call tampilGuru()
        Call aturDGV()
    End Sub
End Class