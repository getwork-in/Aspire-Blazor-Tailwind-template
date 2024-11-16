namespace BlazorApp7.GMS.Entities;

public class UserGameSession
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid UserId { get; set; }
	public Guid SessionId { get; set; }
	public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}
