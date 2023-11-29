using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void OutLogin(out string username, out string pass)
        {
            username = txtUsername.Text;
            pass = txtPassword.Text;
        }
        private static void CredentialCheck(string username, string pass, SqlCommand cmd)
        {
            cmd.CommandText = "SELECT * FROM loginTable WHERE username = @username AND pass = @password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", pass);
        }
        private static DataSet SqlAdapter(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisDashboard regForm = new RegisDashboard();
            regForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username, pass;
                OutLogin(out username, out pass);

                SqlCommand cmd = SqlConnection.GetSqlConDonation();

                CredentialCheck(username, pass, cmd);

                DataSet ds = SqlAdapter(cmd);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Dashboard dsa = new Dashboard();
                    dsa.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
