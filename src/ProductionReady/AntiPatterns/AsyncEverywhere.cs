namespace ProductionReady.AntiPatterns;

public static class AsyncEverywhere
{
    public static async Task DoEverythingAsync()
    {
        await Task.Delay(1);               // async is life
        _ = FireAndForget();               // who needs await anyway
        await Task.Run(() => BusyWait());  // CPU goes brrr
    }

    private static async Task FireAndForget()
    {
        await Task.Delay(42);
        // no error handling, naturally
        _ = 1 / new Random().Next(0, 2);
    }

    private static void BusyWait()
    {
        var end = DateTime.UtcNow.AddMilliseconds(5);
        while (DateTime.UtcNow < end) { /* vibe */ }
    }
}
