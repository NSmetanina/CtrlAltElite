using UnityEngine;

    //is called when other script calls this script

public class HackableObject : MonoBehaviour
{   

    public ElevatorMovement elevatorMovement;
    
    public Animator elevator;

    public void HackBehaviour()
    {
        if (gameObject.tag == "ElevatorGround") 
            {
                Debug.Log("Function from ScriptA is called, I'm " + gameObject.name); 
                 
                if ( transform.position.z >= 0.94f)
                {
                        Debug.Log("Hello"); 
                    elevator.SetBool("DownTrigger", true);
                    elevator.ResetTrigger("UpTrigger");
                }
                else if ( transform.position.z <= -0.88f)
                {
                        Debug.Log("Hello2"); 
                    elevator.SetBool("UpTrigger", true);
                    elevator.ResetTrigger("DownTrigger");
                }
                else 
                Debug.Log("Hello3"); 
                return;
    
        }
    }
}