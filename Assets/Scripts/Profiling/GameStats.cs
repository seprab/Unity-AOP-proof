using Unity.Profiling;

public class GameStats
{
    public static readonly ProfilerCategory PlayerCategory = ProfilerCategory.Scripts;

    public static readonly string ExplosionCountName = "Explosion Count";
    public static ProfilerCounterValue<int> ExplosionCount =
        new ProfilerCounterValue<int>(PlayerCategory, ExplosionCountName,
            ProfilerMarkerDataUnit.Count, ProfilerCounterOptions.FlushOnEndOfFrame);

    public static readonly string PlayerSpeedName = "Player Speed";
    public static ProfilerCounter<float> PlayerSpeed =
        new ProfilerCounter<float>(PlayerCategory, PlayerSpeedName, 
            ProfilerMarkerDataUnit.Count);

    public static readonly string BulletCountName = "Bullet Count";
    public static ProfilerCounter<int> BulletCount =
        new ProfilerCounter<int>(PlayerCategory, BulletCountName,
            ProfilerMarkerDataUnit.Count);
}

