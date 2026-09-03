using UnityEngine;

public class EventRelay : Singleton<EventRelay>
{
    [SerializeField] private SimulationEvents simulationEvents;
    [SerializeField] private ResourceEvents resourceEvents;
    
    public SimulationEvents SimulationEvents => simulationEvents;
    public ResourceEvents ResourceEvents => resourceEvents;
}
