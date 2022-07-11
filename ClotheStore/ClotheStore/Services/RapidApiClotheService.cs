using ClotheStore.Models;
using ClotheStore.Models.DTOs;
using ClotheStore.Services.Interfaces;
using CsharpTools.Services.Interfaces;

namespace ClotheStore.Services;

public class RapidApiClotheService : IClotheService
{
    private readonly IHttpService _httpService;
    public RapidApiClotheService(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<IEnumerable<CategorieWrapper>> GetCategoriesAsync()
    {
        var x = await _httpService.SendHttpRequest<RapidApiCategoriesDtoDown>("https://asos2.p.rapidapi.com/categories/list?country=US&lang=en-US", HttpMethod.Get, bearer: "dc28aefa49msh46ea4b9e4afdffep107050jsna6e09df14814");

        return new List<CategorieWrapper>();
    }

    public Task<IEnumerable<ClotheWrapper>> GetClothesAsync()
    {
        throw new NotImplementedException();
    }
}
