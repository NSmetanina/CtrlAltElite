using UnityEngine;

    //is called when other script calls this script

public class HackableObject : MonoBehaviour
{   

    public ElevatorMovement elevatorMovement;

    public void FunctionToCall()
    {
        if (gameObject.tag.Contains("Elevator")) 
            {
                Debug.Log("Function from ScriptA is called, I'm " + gameObject.name); 
                 
                if (elevatorMovement.ElevatorYPosition == elevatorMovement.BottomStopPoint)
                {
                    Debug.Log("Elevator is moving up"); 
                    elevatorMovement.MoveUp();
                }
                else if (elevatorMovement.ElevatorYPosition == elevatorMovement.TopStopPoint)
                {
                    Debug.Log("Elevator is moving down");
                    elevatorMovement.MoveDown(); 
                }
                else 
                {
                    Debug.Log("Elevator was moving so cant run another move script"); 
                }
            }
    
    }
}
