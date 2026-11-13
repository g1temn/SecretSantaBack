using Microsoft.Extensions.DependencyInjection;
using SecretSantaBack.DAL.Repos.GroupRepo;
using SecretSantaBack.DAL.Repos.UserRepo;
using SecretSantaBack.DAL.Repos.WishRepo;

namespace SecretSantaBack.DAL.Extensions;

public static class RepositoryServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepo, UserRepo>();
        services.AddScoped<IWishRepo, WishRepo>();
        services.AddScoped<IGroupRepo, GroupRepo>();

        return services;
    }
}
