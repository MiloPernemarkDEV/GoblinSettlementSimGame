using System.Collections.Generic;

public class MinerBehaviorTree : BehaviorTree
{
    public MinerBehaviorTree(Blackboard blackboard) : base(blackboard)
    {
        
    }

    protected override BTNode SetupTree()
    {
        return new BTSelector(bb, new List<BTNode>
        {
            new BTCheckHunger(bb),
            new BTMine(bb)
        });
    }

}