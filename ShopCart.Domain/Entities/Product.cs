namespace ShopCart.Domain.Entities;

public class Product : EntityBase
{
    public Product(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    /// <summary>
    /// Nome do produto
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Descrição do Produto
    /// </summary>
    public string Description { get; private set; }
    /// <summary>
    /// Preço do Produto
    /// </summary>
    public decimal Price { get; private set; }
}