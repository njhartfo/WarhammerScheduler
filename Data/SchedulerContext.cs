using Microsoft.EntityFrameworkCore;
using WarhammerScheduler.Models;

namespace WarhammerScheduler.Data;

public class SchedulerContext : DbContext
{
    public SchedulerContext(DbContextOptions<SchedulerContext> options)
        : base(options) { }

    public DbSet<Game> Games => Set<Game>();
    public DbSet<GamePlayer> GamePlayers => Set<GamePlayer>();
}
