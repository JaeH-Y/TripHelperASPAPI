namespace TripHelperS.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public bool isFavorite { get; set; } = false;
    }
}
