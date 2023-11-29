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
using System.Xml.Linq;

namespace FOREALProjectWinForm
{
    public partial class VolunteerDashboard : Form
    {
        public VolunteerDashboard()
        {
            InitializeComponent();
            this.Load += VolunteerDashboard_Load;
        }

        private void VolunteerDashboard_Load(object sender, EventArgs e)
        {
            FillComboBox(); 
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear(); 
                                     
            string connectionString = "Server=tcp:forealserver.database.windows.net,1433;Initial Catalog=FOREAL;Persist Security Info=False;User ID=grandiv;Password=Vidnarg12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

            string query = "SELECT Name, [FullAddress], Contact, ReceivedFood FROM ReceiveDonation";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0); 
                string fullAddress = reader.GetString(1); 
                long contact = reader.GetInt64(2); 
                string receivedFood = reader.GetString(3); 
                string displayText = $"{name} - {fullAddress} - {contact} - {receivedFood}"; 
                comboBox1.Items.Add(displayText); 
            }

            con.Close();
        }




        private void submitVolunteer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameVolunteer.Text;
                string contactNumber = txtContactNumVol.Text;
                string selectedData = comboBox1.SelectedItem.ToString();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(selectedData))
                {
                    MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string connectionString = "Server=tcp:forealserver.database.windows.net,1433;Initial Catalog=FOREAL;Persist Security Info=False;User ID=grandiv;Password=Vidnarg12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = con;
                cmdInsert.CommandText = "INSERT INTO Volunteer (Name, ContactNumber, SelectedData) VALUES (@Name, @ContactNumber, @SelectedData)";
                cmdInsert.Parameters.AddWithValue("@Name", name);
                cmdInsert.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmdInsert.Parameters.AddWithValue("@SelectedData", selectedData);
                cmdInsert.ExecuteNonQuery();

                string[] selectedDataParts = selectedData.Split('-');
                string recipientName = selectedDataParts[0].Trim();
                string address = selectedDataParts[1].Trim();

                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = con;
                cmdDelete.CommandText = "DELETE FROM ReceiveDonation WHERE [FullAddress] = @FullAddress";
                cmdDelete.Parameters.AddWithValue("@FullAddress", address);
                cmdDelete.ExecuteNonQuery();

                comboBox1.SelectedIndex = -1;
                FillComboBox();

                con.Close();

                string contact = selectedDataParts[2].Trim();
                string receivedFood = selectedDataParts[3].Trim();

                MessageBox.Show($"Recipient Name: {recipientName}\nFull Address: {address}\nContact: {contact}\n" +
                    $"Received Food: {receivedFood}\n", "Volunteer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNameVolunteer.Clear();
                txtContactNumVol.Clear();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data");
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }
    }
}
