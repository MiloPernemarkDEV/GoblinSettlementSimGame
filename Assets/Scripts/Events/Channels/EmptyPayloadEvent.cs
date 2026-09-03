using UnityEngine;

[CreateAssetMenu(fileName = "EmptyPayloadEvent", menuName = "Event Channels/EmptyPayloadEvent", order = 0)]
public class EmptyPayloadEvent : ScriptableObject
{
    public event System.Action OnEventTriggered;

    public void TriggerEvent()
    {
        OnEventTriggered?.Invoke();
    }
}
