﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlDigitalBox
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
        Me.NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.LabelText = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.NumericEdit)
        Me.Panel1.Controls.Add(Me.LabelText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 40)
        Me.Panel1.TabIndex = 1
        '
        'NumericEdit
        '
        Me.NumericEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.NumericEdit.Location = New System.Drawing.Point(0, 15)
        Me.NumericEdit.Name = "NumericEdit"
        Me.NumericEdit.Size = New System.Drawing.Size(196, 20)
        Me.NumericEdit.TabIndex = 1
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
        'UserControlDigitalBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlDigitalBox"
        Me.Size = New System.Drawing.Size(200, 40)
        Me.Panel1.ResumeLayout(False)
        CType(Me.NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelText As System.Windows.Forms.Label
    Friend WithEvents NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
