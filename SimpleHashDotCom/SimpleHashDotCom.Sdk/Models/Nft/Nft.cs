using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Nft
{
	[JsonPropertyName("nft_id")]
	public string NftId { get; set; } = "";

	[JsonPropertyName("chain")]
	public string Chain { get; set; } = "";

	[JsonPropertyName("contract_address")]
	public string ContractAddress { get; set; } = "";

	[JsonPropertyName("token_id")]
	public string? TokenId { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("previews")]
	public Previews? Previews { get; set; }

	[JsonPropertyName("image_url")]
	public string? ImageUrl { get; set; }

	[JsonPropertyName("image_properties")]
	public ImageProperties? ImageProperties { get; set; }

	[JsonPropertyName("video_url")]
	public string? VideoUrl { get; set; }

	[JsonPropertyName("video_properties")]
	public VideoProperties? VideoProperties { get; set; }

	[JsonPropertyName("audio_url")]
	public string? AudioUrl { get; set; }

	[JsonPropertyName("audio_properties")]
	public AudioProperties? AudioProperties { get; set; }

	[JsonPropertyName("model_url")]
	public string? ModelUrl { get; set; }

	[JsonPropertyName("model_properties")]
	public ModelProperties? ModelProperties { get; set; }

	[JsonPropertyName("other_url")]
	public string? OtherUrl { get; set; }

	[JsonPropertyName("other_properties")]
	public OtherProperties? OtherProperties { get; set; }

	[JsonPropertyName("background_color")]
	public string? BackgroundColor { get; set; }

	[JsonPropertyName("external_url")]
	public string? ExternalUrl { get; set; }

	[JsonPropertyName("created_date")]
	public DateTime? CreatedDate { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; } = "";

	[JsonPropertyName("token_count")]
	public int? TokenCount { get; set; }

	[JsonPropertyName("owner_count")]
	public int? OwnerCount { get; set; }

	[JsonPropertyName("owners")]
	public IEnumerable<Owner> Owners { get; set; } = new List<Owner>();

	[JsonPropertyName("last_sale")]
	public LastSale? LastSale { get; set; } = new LastSale();

	[JsonPropertyName("first_created")]
	public FirstCreated? FirstCreated { get; set; } = new FirstCreated();

	[JsonPropertyName("contract")]
	public Contract Contract { get; set; } = new Contract();

	[JsonPropertyName("collection")]
	public Collection Collection { get; set; } = new Collection();

	[JsonPropertyName("rarity")]
	public Rarity? Rarity { get; set; }

	[JsonPropertyName("royalty")]
	public IEnumerable<Royalty> Royalty { get; set; } = new List<Royalty>();

	[JsonPropertyName("extra_metadata")]
	public ExtraMetadata? ExtraMetadata { get; set; }
}