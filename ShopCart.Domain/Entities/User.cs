namespace ShopCart.Domain.Entities;

public class User : EntityBase
{
    /// <summary>
    /// Primeiro nome do usuário
    /// </summary>
    public string FirstName { get; private set; }

    /// <summary>
    /// Último do usuário
    /// </summary>
    public string LastName { get; private set; }

    /// <summary>
    /// E-mail do usuário
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Objeto de carrinho do usuário
    /// </summary>
    public Cart Cart { get; private set; }

    public User(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}