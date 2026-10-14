namespace TravelApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// public class TripPlan
// {
//     public int id { get; set; }
//     public int TravelerId { get; set; }
//     public int DestinationId { get; set; }
//     public Traveler traveler { get; set;}
//     public Destination destination { get; set;}
// }

[Table("TripPlan")]
public class TripPlan
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("TravelerId")]
    public int travelerId { get; set; }
    
    [Column("DestinationId")]
    public int destinationId { get; set; }
    
}