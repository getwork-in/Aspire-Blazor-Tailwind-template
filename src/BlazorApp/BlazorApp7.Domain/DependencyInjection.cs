using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp7.Domain;

public static class DependencyInjection
{
	public static IServiceCollection AddBlazorApp7Core(this IServiceCollection services)
	{
		//services.AddMediatR(config =>
		//{
		//	config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
		//});

		return services;
	}
}
