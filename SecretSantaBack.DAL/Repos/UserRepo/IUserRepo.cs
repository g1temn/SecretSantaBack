using SecretSantaBack.DAL.DTOs.UserDTOs;
using SecretSantaBack.DAL.Entities;

namespace SecretSantaBack.DAL.Repos.UserRepo;

public interface IUserRepo
{
    public Task<List<GetUserDto>> GetUsersAsync();
    public Task<GetUserDto?> GetUserByIdAsync(int id);
    public Task<bool> RegisterUserAsync(RegisterUserDto dto);
    public Task<GetUserDto?> UpdateUserAsync(int id, UpdateUserDto dto);
    public Task<bool> DeleteUserAsync(int id);
}
