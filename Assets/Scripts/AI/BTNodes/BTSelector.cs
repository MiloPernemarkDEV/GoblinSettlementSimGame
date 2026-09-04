using System;
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
            switch (child.Evaluate())
            {
                case NodeState.Running:
                    return NodeState.Running;
                case NodeState.Success:
                    return NodeState.Success;
                case NodeState.Failure:
                    continue;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        return NodeState.Failure;
    }
    
}