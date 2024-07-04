namespace learning_dotnet.cache;

public interface ICacheRepository {
    
        T GetCache<T>(string key);
        void Set<T>(string key, T value, int timeInSecond);
}