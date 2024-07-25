namespace MyFriends.Models
{
    public class ViewModel
    {
        public CarModel Car { get; set; }
        public string Color { get; set; }
        public ViewModel(CarModel car, string color) 
        {
            Car = car;
            Color = color;
        }
    }
}
