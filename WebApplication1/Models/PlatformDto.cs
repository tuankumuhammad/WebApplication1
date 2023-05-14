namespace WebApplication1.Models
{
    public class GetPlatformWellActual
    {
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }   
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public WellDto well { get; set; }
    }
}
