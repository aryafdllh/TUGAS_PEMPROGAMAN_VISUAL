﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnDateProperties = New System.Windows.Forms.Button()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnDateNames = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDateProperties
        '
        Me.btnDateProperties.Location = New System.Drawing.Point(115, 150)
        Me.btnDateProperties.Name = "btnDateProperties"
        Me.btnDateProperties.Size = New System.Drawing.Size(117, 36)
        Me.btnDateProperties.TabIndex = 5
        Me.btnDateProperties.Text = "Date Properties"
        Me.btnDateProperties.UseVisualStyleBackColor = True
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(53, 75)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(179, 42)
        Me.btnShowDate.TabIndex = 4
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnDateNames
        '
        Me.btnDateNames.Location = New System.Drawing.Point(298, 74)
        Me.btnDateNames.Name = "btnDateNames"
        Me.btnDateNames.Size = New System.Drawing.Size(146, 42)
        Me.btnDateNames.TabIndex = 6
        Me.btnDateNames.Text = "Date Names"
        Me.btnDateNames.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 369)
        Me.Controls.Add(Me.btnDateNames)
        Me.Controls.Add(Me.btnDateProperties)
        Me.Controls.Add(Me.btnShowDate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDateProperties As Button
    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnDateNames As Button
End Class
