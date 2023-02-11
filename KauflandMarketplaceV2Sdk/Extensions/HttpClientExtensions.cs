using System.Net.Http.Json;
using KauflandMarketplaceV2Sdk.RequestHelpers;

namespace KauflandMarketplaceV2Sdk.Extensions;

/// <summary>
/// Extends the HttpClient to set the header properly.
/// </summary>
public static class HttpClientExtensions
{
    public static async Task<T?> GetJsonFromRequestAsync<T>(this HttpClient client, IRequestBuilder headerBuilder, string requestString, CancellationToken cancellationToken)
    {
        // Todo Set Header
        
        
        return await client.GetFromJsonAsync<T>(requestString, cancellationToken);
    }
}