using System.Collections.Generic;

public class MinerBehaviorTree : BehaviorTree
{
    public MinerBehaviorTree(Blackboard blackboard) : base(blackboard)
    {
        
    }

    protected override void RegisterKeys(Blackboard blackboard)
    {
        blackboard.AddKey(BBConstants.IsHungry, false);
        blackboard.AddKey(BBConstants.IsCurrentlyMining, false);
        blackboard.AddKey(BBConstants.IsMiningFinished, false);
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