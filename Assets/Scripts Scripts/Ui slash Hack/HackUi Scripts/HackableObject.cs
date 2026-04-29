using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

    //is called when other script calls this script

public class HackableObject : MonoBehaviour
{
    public ElevatorMovement elevatorMovement;


    public void FindTargetToHack()
    {
        if (gameObject.tag == "ElevatorGround")
            {
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
        else if(gameObject.tag == "CircularClaw")
            {
              //   CircularClaw?.HackBehaviour();
            }
    }
}