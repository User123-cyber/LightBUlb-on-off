<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Prelim = New Label()
        Midterm = New Label()
        Semi = New Label()
        TxtName = New TextBox()
        TxtAddress = New TextBox()
        TxtPrelim = New TextBox()
        TxtCourse = New TextBox()
        Txtlevel = New TextBox()
        Txtmid = New TextBox()
        Txtsemi = New TextBox()
        BtnDisplay = New Button()
        btnClear = New Button()
        btnExit = New Button()
        LblFinalGrade = New Label()
        Finals = New Label()
        TxtFinal = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student's Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 1
        Label2.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 2
        Label3.Text = "Course"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 3
        Label4.Text = "Level"
        ' 
        ' Prelim
        ' 
        Prelim.AutoSize = True
        Prelim.Location = New Point(272, 19)
        Prelim.Name = "Prelim"
        Prelim.Size = New Size(41, 15)
        Prelim.TabIndex = 4
        Prelim.Text = "Prelim"
        ' 
        ' Midterm
        ' 
        Midterm.AutoSize = True
        Midterm.Location = New Point(265, 75)
        Midterm.Name = "Midterm"
        Midterm.Size = New Size(53, 15)
        Midterm.TabIndex = 5
        Midterm.Text = "Midterm"
        ' 
        ' Semi
        ' 
        Semi.AutoSize = True
        Semi.Location = New Point(280, 133)
        Semi.Name = "Semi"
        Semi.Size = New Size(33, 15)
        Semi.TabIndex = 6
        Semi.Text = "Semi"
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(123, 16)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(100, 23)
        TxtName.TabIndex = 7
        ' 
        ' TxtAddress
        ' 
        TxtAddress.Location = New Point(123, 72)
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(100, 23)
        TxtAddress.TabIndex = 8
        ' 
        ' TxtPrelim
        ' 
        TxtPrelim.Location = New Point(338, 16)
        TxtPrelim.Name = "TxtPrelim"
        TxtPrelim.Size = New Size(100, 23)
        TxtPrelim.TabIndex = 9
        ' 
        ' TxtCourse
        ' 
        TxtCourse.Location = New Point(123, 115)
        TxtCourse.Name = "TxtCourse"
        TxtCourse.Size = New Size(100, 23)
        TxtCourse.TabIndex = 10
        ' 
        ' Txtlevel
        ' 
        Txtlevel.Location = New Point(123, 164)
        Txtlevel.Name = "Txtlevel"
        Txtlevel.Size = New Size(100, 23)
        Txtlevel.TabIndex = 11
        ' 
        ' Txtmid
        ' 
        Txtmid.Location = New Point(338, 72)
        Txtmid.Name = "Txtmid"
        Txtmid.Size = New Size(100, 23)
        Txtmid.TabIndex = 12
        ' 
        ' Txtsemi
        ' 
        Txtsemi.Location = New Point(338, 130)
        Txtsemi.Name = "Txtsemi"
        Txtsemi.Size = New Size(100, 23)
        Txtsemi.TabIndex = 13
        ' 
        ' BtnDisplay
        ' 
        BtnDisplay.Location = New Point(63, 344)
        BtnDisplay.Name = "BtnDisplay"
        BtnDisplay.Size = New Size(75, 23)
        BtnDisplay.TabIndex = 14
        BtnDisplay.Text = "Display"
        BtnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(195, 344)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(321, 344)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 16
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' LblFinalGrade
        ' 
        LblFinalGrade.Location = New Point(70, 212)
        LblFinalGrade.Name = "LblFinalGrade"
        LblFinalGrade.Size = New Size(153, 74)
        LblFinalGrade.TabIndex = 17
        ' 
        ' Finals
        ' 
        Finals.AutoSize = True
        Finals.Location = New Point(276, 186)
        Finals.Name = "Finals"
        Finals.Size = New Size(37, 15)
        Finals.TabIndex = 18
        Finals.Text = "Finals"
        ' 
        ' TxtFinal
        ' 
        TxtFinal.Location = New Point(338, 186)
        TxtFinal.Name = "TxtFinal"
        TxtFinal.Size = New Size(100, 23)
        TxtFinal.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 391)
        Controls.Add(TxtFinal)
        Controls.Add(Finals)
        Controls.Add(LblFinalGrade)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(BtnDisplay)
        Controls.Add(Txtsemi)
        Controls.Add(Txtmid)
        Controls.Add(Txtlevel)
        Controls.Add(TxtCourse)
        Controls.Add(TxtPrelim)
        Controls.Add(TxtAddress)
        Controls.Add(TxtName)
        Controls.Add(Semi)
        Controls.Add(Midterm)
        Controls.Add(Prelim)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Student's Profile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Prelim As Label
    Friend WithEvents Midterm As Label
    Friend WithEvents Semi As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtPrelim As TextBox
    Friend WithEvents TxtCourse As TextBox
    Friend WithEvents Txtlevel As TextBox
    Friend WithEvents Txtmid As TextBox
    Friend WithEvents Txtsemi As TextBox
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LblFinalGrade As Label
    Friend WithEvents Finals As Label
    Friend WithEvents TxtFinal As TextBox

End Class
