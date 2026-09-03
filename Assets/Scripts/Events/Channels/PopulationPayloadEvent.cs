using UnityEngine;

[CreateAssetMenu(fileName = "PopulationPayloadEvent", menuName = "Event Channels/PopulationPayloadEvent")]
public class PopulationPayloadEvent : ScriptableObject
{
    public event System.Action<PopulationChange>  Event;

    public void Ping(PopulationChange resourceChange)
    {
        Event?.Invoke(resourceChange);
    }
}
