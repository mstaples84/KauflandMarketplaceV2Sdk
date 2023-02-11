using System.Text.Json.Serialization;

namespace KauflandMarketplaceV2Sdk.Models;

public class KauflandCategoryTree : KauflandCategory
{
    [JsonPropertyName("children")]
    public IEnumerable<string> Children { get; set; }
}