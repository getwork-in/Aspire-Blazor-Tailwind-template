using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp7.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services/*, IConfiguration configuration*/)
	{
		//services.AddDbContext<AppContext>(options =>
		//{
		//	options.UseSqlServer(configuration.GetConnectionString("GMS"));
		//});

		return services;
	}
}
