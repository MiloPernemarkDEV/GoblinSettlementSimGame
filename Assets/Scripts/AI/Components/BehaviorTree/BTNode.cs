public abstract class BTNode
{
    protected Blackboard blackboard;
    
    public enum NodeState { Running, Success, Failure }
    
    public BTNode(Blackboard blackboard) { this.blackboard = blackboard; }
    public abstract NodeState Evaluate();
}
