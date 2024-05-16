using Microsoft.Extensions.DependencyInjection;
using Refit;
using SimpleHashDotCom.Sdk.Clients;

namespace SimpleHashDotCom.Sdk.Common;

public static class SimpleHashExtensions
{
	public static void AddSimpleHash(this IServiceCollection services, AuthHeaderConfiguration authHeaderConfiguration)
	{
		var uri = new Uri(authHeaderConfiguration.BaseUrl);

		services.AddSingleton(authHeaderConfiguration);
		services.AddTransient<AuthHeaderHandler>();

		services.AddRefitClient<INftClient>().ConfigureHttpClient(c => c.BaseAddress = uri).AddHttpMessageHandler<AuthHeaderHandler>();
		services.AddRefitClient<IFungiblesClient>().ConfigureHttpClient(c => c.BaseAddress = uri).AddHttpMessageHandler<AuthHeaderHandler>();
	}
}