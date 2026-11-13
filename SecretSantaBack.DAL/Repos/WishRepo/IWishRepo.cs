using SecretSantaBack.DAL.DTOs.WishDTOs;

namespace SecretSantaBack.DAL.Repos.WishRepo;

public interface IWishRepo
{
    public Task<List<GetWishDto>> GetWishesAsync();
    public Task<GetWishDto?> GetWishByIdAsync(int id);
    public Task<bool> CreateWishAsync(CreateWishDto dto);
    public Task<GetWishDto?> UpdateWishAsync(int id, UpdateWishDto dto);
    public Task<bool> DeleteWishAsync(int id);
}
