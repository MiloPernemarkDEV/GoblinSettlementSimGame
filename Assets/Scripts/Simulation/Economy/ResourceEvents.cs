using UnityEngine;

public class ResourceEvents : MonoBehaviour
{
    [SerializeField] private ResourcePayloadEvent resourceActionHappened; 
    
    public ResourcePayloadEvent ResourceActionHappened => resourceActionHappened;
}
