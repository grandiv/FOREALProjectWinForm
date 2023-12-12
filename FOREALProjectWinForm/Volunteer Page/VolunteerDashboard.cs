using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        private void ClearVolunteer()
        {
            txtNameVolunteer.Clear();
            txtContactNumVol.Clear();
        }

        private static void DeleteVolunteer(System.Data.SqlClient.SqlConnection con, string address)
        {
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = con;
            cmdDelete.CommandText = "DELETE FROM ReceiveDonation WHERE [FullAddress] = @FullAddress";
            cmdDelete.Parameters.AddWithValue("@FullAddress", address);
            cmdDelete.ExecuteNonQuery();
        }

        private static void InsertVolunteer(string name, string contactNumber, string selectedData, System.Data.SqlClient.SqlConnection con)
        {
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = con;
            cmdInsert.CommandText = "INSERT INTO Volunteer (Name, ContactNumber, SelectedData) VALUES (@Name, @ContactNumber, @SelectedData)";
            cmdInsert.Parameters.AddWithValue("@Name", name);
            cmdInsert.Parameters.AddWithValue("@ContactNumber", contactNumber);
            cmdInsert.Parameters.AddWithValue("@SelectedData", selectedData);
            cmdInsert.ExecuteNonQuery();
        }

        private static System.Data.SqlClient.SqlConnection SqlConnect()
        {
            string connectionString = "Server=tcp:forealserver.database.windows.net,1433;Initial Catalog=FOREAL;Persist Security Info=False;User ID=grandiv;Password=Vidnarg12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private void VolunteerData(out string name, out string contactNumber, out string selectedData)
        {
            name = txtNameVolunteer.Text;
            contactNumber = txtContactNumVol.Text;
            selectedData = comboBox1.SelectedItem.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void submitVolunteer_Click(object sender, EventArgs e)
        {
            try
            {
                string name, contactNumber, selectedData;
                VolunteerData(out name, out contactNumber, out selectedData);

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(selectedData))
                {
                    MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                System.Data.SqlClient.SqlConnection con = SqlConnect();
                InsertVolunteer(name, contactNumber, selectedData, con);

                string[] selectedDataParts = selectedData.Split('-');
                string recipientName = selectedDataParts[0].Trim();
                string address = selectedDataParts[1].Trim();
                DeleteVolunteer(con, address);

                comboBox1.SelectedIndex = -1;
                FillComboBox();

                con.Close();

                string contact = selectedDataParts[2].Trim();
                string receivedFood = selectedDataParts[3].Trim();

                MessageBox.Show($"Recipient Name: {recipientName}\nFull Address: {address}\nContact: {contact}\n" +
                    $"Received Food: {receivedFood}\n", "Volunteer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearVolunteer();
                SqlCommand cmdclose = SqlConnection.CloseSqlCon();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data");
            }
        }
    }
}