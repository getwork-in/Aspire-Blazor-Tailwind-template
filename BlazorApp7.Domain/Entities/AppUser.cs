namespace BlazorApp7.Domain.Entities;

public class AppUser
{
	public virtual string Id { get; set; } = default!;
	public virtual string? UserName { get; set; }
	public virtual string? NormalizedUserName { get; set; }
	public virtual string? Email { get; set; }
	public virtual bool EmailConfirmed { get; set; }
	public virtual string? PhoneNumber { get; set; }
	public virtual bool PhoneNumberConfirmed { get; set; }
	public virtual bool TwoFactorEnabled { get; set; }
	public virtual DateTimeOffset? LockoutEnd { get; set; }
	public virtual bool LockoutEnabled { get; set; }
	public virtual int AccessFailedCount { get; set; }
}
