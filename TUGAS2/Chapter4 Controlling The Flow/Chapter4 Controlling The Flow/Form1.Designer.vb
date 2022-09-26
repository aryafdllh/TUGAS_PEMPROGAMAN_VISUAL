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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpleIf = New System.Windows.Forms.Button()
        Me.btnIfDemo = New System.Windows.Forms.Button()
        Me.btnAndOrDemo = New System.Windows.Forms.Button()
        Me.btnSelectDemo = New System.Windows.Forms.Button()
        Me.btnLoops = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Chapter 4"
        '
        'btnSimpleIf
        '
        Me.btnSimpleIf.Location = New System.Drawing.Point(109, 92)
        Me.btnSimpleIf.Name = "btnSimpleIf"
        Me.btnSimpleIf.Size = New System.Drawing.Size(82, 23)
        Me.btnSimpleIf.TabIndex = 3
        Me.btnSimpleIf.Text = "Simple If"
        Me.btnSimpleIf.UseVisualStyleBackColor = True
        '
        'btnIfDemo
        '
        Me.btnIfDemo.Location = New System.Drawing.Point(109, 121)
        Me.btnIfDemo.Name = "btnIfDemo"
        Me.btnIfDemo.Size = New System.Drawing.Size(82, 23)
        Me.btnIfDemo.TabIndex = 4
        Me.btnIfDemo.Text = "If Demo"
        Me.btnIfDemo.UseVisualStyleBackColor = True
        '
        'btnAndOrDemo
        '
        Me.btnAndOrDemo.Location = New System.Drawing.Point(109, 150)
        Me.btnAndOrDemo.Name = "btnAndOrDemo"
        Me.btnAndOrDemo.Size = New System.Drawing.Size(82, 23)
        Me.btnAndOrDemo.TabIndex = 5
        Me.btnAndOrDemo.Text = "And Or Demo"
        Me.btnAndOrDemo.UseVisualStyleBackColor = True
        '
        'btnSelectDemo
        '
        Me.btnSelectDemo.Location = New System.Drawing.Point(109, 179)
        Me.btnSelectDemo.Name = "btnSelectDemo"
        Me.btnSelectDemo.Size = New System.Drawing.Size(82, 23)
        Me.btnSelectDemo.TabIndex = 6
        Me.btnSelectDemo.Text = "Select Demo"
        Me.btnSelectDemo.UseVisualStyleBackColor = True
        '
        'btnLoops
        '
        Me.btnLoops.Location = New System.Drawing.Point(109, 208)
        Me.btnLoops.Name = "btnLoops"
        Me.btnLoops.Size = New System.Drawing.Size(82, 23)
        Me.btnLoops.TabIndex = 7
        Me.btnLoops.Text = "Loops"
        Me.btnLoops.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnLoops)
        Me.Controls.Add(Me.btnSelectDemo)
        Me.Controls.Add(Me.btnAndOrDemo)
        Me.Controls.Add(Me.btnIfDemo)
        Me.Controls.Add(Me.btnSimpleIf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSimpleIf As Button
    Friend WithEvents btnIfDemo As Button
    Friend WithEvents btnAndOrDemo As Button
    Friend WithEvents btnSelectDemo As Button
    Friend WithEvents btnLoops As Button
End Class
