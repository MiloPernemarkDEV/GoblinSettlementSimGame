using System;

public static class EnumHelpers
{
    public static string GoblinAffinityToString(GoblinAffinity affinity)
    {
        return affinity switch
        {
            GoblinAffinity.Cooking => "Cooking",
            GoblinAffinity.Fighting => "Fighting",
            GoblinAffinity.Mining => "Mining",
            _ => throw new ArgumentOutOfRangeException(nameof(affinity), affinity, null)
        };
    }
}