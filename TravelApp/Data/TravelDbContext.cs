using Microsoft.EntityFrameworkCore;

namespace TravelApp.Data;

public class TravelDbContext :DbContext
{
    public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Traveler> Travelers { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<TripPlan> TripPlans { get; set; }
}