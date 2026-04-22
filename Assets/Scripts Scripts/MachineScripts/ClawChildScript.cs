using UnityEngine;

public class ClawChildScript : MonoBehaviour
{

    public Transform ObjectToParent;
    public Transform ParentObject;

        public void EventToSetParent(Collider collision) 
        {
            Debug.Log("ThisRuns!");
            ObjectToParent.SetParent(ParentObject);
            //reset local pos?
        }

        public void EventToRemoveParent(Collider collision) 
        {
            Debug.Log("ThisAlsoRuns!");
            ObjectToParent.SetParent(null);
            //reset local pos?
        }

        // on animation event exit
      //  {
           // collision.transform.SetParent(null);
       // }
        
   // in the animation window you can add an event, in this event you can call something in a script but i wasn't thinking about how you couldn't control an object before childing,
    //maybe when you move the claw parenting alone could be enough as long as you reset the childs position (but that would have to be through script?) and have it be a child of the bit of the end of the claw like the tips of it

}
