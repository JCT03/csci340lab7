using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SoccerRoster.Models;

public class Player
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string? Name { get; set; }
    public string? Position { get; set; }
    [Display(Name = "Home Town")]
    public string? HomeTown { get; set; }
}