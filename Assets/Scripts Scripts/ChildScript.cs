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
            //Set RigidBody To Active
        }

        // on animation event exit
      //  {
           // collision.transform.SetParent(null);
       // }

}