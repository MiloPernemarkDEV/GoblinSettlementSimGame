using UnityEngine;

public class EventRelay : Singleton<EventRelay>
{
    [SerializeField] private SimulationEvents simulationEvents;
    [SerializeField] private ResourceEvents resourceEvents;
    [SerializeField] private GoblinEvents goblinEvents;
    
    public SimulationEvents SimulationEvents => simulationEvents;
    public ResourceEvents ResourceEvents => resourceEvents;
    public GoblinEvents GoblinEvents => goblinEvents;
}
