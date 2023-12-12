using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FOREALProjectWinForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void OpenMainDashboard()
        {
            this.Hide();
            Dashboard dsa = new Dashboard();
            dsa.Show();
        }

        private readonly IUserRepository _userRepository;

        public LoginForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (_userRepository.ValidateUser(username, password))
                {
                    OpenMainDashboard();
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
