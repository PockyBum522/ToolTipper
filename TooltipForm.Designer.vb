<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TooltipForm
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
        Me.Tooltip_3s = New System.Windows.Forms.Button()
        Me.Tooltip_10s = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tooltip_3s
        '
        Me.Tooltip_3s.Location = New System.Drawing.Point(12, 12)
        Me.Tooltip_3s.Name = "Tooltip_3s"
        Me.Tooltip_3s.Size = New System.Drawing.Size(117, 23)
        Me.Tooltip_3s.TabIndex = 0
        Me.Tooltip_3s.Text = "Get 3 second tooltip"
        Me.Tooltip_3s.UseVisualStyleBackColor = True
        '
        'Tooltip_10s
        '
        Me.Tooltip_10s.Location = New System.Drawing.Point(12, 41)
        Me.Tooltip_10s.Name = "Tooltip_10s"
        Me.Tooltip_10s.Size = New System.Drawing.Size(117, 23)
        Me.Tooltip_10s.TabIndex = 1
        Me.Tooltip_10s.Text = "Get 10 second tooltip"
        Me.Tooltip_10s.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Get long text tooltip"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hide above tooltip"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TooltipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(143, 138)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tooltip_10s)
        Me.Controls.Add(Me.Tooltip_3s)
        Me.Name = "TooltipForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tooltip_3s As Button
    Friend WithEvents Tooltip_10s As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
