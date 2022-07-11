using ClotheStore.Commons;
using ClotheStore.Models;
using ClotheStore.Services.Interfaces;
using DynamicData;
using System.Collections.ObjectModel;

namespace ClotheStore.ViewModels.Home;

public class HomeViewModel : BaseViewModel
{
   

    private readonly IClotheService _clotheService;

    public HomeViewModel(INavigationService navigationService, IClotheService clotheService) : base(navigationService)
    {
        _clotheService = clotheService;

        _categoriesCache.Connect().Bind(out _categories).Subscribe();
        _trendingClothesCache.Connect().Bind(out _trendingClothes).Subscribe();

        RecommendationClothes = new List<ClotheWrapper>()
        {
            new ClotheWrapper(0, "Women Blue Denim", "https://images.asos-media.com/products/collusion-sweat-a-capuche-a-logo-fauve/202030215-1-tan?$n_750w$&wid=750&fit=constrain", 29.99, 39.99),
            new ClotheWrapper(9, "Nike Hoodie", "https://images.asos-media.com/products/collusion-t-shirt-a-logo-oversize-vert/24441312-1-green?$n_640w$&wid=513&fit=constrain", 24.99, null),
        };

    }

    protected override async Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        await base.OnNavigatedToAsync(parameters);

        _trendingClothesCache.AddOrUpdate(await _clotheService.GetClothesAsync());
        _categoriesCache.AddOrUpdate(await _clotheService.GetCategoriesAsync());
    }

    public IEnumerable<ClotheWrapper> RecommendationClothes { get; set; }

    #region TrendingClothes
    private SourceCache<ClotheWrapper, long> _trendingClothesCache = new SourceCache<ClotheWrapper, long>(l => l.Id);
    private readonly ReadOnlyObservableCollection<ClotheWrapper> _trendingClothes;
    public ReadOnlyObservableCollection<ClotheWrapper> TrendingClothes => _trendingClothes;
    #endregion


    #region Categories
    private SourceCache<CategorieWrapper, long> _categoriesCache = new SourceCache<CategorieWrapper, long>(l => l.Id);
    private readonly ReadOnlyObservableCollection<CategorieWrapper> _categories;
    public ReadOnlyObservableCollection<CategorieWrapper> Categories => _categories;
    #endregion
}
