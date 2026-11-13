using Microsoft.EntityFrameworkCore;
using SecretSantaBack.DAL.Data;
using SecretSantaBack.DAL.DTOs.WishDTOs;
using SecretSantaBack.DAL.Entities;

namespace SecretSantaBack.DAL.Repos.WishRepo;

public class WishRepo(SecretSantaBackDbContext context) : IWishRepo
{
    public async Task<bool> DeleteWishAsync(int id)
    {
        var wish = await context.Wishes.FindAsync(id);
        if (wish == null) return false;
        context.Wishes.Remove(wish);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<GetWishDto?> GetWishByIdAsync(int id)
    {
        var wish = await context.Wishes.AsNoTracking().FirstOrDefaultAsync(w => w.Id == id);
        if (wish == null) return null;

        return ToDto(wish);
    }

    public async Task<List<GetWishDto>> GetWishesAsync()
    {
        return await context.Wishes.AsNoTracking().Select(w => new GetWishDto
        {
            Id = w.Id,
            Title = w.Title,
            Comment = w.Comment,
            Price = w.Price,
            Quantity = w.Quantity,
            Status = w.Status
        }).ToListAsync();
    }

    public async Task<bool> CreateWishAsync(CreateWishDto dto)
    {
        var wish = new Wish
        {
            Title = dto.Title,
            Comment = dto.Comment,
            Price = dto.Price,
            Quantity = dto.Quantity,
            Status = dto.Status
        };
        context.Wishes.Add(wish);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<GetWishDto?> UpdateWishAsync(int id, UpdateWishDto dto)
    {
        var wish = await context.Wishes.FindAsync(id);
        if (wish == null) return null;

        wish.Title = dto.Title;
        wish.Comment = dto.Comment;
        wish.Price = dto.Price;
        wish.Quantity = dto.Quantity;
        wish.Status = dto.Status;

        await context.SaveChangesAsync();
        return ToDto(wish);
    }

    private static GetWishDto ToDto(Wish wish) => new()
    {
        Id = wish.Id,
        Title = wish.Title,
        Comment = wish.Comment,
        Price = wish.Price,
        Quantity = wish.Quantity,
        Status = wish.Status
    };
}
