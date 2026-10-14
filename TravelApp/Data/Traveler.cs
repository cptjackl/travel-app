namespace TravelApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// public class Traveler
// {
//     public int TravelerId { get; set; }
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public string Style { get; set; } //Budget, Luxury, or Adventure
//     public List<TripPlan> TripPlans { get; set; }
// }

[Table("Travelers")]
public class Traveler
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
   
    [Column("FirstName")]
    [Required]
    public string first_name { get; set; }
    
    [Column("LastName")]
    [Required]
    public string last_name { get; set; }
    
    [Column("Style")]
    [Required]
    public string style { get; set; }
}