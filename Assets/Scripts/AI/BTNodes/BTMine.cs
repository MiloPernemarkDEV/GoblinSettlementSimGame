using UnityEngine;

public class BTMine : BTNode
{
    public BTMine(Blackboard blackboard) : base(blackboard) {}

    public override NodeState Evaluate()
    {
            var isCurrentlyMining = blackboard.GetValue<bool>(BBConstants.IsCurrentlyMining);

            // Need a find mining site function 
            Vector3 MiningSite;
            
            if (!isCurrentlyMining)
            {
                // BTMoveTo(MiningSite);
                
                blackboard.SetValue(BBConstants.IsCurrentlyMining, true);
                EventRelay.Instance.GoblinEvents.Mining.Ping(EventStatus.Started);
            }
            
            var isMiningFinished = blackboard.GetValue<bool>(BBConstants.IsMiningFinished);

            if (isMiningFinished)
            {
                blackboard.SetValue(BBConstants.IsCurrentlyMining, false);
                blackboard.SetValue(BBConstants.IsMiningFinished, false);

                return NodeState.Success;
            }

            return NodeState.Running;   
    }

}
