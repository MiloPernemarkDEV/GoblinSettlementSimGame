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
    }

    private void Start()
    {
        if (config.GoblinAffinity == GoblinAffinity.Mining)
        {
            tree = new MinerBehaviorTree(blackboard, agent);
            tree.Initialize(blackboard);

            tree.bb.SetValue(BBConstants.TargetMiningSite, MineSitesManager.Instance.GetMineSiteSpawn(transform.position));
            Debug.Log($"Target Mining site = {tree.bb.GetValue<Vector3>(BBConstants.TargetMiningSite)}");
        }

        EventRelay.Instance.GoblinEvents.Mining.Subscribe += OnMiningFinished;
    }

    private void Update()
    {
        tickTimer -= Time.deltaTime;
        if (tickTimer > 0f) return;
        tickTimer = tickInterval;
        tree.Tick();
    }

    private void OnMiningFinished(EventStatus status)
    {
        if (status == EventStatus.Finished)
        {
            tree.bb.SetValue(BBConstants.IsMiningFinished, true);
        }
    }
}
