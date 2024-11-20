using BlazorApp7.Domain.BuildingBlocks;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp7.Domain.Entities;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser, IUser
{
}
