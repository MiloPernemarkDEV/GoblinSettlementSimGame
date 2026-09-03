using UnityEngine;

public class SimulationEvents : Singleton<SimulationEvents>
{
    [SerializeField] private StringPayloadEvent populationAdded;
    public StringPayloadEvent PopulationAdded => populationAdded;
}
