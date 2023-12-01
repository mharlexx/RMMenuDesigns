Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class Log_in_form
    REM ============================================ CLOSE BUTTON ==========================================================

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dim result = MessageBox.Show("Are you sure you want to exit SB23?", "SB23 for Windows", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End


        End If
    End Sub
    REM ============================================ CLOSE BUTTON ==========================================================


    REM ============================================ LOG IN BUTTON ==========================================================
    Private Sub Log_in_btn_Click(sender As Object, e As EventArgs) Handles Log_in_btn.Click
        Dim connection As New SqlConnection("Data Source=WINERIC6_SERVER;Initial Catalog=RMMENU3;Persist Security Info=True;User ID=sa;Password=@dm1n")
        Dim command As New SqlCommand("select * from a_users where username = @username and password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = Username_text.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password_text.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)



        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Invalid Username or Password!", "Log in error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Username_text.Text = ""
            Password_text.Text = ""
            Username_text.Select()
        Else

            ' MessageBox.Show("Welcome " + table.Rows(0)(0))
            Me.Hide()
            Main_Form.Enabled = True
            Main_Form.TopMost = True

            Main_Form.Transdate.Enabled = True
            Main_Form.Transdate.Interval = 1000
            Main_Form.Transdate.Start()

            Main_Form.Lbl_employee_name.Text = "Welcome" + "   " + table.Rows(0)(0)

        End If
    End Sub
    REM ============================================ LOG IN BUTTON ==========================================================

    REM ============================================ CHANGE PASSWORD BUTTON ==========================================================
    Private Sub LBL_change_pw_Click(sender As Object, e As EventArgs) Handles LBL_change_pw.Click

        If Username_text.Text = "" Or Password_text.Text = "" Then
            MessageBox.Show("Please fill in username and password!", "Change password error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else

            Dim connection As New SqlConnection("Data Source=WINERIC6_SERVER;Initial Catalog=RMMENU3;Persist Security Info=True;User ID=sa;Password=@dm1n")
            Dim command As New SqlCommand("select * from a_users where username = @username and password = @password", connection)

            command.Parameters.Add("@username", SqlDbType.VarChar).Value = Username_text.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password_text.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)



            If table.Rows.Count() <= 0 Then

                MessageBox.Show("Invalid Username or Password!", "Changing Password error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Username_text.Text = ""
                Password_text.Text = ""
                Username_text.Select()
            Else

                Me.Enabled = False
                Me.TopMost = False
                Change_pw_form.Show()
                Change_pw_form.TopMost = True

            End If




        End If



    End Sub
    REM ============================================ CHANGE PASSWORD BUTTON ==========================================================


    Private Sub Log_in_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username_text.Select()
    End Sub





End Class