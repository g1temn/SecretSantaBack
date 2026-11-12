using SecretSantaBack.DAL.Entities.BaseEntity;

namespace SecretSantaBack.DAL.Entities;

public class Group : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
