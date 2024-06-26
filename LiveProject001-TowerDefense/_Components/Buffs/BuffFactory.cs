namespace LiveProject001;

public static class BuffFactory
{
    public static Buff CreateBuff(Monster monster, Effects effect)
    {
        return effect switch
        {
            Effects.Freeze => new(monster, effect, 3f, 99f, (m) => m.RecalculateSpeed(), (m) => m.RecalculateSpeed()),
            Effects.Burn => new(monster, effect, 3.5f, 1f, tick: (m) => m.TakeDamage(1, DamageTypes.Fire)),
            _ => null,
        };
    }
}
