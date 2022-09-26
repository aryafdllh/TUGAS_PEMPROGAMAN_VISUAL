<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class If_Demo
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnChekNumbers = New System.Windows.Forms.Button()
        Me.btnCheckNumbers1 = New System.Windows.Forms.Button()
        Me.btnCheckNumbers2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Stephanie"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(152, 12)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(120, 23)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(12, 38)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(134, 20)
        Me.txtValue.TabIndex = 2
        '
        'btnChekNumbers
        '
        Me.btnChekNumbers.Location = New System.Drawing.Point(152, 39)
        Me.btnChekNumbers.Name = "btnChekNumbers"
        Me.btnChekNumbers.Size = New System.Drawing.Size(120, 23)
        Me.btnChekNumbers.TabIndex = 3
        Me.btnChekNumbers.Text = "Check Numbers"
        Me.btnChekNumbers.UseVisualStyleBackColor = True
        '
        'btnCheckNumbers1
        '
        Me.btnCheckNumbers1.Location = New System.Drawing.Point(152, 68)
        Me.btnCheckNumbers1.Name = "btnCheckNumbers1"
        Me.btnCheckNumbers1.Size = New System.Drawing.Size(120, 23)
        Me.btnCheckNumbers1.TabIndex = 4
        Me.btnCheckNumbers1.Text = "Check Numbers1"
        Me.btnCheckNumbers1.UseVisualStyleBackColor = True
        '
        'btnCheckNumbers2
        '
        Me.btnCheckNumbers2.Location = New System.Drawing.Point(152, 97)
        Me.btnCheckNumbers2.Name = "btnCheckNumbers2"
        Me.btnCheckNumbers2.Size = New System.Drawing.Size(120, 23)
        Me.btnCheckNumbers2.TabIndex = 5
        Me.btnCheckNumbers2.Text = "Check Numbers2"
        Me.btnCheckNumbers2.UseVisualStyleBackColor = True
        '
        'If_Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCheckNumbers2)
        Me.Controls.Add(Me.btnCheckNumbers1)
        Me.Controls.Add(Me.btnChekNumbers)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtName)
        Me.Name = "If_Demo"
        Me.Text = "If_Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnChekNumbers As Button
    Friend WithEvents btnCheckNumbers1 As Button
    Friend WithEvents btnCheckNumbers2 As Button
End Class
