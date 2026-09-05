using System;
using System.Collections.Generic;

public class BTSequence : BTNode
{
    private List<BTNode> children;

    public BTSequence(Blackboard blackboard, List<BTNode> children) : base(blackboard)
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
                case NodeState.Failure:
                    return NodeState.Failure;
                case NodeState.Success:
                    continue;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        return NodeState.Success;
    }
}
