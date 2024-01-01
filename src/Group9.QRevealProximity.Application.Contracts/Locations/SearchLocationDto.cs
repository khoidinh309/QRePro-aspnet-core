using System.ComponentModel.DataAnnotations;

namespace Group9.QRevealProximity.Locations;

public class SearchLocationDto
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Address { get; set; }
    [Required]
    public string? Description { get; set; }
}