public abstract class BehaviorTree 
 {
     public Blackboard bb;
     protected BTNode rootNode;

     public BehaviorTree(Blackboard blackboard)
     {
         bb = blackboard;
     }

     public void Initialize(Blackboard blackboard)
     {
         bb = blackboard;
         rootNode = SetupTree();
     }
     protected virtual void RegisterKeys(Blackboard blackboard) { }
     protected abstract BTNode SetupTree();

     public void Tick()
     {
         if (rootNode != null)
         {
             rootNode.Evaluate();
         }
     }
 }