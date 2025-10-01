namespace ProductionReady.AntiPatterns;

public static class CopyPasteConfig
{
    // imagine this came from 7 different microservices and was merged by hand
    private static readonly Dictionary<string, string> _cfg = new()
    {
        ["timeout_ms"] = "1337",
        ["retries"] = "0",
        ["log_level"] = "¯\\_(ツ)_/¯",
        ["mode"] = "fast-and-loose"
    };

    public static IReadOnlyDictionary<string, string> Load() => _cfg;
}
