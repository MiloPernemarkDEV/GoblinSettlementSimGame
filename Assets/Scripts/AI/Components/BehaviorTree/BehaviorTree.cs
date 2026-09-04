using UnityEngine;

public abstract class BehaviorTree : MonoBehaviour
 {
     public Blackboard bb;
     protected BTNode rootNode;

     public BehaviorTree(Blackboard blackboard)
     {
         bb = blackboard;
     }

     public void Initialize()
     {
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