using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoginForm lf = new LoginForm();
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
