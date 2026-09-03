public class PopulationManager
{
    public void AddToPopulation(PopulationType type, int amount)
    {
        SimulationRuntime.Instance.TotalPopulation += amount;
    }
}
