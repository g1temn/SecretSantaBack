using SecretSantaBack.DAL.DTOs.GroupDTOs;

namespace SecretSantaBack.DAL.Repos.GroupRepo;

public interface IGroupRepo
{
    public Task<List<GetGroupDto>> GetGroupsAsync();
    public Task<GetGroupDto?> GetGroupByIdAsync(int id);
    public Task<bool> CreateGroupAsync(CreateGroupDto dto);
    public Task<GetGroupDto?> UpdateGroupAsync(int id, UpdateGroupDto dto);
    public Task<bool> DeleteGroupAsync(int id);
}
