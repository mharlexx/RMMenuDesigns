<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log_in_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Log_in_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBL_change_pw = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username_text = New System.Windows.Forms.TextBox()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Password_text = New System.Windows.Forms.TextBox()
        Me.Log_in_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LBL_change_pw)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Username_text)
        Me.Panel1.Controls.Add(Me.Close_btn)
        Me.Panel1.Controls.Add(Me.Password_text)
        Me.Panel1.Controls.Add(Me.Log_in_btn)
        Me.Panel1.Location = New System.Drawing.Point(281, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 240)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(177, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(176, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "username"
        '
        'LBL_change_pw
        '
        Me.LBL_change_pw.AutoSize = True
        Me.LBL_change_pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_change_pw.ForeColor = System.Drawing.Color.White
        Me.LBL_change_pw.Location = New System.Drawing.Point(153, 218)
        Me.LBL_change_pw.Name = "LBL_change_pw"
        Me.LBL_change_pw.Size = New System.Drawing.Size(93, 13)
        Me.LBL_change_pw.TabIndex = 6
        Me.LBL_change_pw.Text = "Change Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Supply Built Inventory Management System"
        '
        'Username_text
        '
        Me.Username_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_text.Location = New System.Drawing.Point(56, 60)
        Me.Username_text.Name = "Username_text"
        Me.Username_text.Size = New System.Drawing.Size(294, 26)
        Me.Username_text.TabIndex = 0
        Me.Username_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Close_btn
        '
        Me.Close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_btn.Location = New System.Drawing.Point(214, 171)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(117, 32)
        Me.Close_btn.TabIndex = 4
        Me.Close_btn.Text = "Close"
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'Password_text
        '
        Me.Password_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_text.Location = New System.Drawing.Point(56, 110)
        Me.Password_text.Name = "Password_text"
        Me.Password_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_text.Size = New System.Drawing.Size(294, 26)
        Me.Password_text.TabIndex = 2
        Me.Password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Log_in_btn
        '
        Me.Log_in_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_in_btn.Location = New System.Drawing.Point(73, 171)
        Me.Log_in_btn.Name = "Log_in_btn"
        Me.Log_in_btn.Size = New System.Drawing.Size(117, 32)
        Me.Log_in_btn.TabIndex = 3
        Me.Log_in_btn.Text = "Login"
        Me.Log_in_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Log_in_form
        '
        Me.AcceptButton = Me.Log_in_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Log_in_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB23 - Supply Built Inventory Management System"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_change_pw As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Username_text As TextBox
    Friend WithEvents Close_btn As Button
    Friend WithEvents Password_text As TextBox
    Friend WithEvents Log_in_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
