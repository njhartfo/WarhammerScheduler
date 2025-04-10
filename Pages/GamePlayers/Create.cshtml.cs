using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WarhammerScheduler.Data;
using WarhammerScheduler.Models;

namespace WarhammerScheduler.Pages.GamePlayers;

public class CreateModel : PageModel
{
    private readonly SchedulerContext _context;
    public WarhammerScheduler.Models.Game? Game { get; set; }

    public CreateModel(SchedulerContext context)
    {
        _context = context;
    }

    [BindProperty]
    public GamePlayer GamePlayer { get; set; } = new();

    public List<SelectListItem> FactionOptions { get; set; } = new();

    public int GameID { get; set; }

    public void OnGet(int gameId)
    {
        GameID = gameId;
        GamePlayer.GameID = gameId;
        Game = _context.Games.FirstOrDefault(g => g.GameID == gameId);

        var imperium = new SelectListGroup { Name = "Imperium" };
        var chaos = new SelectListGroup { Name = "Chaos" };
        var xenos = new SelectListGroup { Name = "Xenos" };

        FactionOptions = new List<SelectListItem>
        {
            new() { Value = "Adepta Sororitas", Text = "Adepta Sororitas", Group = imperium },
            new() { Value = "Adeptus Custodes", Text = "Adeptus Custodes", Group = imperium },
            new() { Value = "Adeptus Mechanicus", Text = "Adeptus Mechanicus", Group = imperium },
            new() { Value = "Astrum Militarum", Text = "Astrum Militarum", Group = imperium },
            new() { Value = "Grey Knights", Text = "Grey Knights", Group = imperium },
            new() { Value = "Imperial Agents", Text = "Imperial Agents", Group = imperium },
            new() { Value = "Imperial Knights", Text = "Imperial Knights", Group = imperium },
            new() { Value = "Space Marines", Text = "Space Marines", Group = imperium },
            
            new() { Value = "Chaos Daemons", Text = "Chaos Daemons", Group = chaos },
            new() { Value = "Chaos Knights", Text = "Chaos Knights", Group = chaos },
            new() { Value = "Chaos Space Marines", Text = "Chaos Space Marines", Group = chaos },
            new() { Value = "Death Guard", Text = "Death Guard", Group = chaos },
            new() { Value = "Thousand Sons", Text = "Thousand Sons", Group = chaos },
            new() { Value = "World Eaters", Text = "World Eaters", Group = chaos },
            
            new() { Value = "Aeldari", Text = "Aeldari", Group = xenos },
            new() { Value = "Drukhari", Text = "Drukhari", Group = xenos },
            new() { Value = "Genestealer Cults", Text = "Genestealer Cults", Group = xenos },
            new() { Value = "Leagues of Votann", Text = "Necrons", Group = xenos },
            new() { Value = "Necrons", Text = "Necrons", Group = xenos },
            new() { Value = "Orks", Text = "Orks", Group = xenos },
            new() { Value = "T'au", Text = "T'au", Group = xenos },
            new() { Value = "Tyranids", Text = "Tyranids", Group = xenos }            
        };
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        _context.GamePlayers.Add(GamePlayer);
        await _context.SaveChangesAsync();

        return RedirectToPage("/Games/Index");
    }
}
