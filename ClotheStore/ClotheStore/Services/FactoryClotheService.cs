using ClotheStore.Commons;
using ClotheStore.Models;
using ClotheStore.Services.Interfaces;

namespace ClotheStore.Services;

internal class FactoryClotheService : IClotheService
{
    public async Task<IEnumerable<CategorieWrapper>> GetCategoriesAsync()
    {
        return new List<CategorieWrapper>()
        {
            new CategorieWrapper(1, "Woman", Constants.Venus, new List<ClotheWrapper>()),
            new CategorieWrapper(2, "Man", Constants.Mars, new List<ClotheWrapper>()),
        };
    }

    public async Task<IEnumerable<ClotheWrapper>> GetClothesAsync()
    {
        return new List<ClotheWrapper>()
        {
            new ClotheWrapper(1, "Russ Shirt", "https://images.asos-media.com/products/american-stitch-short-cargo-en-jersey-blanc/202286972-1-white?$n_750w$&wid=750&fit=constrain", 19.99, 25.99),
            new ClotheWrapper(2, "Comfort Jacket", "https://images.asos-media.com/products/replay-sweat-bleu/202194183-1-blue?$n_640w$&wid=513&fit=constrain", 50.95, 60.95),
            new ClotheWrapper(3, "Eywa Hoodie", "https://images.asos-media.com/products/asos-design-sweat-oversize-avec-imprime-tigres-au-dos-noir/202587786-1-black?$n_640w$&wid=513&fit=constrain", 30.99, 35.99),
            new ClotheWrapper(4, "Nike Hoodie", "https://images.asos-media.com/products/collusion-t-shirt-a-logo-oversize-vert/24441312-1-green?$n_640w$&wid=513&fit=constrain", 24.99, null),
        };
    }
}
