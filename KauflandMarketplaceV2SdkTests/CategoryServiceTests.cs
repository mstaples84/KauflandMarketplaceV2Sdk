using KauflandMarketplaceV2Sdk.Interfaces;
using KauflandMarketplaceV2Sdk.RequestHelpers;
using KauflandMarketplaceV2Sdk.Services;

namespace KauflandMarketplaceV2SdkTests;

public class CategoryServiceTests
{
    private ICategoryService? _categoryService;
    
    [SetUp]
    public void Setup()
    {
        _categoryService = new CategoryService(new HttpClient(), new RequestBuilder());
    }
    
    [Test]
    public async Task GetCategoryByIdTestAsync()
    {
        var category = await _categoryService.GetAsync(11, null);
        Assert.IsNotNull(category);
    }

    [Test]
    public async Task GetCategoryBySearchTestAsync()
    {
        Assert.Pass();
    }

    [Test]
    public async Task GetCategoryTreeTestAsync()
    {
        Assert.Pass();
    }

    [Test]
    public async Task DecideCategoryTestAsync()
    {
        Assert.Pass();
    }
}