using UnityEngine;

public class BTCheckHunger : BTNode
{
    public BTCheckHunger(Blackboard blackboard) : base(blackboard) {}

    public override NodeState Evaluate()
    {
        var isHungry = blackboard.GetValue<bool>(BBConstants.IsHungry);

        if (!isHungry) return NodeState.Failure;
        
        Debug.Log("Is Hungry");
        // Either set another bb value or call functionality here 
        return NodeState.Success;
    }
}
