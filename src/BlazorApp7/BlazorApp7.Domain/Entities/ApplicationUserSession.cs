namespace BlazorApp7.Domain.Entities;

public class ApplicationUserSession
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public required string UserId { get; set; }
	public required Guid SessionId { get; set; }
	public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}