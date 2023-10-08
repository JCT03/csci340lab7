using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SoccerRoster.Models;

public class Player
{
    public int Id { get; set; }
    [Range(0, 100)]
    [Required]
    public int Number { get; set; }
    [StringLength(60)]
    [Required]
    public string? Name { get; set; }
    [Required]
    [StringLength(10)]
    public string? Position { get; set; }
    [Display(Name = "Home Town")]
    [Required]
    [StringLength(60)]
    public string? HomeTown { get; set; }
}