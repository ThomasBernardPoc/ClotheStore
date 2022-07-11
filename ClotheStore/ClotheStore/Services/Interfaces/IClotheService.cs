using ClotheStore.Models;

namespace ClotheStore.Services.Interfaces;

public interface IClotheService
{
    Task<IEnumerable<ClotheWrapper>> GetClothesAsync();
    Task<IEnumerable<CategorieWrapper>> GetCategoriesAsync();
}
