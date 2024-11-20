namespace BlazorApp7.Domain.Entities.InSession;

public class Statistic
{
	public Guid SessionId { get; set; }
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid MatchId { get; set; }
	public Guid PlayerId { get; set; }

	public int Goals { get; set; } = 0;
	public int Assists { get; set; } = 0;
	public int Penalties { get; set; } = 0;
}
