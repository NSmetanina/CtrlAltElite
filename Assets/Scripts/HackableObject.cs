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
                 
                if ( transform.position.y == 2.21f)
                {
                    elevator.SetBool("Trigger", true);
                }
                else if ( transform.position.y == 0f)
                {
                    elevator.SetBool("Trigger", true);
                }
                else 
                return;
    
        }
    }
}