using UnityEngine;
using UnityEngine.AI;

public class GoblinAgent :  MonoBehaviour
{
    [SerializeField] private float tickInterval = 0.25f;
    [SerializeField] private GoblinConfig config;
    [SerializeField] private NavMeshAgent agent;
    
    private Blackboard blackboard;
    private BehaviorTree tree;
    private float tickTimer;
    
    private void Awake()
    {
        blackboard = GetComponent<Blackboard>();

        if (config.GoblinAffinity == GoblinAffinity.Mining)
        {
            // Move tree assignment depending on affinity 
        }
    }

    private void Start()
    {
        tree = new MinerBehaviorTree(blackboard, agent);
        
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
