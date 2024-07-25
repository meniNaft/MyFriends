namespace MyFriends.Models
{
    public class CarModel
    {
        public string Model { get; set; }
        public string Year { get; set; }

        public CarModel(string model, string year)
        {
            Model = model;
            Year = year;
        }
    }
}
