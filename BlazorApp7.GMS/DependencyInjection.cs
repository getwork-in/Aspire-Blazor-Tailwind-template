using BlazorApp7.GMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp7.GMS;

public static class DependencyInjection
{
	public static IServiceCollection AddGMS(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<GMSContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("GMS"));
		});

		services.AddMediatR(config =>
		{
			config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
		});

		return services;
	}
}
