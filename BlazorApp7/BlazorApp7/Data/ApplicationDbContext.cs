using BlazorApp7.GMS.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp7.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
	public DbSet<Session> GameSessions => Set<Session>();
	public DbSet<ApplicationUserSession> UserGameSessions => Set<ApplicationUserSession>();
}
