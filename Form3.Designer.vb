<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.cmdProfile = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.cmdLecturer = New System.Windows.Forms.Button()
        Me.cmdStudent = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdProfile
        '
        Me.cmdProfile.BackColor = System.Drawing.Color.Purple
        Me.cmdProfile.ForeColor = System.Drawing.Color.White
        Me.cmdProfile.Location = New System.Drawing.Point(93, 114)
        Me.cmdProfile.Name = "cmdProfile"
        Me.cmdProfile.Size = New System.Drawing.Size(195, 32)
        Me.cmdProfile.TabIndex = 24
        Me.cmdProfile.Text = "ADMINS"
        Me.cmdProfile.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.Purple
        Me.cmdReturn.ForeColor = System.Drawing.Color.White
        Me.cmdReturn.Location = New System.Drawing.Point(93, 302)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(195, 32)
        Me.cmdReturn.TabIndex = 23
        Me.cmdReturn.Text = "RETURN"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdLecturer
        '
        Me.cmdLecturer.BackColor = System.Drawing.Color.Purple
        Me.cmdLecturer.ForeColor = System.Drawing.Color.White
        Me.cmdLecturer.Location = New System.Drawing.Point(93, 243)
        Me.cmdLecturer.Name = "cmdLecturer"
        Me.cmdLecturer.Size = New System.Drawing.Size(195, 32)
        Me.cmdLecturer.TabIndex = 22
        Me.cmdLecturer.Text = "LECTURERS"
        Me.cmdLecturer.UseVisualStyleBackColor = False
        '
        'cmdStudent
        '
        Me.cmdStudent.BackColor = System.Drawing.Color.Purple
        Me.cmdStudent.ForeColor = System.Drawing.Color.White
        Me.cmdStudent.Location = New System.Drawing.Point(93, 178)
        Me.cmdStudent.Name = "cmdStudent"
        Me.cmdStudent.Size = New System.Drawing.Size(195, 32)
        Me.cmdStudent.TabIndex = 21
        Me.cmdStudent.Text = "STUDENTS"
        Me.cmdStudent.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(90, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Click a Button to do an Activity"
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHello.Location = New System.Drawing.Point(137, 20)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(40, 17)
        Me.lblHello.TabIndex = 19
        Me.lblHello.Text = "Hello"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(379, 354)
        Me.Controls.Add(Me.cmdProfile)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.cmdLecturer)
        Me.Controls.Add(Me.cmdStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHello)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProfile As System.Windows.Forms.Button
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents cmdLecturer As System.Windows.Forms.Button
    Friend WithEvents cmdStudent As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHello As System.Windows.Forms.Label
End Class
