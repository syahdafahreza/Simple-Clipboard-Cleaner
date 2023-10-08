Imports System.Windows.Forms
Public Class Form1
    Private Sub btncleanclip_Click(sender As Object, e As EventArgs) Handles btncleanclip.Click
        ' Clear the clipboard contents
        Clipboard.Clear()

        ' Optionally, provide feedback to the user
        MessageBox.Show("Clipboard cleared!", "Clipboard Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
