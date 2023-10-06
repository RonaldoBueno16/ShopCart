using System.Text.Json;
using ShopCart.Domain.ValueObjects;

namespace ShopCart.Domain.Entities;

public class Cart : EntityBase
{
    public Cart()
    {
    }

    /// <summary>
    /// Lista de produtos
    /// </summary>
    public List<CartProduct> Products { get; private set; } = new();

    /// <summary>
    /// Cupom de desconto
    /// </summary>
    public Cupom? CupomDiscount { get; set; }

    /// <summary>
    /// Obtem o valor bruto da compra, sem o valor de desconto aplicado
    /// </summary>
    /// <returns></returns>
    public decimal Total()
        => Products.Sum(product => product.Quantity * product.Product.Price);

    /// <summary>
    /// Obtém o subtotal com o cupom de desconto aplicado
    /// </summary>
    /// <returns></returns>
    public decimal SubTotal()
    {
        var total = Total();
        if (CupomDiscount != null)
            total *= CupomDiscount.Discount;
        return total;
    }

    /// <summary>
    /// Limpar o carrinho
    /// </summary>
    public void Clear()
        => Products.Clear();

    /// <summary>
    /// Adiciona um cupom de desconto
    /// </summary>
    /// <param name="cupom"></param>
    public void AddCupom(Cupom cupom)
        => CupomDiscount = cupom;

    /// <summary>
    /// Adiciona um produto no carrinho ou atualiza a quantidade se o produto já estiver no carrinho.
    /// </summary>
    /// <param name="product">Produto</param>
    /// <param name="quantity">Valor</param>
    public void AddProduct(Product product, int quantity)
    {
        var existingProduct = Products.FirstOrDefault(p => p.Product.Id == product.Id);

        if (existingProduct != null)
            existingProduct.IncreaseQuantity(quantity);
        else
            Products.Add(new CartProduct(product, quantity));
    }

    /// <summary>
    /// Remove o produto especifico do carrinho
    /// </summary>
    /// <param name="product"></param>
    public void RemoveProduct(Product product)
    {
        Products.RemoveAll(cartProduct => cartProduct.Product.Id == product.Id);
    }

    /// <summary>
    /// Define a quantidade de item do produto
    /// </summary>
    /// <param name="product"></param>
    /// <param name="quantity"></param>
    public void UpdateQuantityProduct(Product product, int quantity)
    {
        
    }

    public static implicit operator string(Cart cart)
        => cart.ToString();

    public override string ToString()
        => JsonSerializer.Serialize(this);
}