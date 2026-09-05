using UnityEngine;

[CreateAssetMenu(fileName = "BoolPayloadEvent", menuName = "Event Channels/StatusPayloadEvent")]
public class StatusPayloadEvent : ScriptableObject
{
    public event System.Action<EventStatus> Subscribe;

    public void Ping(EventStatus status)
    {
        Subscribe?.Invoke(status);
    }
}