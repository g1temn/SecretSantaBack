using SecretSantaBack.DAL.Constants;
using SecretSantaBack.DAL.Enums;

namespace SecretSantaBack.DAL.DTOs.WishDTOs;

public class CreateWishDto
{
    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; } = WishConstants.MinQuantity;
    public WishStatus Status { get; set; } = WishStatus.Published;
}
