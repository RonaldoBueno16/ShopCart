namespace ShopCart.Domain.Entities;

public class Item : EntityBase
{
    public Item(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    public Item()
    {
    }

    /// <summary>
    /// Nome do produto
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Descrição do produto
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Preço do produto
    /// </summary>
    public double Price { get; private set; }
}