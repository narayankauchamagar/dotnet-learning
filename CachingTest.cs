using learning_dotnet.cache;
using learning_dotnet.config;
using Microsoft.Extensions.DependencyInjection;


namespace learning_dotnet;

public class Caching {
    
    static void Main(String[] args) {
        try {
            var provider = CacheConfig.Configure();

            Console.WriteLine("Set cache");
            var cacheRepository = provider.GetService<ICacheRepository>();
            // Set cache
            cacheRepository.Set("Key_1", "123", 60 * 3);

            Console.WriteLine("Sleep for 1 minutes");
            // Sleep for 1  Minutes
            Thread.Sleep(1000 * 60 * 2);

            Console.WriteLine("Get cache");
            // Get cache
            Console.WriteLine($"Value from cache {cacheRepository.GetCache<string>("Key_1")}");
        } catch (Exception e) {
            Console.WriteLine(e);
        }
        
    }
}