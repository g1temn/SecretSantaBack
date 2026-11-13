using SecretSantaBack.DAL.Entities.BaseEntity;
using SecretSantaBack.DAL.Enums;
using SecretSantaBack.DAL.Constants;

namespace SecretSantaBack.DAL.Entities;

public class Wish : Entity
{
    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public int Quantity { get; set; } = WishConstants.MinQuantity;
    public WishStatus Status { get; set; } = WishStatus.Published;
}
