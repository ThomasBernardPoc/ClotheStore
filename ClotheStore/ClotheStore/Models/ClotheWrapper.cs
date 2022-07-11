namespace ClotheStore.Models;

public class ClotheWrapper
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public double Price { get; set; }
    public double? OldPrice { get; set; }
    public IEnumerable<Color> Colors { get; set; }
    public IEnumerable<Sizes> Sizes { get; set; }

    public ClotheWrapper()
    {
    }


    public ClotheWrapper(long id, string name, string image, double price, double? oldPrice)
    {
        Id = id;
        Name = name;
        Image = image;
        Price = price;
        OldPrice = oldPrice;
    }

    public ClotheWrapper(long id, string name, string image, double price, double? oldPrice, IEnumerable<Color> colors, IEnumerable<Sizes> sizes)
        :this(id, name, image, price, oldPrice)
    {
        Colors = colors;
        Sizes = sizes;
    }
}


public enum Sizes
{
    S,
    M,
    L,
    XL,
    XXL
}
