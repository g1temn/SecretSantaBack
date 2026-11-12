namespace SecretSantaBack.DAL.Entities.BaseEntity;

public abstract class Entity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
