namespace WebApplication1.Models
{     
    public class DashboardDto
    {
        public Boolean success   { get; set; }
        public ChartDashboardDto chartDonut { get; set; }
        public ChartDashboardDto chartBar { get; set; } 
        public TableUserDto tableUsers { get; set; }                    
    }
}
