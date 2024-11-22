namespace BlazorApp7.Domain.Entities.InSession;

public class Team
{
	public Guid SessionId { get; set; }
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid? LeagueId { get; set; }
	public string Name { get; set; } = string.Empty;
	public string ShortName { get; set; } = string.Empty;
	public string Logo { get; set; } = string.Empty;
	public string City { get; set; } = string.Empty;
}
