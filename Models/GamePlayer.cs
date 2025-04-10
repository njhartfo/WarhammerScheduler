using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerScheduler.Models;

public class GamePlayer
{
    public int GamePlayerID { get; set; }

    [Required]
    public string PlayerName { get; set; } = string.Empty;

    [Required]
    public string Faction { get; set; } = string.Empty;

    public string Detachment { get; set; } = String.Empty;

    public int GameID { get; set; }

    public Game? Game { get; set; }
}