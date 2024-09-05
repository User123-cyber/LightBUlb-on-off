Public Class Form1
    'Date: September 5, 2024
    'Programmed by: nash Emmanuel Sumalinog
    'Description:
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BulbOff.Visible = True
        Bulbon.Visible = False
    End Sub

    Private Sub Yellow_CheckedChanged(sender As Object, e As EventArgs) Handles Yellow.CheckedChanged
        BulbOff.Visible = False
        Bulbon.Visible = True
        Label2.ForeColor = Color.Yellow

    End Sub

    Private Sub Blue_CheckedChanged(sender As Object, e As EventArgs) Handles Blue.CheckedChanged
        BulbOff.Visible = False
        Bulbon.Visible = True
        Label2.ForeColor = Color.Blue

    End Sub

    Private Sub Red_CheckedChanged(sender As Object, e As EventArgs) Handles Red.CheckedChanged
        BulbOff.Visible = False
        Bulbon.Visible = True
        Label2.ForeColor = Color.Red

    End Sub

    Private Sub Green_CheckedChanged(sender As Object, e As EventArgs) Handles Green.CheckedChanged
        BulbOff.Visible = False
        Bulbon.Visible = True
        Label2.ForeColor = Color.Green

    End Sub

    Private Sub BulbOff_Click(sender As Object, e As EventArgs) Handles BulbOff.Click
        Bulbon.Visible = True
        BulbOff.Visible = False
        Label2.Visible = True
        Label2.Text = "Light is turn on, Maribella "

    End Sub

    Private Sub Bulbon_Click(sender As Object, e As EventArgs) Handles Bulbon.Click
        Bulbon.Visible = False
        BulbOff.Visible = True
        Label2.Text = " Light is turn off, Maribella "
        Label2.Visible = True



    End Sub
End Class