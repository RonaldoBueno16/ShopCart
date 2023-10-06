using ShopCart.Domain.Entities;

namespace ShopCart.Domain.ValueObjects;

public class CartProduct
{
    public Product Product { get; private set; }
    public int Quantity { get; private set; }

    public CartProduct(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    /// <summary>
    /// Adiciona a quantidade do item
    /// </summary>
    /// <param name="quantity"></param>
    public void IncreaseQuantity(int quantity)
        => Quantity += quantity;
}