Imports System.Data.Odbc
Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Kode Admin dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From admin where
username='" & UsernameTextBox.Text & "' and pass='" & PasswordTextBox.Text &
"'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MainForm.Show()
                Me.Hide()
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            Else
                MsgBox("Username atau Password Salah!")
            End If
        End If

    End Sub
End Class
