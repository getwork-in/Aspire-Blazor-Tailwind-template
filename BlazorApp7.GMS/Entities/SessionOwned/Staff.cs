namespace BlazorApp7.GMS.Entities.SessionOwned;

public class Staff
{
	public Guid SessionId { get; set; }
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid? TeamId { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string Country { get; set; } = string.Empty;
	public DateTime BirthDate { get; set; }
	public string BirthPlace { get; set; } = string.Empty;
}
