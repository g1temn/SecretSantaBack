using Microsoft.EntityFrameworkCore;
using SecretSantaBack.DAL.Data;
using SecretSantaBack.DAL.DTOs.UserDTOs;
using SecretSantaBack.DAL.Entities;

namespace SecretSantaBack.DAL.Repos.UserRepo;

public class UserRepo(SecretSantaBackDbContext context) : IUserRepo
{
    public async Task<bool> DeleteUserAsync(int id)
    {
        var user = await context.Users.FindAsync(id);
        if (user == null) return false;
        context.Users.Remove(user);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<GetUserDto?> GetUserByIdAsync(int id)
    {
        var user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null) return null;

        return new GetUserDto
        {
            Id = user.Id,
            Username = user.Username,
            Bio = user.Bio,
            Email = user.Email
        };
    }

    public async Task<List<GetUserDto>> GetUsersAsync()
    {
        return await context.Users.AsNoTracking().Select(u => new GetUserDto
        {
            Id = u.Id,
            Username = u.Username,
            Bio = u.Bio,
            Email = u.Email
        }).ToListAsync();
    }

    public async Task<bool> RegisterUserAsync(RegisterUserDto dto)
    {
        var user = new User
        {
            Username = dto.Username,
            Bio = dto.Bio,
            Email = dto.Email,
            PasswordHash = dto.Password // Will be hashed later
        };
        context.Users.Add(user);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<GetUserDto?> UpdateUserAsync(int id, UpdateUserDto dto)
    {
        var user = await context.Users.FindAsync(id);
        if (user == null) return null;

        user.Username = dto.Username;
        user.Bio = dto.Bio;
        user.Email = dto.Email;

        await context.SaveChangesAsync();
        return new GetUserDto
        {
            Id = user.Id,
            Username = user.Username,
            Bio = user.Bio,
            Email = user.Email
        };
    }
}
