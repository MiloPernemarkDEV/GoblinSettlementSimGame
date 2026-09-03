using UnityEngine;

[CreateAssetMenu(fileName = "ResourcePayloadEvent", menuName = "Event Channels/ResourcePayloadEvent", order = 0)]
public class ResourcePayloadEvent : ScriptableObject
{
    public event System.Action<ResourceChange> Event;
    public void Ping(ResourceChange resourceChange)
    {
        Event?.Invoke(resourceChange);
    }
}
