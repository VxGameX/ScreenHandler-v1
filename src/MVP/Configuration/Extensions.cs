using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MVP.Settings;

namespace MVP.Configuration;

public static class Extensions
{
    public static IServiceCollection AddConfigFile(this IServiceCollection services)
    {
        services.AddSingleton(sp =>
        {
            var configuration = sp.GetService<IConfiguration>()!;

            var serviceSettings = configuration
                .GetSection(nameof(ConfigFile))
                .Get<ConfigFile>();

            var mongoDbSettings = configuration
                .GetSection(nameof(MongoDbSettings))
                .Get<MongoDbSettings>();

            var mongoDbClient = new MongoClient(mongoDbSettings.ConnectionString);
            return mongoDbClient.GetDatabase(serviceSettings.ServiceName);
        });

        return services;
    }
}
