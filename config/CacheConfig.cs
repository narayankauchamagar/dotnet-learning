using Enyim.Caching.Configuration;
using learning_dotnet.cache;
using Microsoft.Extensions.DependencyInjection;

namespace learning_dotnet.config;

internal static class CacheConfig {
    
    public static IServiceProvider Configure() {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddEnyimMemcached(o => o.Servers = new List<Server> { new Server { Address = "0.0.0.0", Port = 11211 } });
 
        services.AddSingleton<ICacheRepository, CacheRepository>();
        return services.BuildServiceProvider();
    }
}