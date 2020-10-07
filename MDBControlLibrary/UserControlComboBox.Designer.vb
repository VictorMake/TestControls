<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlComboBox
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
        Me.ComboBox = New System.Windows.Forms.ComboBox
        Me.LabelText = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox)
        Me.Panel1.Controls.Add(Me.LabelText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 1
        '
        'ComboBox
        '
        Me.ComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(0, 15)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(196, 81)
        Me.ComboBox.Sorted = True
        Me.ComboBox.TabIndex = 1
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
        'UserControlComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlComboBox"
        Me.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelText As System.Windows.Forms.Label
    Friend WithEvents ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
