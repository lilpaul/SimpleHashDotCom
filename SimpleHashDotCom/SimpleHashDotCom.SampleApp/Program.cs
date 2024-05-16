using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleHashDotCom.Sdk.Clients;
using SimpleHashDotCom.Sdk.Common;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((hostContext, services) =>
	{
		var apiAuthKey = hostContext.Configuration["SimpleHash:ApiAuthKey"];
		var baseUrl = hostContext.Configuration["SimpleHash:BaseUrl"];
		var authConfig = new AuthHeaderConfiguration(apiAuthKey!, baseUrl!);
		services.AddSimpleHash(authConfig);
		services.AddHostedService<Worker>();
	})
	.Build();
await host.RunAsync();

public class Worker : BackgroundService
{
	private readonly INftClient _nftClient;
	private readonly IFungiblesClient _fungiblesClient;

	public Worker(
		INftClient nftClient,
		IFungiblesClient fungiblesClient)
	{
		_nftClient = nftClient;
		_fungiblesClient = fungiblesClient;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		// Test Calls
		var nfts = await _nftClient.GetNftsByWallets("polygon,ethereum", "0xfa6E0aDDF68267b8b6fF2dA55Ce01a53Fad6D8e2", "ZXZtLXBnLjB4ZDRkODZjM2FjYzhjNTViNDdhMGY3YzlkY2I4MjIxMzFlZWFiYjBkOS4wMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDkxNThfMjAyMy0wNy0xNSAwOTo0NTozNSswMDowMF9fbmV4dA");
		var fungibles = await _fungiblesClient.GetFungiblesBalanceByWallets("bitcoin", "bc1pmapf99lm09syzdufkuus6juuxqa8q2mc76r8679je5sw0ll9wnyqztcn2d");
	}
}