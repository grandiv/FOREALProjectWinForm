namespace FOREAL_API.Models
{
    public class Donation
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string FoodType { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
