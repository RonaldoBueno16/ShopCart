namespace ShopCart.Domain.Entities;

public class Cart : EntityBase
{
    /// <summary>
    /// Lista de produtos do carrinho
    /// </summary>
    public List<Item> Items { get; set; }

    public Cart()
        => Items = new List<Item>();
}