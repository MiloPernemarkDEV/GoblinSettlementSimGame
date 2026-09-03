using UnityEngine.Audio;

public abstract class BehaviorTree
 {
     public Blackboard bb;
     protected BTNode rootNode;

     public BehaviorTree(Blackboard blackboard)
     {
         bb = blackboard;
         rootNode = SetupTree();

     }
     
     protected abstract BTNode SetupTree();

     public void Tick()
     {
         if (rootNode != null)
         {
             rootNode.Evaluate();
         }
     }
 }