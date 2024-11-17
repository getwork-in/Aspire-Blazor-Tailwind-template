namespace BlazorApp7.GMS.Entities;

public enum SessionStatus
{
	Open,
	Active,
	Closed,
}

public class Session
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public required string HostId { get; set; }
	public string Name { get; set; } = string.Empty;
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	public SessionStatus Status { get; set; } = SessionStatus.Open;
}
