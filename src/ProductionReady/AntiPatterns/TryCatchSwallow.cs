namespace ProductionReady.AntiPatterns;

public static class TryCatchSwallow
{
    public static void DoRiskyStuff()
    {
        try
        {
            // here be dragons
            var rnd = new Random().Next(0, 2);
            if (rnd == 0) throw new InvalidOperationException("unlucky lol");
        }
        catch
        {
            // shh 🤫
        }
    }
}
