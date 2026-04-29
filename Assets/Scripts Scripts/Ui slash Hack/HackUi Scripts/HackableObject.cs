using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

public class HackableObject : MonoBehaviour
{
    public ElevatorMovement elevatorMovement;
    public CircularClaw circularClaw;


    public void FindTargetToHack()
    {
      Debug.Log("FindTargetToHackRuns");
        if (gameObject.tag == "ElevatorGround")
            {
              Debug.Log("Elevator tag found");
                elevatorMovement.HackBehaviour();
            }
        else if(gameObject.tag == "Fan")
            {
              //   Fan?.HackBehaviour();
            }
        else if(gameObject.tag == "WallClaw")
            {
              //   WallClaw?.HackBehaviour();
            }
        else if(gameObject.tag == "BombHook")
            {
              //   BombHook?.HackBehaviour();
            }
        else if(gameObject.tag == "Circular")
            {
              Debug.Log("CircularClawRuns");
              circularClaw.HackBehaviour();
            }
    }
}