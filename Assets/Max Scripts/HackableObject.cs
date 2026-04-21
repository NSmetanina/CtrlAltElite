using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

    //is called when other script calls this script

public class HackableObject : MonoBehaviour
{   

    int counter;
    public ElevatorMovement elevatorMovement;
    [SerializeField] private float WaitTime; 
    public Animator elevator;
    bool isBlocked = false;

    void Awake()
        {
            counter = 0;
        }

        

    public void HackBehaviour()
    {
        if (gameObject.tag == "ElevatorGround" && isBlocked == false) 
            {
                isBlocked = true;
                //Debug.Log("Function is called, isBlocked is true, I'm " + gameObject.name); 
                 
                if (counter % 2 == 0)
                {
                        //Debug.Log("Go Up"); 
                    elevator.SetBool("UpTrigger", true);
                    elevator.ResetTrigger("DownTrigger");
                    counter = counter + 1;
                    StartCoroutine(WaitOneSecond());
                }
                else if (counter % 2 == 1)
                {
                        //Debug.Log("Go Down"); 
                    elevator.SetBool("DownTrigger", true);
                    elevator.ResetTrigger("UpTrigger");
                    counter = counter + 1;
                    StartCoroutine(WaitOneSecond());
                }
                else 
                Debug.Log("DIDNT WORK"); 
                return;
    
        }
    }
    
    IEnumerator WaitOneSecond()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);  //wait
        isBlocked = false;
    }
}