using UnityEngine;
using UnityEngine.AI;

public class BTMoveTo : BTNode
{
    public BTMoveTo(Blackboard blackboard) : base(blackboard) {}

    public override NodeState Evaluate()
    {
        var agent = blackboard.GetValue<NavMeshAgent>(BBConstants.NavMeshAgent);

        if (!agent.isOnNavMesh)
        {
            Debug.LogWarning("NavMesh agent is not on navmesh");
            return NodeState.Failure;
        }

        var destination = blackboard.GetValue<Vector3>(BBConstants.TargetMiningSite);
        if (destination == Vector3.zero)
        {
            destination = MineSitesManager.Instance.GetMineSiteSpawn();
            blackboard.SetValue(BBConstants.TargetMiningSite, destination);
        }

        destination.y = agent.transform.position.y;

        if (!agent.pathPending)
        {
            var needsNewPath = !agent.hasPath || (agent.destination - destination).sqrMagnitude > 1f;
            if (needsNewPath)
            {
                if (!agent.SetDestination(destination))
                    return NodeState.Failure;

                return NodeState.Running;
            }

            if (agent.remainingDistance <= Mathf.Max(agent.stoppingDistance, 0.5f))
                return NodeState.Success;
        }

        return NodeState.Running;
    }
}
