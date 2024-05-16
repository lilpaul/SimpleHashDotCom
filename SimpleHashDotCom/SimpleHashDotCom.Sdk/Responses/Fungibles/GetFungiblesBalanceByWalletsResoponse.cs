using SimpleHashDotCom.Sdk.Models.Fungibles;
using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Responses;

public sealed class GetFungiblesBalanceByWalletsResponse : SimpleHashResponseBase
{
	[JsonPropertyName("fungibles")]
	public IEnumerable<Fungible> Fungibles { get; set; } = new List<Fungible>();
}