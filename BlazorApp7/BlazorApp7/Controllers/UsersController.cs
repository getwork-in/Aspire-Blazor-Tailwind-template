using BlazorApp7.Domain;
using BlazorApp7.Domain.Entities;
using BlazorApp7.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp7.Controllers;

[Authorize(Roles = ApplicationRoles.Admin)]
[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class UsersController(
	ApplicationDbContext _context,
	UserManager<ApplicationUser> _userManager) : ApiControllerBase
{
	[HttpGet]
	public async Task<ActionResult<IEnumerable<ApplicationUser>>> Get(CancellationToken cancellationToken)
	{
		return Ok(await _context.Users.AsNoTracking().ToListAsync(cancellationToken));
	}
}
