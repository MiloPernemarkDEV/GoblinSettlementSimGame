using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinerBehaviorTree : BehaviorTree
{
    private NavMeshAgent _agent;

    public MinerBehaviorTree(Blackboard blackboard, NavMeshAgent agent) : base(blackboard)
    {
        _agent = agent;
    }

    protected override void RegisterKeys(Blackboard blackboard)
    {
        blackboard.AddKey(BBConstants.IsHungry, false);
        blackboard.AddKey(BBConstants.IsCurrentlyMining, false);
        blackboard.AddKey(BBConstants.IsMiningFinished, false);
        blackboard.AddKey(BBConstants.TargetMiningSite, Vector3.zero);
        blackboard.AddKey(BBConstants.IsAtMiningSite, false);
        blackboard.AddKey(BBConstants.NavMeshAgent, _agent);
    }

    protected override BTNode SetupTree()
    {
        return new BTSelector(bb, new List<BTNode>
        {
            new BTCheckHunger(bb),
            new BTSequence(bb, new List<BTNode>
            {
                new BTMoveTo(bb),
                new BTMine(bb)
            })
        });
    }
}