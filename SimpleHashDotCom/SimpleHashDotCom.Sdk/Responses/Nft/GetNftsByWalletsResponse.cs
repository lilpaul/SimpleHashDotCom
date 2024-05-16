using SimpleHashDotCom.Sdk.Models.Nft;
using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Responses;

public class GetNftsByWalletsResponse : SimpleHashResponseBase
{
	[JsonPropertyName("nfts")]
	public IEnumerable<Nft> Nfts { get; set; } = new List<Nft>();
}