using BlazorApp7.Domain.DTOs;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp7.Domain.Entities;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
	
}

public static class ApplicationUserExtensions
{
	public static AppUserDTO AsDto(this ApplicationUser user) => new AppUserDTO
	{
		Id = user.Id,
		UserName = user.UserName,
		NormalizedUserName = user.NormalizedUserName,
		Email = user.Email,
		EmailConfirmed = user.EmailConfirmed,
		PhoneNumber = user.PhoneNumber,
		PhoneNumberConfirmed = user.PhoneNumberConfirmed,
		TwoFactorEnabled = user.TwoFactorEnabled,
		LockoutEnd = user.LockoutEnd,
		LockoutEnabled = user.LockoutEnabled,
		AccessFailedCount = user.AccessFailedCount
	};
}