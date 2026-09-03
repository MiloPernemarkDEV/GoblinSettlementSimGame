using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "AITypeConfig", menuName = "AI/AITypeConfig", order = 0)]
public class AITypeConfig : ScriptableObject
{
    [FormerlySerializedAs("npcType")] [SerializeField] private GoblinType goblinType;
    [FormerlySerializedAs("npcAffinity")] [SerializeField] private GoblinAffinity goblinAffinity;
    
    public GoblinType GoblinType { get => goblinType; set => goblinType = value; }
    public GoblinAffinity GoblinAffinity { get => goblinAffinity; set => goblinAffinity = value; }
}
