using System.ComponentModel.DataAnnotations;

namespace SoccerRoster.Models;

public class Player
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Position { get; set; }
    public string? HomeTown { get; set; }
}