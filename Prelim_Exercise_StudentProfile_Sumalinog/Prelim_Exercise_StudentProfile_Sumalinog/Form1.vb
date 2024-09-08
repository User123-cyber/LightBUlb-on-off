Public Class Form1
    'September 6, 2024'
    'Programmed by: Nash Emmanuel Sumalinog'
    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click


        Dim Prelim As Double
        Dim Midterm As Double
        Dim Semi As Double
        Dim Finals As Double
        Dim FinalGrade As Double


        Prelim = CDbl(TxtPrelim.Text)
        Midterm = CDbl(Txtmid.Text)
        Semi = CDbl(Txtsemi.Text)
        Finals = CDbl(TxtFinal.Text)


        FinalGrade = (Prelim + Midterm + Semi + Finals) / 4


        LblFinalGrade.Text = "Student: " & TxtName.Text & vbCrLf &
                             "Address: " & TxtAddress.Text & vbCrLf &
                             "Course: " & TxtCourse.Text & vbCrLf &
                             "Level: " & Txtlevel.Text & vbCrLf &
                             "Final Grade: " & FinalGrade.ToString("F2") ' Format the grade to 2 decimal places

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtName.Clear()
        TxtAddress.Clear()
        TxtCourse.Clear()
        Txtlevel.Clear()
        TxtPrelim.Clear()
        Txtmid.Clear()
        Txtsemi.Clear()
        TxtFinal.Clear()
        LblFinalGrade.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
