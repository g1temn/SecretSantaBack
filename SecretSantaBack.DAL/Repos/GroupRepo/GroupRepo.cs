using Microsoft.EntityFrameworkCore;
using SecretSantaBack.DAL.Data;
using SecretSantaBack.DAL.DTOs.GroupDTOs;
using SecretSantaBack.DAL.Entities;

namespace SecretSantaBack.DAL.Repos.GroupRepo;

public class GroupRepo(SecretSantaBackDbContext context) : IGroupRepo
{
    public async Task<bool> DeleteGroupAsync(int id)
    {
        var group = await context.Groups.FindAsync(id);
        if (group == null) return false;
        context.Groups.Remove(group);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<GetGroupDto?> GetGroupByIdAsync(int id)
    {
        var group = await context.Groups.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
        if (group == null) return null;

        return ToDto(group);
    }

    public async Task<List<GetGroupDto>> GetGroupsAsync()
    {
        return await context.Groups.AsNoTracking().Select(g => new GetGroupDto
        {
            Id = g.Id,
            Name = g.Name,
            Description = g.Description
        }).ToListAsync();
    }

    public async Task<bool> CreateGroupAsync(CreateGroupDto dto)
    {
        var group = new Group
        {
            Name = dto.Name,
            Description = dto.Description
        };
        context.Groups.Add(group);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<GetGroupDto?> UpdateGroupAsync(int id, UpdateGroupDto dto)
    {
        var group = await context.Groups.FindAsync(id);
        if (group == null) return null;

        group.Name = dto.Name;
        group.Description = dto.Description;

        await context.SaveChangesAsync();
        return ToDto(group);
    }

    private static GetGroupDto ToDto(Group group) => new()
    {
        Id = group.Id,
        Name = group.Name,
        Description = group.Description
    };
}
