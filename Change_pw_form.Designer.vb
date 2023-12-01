<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_pw_form
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Text_confirm_pw = New System.Windows.Forms.TextBox()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Text_new_pw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(43, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "New password :"
        '
        'Close_btn
        '
        Me.Close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_btn.Location = New System.Drawing.Point(329, 116)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(117, 32)
        Me.Close_btn.TabIndex = 12
        Me.Close_btn.Text = "Cancel"
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'Text_confirm_pw
        '
        Me.Text_confirm_pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_confirm_pw.Location = New System.Drawing.Point(183, 73)
        Me.Text_confirm_pw.Name = "Text_confirm_pw"
        Me.Text_confirm_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_confirm_pw.Size = New System.Drawing.Size(294, 26)
        Me.Text_confirm_pw.TabIndex = 10
        Me.Text_confirm_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Update_btn
        '
        Me.Update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.Location = New System.Drawing.Point(206, 116)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(117, 32)
        Me.Update_btn.TabIndex = 11
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = True
        '
        'Text_new_pw
        '
        Me.Text_new_pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_new_pw.Location = New System.Drawing.Point(183, 24)
        Me.Text_new_pw.Name = "Text_new_pw"
        Me.Text_new_pw.Size = New System.Drawing.Size(294, 26)
        Me.Text_new_pw.TabIndex = 9
        Me.Text_new_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Confirm password :"
        '
        'Change_pw_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Text_new_pw)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.Text_confirm_pw)
        Me.Controls.Add(Me.Update_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Change_pw_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB23-Change Password Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Close_btn As Button
    Friend WithEvents Text_confirm_pw As TextBox
    Friend WithEvents Update_btn As Button
    Friend WithEvents Text_new_pw As TextBox
    Friend WithEvents Label3 As Label
End Class
