using BlazorApp7.Data;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp7;

public static class DependencyInjection
{
	//public static string[] GetRoles(this ClaimsPrincipal? principal) => principal?.Claims.Where(x => x.Type == ClaimTypes.Role)
	//	.Select(x => x.Value).ToArray() ?? [];
	//public static string? GetDisplayName(this ClaimsPrincipal? principal) =>
	//	principal?.FindFirst(principal.Identities.FirstOrDefault()?.NameClaimType ?? ClaimTypes.Name)?.Value;

	public static async Task ConfigureDbAsync(this WebApplication app)
	{
		var sp = app.Services;
		await using var scope = sp.CreateAsyncScope();
		var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

		if (app.Environment.IsDevelopment())
		{
			await dbContext.Database.EnsureDeletedAsync();
			await dbContext.Database.EnsureCreatedAsync();
		}
		else
		{
			await dbContext.Database.EnsureCreatedAsync();
		}

		//var migrations = await dbContext.Database.GetPendingMigrationsAsync();
		//if (migrations.Any())
		//{
		//	await dbContext.Database.MigrateAsync();
		//}

		if (!dbContext.Users.Any())
		{
			var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
			var userStore = scope.ServiceProvider.GetRequiredService<IUserStore<ApplicationUser>>();
			string[] allRoles = [ApplicationRoles.Admin, ApplicationRoles.Developer];

			await SeedRoles();
			await SeedUsers();

			async Task SeedRoles()
			{
				if (await roleManager.RoleExistsAsync(ApplicationRoles.Admin) is false)
				{
					var adminRole = new IdentityRole(roleName: ApplicationRoles.Admin);
					var result = await roleManager.CreateAsync(adminRole);
					if (result.Succeeded)
					{
						//foreach (var claim in AuthorizationPolicyNames.GetPolicyNames())
						//{
						//	await roleManager.AddClaimAsync(adminRole, new Claim(type: ClaimTypes.Role, value: claim));
						//}
					}
				}

				if (await roleManager.RoleExistsAsync(ApplicationRoles.Developer) is false)
				{
					var result = await roleManager.CreateAsync(new IdentityRole(roleName: ApplicationRoles.Developer));
					if (result.Succeeded)
					{
						//foreach (var claim in AuthorizationPolicyNames.GetPolicyNames())
						//{
						//	await roleManager.AddClaimAsync(adminRole, new Claim(type: ClaimTypes.Role, value: claim));
						//}
					}
				}
			}

			async Task SeedUsers()
			{
				const string devEmail = "philippe.lafrance@viragesimulation.com";
				if (await userManager.FindByEmailAsync(devEmail) is null)
				{
					var emailStore = (IUserEmailStore<ApplicationUser>)userStore;
					var email = devEmail;
					var @default = new ApplicationUser()
					{
						EmailConfirmed = true,
						SecurityStamp = Guid.NewGuid().ToString()
					};

					await userStore.SetUserNameAsync(@default, email, CancellationToken.None);
					await emailStore.SetEmailAsync(@default, email, CancellationToken.None);
					var result = await userManager.CreateAsync(@default, "Cadi123@");

					if (result.Succeeded)
					{
						await userManager.AddToRoleAsync(@default, ApplicationRoles.Developer);
					}
				}

				const string adminEmail = "sa@domain.com";
				if (await userManager.FindByEmailAsync(adminEmail) is null)
				{
					var emailStore = (IUserEmailStore<ApplicationUser>)userStore;
					var email = adminEmail;
					var @default = new ApplicationUser()
					{
						EmailConfirmed = true,
						SecurityStamp = Guid.NewGuid().ToString()
					};

					await userStore.SetUserNameAsync(@default, email, CancellationToken.None);
					await emailStore.SetEmailAsync(@default, email, CancellationToken.None);
					var result = await userManager.CreateAsync(@default, "Admin123@");

					if (result.Succeeded)
					{
						await userManager.AddToRolesAsync(@default, allRoles);
					}
				}

				const string userEmail = "user@domain.com";
				if (await userManager.FindByEmailAsync(userEmail) is null)
				{
					var emailStore = (IUserEmailStore<ApplicationUser>)userStore;
					var email = userEmail;
					var @default = new ApplicationUser()
					{
						EmailConfirmed = true,
						SecurityStamp = Guid.NewGuid().ToString()
					};

					await userStore.SetUserNameAsync(@default, email, CancellationToken.None);
					await emailStore.SetEmailAsync(@default, email, CancellationToken.None);
					var result = await userManager.CreateAsync(@default, "User123@");
				}
			}
		}
	}
}
