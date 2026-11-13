using SecretSantaBack.DAL.Enums;

namespace SecretSantaBack.DAL.DTOs.WishDTOs;

public class GetWishDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public WishStatus Status { get; set; }
}
