namespace WebApplication1.Models
{
    public class WellDummyDto
    {

        public int Id { get; set; }
        public int platformID { get; set; }
        public string uniqueName { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
