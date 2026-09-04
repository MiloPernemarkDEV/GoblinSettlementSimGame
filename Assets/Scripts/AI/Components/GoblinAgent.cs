using UnityEngine;

[RequireComponent(typeof(Blackboard))]
public class GoblinAgent :  MonoBehaviour
{
    [SerializeField] private float tickInterval = 0.25f;
    [SerializeField] private GoblinConfig config; 
    
    private Blackboard blackboard;
    private BehaviorTree tree;
    private float tickTimer;
    
    private void Awake()
    {
        if (config.GoblinAffinity == GoblinAffinity.Mining)
        {
            // Move tree assignment depending on affinity 
        }
        
        tree = new MinerBehaviorTree(blackboard);
        
        tree.Initialize(blackboard);
    }
    
    private void Update()
    {
        tickTimer -= Time.deltaTime;
        if (tickTimer > 0f) return;
        tickTimer = tickInterval;
        tree.Tick();
    }
}
