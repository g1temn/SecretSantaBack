using SecretSantaBack.DAL.Entities.BaseEntity;

namespace SecretSantaBack.DAL.Entities;

public class User : Entity
{
    public string Username { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

}
