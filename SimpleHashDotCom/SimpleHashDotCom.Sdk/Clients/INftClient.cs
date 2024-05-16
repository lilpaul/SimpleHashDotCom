using Refit;
using SimpleHashDotCom.Sdk.Responses;

namespace SimpleHashDotCom.Sdk.Clients;

public interface INftClient
{
	[Get("/nfts/owners")]
	Task<ApiResponse<GetNftsByWalletsResponse>> GetNftsByWallets(string chains, string wallet_addresses, string? cursor = null, int limit = 50);
}