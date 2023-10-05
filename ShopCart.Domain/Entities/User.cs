namespace ShopCart.Domain.Entities;

public class User : EntityBase
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Cart? Cart { get; private set; }
}