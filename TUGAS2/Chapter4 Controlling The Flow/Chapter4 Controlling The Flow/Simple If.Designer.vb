<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simple_If
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
        Me.btnIf = New System.Windows.Forms.Button()
        Me.btnAnotherIf = New System.Windows.Forms.Button()
        Me.btnAnotherIf1 = New System.Windows.Forms.Button()
        Me.btnAnotherIf2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIf
        '
        Me.btnIf.Location = New System.Drawing.Point(12, 12)
        Me.btnIf.Name = "btnIf"
        Me.btnIf.Size = New System.Drawing.Size(75, 23)
        Me.btnIf.TabIndex = 0
        Me.btnIf.Text = "If"
        Me.btnIf.UseVisualStyleBackColor = True
        '
        'btnAnotherIf
        '
        Me.btnAnotherIf.Location = New System.Drawing.Point(12, 41)
        Me.btnAnotherIf.Name = "btnAnotherIf"
        Me.btnAnotherIf.Size = New System.Drawing.Size(75, 23)
        Me.btnAnotherIf.TabIndex = 1
        Me.btnAnotherIf.Text = "Another If"
        Me.btnAnotherIf.UseVisualStyleBackColor = True
        '
        'btnAnotherIf1
        '
        Me.btnAnotherIf1.Location = New System.Drawing.Point(12, 70)
        Me.btnAnotherIf1.Name = "btnAnotherIf1"
        Me.btnAnotherIf1.Size = New System.Drawing.Size(75, 23)
        Me.btnAnotherIf1.TabIndex = 2
        Me.btnAnotherIf1.Text = "Another If1"
        Me.btnAnotherIf1.UseVisualStyleBackColor = True
        '
        'btnAnotherIf2
        '
        Me.btnAnotherIf2.Location = New System.Drawing.Point(12, 99)
        Me.btnAnotherIf2.Name = "btnAnotherIf2"
        Me.btnAnotherIf2.Size = New System.Drawing.Size(75, 23)
        Me.btnAnotherIf2.TabIndex = 3
        Me.btnAnotherIf2.Text = "Another If2"
        Me.btnAnotherIf2.UseVisualStyleBackColor = True
        '
        'Simple_If
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnAnotherIf2)
        Me.Controls.Add(Me.btnAnotherIf1)
        Me.Controls.Add(Me.btnAnotherIf)
        Me.Controls.Add(Me.btnIf)
        Me.Name = "Simple_If"
        Me.Text = "Simple_If"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIf As Button
    Friend WithEvents btnAnotherIf As Button
    Friend WithEvents btnAnotherIf1 As Button
    Friend WithEvents btnAnotherIf2 As Button
End Class
