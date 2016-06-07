<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblAllbwn = New System.Windows.Forms.Label()
        Me.btnTrosi = New System.Windows.Forms.Button()
        Me.txtNod = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAllbwn
        '
        Me.lblAllbwn.AutoSize = True
        Me.lblAllbwn.Location = New System.Drawing.Point(25, 131)
        Me.lblAllbwn.Name = "lblAllbwn"
        Me.lblAllbwn.Size = New System.Drawing.Size(39, 13)
        Me.lblAllbwn.TabIndex = 0
        Me.lblAllbwn.Text = "Label1"
        '
        'btnTrosi
        '
        Me.btnTrosi.Location = New System.Drawing.Point(191, 63)
        Me.btnTrosi.Name = "btnTrosi"
        Me.btnTrosi.Size = New System.Drawing.Size(71, 40)
        Me.btnTrosi.TabIndex = 1
        Me.btnTrosi.Text = "Trosi"
        Me.btnTrosi.UseVisualStyleBackColor = True
        '
        'txtNod
        '
        Me.txtNod.Location = New System.Drawing.Point(24, 67)
        Me.txtNod.Name = "txtNod"
        Me.txtNod.Size = New System.Drawing.Size(117, 20)
        Me.txtNod.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtNod)
        Me.Controls.Add(Me.btnTrosi)
        Me.Controls.Add(Me.lblAllbwn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAllbwn As System.Windows.Forms.Label
    Friend WithEvents btnTrosi As System.Windows.Forms.Button
    Friend WithEvents txtNod As System.Windows.Forms.TextBox

End Class
