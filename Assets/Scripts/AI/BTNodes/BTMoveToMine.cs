using UnityEngine;
using UnityEngine.AI;

public class BTMoveToMine : BTNode
{
    public BTMoveToMine(Blackboard blackboard) : base(blackboard)
    {
   
    }
    

    public override NodeState Evaluate()
    {
        var agent = blackboard.GetValue<NavMeshAgent>(BBConstants.NavMeshAgent);

        if (!agent.isOnNavMesh)
        {
            Debug.LogWarning("NavMesh agent is not on navmesh");
            return NodeState.Failure;
        }

        var destination = blackboard.GetValue<Vector3>(BBConstants.TargetMiningSite);
        destination.y = agent.transform.position.y;

        if (agent.pathPending) return NodeState.Running;
        var needsNewPath = !agent.hasPath || (agent.destination - destination).sqrMagnitude > 1f;
        if (needsNewPath)
        {
            return !agent.SetDestination(destination) ? NodeState.Failure : NodeState.Running;
        }

        return agent.remainingDistance <= Mathf.Max(agent.stoppingDistance, 0.5f) ? NodeState.Success : NodeState.Running;
    }
}
