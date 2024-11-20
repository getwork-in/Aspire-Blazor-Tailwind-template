using BlazorApp7.Domain.BuildingBlocks;
using BlazorApp7.GMS.Entities;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp7.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser, IUser
{
}

public class ApplicationUserSession : UserSession
{
	
}