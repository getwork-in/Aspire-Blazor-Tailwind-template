using BlazorApp7.GMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp7.GMS.Data;

public class AppContext : DbContext
{
	public DbSet<Session> GameSessions => Set<Session>();
	public DbSet<UserSession> UserGameSessions => Set<UserSession>();
	//public DbSet<League> Leagues => Set<League>();
	//public DbSet<Team> Teams => Set<Team>();
	//public DbSet<Staff> Staff => Set<Staff>();
	//public DbSet<Player> Players => Set<Player>();
	//public DbSet<Contract> Contracts => Set<Contract>();
	//public DbSet<Match> Matches => Set<Match>();
	//public DbSet<Statistic> Statistics => Set<Statistic>();
	//public DbSet<Season> Seasons => Set<Season>();
	public AppContext(DbContextOptions<AppContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}