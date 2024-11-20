using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp7.Domain;

public static class DependencyInjection
{
	public static IServiceCollection AddGMS(this IServiceCollection services/*, IConfiguration configuration*/)
	{
		//services.AddDbContext<AppContext>(options =>
		//{
		//	options.UseSqlServer(configuration.GetConnectionString("GMS"));
		//});

		//services.AddMediatR(config =>
		//{
		//	config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
		//});

		return services;
	}
}
