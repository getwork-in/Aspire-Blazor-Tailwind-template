using BlazorApp7.GMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp7.GMS.Data;

public class GMSDbContext : DbContext
{
	public DbSet<Session> GameSessions => Set<Session>();
	public DbSet<UserGameSession> UserGameSessions => Set<UserGameSession>();
	//public DbSet<League> Leagues => Set<League>();
	//public DbSet<Team> Teams => Set<Team>();
	//public DbSet<Staff> Staff => Set<Staff>();
	//public DbSet<Player> Players => Set<Player>();
	//public DbSet<Contract> Contracts => Set<Contract>();
	//public DbSet<Match> Matches => Set<Match>();
	//public DbSet<Statistic> Statistics => Set<Statistic>();
	//public DbSet<Season> Seasons => Set<Season>();
	public GMSDbContext(DbContextOptions<GMSDbContext> options) : base(options)
	{
	}
}