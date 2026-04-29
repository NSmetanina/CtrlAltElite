using UnityEngine;
using System.Collections; //for the Coroutine

    //is called when other script calls this script
    //Based of tutorial video https://youtu.be/ly9mK0TGJJo?si=QwI64tHTRKeiEYR8 
public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] private float WaitTime; 
    public Animator elevator;
    int counter;
    bool isBlocked = false;

    void Awake()
        {
            counter = 0;
        }    
    
      public void HackBehaviour()
        {
            if (gameObject.tag == "ElevatorGround" && isBlocked == false) 
                {
                    isBlocked = true; //when moving the script is stoped
                    
                if (counter % 2 == 0)
                    {//Debug.Log("Go Up"); 
                        elevator.SetBool("UpTrigger", true);
                        elevator.ResetTrigger("DownTrigger");

                        counter = counter + 1;

                        StartCoroutine(WaitOneSecond());
                    }
                else if (counter % 2 == 1)
                    {//Debug.Log("Go Down");
 
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