<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loops
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.btnForNextLoopWithStep = New System.Windows.Forms.Button()
        Me.btnBackwardsForNextLoop = New System.Windows.Forms.Button()
        Me.btnForEachLoop = New System.Windows.Forms.Button()
        Me.btnDoUntilLoop = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnNestedLoops = New System.Windows.Forms.Button()
        Me.btnQuittingAForLoop = New System.Windows.Forms.Button()
        Me.btnQuittingADoLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.Location = New System.Drawing.Point(12, 12)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(178, 342)
        Me.lstData.TabIndex = 0
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(196, 12)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnForNextLoop.TabIndex = 1
        Me.btnForNextLoop.Text = "For Next Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForNextLoopWithStep
        '
        Me.btnForNextLoopWithStep.Location = New System.Drawing.Point(196, 41)
        Me.btnForNextLoopWithStep.Name = "btnForNextLoopWithStep"
        Me.btnForNextLoopWithStep.Size = New System.Drawing.Size(171, 23)
        Me.btnForNextLoopWithStep.TabIndex = 2
        Me.btnForNextLoopWithStep.Text = " For Next Loop w/ Step"
        Me.btnForNextLoopWithStep.UseVisualStyleBackColor = True
        '
        'btnBackwardsForNextLoop
        '
        Me.btnBackwardsForNextLoop.Location = New System.Drawing.Point(196, 70)
        Me.btnBackwardsForNextLoop.Name = "btnBackwardsForNextLoop"
        Me.btnBackwardsForNextLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnBackwardsForNextLoop.TabIndex = 3
        Me.btnBackwardsForNextLoop.Text = "Backwards For Next Loop"
        Me.btnBackwardsForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForEachLoop
        '
        Me.btnForEachLoop.Location = New System.Drawing.Point(196, 99)
        Me.btnForEachLoop.Name = "btnForEachLoop"
        Me.btnForEachLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnForEachLoop.TabIndex = 4
        Me.btnForEachLoop.Text = " For Each Loop"
        Me.btnForEachLoop.UseVisualStyleBackColor = True
        '
        'btnDoUntilLoop
        '
        Me.btnDoUntilLoop.Location = New System.Drawing.Point(196, 128)
        Me.btnDoUntilLoop.Name = "btnDoUntilLoop"
        Me.btnDoUntilLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnDoUntilLoop.TabIndex = 5
        Me.btnDoUntilLoop.Text = "Do Until Loop"
        Me.btnDoUntilLoop.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(196, 157)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnDoWhileLoop.TabIndex = 6
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnNestedLoops
        '
        Me.btnNestedLoops.Location = New System.Drawing.Point(196, 186)
        Me.btnNestedLoops.Name = "btnNestedLoops"
        Me.btnNestedLoops.Size = New System.Drawing.Size(171, 23)
        Me.btnNestedLoops.TabIndex = 7
        Me.btnNestedLoops.Text = "Nested Loops"
        Me.btnNestedLoops.UseVisualStyleBackColor = True
        '
        'btnQuittingAForLoop
        '
        Me.btnQuittingAForLoop.Location = New System.Drawing.Point(196, 215)
        Me.btnQuittingAForLoop.Name = "btnQuittingAForLoop"
        Me.btnQuittingAForLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnQuittingAForLoop.TabIndex = 8
        Me.btnQuittingAForLoop.Text = "Quitting A For Loop"
        Me.btnQuittingAForLoop.UseVisualStyleBackColor = True
        '
        'btnQuittingADoLoop
        '
        Me.btnQuittingADoLoop.Location = New System.Drawing.Point(196, 244)
        Me.btnQuittingADoLoop.Name = "btnQuittingADoLoop"
        Me.btnQuittingADoLoop.Size = New System.Drawing.Size(171, 23)
        Me.btnQuittingADoLoop.TabIndex = 9
        Me.btnQuittingADoLoop.Text = "Quitting A Do Loop"
        Me.btnQuittingADoLoop.UseVisualStyleBackColor = True
        '
        'Loops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 361)
        Me.Controls.Add(Me.btnQuittingADoLoop)
        Me.Controls.Add(Me.btnQuittingAForLoop)
        Me.Controls.Add(Me.btnNestedLoops)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoUntilLoop)
        Me.Controls.Add(Me.btnForEachLoop)
        Me.Controls.Add(Me.btnBackwardsForNextLoop)
        Me.Controls.Add(Me.btnForNextLoopWithStep)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Loops"
        Me.Text = "Loops"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents btnForNextLoop As Button
    Friend WithEvents btnForNextLoopWithStep As Button
    Friend WithEvents btnBackwardsForNextLoop As Button
    Friend WithEvents btnForEachLoop As Button
    Friend WithEvents btnDoUntilLoop As Button
    Friend WithEvents btnDoWhileLoop As Button
    Friend WithEvents btnNestedLoops As Button
    Friend WithEvents btnQuittingAForLoop As Button
    Friend WithEvents btnQuittingADoLoop As Button
End Class
