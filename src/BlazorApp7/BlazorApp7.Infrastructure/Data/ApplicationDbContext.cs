using BlazorApp7.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp7.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
	public DbSet<Session> GameSessions => Set<Session>();
	public DbSet<ApplicationUserSession> UserGameSessions => Set<ApplicationUserSession>();
	//public DbSet<League> Leagues => Set<League>();
	//public DbSet<Team> Teams => Set<Team>();
	//public DbSet<Staff> Staff => Set<Staff>();
	//public DbSet<Player> Players => Set<Player>();
	//public DbSet<Contract> Contracts => Set<Contract>();
	//public DbSet<Match> Matches => Set<Match>();
	//public DbSet<Statistic> Statistics => Set<Statistic>();
	//public DbSet<Season> Seasons => Set<Season>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}
