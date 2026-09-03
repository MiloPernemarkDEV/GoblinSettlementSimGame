using UnityEngine;

[CreateAssetMenu(fileName = "BoolPayloadEvent", menuName = "Event Channels/StatusPayloadEvent")]
public class StatusPayloadEvent : ScriptableObject
{
    public event System.Action<EventStatus> Event;

    public void Ping(EventStatus status)
    {
        Event?.Invoke(status);
    }
}