Imports System.Data.Odbc
Public Class EditStudentDataForm
    Private Sub EditStudentDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilSiswa()
        Call aturDGV()
    End Sub
    Sub tampilSiswa()

        Call Koneksi()
        Da = New OdbcDataAdapter("select * from murid", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "murid")
        dgvESD.DataSource = Ds.Tables("murid")

    End Sub

    Sub aturDGV()
        Try
            dgvESD.Columns(0).Width = 50
            dgvESD.Columns(1).Width = 130
            dgvESD.Columns(2).Width = 100
            dgvESD.Columns(3).Width = 50
            dgvESD.Columns(4).Width = 150
            dgvESD.Columns(5).Width = 150
            dgvESD.Columns(0).HeaderText = "Student ID"
            dgvESD.Columns(1).HeaderText = "Name"
            dgvESD.Columns(2).HeaderText = "Adress"
            dgvESD.Columns(3).HeaderText = "Age"
            dgvESD.Columns(4).HeaderText = "Phone Number"
            dgvESD.Columns(5).HeaderText = "Grade"
        Catch ex As Exception
        End Try
    End Sub
    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        EditStudentCB.ResetText()

        Call tampilSiswa()
        Call aturDGV()
    End Sub

    Private Sub dgvESD_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvESD.CellMouseClick
        TextBox1.Text = dgvESD.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dgvESD.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dgvESD.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = dgvESD.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = dgvESD.Rows(e.RowIndex).Cells(4).Value
        EditStudentCB.Text = dgvESD.Rows(e.RowIndex).Cells(5).Value

        Call tampilSiswa()
        Call aturDGV()
    End Sub

    Private Sub DeleteESD_Click(sender As Object, e As EventArgs) Handles DeleteESD.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Or
           TextBox4.Text = "" Or
           TextBox5.Text = "" Or
           EditStudentCB.Text = "" Then
            MessageBox.Show("Data Harus Terisi Lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MsgBox("Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo, "Pilihan!") = MsgBoxResult.Yes Then
                Call Koneksi()
                Cmd = New OdbcCommand("Delete From murid where id_siswa ='" & TextBox1.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                Call tampilSiswa()
                Call aturDGV()
                Call bersih()

            End If
        End If
    End Sub

    Private Sub EditESD_Click(sender As Object, e As EventArgs) Handles EditESD.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Or
           TextBox4.Text = "" Or
           TextBox5.Text = "" Or
           EditStudentCB.Text = "" Then
            MessageBox.Show("Pilih terlebih dahulu data yang akan diupdate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("UPDATE murid SET Nama = '" & TextBox2.Text & "', Alamat = '" & TextBox3.Text & "', Umur = '" & TextBox4.Text & "', No_telp = '" & TextBox5.Text & "', Grade = '" & EditStudentCB.SelectedItem & "'  where id_siswa = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            MessageBox.Show("Data Berhasil Di Update", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call tampilSiswa()
            Call aturDGV()
            Call bersih()


        End If
    End Sub

    Private Sub ClearESD_Click(sender As Object, e As EventArgs) Handles ClearESD.Click
        Call bersih()
        Call tampilSiswa()
        Call aturDGV()
    End Sub
End Class