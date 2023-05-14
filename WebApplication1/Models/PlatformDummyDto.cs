namespace WebApplication1.Models
{
    public class GetPlatformWellDummy
    {
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public WellDummyDto well { get; set; }
    }
}
