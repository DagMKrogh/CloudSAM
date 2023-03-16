

namespace Domain.Entities.User;

public class UserEntity : IEntity<Guid>, IAggregateRoot
{
    public Guid Id { get; private set; }
    public string UserPrincipalName { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public bool Active { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    public UserEntity(string name, string email, string password, string role)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
        Role = role;
        Active = true;
        CreatedAt = DateTime.Now;
    }

    public void Update(string name, string email, string password, string role)
    {
        Name = name;
        Email = email;
        Password = password;
        Role = role;
        UpdatedAt = DateTime.Now;
    }

    public void Activate()
    {
        Active = true;
    }

    public void Inactivate()
    {
        Active = false;
    }
}