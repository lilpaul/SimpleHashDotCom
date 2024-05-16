using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Collection
{
	[JsonPropertyName("collection_id")]
	public string? CollectionId { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("image_url")]
	public string? ImageUrl { get; set; }

	[JsonPropertyName("image_properties")]
	public ImageProperties? ImageProperties { get; set; }

	[JsonPropertyName("banner_image_url")]
	public string? BannerImageUrl { get; set; }

	[JsonPropertyName("category")]
	public string? Category { get; set; }

	[JsonPropertyName("is_nsfw")]
	public bool? IsNsfw { get; set; }

	[JsonPropertyName("external_url")]
	public string? ExternalUrl { get; set; }

	[JsonPropertyName("twitter_username")]
	public string? TwitterUsername { get; set; }

	[JsonPropertyName("discord_url")]
	public string? DiscordUrl { get; set; }

	[JsonPropertyName("instagram_url")]
	public string? InstagramUrl { get; set; }

	[JsonPropertyName("instagram_username")]
	public string? InstagramUsername { get; set; }

	[JsonPropertyName("medium_username")]
	public string? MediumUsername { get; set; }

	[JsonPropertyName("telegram_url")]
	public string? TelegramUrl { get; set; }

	[JsonPropertyName("marketplace_pages")]
	public IEnumerable<MarketplacePage> MarketplacePages { get; set; } = new List<MarketplacePage>();

	[JsonPropertyName("metaplex_mint")]
	public string? MetaplexMint { get; set; }

	[JsonPropertyName("metaplex_candy_machine")]
	public string? MetaplexCandyMachine { get; set; }

	[JsonPropertyName("metaplex_first_verified_creator")]
	public string? MetaplexFirstVerifiedCreator { get; set; }

	[JsonPropertyName("spam_score")]
	public long? SpamScore { get; set; }

	[JsonPropertyName("floor_prices")]
	public IEnumerable<FloorPrice> FloorPrices { get; set; } = new List<FloorPrice>();

	[JsonPropertyName("top_bids")]
	public IEnumerable<TopBid> TopBids { get; set; } = new List<TopBid>();

	[JsonPropertyName("distinct_owner_count")]
	public int? DistinctOwnerCount { get; set; }

	[JsonPropertyName("distinct_nft_count")]
	public int? DistinctNftCount { get; set; }

	[JsonPropertyName("total_quantity")]
	public long? TotalQuantity { get; set; }

	[JsonPropertyName("chains")]
	public IEnumerable<string> Chains { get; set; } = new List<string>();

	[JsonPropertyName("top_contracts")]
	public IEnumerable<string> TopContracts { get; set; } = new List<string>();

	[JsonPropertyName("collection_royalties")]
	public IEnumerable<Royalty> CollectionRoyalties { get; set; } = new List<Royalty>();
}