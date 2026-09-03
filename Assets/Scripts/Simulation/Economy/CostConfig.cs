using UnityEngine;

[CreateAssetMenu(fileName = "CostConfig", menuName = "Economy/Resources/CostConfig", order = 0)]
public class CostConfig : ScriptableObject
{
    [SerializeField, Range(0, 200)] private int goblinCost;
    [SerializeField, Range(200, 500)] private int hobGoblin;
    public int GoblinCost => goblinCost;
    public int HobGoblin => hobGoblin;
}

