using System.Collections.Generic;

public class BTSelector : BTNode
{
    private List<BTNode> children;

    public BTSelector(Blackboard blackboard, List<BTNode> children) : base(blackboard)
    {
        this.children = children;
    }

    public override NodeState Evaluate()
    {
        foreach (var child in children)
        {
            NodeState childState = child.Evaluate();
            if (childState == NodeState.Success)
            {
                return NodeState.Success;
            }
        }
        return NodeState.Failure;
    }
    
}