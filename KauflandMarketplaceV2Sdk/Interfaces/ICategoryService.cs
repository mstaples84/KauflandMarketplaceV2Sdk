using KauflandMarketplaceV2Sdk.Models;
using KauflandMarketplaceV2Sdk.Models.Requests;
using KauflandMarketplaceV2Sdk.Params;

namespace KauflandMarketplaceV2Sdk.Interfaces;

public interface ICategoryService
{
    /// <summary>
    /// GET categories
    /// </summary>
    /// <param name="categoryId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<KauflandCategory?> GetAsync(int categoryId, CancellationToken? cancellationToken);

    /// <summary>
    /// GET categories by search term
    /// </summary>
    /// <param name="countryEnum"></param>
    /// <param name="query"></param>
    /// <param name="parentId"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<KauflandCategory>?> GetAsync(CountryEnum countryEnum, string query, long parentId, int limit, int offset, CancellationToken? cancellationToken);

    /// <summary>
    /// GET categories/tree
    /// </summary>
    /// <param name="countryEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<KauflandCategoryTree>?> GetAsync(CountryEnum countryEnum, CancellationToken? cancellationToken);

    /// <summary>
    /// POST categories/decide
    /// Guess potential categories for a product based on its product data. The first result is the category the product is most likely in.
    /// </summary>
    /// <param name="countryEnum"></param>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<KauflandCategoryTree>?> DecideAsync(CountryEnum countryEnum, ItemRequest request, CancellationToken? cancellationToken);

}