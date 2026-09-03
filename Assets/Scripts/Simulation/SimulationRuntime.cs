public class SimulationRuntime : Singleton<SimulationRuntime>
{
    public SimulationModel Model { get; } = new();
}