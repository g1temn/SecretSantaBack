using Microsoft.EntityFrameworkCore;
using SecretSantaBack.DAL.Entities;

namespace SecretSantaBack.DAL.Data;

public class SecretSantaBackDbContext(DbContextOptions<SecretSantaBackDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Wish> Wishes { get; set; }
    public DbSet<Group> Groups { get; set; }
}
