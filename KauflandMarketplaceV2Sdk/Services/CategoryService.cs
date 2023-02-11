using KauflandMarketplaceV2Sdk.Interfaces;
using KauflandMarketplaceV2Sdk.Models;
using KauflandMarketplaceV2Sdk.Models.Requests;
using KauflandMarketplaceV2Sdk.Params;
using KauflandMarketplaceV2Sdk.RequestHelpers;

namespace KauflandMarketplaceV2Sdk.Services;

public class CategoryService : HttpServiceBase, ICategoryService
{
    private const string BaseEndpoint = Endpoints.Categories;

    public CategoryService(HttpClient httpClient, IRequestBuilder requestBuilder) : base(httpClient, requestBuilder)
    {
    }
    
    public async Task<KauflandCategory?> GetAsync(int categoryId, CancellationToken? cancellationToken)
    {
        var urlString = $"{BaseEndpoint}/{categoryId}";
        return await GetRequestAsync<KauflandCategory?>(urlString);
    }

    public async Task<IEnumerable<KauflandCategory>?> GetAsync(CountryEnum countryEnum, string query, long parentId, int limit, int offset, CancellationToken? cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<KauflandCategoryTree>?> GetAsync(CountryEnum countryEnum, CancellationToken? cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<KauflandCategoryTree>?> DecideAsync(CountryEnum countryEnum, ItemRequest request, CancellationToken? cancellationToken)
    {
        throw new NotImplementedException();
    }
}