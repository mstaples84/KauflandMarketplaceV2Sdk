using System.Net.Http.Json;
using KauflandMarketplaceV2Sdk.RequestHelpers;

namespace KauflandMarketplaceV2Sdk.Services;

/// <summary>
/// Base Class of all Endpoint related Services
/// </summary>
public abstract class HttpServiceBase
{
    private readonly HttpClient _httpClient;
    private readonly IRequestBuilder _requestBuilder;

    protected HttpServiceBase(HttpClient httpClient, IRequestBuilder requestBuilder)
    {
        _requestBuilder = requestBuilder;
        _httpClient = httpClient;
    }

    protected async Task<T?> GetRequestAsync<T>(string uriString)
    {
        // Build Header
        
        // Make Request
        using var requestMessage = _requestBuilder.Build(HttpMethod.Get, uriString, null);

        // Return specified Type
        using var response = await _httpClient.SendAsync(requestMessage);
        
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<T>();

        using var streamReader = new StreamReader(response.Content.ReadAsStream());
        var message = $"GET {uriString} responded with {response.StatusCode}: {streamReader.ReadToEnd()}";
        throw new Exception(message);
    }
}