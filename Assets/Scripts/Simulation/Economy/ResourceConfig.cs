using UnityEngine;

[CreateAssetMenu(fileName = "ResourceConfig", menuName = "Economy/Resources/ResourceConfig", order = 0)]
public class ResourceConfig : ScriptableObject
{
    [SerializeField] private int peasantGoblinCost= 100;
    [SerializeField] private int standardGoblinCost = 200;
    [SerializeField] private int hobGoblin = 300;
}
