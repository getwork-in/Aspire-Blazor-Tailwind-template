namespace BlazorApp7.GMS.Entities;

public class Season
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid LeagueId { get; set; }
	public string Name { get; set; } = string.Empty;
	public int Year { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
}
