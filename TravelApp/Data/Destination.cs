namespace TravelApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// public class Destination
// {
//     public int DestinationId { get; set; }
//     public string Name { get; set; }
//     public string ExperienceType { get; set; } // Beach, Culture, Nature, City
//     public double CostEstimate { get; set; }
//     
//     public List<TripPlan> TripPlans { get; set; }
// }

[Table("Destinations")]
public class Destination
{
    [Key]
    [Column("DestinationId")]
    public int destination_id { get; set; }
    
    [Column("Name")]
    public string name { get; set; }
    
    [Column("ExperienceType")]
    public string experience_type { get; set; }
    
    [Column("CostEstimate")]
    public double cost_estimate { get; set; }
    
}