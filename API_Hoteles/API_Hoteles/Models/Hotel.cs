namespace API_Hoteles.Models
{
    public class Hotel
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public float Stars { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
