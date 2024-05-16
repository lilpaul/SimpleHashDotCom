using Refit;
using SimpleHashDotCom.Sdk.Responses;

namespace SimpleHashDotCom.Sdk.Clients;

public interface IFungiblesClient
{
	[Get("/fungibles/balances")]
	Task<ApiResponse<GetFungiblesBalanceByWalletsResponse>> GetFungiblesBalanceByWallets(string chains, string wallet_addresses, string? cursor = null, int limit = 50);
}