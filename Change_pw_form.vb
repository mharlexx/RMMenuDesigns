Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class Change_pw_form
    REM ============================================ CLOSE BUTTON ==========================================================

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dim result = MessageBox.Show("Are you sure you cancel?", "SB23 for Windows", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Text_new_pw.Text = ""
            Text_confirm_pw.Text = ""
            Me.Close()
            Log_in_form.Enabled = True
            Log_in_form.TopMost = True

        End If
    End Sub


    REM ============================================ CLOSE BUTTON ==========================================================

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click

        If Text_new_pw.Text = "" Or Text_confirm_pw.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Update User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else

            If Text_new_pw.Text = Text_confirm_pw.Text Then



                Dim connection As New SqlConnection("Data Source=WINERIC6_SERVER;Initial Catalog=RMMENU3;Persist Security Info=True;User ID=sa;Password=@dm1n")

                connection.Open()

                Try

                    Dim cmd = New SqlCommand("Update a_users set password=@password,date_modified=@date_modified
                                                 where username='" & Log_in_form.Username_text.Text & "'", connection)


                    cmd.Parameters.AddWithValue("@password", Text_new_pw.Text)
                    cmd.Parameters.AddWithValue("@date_modified", DateTime.Now.ToString("MM/dd/yyyy"))

                    cmd.ExecuteNonQuery()


                    MessageBox.Show("Password updated successfully")

                    Text_new_pw.Text = ""
                    Text_confirm_pw.Text = ""
                    Me.Close()
                    Log_in_form.Enabled = True


                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else


                MessageBox.Show("Password do not match")

                Text_new_pw.Text = ""
                Text_confirm_pw.Text = ""
                Text_new_pw.Select()


            End If


















        End If





    End Sub


End Class