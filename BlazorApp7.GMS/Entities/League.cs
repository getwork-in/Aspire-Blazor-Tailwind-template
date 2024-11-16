namespace BlazorApp7.GMS.Entities;

public class League
{
	public Guid SessionId { get; set; }
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; } = string.Empty;
	public string ShortName { get; set; } = string.Empty;
}
