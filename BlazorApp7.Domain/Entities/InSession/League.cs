namespace BlazorApp7.GMS.Entities.InSession;

public class League
{
	public Guid SessionId { get; set; }
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; } = string.Empty;
	public string ShortName { get; set; } = string.Empty;
}

public class Season
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid LeagueId { get; set; }
	public int Year { get; set; }
	public string Name { get; set; } = string.Empty;
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
}