<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdRegister = New System.Windows.Forms.Button()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.ForeColor = System.Drawing.Color.White
        Me.lblProgram.Location = New System.Drawing.Point(154, 72)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(51, 17)
        Me.lblProgram.TabIndex = 121
        Me.lblProgram.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Program:"
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.BlueViolet
        Me.cmdBack.ForeColor = System.Drawing.Color.White
        Me.cmdBack.Location = New System.Drawing.Point(450, 302)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(120, 34)
        Me.cmdBack.TabIndex = 119
        Me.cmdBack.Text = "GO BACK"
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'cmdRegister
        '
        Me.cmdRegister.BackColor = System.Drawing.Color.BlueViolet
        Me.cmdRegister.ForeColor = System.Drawing.Color.White
        Me.cmdRegister.Location = New System.Drawing.Point(450, 234)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Size = New System.Drawing.Size(120, 36)
        Me.cmdRegister.TabIndex = 118
        Me.cmdRegister.Text = "REGISTER"
        Me.cmdRegister.UseVisualStyleBackColor = False
        '
        'txtCounter
        '
        Me.txtCounter.Location = New System.Drawing.Point(223, 391)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.Size = New System.Drawing.Size(100, 23)
        Me.txtCounter.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "No. of Courses Registered:"
        '
        'cmdRemove
        '
        Me.cmdRemove.BackColor = System.Drawing.Color.BlueViolet
        Me.cmdRemove.ForeColor = System.Drawing.Color.White
        Me.cmdRemove.Location = New System.Drawing.Point(450, 168)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(120, 36)
        Me.cmdRemove.TabIndex = 115
        Me.cmdRemove.Text = "REMOVE"
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.ItemHeight = 16
        Me.lstCourses.Location = New System.Drawing.Point(41, 195)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(253, 180)
        Me.lstCourses.TabIndex = 114
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.BlueViolet
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(450, 105)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(120, 36)
        Me.cmdAdd.TabIndex = 113
        Me.cmdAdd.Text = "ADD"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(38, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Semester:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(38, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Course:"
        '
        'cboSemester
        '
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(157, 153)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(236, 24)
        Me.cboSemester.TabIndex = 110
        '
        'cboCourse
        '
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(157, 112)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(236, 24)
        Me.cboCourse.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(137, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Welcome to Semester Registration Menu for Students"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(609, 449)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdRegister)
        Me.Controls.Add(Me.txtCounter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form11"
        Me.Text = "Form11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdRegister As System.Windows.Forms.Button
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents lstCourses As System.Windows.Forms.ListBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
