using System.ComponentModel.DataAnnotations;

namespace WarhammerScheduler.Models;

public class Game
{
    public int GameID { get; set; }

    [Required]
    [Display(Name = "Game Date")]
    public DateTime GameDate { get; set; }

    [Required]
    [Display(Name = "Points Limit")]
    public int PointsLimit { get; set; }

    [Required]
    [Display(Name = "Game Time")]
    public TimeSpan GameTime { get; set; }

    public string? Notes { get; set; }

    [Required]
    [Display(Name = "Faction")]
    public string Faction { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Detachment")]
    public string Detachment { get; set; } = string.Empty;

    public List<GamePlayer> Players { get; set; } = new();
}