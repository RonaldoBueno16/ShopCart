namespace ShopCart.Domain.Entities;

public class Cupom : EntityBase
{
    /// <summary>
    /// Código do Cupom
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Porcentagem do desconto (Valor de 0.0 a 1.0)
    /// </summary>
    public decimal Discount { get; set; }
}