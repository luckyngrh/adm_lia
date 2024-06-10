Imports System.Data.Odbc
Public Class EditAdmin
    Private Sub EditAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilAdmin()
        Call aturDGV()
    End Sub

    Sub tampilAdmin()

        Call Koneksi()
        Da = New OdbcDataAdapter("select * from admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "admin")
        dgvAdmin.DataSource = Ds.Tables("admin")

    End Sub

    Sub aturDGV()
        Try
            dgvAdmin.Columns(0).Width = 50
            dgvAdmin.Columns(1).Width = 80
            dgvAdmin.Columns(2).Width = 80
            dgvAdmin.Columns(0).HeaderText = "ID Admin"
            dgvAdmin.Columns(1).HeaderText = "Username"
            dgvAdmin.Columns(2).HeaderText = "Password"
        Catch ex As Exception
        End Try
    End Sub

    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub dgvAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellContentClick
        TextBox1.Text = dgvAdmin.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dgvAdmin.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dgvAdmin.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or
           TextBox3.Text = "" Then
            MessageBox.Show("Username atau Password belum diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("INSERT INTO `admin` (`username`, `pass`)
            VALUES ('" & TextBox2.Text & "', '" & TextBox3.Text & "')", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            Call bersih()

            MessageBox.Show("Data Berhasil Di Input", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Call tampilAdmin()
        Call aturDGV()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Then
            MessageBox.Show("Pilih terlebih dahulu data yang akan diupdate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("UPDATE admin SET username = '" & TextBox2.Text & "', pass = '" & TextBox3.Text & "'  where id_user = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            MessageBox.Show("Data Berhasil Di Update", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call tampilAdmin()
            Call aturDGV()
            Call bersih()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Then
            MessageBox.Show("Pilih terlebih dahulu data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo, "Pilihan!") = MsgBoxResult.Yes Then
                Call Koneksi()
                Cmd = New OdbcCommand("Delete From admin where id_pengajar ='" & TextBox1.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                Call tampilAdmin()
                Call aturDGV()
                Call bersih()

            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call bersih()
        Call tampilAdmin()
        Call aturDGV()
    End Sub
End Class