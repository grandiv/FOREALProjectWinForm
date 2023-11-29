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
    public partial class RequestDashboard : Form
    {
        public RequestDashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void submitRequest_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtNameRequest.Text;
                String FullAddress = txtFullAddress.Text;
                Int64 contact = Convert.ToInt64(txtContactNumber.Text);

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
                con.ConnectionString = "Server=tcp:forealserver.database.windows.net,1433;Initial Catalog=FOREAL;Persist Security Info=False;User ID=grandiv;Password=Vidnarg12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();

                String selectQuery = "SELECT TOP 1 * FROM AddDonation WHERE Quantity > 0 ORDER BY NEWID()";
                cmd.CommandText = selectQuery;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    String donatedName = DS.Tables[0].Rows[0]["Name"].ToString();
                    String location = DS.Tables[0].Rows[0]["Location"].ToString();
                    String foodType = DS.Tables[0].Rows[0]["FoodType"].ToString();
                    int quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["Quantity"]);
                    DateTime dateTime = Convert.ToDateTime(DS.Tables[0].Rows[0]["ExpDate"]);

                    quantity--;

                    string updateQuery = "UPDATE AddDonation SET Quantity = @Quantity WHERE Name = @Name";
                    cmd.CommandText = updateQuery;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Name", donatedName);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Food Received: " + foodType + " from " + donatedName);

                    string insertReceiveQuery = "INSERT INTO ReceiveDonation (Name, FullAddress, Contact, ReceivedFood) VALUES (@Name, @FullAddress, @Contact, @ReceivedFood)";
                    cmd.CommandText = insertReceiveQuery;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@FullAddress", FullAddress);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@ReceivedFood", foodType);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("No available food.");
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNameRequest.Clear();
            txtFullAddress.Clear();
            txtContactNumber.Clear();
        }
    }
}
