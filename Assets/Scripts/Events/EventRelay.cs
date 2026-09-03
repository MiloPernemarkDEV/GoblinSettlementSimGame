using UnityEngine;

public class EventRelay : Singleton<EventRelay>
{
    [SerializeField] private SimulationEvents simulationEvents;
    
    public SimulationEvents SimulationEvents => simulationEvents;
}
