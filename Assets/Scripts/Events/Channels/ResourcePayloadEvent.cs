using UnityEngine;

[CreateAssetMenu(fileName = "ResourcePayloadEvent", menuName = "Event Channels/ResourcePayloadEvent", order = 0)]
public class ResourcePayloadEvent : ScriptableObject
{
    public event System.Action<ResourceChange> OnEventTriggered;
    public void TriggerEvent(ResourceChange resourceChange)
    {
        OnEventTriggered?.Invoke(resourceChange);
    }
}
