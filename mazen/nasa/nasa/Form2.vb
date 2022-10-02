Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        Print("hey :3")
    End Sub
End Class