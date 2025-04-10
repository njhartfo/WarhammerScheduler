using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WarhammerScheduler.Data;
using WarhammerScheduler.Models;

namespace WarhammerScheduler.Pages.Games;

public class IndexModel : PageModel
{
    private readonly SchedulerContext _context;
    
    public IndexModel(SchedulerContext context)
    {
        _context = context;
    }

    public List<Game> Games { get; set; } = new();

    public async Task OnGetAsync()
    {
        Games = await _context.Games.ToListAsync();
    }
}