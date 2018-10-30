<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdLecturer = New System.Windows.Forms.Button()
        Me.cmdStudent = New System.Windows.Forms.Button()
        Me.cmdAdmin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdExit.Location = New System.Drawing.Point(273, 370)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(139, 36)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Text = "EXIT"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdLecturer
        '
        Me.cmdLecturer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdLecturer.Location = New System.Drawing.Point(273, 313)
        Me.cmdLecturer.Name = "cmdLecturer"
        Me.cmdLecturer.Size = New System.Drawing.Size(139, 36)
        Me.cmdLecturer.TabIndex = 10
        Me.cmdLecturer.Text = "LECTURER"
        Me.cmdLecturer.UseVisualStyleBackColor = False
        '
        'cmdStudent
        '
        Me.cmdStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdStudent.Location = New System.Drawing.Point(273, 254)
        Me.cmdStudent.Name = "cmdStudent"
        Me.cmdStudent.Size = New System.Drawing.Size(139, 36)
        Me.cmdStudent.TabIndex = 9
        Me.cmdStudent.Text = "STUDENT"
        Me.cmdStudent.UseVisualStyleBackColor = False
        '
        'cmdAdmin
        '
        Me.cmdAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdAdmin.Location = New System.Drawing.Point(273, 193)
        Me.cmdAdmin.Name = "cmdAdmin"
        Me.cmdAdmin.Size = New System.Drawing.Size(139, 36)
        Me.cmdAdmin.TabIndex = 8
        Me.cmdAdmin.Text = "ADMIN"
        Me.cmdAdmin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select the Type of User You Are"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "COLLEGE MANAGEMENT SYSTEM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(684, 428)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLecturer)
        Me.Controls.Add(Me.cmdStudent)
        Me.Controls.Add(Me.cmdAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdLecturer As System.Windows.Forms.Button
    Friend WithEvents cmdStudent As System.Windows.Forms.Button
    Friend WithEvents cmdAdmin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
