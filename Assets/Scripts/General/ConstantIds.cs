public static class ConstantIds
{
    public const string PeasantGoblin =  "PEASANT_GOBLIN_ID";
    public const string RandomGoblin = "RANDOM_POPULATION_ID";
    
    // 

    public static string ToDisplayName(string id)
    {
        return id switch
        {
            PeasantGoblin => "Peasant Goblin",
            RandomGoblin => "Random Goblin",
            _ => "Unknown, couldn't find which goblin to display"
        };
    }
}
