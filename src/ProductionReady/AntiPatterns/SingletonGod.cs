namespace ProductionReady.AntiPatterns;

// Global mutable state because why not.
public sealed class SingletonGod
{
    private static SingletonGod _instance; // no locks, we trust the universe
    public static SingletonGod Instance => _instance ??= new SingletonGod();

    private readonly Dictionary<string, string> _bag = new();

    private SingletonGod() { }

    public void Set(string key, string value) => _bag[key] = value;
    public string Get(string key) => _bag.TryGetValue(key, out var v) ? v : "¯\\_(ツ)_/¯";
}
