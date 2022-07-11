namespace ClotheStore.Models;

public class CategorieWrapper
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public IEnumerable<ClotheWrapper> Clothes { get; set; }

    public CategorieWrapper(long id, string name, string icon, IEnumerable<ClotheWrapper> clothes)
    {
        Id = id;
        Name = name;
        Icon = icon;
        Clothes = clothes;
    }
}
