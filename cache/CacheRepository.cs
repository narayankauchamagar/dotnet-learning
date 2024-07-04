using Enyim.Caching;

namespace learning_dotnet.cache;

 internal class CacheRepository: ICacheRepository {
    
    private readonly IMemcachedClient memcachedClient;

    public CacheRepository(IMemcachedClient memcachedClient) {
        this.memcachedClient = memcachedClient;
    }
    public T GetCache<T>(string key) {
        return memcachedClient.Get<T>(key);
    }
    
    public void Set<T>(string key, T value, int timeInSecond = 60 * 60) {
        // Setting cache expiration for an hour
        memcachedClient.Set(key, value, timeInSecond);
    }
    
}