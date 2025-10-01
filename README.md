# production-ready

> If it compiles — it ships.  
> Tested in prod. Twice.

This repo is a museum of conscious anti-patterns.  
It exists to trigger architects, confuse linters, and make juniors cry.

**Rules of this house:**
- `try { /* magic */ } catch { /* ignore */ }`
- `async` everywhere. Especially where it makes no sense.
- Singletons that know everything about everyone.
- Magic numbers. Because names are for cowards.
- Copy-paste configs — DRY is for meetings, not for shipping.

### What’s inside?

- `TryCatchSwallow` — swallow every exception and move on with your life.
- `SingletonGod` — global mutable state because… why not.
- `MagicNumbers` — constants? never heard of them.
- `AsyncEverywhere` — latency-as-a-service.
- `CopyPasteConfig` — configuration via Ctrl+C / Ctrl+V.

### Quick start

```bash
dotnet build
dotnet run --project src/ProductionReady
dotnet test
