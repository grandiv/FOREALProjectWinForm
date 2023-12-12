using System;
using System.Windows.Forms;

namespace FOREALProjectWinForm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestDashboard reqForm = new RequestDashboard();
            reqForm.Show();
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonationDashboard doForm = new DonationDashboard();
            doForm.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            IUserRepository userRepository = new SqlUserRepository();
            LoginForm lf = new LoginForm(userRepository);
            lf.Show();
        }

        private void Volunteer_Click(object sender, EventArgs e)
        {
            this.Hide();
            VolunteerDashboard volForm = new VolunteerDashboard();
            volForm.Show();
        }
    }
}
