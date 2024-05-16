using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Contract
{
	[JsonPropertyName("type")]
	public string Type { get; set; } = "";

	[JsonPropertyName("name")]
	public string Name { get; set; } = "";

	[JsonPropertyName("symbol")]
	public string? Symbol { get; set; }

	[JsonPropertyName("deployed_by")]
	public string DeployedBy { get; set; } = "";

	[JsonPropertyName("deployed_via_contract")]
	public string? DeployedViaContract { get; set; }

	[JsonPropertyName("owned_by")]
	public string? OwnedBy { get; set; }

	[JsonPropertyName("has_multiple_collections")]
	public bool HasMultipleCollections { get; set; }
}