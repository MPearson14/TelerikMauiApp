namespace TelerikMauiApp.Models
{
    public class CityModel(int id, string name)
    {
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
    }
}
