Imports System.Data.Odbc
Public Class RegisForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InputButton.Click
        If NameTextBox.Text = "" Or
           AdressTextBox.Text = "" Or
           AgeTextBox.Text = "" Or
           PhoneTextBox.Text = "" Or
           GradeComboBox.SelectedItem = "" Then
            MessageBox.Show("Data Harus Terisi Lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("INSERT INTO `murid` (`Nama`, `Alamat`, `Umur`, `No_telp`, `Grade`)
            VALUES ('" & NameTextBox.Text & "', '" & AdressTextBox.Text & "', '" & AgeTextBox.Text & "', '" & PhoneTextBox.Text & "', '" & GradeComboBox.SelectedItem & "')", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            NameTextBox.Clear()
            AdressTextBox.Clear()
            AgeTextBox.Clear()
            PhoneTextBox.Clear()
            GradeComboBox.ResetText()

            MessageBox.Show("Data Berhasil Di Input", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NameTextBox.Clear()
        AdressTextBox.Clear()
        AgeTextBox.Clear()
        PhoneTextBox.Clear()
        GradeComboBox.ResetText()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class