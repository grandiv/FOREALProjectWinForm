﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOREALProjectWinForm
{
    public partial class RegisDashboard : Form
    {
        public RegisDashboard()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                String usernameNew = txtUsernameNew.Text;
                String passNew = txtPasswordNew.Text;
                String email = txtEmail.Text;

                if (string.IsNullOrWhiteSpace(usernameNew) || string.IsNullOrWhiteSpace(passNew))
                {
                    MessageBox.Show("Please enter input all data.");
                    return;
                }

                SqlCommand cmd = SqlConnection.GetSqlCon();

                int userCount = UsernameCheck(usernameNew, cmd);

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO loginTable (Username, Pass, Email) VALUES (@Username, @Pass, @Email)";
                    cmd.Parameters.AddWithValue("@Username", usernameNew);
                    cmd.Parameters.AddWithValue("@Pass", passNew);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Completed");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data");
            }
            this.Hide();
            LoginForm logForm = new LoginForm();
            logForm.Show();
            txtUsernameNew.Clear();
            txtPasswordNew.Clear();
        }

        private static int UsernameCheck(string usernameNew, SqlCommand cmd)
        {
            cmd.CommandText = "SELECT COUNT(*) FROM loginTable WHERE Username = @Username";
            cmd.Parameters.AddWithValue("@Username", usernameNew);
            int userCount = (int)cmd.ExecuteScalar();
            return userCount;
        }

        private void txtUsernameNew_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsernameNew.Text == "Username")
            {
                txtUsernameNew.Clear();
            }
        }

        private void txtPasswordNew_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPasswordNew.Text == "Password")
            {
                txtPasswordNew.Clear();
                txtPasswordNew.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }
    }
}