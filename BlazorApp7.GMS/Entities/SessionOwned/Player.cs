using Bogus;

namespace BlazorApp7.GMS.Entities.SessionOwned;

public class Player
{
	public Guid SessionId { get; set; }
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid? TeamId { get; set; }

	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public int Height { get; set; }
	public int Weight { get; set; }
	public string Nationality { get; set; } = string.Empty;
	public string BirthPlace { get; set; } = string.Empty;
	public DateTime BirthDate { get; set; }
}
