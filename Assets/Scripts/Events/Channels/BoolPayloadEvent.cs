using UnityEngine;

[CreateAssetMenu(fileName = "BoolPayloadEvent", menuName = "Event Channels/BoolPayloadEvent")]
public class BoolPayloadEvent : ScriptableObject
{
    public event System.Action<bool> Event;

    public void Ping(bool flag)
    {
        Event?.Invoke(flag);
    }
}