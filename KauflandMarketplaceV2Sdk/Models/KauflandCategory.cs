using System.Text.Json.Serialization;

namespace KauflandMarketplaceV2Sdk.Models;

public class KauflandCategory
{
    [JsonPropertyName("id_category")]
    public int IdCategory { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("id_parent_category")]
    public int IdParentCategory { get; set; }
    
    [JsonPropertyName("title_singular")]
    public string TitleSingular { get; set; }
    
    [JsonPropertyName("title_plural")]
    public string TitlePlural { get; set; }
    
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    [JsonPropertyName("shipping_category")]
    public int ShippingCategory { get; set; }
    
    [JsonPropertyName("variable_fee")]
    public decimal VariableFee { get; set; }
    
    [JsonPropertyName("fixed_fee")]
    public decimal FixedFee { get; set; }
    
    [JsonPropertyName("vat")]
    public decimal Vat { get; set; }
}