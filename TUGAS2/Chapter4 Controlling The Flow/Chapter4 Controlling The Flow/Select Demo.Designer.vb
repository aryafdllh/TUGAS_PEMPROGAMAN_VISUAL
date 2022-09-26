<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Case
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
        Me.lstData1 = New System.Windows.Forms.ListBox()
        Me.lstData2 = New System.Windows.Forms.ListBox()
        Me.lstData3 = New System.Windows.Forms.ListBox()
        Me.lstData4 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.Items.AddRange(New Object() {"Bryan", "Ashley", "Jennifer", "Ediie", "Katelyn"})
        Me.lstData.Location = New System.Drawing.Point(0, 0)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(120, 261)
        Me.lstData.TabIndex = 0
        '
        'lstData1
        '
        Me.lstData1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstData1.FormattingEnabled = True
        Me.lstData1.IntegralHeight = False
        Me.lstData1.Items.AddRange(New Object() {"BRYAN", "ASHLEY", "JENNIFER", "EDIIE", "KATELYN"})
        Me.lstData1.Location = New System.Drawing.Point(120, 0)
        Me.lstData1.Name = "lstData1"
        Me.lstData1.Size = New System.Drawing.Size(120, 261)
        Me.lstData1.TabIndex = 1
        '
        'lstData2
        '
        Me.lstData2.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstData2.FormattingEnabled = True
        Me.lstData2.IntegralHeight = False
        Me.lstData2.Items.AddRange(New Object() {"BRYAN", "ASHLEY", "JENNIFER", "EDIIE", "KATELYN"})
        Me.lstData2.Location = New System.Drawing.Point(240, 0)
        Me.lstData2.Name = "lstData2"
        Me.lstData2.Size = New System.Drawing.Size(120, 261)
        Me.lstData2.TabIndex = 2
        '
        'lstData3
        '
        Me.lstData3.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstData3.FormattingEnabled = True
        Me.lstData3.IntegralHeight = False
        Me.lstData3.Items.AddRange(New Object() {"BRYAN", "ASHLEY", "JENNIFER", "EDIIE", "KATELYN"})
        Me.lstData3.Location = New System.Drawing.Point(360, 0)
        Me.lstData3.Name = "lstData3"
        Me.lstData3.Size = New System.Drawing.Size(120, 261)
        Me.lstData3.TabIndex = 3
        '
        'lstData4
        '
        Me.lstData4.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstData4.FormattingEnabled = True
        Me.lstData4.IntegralHeight = False
        Me.lstData4.Items.AddRange(New Object() {"BRYAN", "ASHLEY", "JENNIFER", "EDIIE", "KATELYN", "YAAR"})
        Me.lstData4.Location = New System.Drawing.Point(480, 0)
        Me.lstData4.Name = "lstData4"
        Me.lstData4.Size = New System.Drawing.Size(120, 261)
        Me.lstData4.TabIndex = 4
        '
        'Select_Case
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 261)
        Me.Controls.Add(Me.lstData4)
        Me.Controls.Add(Me.lstData3)
        Me.Controls.Add(Me.lstData2)
        Me.Controls.Add(Me.lstData1)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Select_Case"
        Me.Text = "Select_Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents lstData1 As ListBox
    Friend WithEvents lstData2 As ListBox
    Friend WithEvents lstData3 As ListBox
    Friend WithEvents lstData4 As ListBox
End Class
