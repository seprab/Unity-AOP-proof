using Unity.Profiling;
using Unity.Profiling.Editor;

[System.Serializable]
[ProfilerModuleMetadata("Player Stats")]
public class PlayerModule : ProfilerModule
{
    static readonly ProfilerCounterDescriptor[]
    k_Counters = {
    new(GameStats.ExplosionCountName, GameStats.PlayerCategory),
    new(GameStats.PlayerSpeedName, GameStats.PlayerCategory),
    new(GameStats.BulletCountName, GameStats.PlayerCategory),
    };

    public PlayerModule() : base(k_Counters) { }
}