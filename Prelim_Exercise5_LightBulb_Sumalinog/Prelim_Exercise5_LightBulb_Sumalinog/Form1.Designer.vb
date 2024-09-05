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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Bulbon = New PictureBox()
        BulbOff = New PictureBox()
        Yellow = New RadioButton()
        Blue = New RadioButton()
        Red = New RadioButton()
        Green = New RadioButton()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        CType(Bulbon, ComponentModel.ISupportInitialize).BeginInit()
        CType(BulbOff, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 21)
        Label1.TabIndex = 0
        Label1.Text = "Enter Name:"
        ' 
        ' Bulbon
        ' 
        Bulbon.Image = CType(resources.GetObject("Bulbon.Image"), Image)
        Bulbon.Location = New Point(189, 129)
        Bulbon.Name = "Bulbon"
        Bulbon.Size = New Size(159, 177)
        Bulbon.SizeMode = PictureBoxSizeMode.StretchImage
        Bulbon.TabIndex = 1
        Bulbon.TabStop = False
        ' 
        ' BulbOff
        ' 
        BulbOff.Image = CType(resources.GetObject("BulbOff.Image"), Image)
        BulbOff.Location = New Point(189, 130)
        BulbOff.Name = "BulbOff"
        BulbOff.Size = New Size(159, 177)
        BulbOff.SizeMode = PictureBoxSizeMode.StretchImage
        BulbOff.TabIndex = 2
        BulbOff.TabStop = False
        ' 
        ' Yellow
        ' 
        Yellow.AutoSize = True
        Yellow.Location = New Point(34, 130)
        Yellow.Name = "Yellow"
        Yellow.Size = New Size(59, 19)
        Yellow.TabIndex = 3
        Yellow.TabStop = True
        Yellow.Text = "Yellow"
        Yellow.UseVisualStyleBackColor = True
        ' 
        ' Blue
        ' 
        Blue.AutoSize = True
        Blue.Location = New Point(34, 178)
        Blue.Name = "Blue"
        Blue.Size = New Size(48, 19)
        Blue.TabIndex = 4
        Blue.TabStop = True
        Blue.Text = "Blue"
        Blue.UseVisualStyleBackColor = True
        ' 
        ' Red
        ' 
        Red.AutoSize = True
        Red.Location = New Point(34, 233)
        Red.Name = "Red"
        Red.Size = New Size(45, 19)
        Red.TabIndex = 5
        Red.TabStop = True
        Red.Text = "Red"
        Red.UseVisualStyleBackColor = True
        ' 
        ' Green
        ' 
        Green.AutoSize = True
        Green.Location = New Point(34, 287)
        Green.Name = "Green"
        Green.Size = New Size(56, 19)
        Green.TabIndex = 6
        Green.TabStop = True
        Green.Text = "Green"
        Green.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        TextBox1.Location = New Point(139, 41)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(190, 23)
        TextBox1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(103, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 21)
        Label2.TabIndex = 8
        Label2.Text = "Light is Turn Off, Maribella"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(83, 386)
        Label3.Name = "Label3"
        Label3.Size = New Size(246, 15)
        Label3.TabIndex = 9
        Label3.Text = "Programmed by: Nash Emmanuel Sumalinog"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(393, 410)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Green)
        Controls.Add(Red)
        Controls.Add(Blue)
        Controls.Add(Yellow)
        Controls.Add(BulbOff)
        Controls.Add(Bulbon)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "The Switcher"
        CType(Bulbon, ComponentModel.ISupportInitialize).EndInit()
        CType(BulbOff, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bulbon As PictureBox
    Friend WithEvents BulbOff As PictureBox
    Friend WithEvents Yellow As RadioButton
    Friend WithEvents Blue As RadioButton
    Friend WithEvents Red As RadioButton
    Friend WithEvents Green As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
