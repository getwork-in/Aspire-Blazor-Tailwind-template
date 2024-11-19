namespace BlazorApp7.GMS.Entities.InSession;

public class Contract
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid TeamId { get; set; }
	public Guid? StaffId { get; set; }
	public Guid? PlayerId { get; set; }
	public decimal CapHit { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
}
