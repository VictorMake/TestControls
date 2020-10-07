<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlListBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ListBox = New System.Windows.Forms.ListBox
        Me.LabelText = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ListBox)
        Me.Panel1.Controls.Add(Me.LabelText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 1
        '
        'ListBox
        '
        Me.ListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(0, 15)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(196, 69)
        Me.ListBox.TabIndex = 1
        '
        'LabelText
        '
        Me.LabelText.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelText.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelText.Location = New System.Drawing.Point(0, 0)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(196, 15)
        Me.LabelText.TabIndex = 0
        '
        'UserControlListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlListBox"
        Me.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents LabelText As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
