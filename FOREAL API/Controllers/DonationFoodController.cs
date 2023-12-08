using FOREAL_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace FOREAL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationFoodController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public DonationFoodController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllDonationFood")]
        public string GetDonationFood()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("FOREALAppCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM AddDonation", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Donation> donationList = new List<Donation>();
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Donation donation = new Donation();
                    donation.Name = dt.Rows[i]["Name"].ToString();
                    donation.Location = dt.Rows[i]["Location"].ToString();
                    donation.FoodType = dt.Rows[i]["FoodType"].ToString();
                    donation.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"]);
                    donation.ExpDate = Convert.ToDateTime(dt.Rows[i]["ExpDate"]);
                    donationList.Add(donation);
                }
            }
            if (donationList.Count > 0)
                return JsonConvert.SerializeObject(donationList);
            else
            {
                response.StatusCode = 100;
                response.ErrorMessage = "No data found";
                return JsonConvert.SerializeObject(response);
            }
        }

        [HttpPost]
        [Route("AddDonationFood")]
        public IActionResult AddDonationFood([FromBody] Donation newDonation)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("ForealAppCon")))
                {
                    string query = "INSERT INTO AddDonation (Name, Location, FoodType, Quantity, ExpDate) " +
                                   "VALUES (@Name, @Location, @FoodType, @Quantity, @ExpDate)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", newDonation.Name);
                    cmd.Parameters.AddWithValue("@Location", newDonation.Location);
                    cmd.Parameters.AddWithValue("@FoodType", newDonation.FoodType);
                    cmd.Parameters.AddWithValue("@Quantity", newDonation.Quantity);
                    cmd.Parameters.AddWithValue("@ExpDate", newDonation.ExpDate);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        return StatusCode(StatusCodes.Status201Created, "Donation added successfully");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, "Failed to add donation");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }
}
