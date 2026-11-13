namespace SecretSantaBack.DAL.DTOs.UserDTOs;

public class GetUserDto
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
