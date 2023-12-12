using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace FOREALProjectWinForm
{
    public partial class RequestDashboard : Form
    {
        public RequestDashboard()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private static DataSet SqlAdapter(SqlCommand cmd)
        {
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            return DS;
        }

        private void RequestClear()
        {
            txtNameRequest.Clear();
            txtFullAddress.Clear();
            txtContactNumber.Clear();
        }

        private static void InsertReceiveFood(string name, string FullAddress, long contact, SqlCommand cmd, string foodType)
        {
            string insertReceiveQuery = "INSERT INTO ReceiveDonation (Name, FullAddress, Contact, ReceivedFood) VALUES (@Name, @FullAddress, @Contact, @ReceivedFood)";
            cmd.CommandText = insertReceiveQuery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@FullAddress", FullAddress);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@ReceivedFood", foodType);
            cmd.ExecuteNonQuery();
        }

        private static void UpdateFoodData(SqlCommand cmd, string donatedName, int quantity)
        {
            string updateQuery = "UPDATE AddDonation SET Quantity = @Quantity WHERE Name = @Name";
            cmd.CommandText = updateQuery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Name", donatedName);
            cmd.ExecuteNonQuery();
        }

        private static void GetFoodData(DataSet DS, out string donatedName, out string foodType, out int quantity)
        {
            donatedName = DS.Tables[0].Rows[0]["Name"].ToString();
            string location = DS.Tables[0].Rows[0]["Location"].ToString();
            foodType = DS.Tables[0].Rows[0]["FoodType"].ToString();
            quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["Quantity"]);
            DateTime dateTime = Convert.ToDateTime(DS.Tables[0].Rows[0]["ExpDate"]);

            quantity--;
        }

        private void submitRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameRequest.Text;
                string FullAddress = txtFullAddress.Text;
                Int64 contact = Convert.ToInt64(txtContactNumber.Text);

                SqlCommand cmd = SqlConnection.GetSqlCon();

                string selectQuery = "SELECT TOP 1 * FROM AddDonation WHERE Quantity > 0 ORDER BY NEWID()";
                cmd.CommandText = selectQuery;
                DataSet DS = SqlAdapter(cmd);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    string donatedName, foodType;
                    int quantity;
                    GetFoodData(DS, out donatedName, out foodType, out quantity);
                    UpdateFoodData(cmd, donatedName, quantity);

                    MessageBox.Show("Food Received: " + foodType + " from " + donatedName, "Request Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertReceiveFood(name, FullAddress, contact, cmd, foodType);
                }
                else
                {
                    MessageBox.Show("No available food.");
                }
                SqlCommand cmdclose = SqlConnection.CloseSqlCon();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RequestClear();
        }
    }
}
