using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOREALProjectWinForm
{
    public partial class DonationDashboard : Form
    {
        public DonationDashboard()
        {
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }
        private void DonationClear()
        {
            txtNameDonator.Clear();
            txtLocation.Clear();
            txtFoodType.Clear();
            txtQuantity.Clear();
            dateTimePicker1.ResetText();
        }
        private void OutDonation(out string name, out string location, out string foodType, out int quantity, out DateTime dateTime)
        {
            name = txtNameDonator.Text;
            location = txtLocation.Text;
            foodType = txtFoodType.Text;
            quantity = Convert.ToInt32(txtQuantity.Text);
            dateTime = dateTimePicker1.Value;
        }
        private void SubmitDonation_Click(object sender, EventArgs e)
        {
            try
            {
                string name, location, foodType;
                int quantity;
                DateTime dateTime;
                OutDonation(out name, out location, out foodType, out quantity, out dateTime);

                SqlCommand cmd = SqlConnection.GetSqlConDonation();

                cmd.CommandText = "insert into AddDonation values('" + name + "','" + location + "','" + foodType + "'," + quantity + ",'" + dateTime + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Food Donated! Thank you");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DonationClear();
        }
    }
}
