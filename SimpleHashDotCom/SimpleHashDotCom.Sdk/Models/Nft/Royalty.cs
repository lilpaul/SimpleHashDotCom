using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Royalty
{
	[JsonPropertyName("source")]
	public string Source { get; set; } = "";

	[JsonPropertyName("total_creator_fee_basis_points")]
	public int TotalCreatorFeeBasisPoints { get; set; }

	[JsonPropertyName("recipients")]
	public IEnumerable<Recipient> Recipients { get; set; } = new List<Recipient>();
}