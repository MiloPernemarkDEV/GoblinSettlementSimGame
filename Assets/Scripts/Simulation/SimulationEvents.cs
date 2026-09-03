using UnityEngine;

public class SimulationEvents : Singleton<SimulationEvents>
{
    [SerializeField] private PopulationPayloadEvent populationAdded;
    public PopulationPayloadEvent PopulationAdded => populationAdded;
}
