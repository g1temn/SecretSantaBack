using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SecretSantaBack.DAL.Data;

namespace SecretSantaBack.DAL.Extensions;

public static class DatabaseServiceExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<SecretSantaBackDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}
