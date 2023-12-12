using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FOREALProjectWinForm
{
    public partial class RegisDashboard : Form
    {
        public RegisDashboard()
        {
            InitializeComponent();
        }

        private void OpenLoginForm()
        {
            this.Hide();
            IUserRepository userRepository = new SqlUserRepository();
            LoginForm logForm = new LoginForm(userRepository);
            logForm.Show();
            txtUsernameNew.Clear();
            txtPasswordNew.Clear();
        }

        private static void InsertCredentials(string usernameNew, string passNew, string email, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO loginTable (Username, Pass, Email) VALUES (@Username, @Pass, @Email)";
            cmd.Parameters.AddWithValue("@Username", usernameNew);
            cmd.Parameters.AddWithValue("@Pass", passNew);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OutRegis(out string usernameNew, out string passNew, out string email)
        {
            usernameNew = txtUsernameNew.Text;
            passNew = txtPasswordNew.Text;
            email = txtEmail.Text;
        }

        private static int UsernameCheck(string usernameNew, SqlCommand cmd)
        {
            cmd.CommandText = "SELECT COUNT(*) FROM loginTable WHERE Username = @Username";
            cmd.Parameters.AddWithValue("@Username", usernameNew);
            int userCount = (int)cmd.ExecuteScalar();
            return userCount;
        }

        private void TxtUsernameNew_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsernameNew.Text == "Username")
            {
                txtUsernameNew.Clear();
            }
        }

        private void TxtPasswordNew_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPasswordNew.Text == "Password")
            {
                txtPasswordNew.Clear();
                txtPasswordNew.PasswordChar = '*';
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            IUserRepository userRepository = new SqlUserRepository();
            LoginForm lf = new LoginForm(userRepository);
            lf.Show();
        }

        private void TxtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void BtnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                string usernameNew, passNew, email;
                OutRegis(out usernameNew, out passNew, out email);

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
                    InsertCredentials(usernameNew, passNew, email, cmd);
                }
                SqlCommand cmdclose = SqlConnection.CloseSqlCon();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data");
            }
            OpenLoginForm();
        }
    }
}
