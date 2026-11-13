using DotNetEnv;
using SecretSantaBack.DAL.Constants;
using SecretSantaBack.DAL.Extensions;

namespace SecretSantaBack.WebAPI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Env.Load();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connStr = builder.Configuration.GetConnectionString(DatabaseConstants.ConnectionStringName)
                ?? throw new InvalidOperationException(DatabaseConstants.ConnectionStringMissingMessage);
            builder.Services.AddDatabase(connStr);
            builder.Services.AddRepositories();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
