public abstract class BehaviorTree
 {
     public Blackboard bb;
     public BTNode rootNode;

     public BehaviorTree(Blackboard blackboard)
     {
         bb = blackboard;
        
     }

     public void Tick()
     {
         
     }
 }