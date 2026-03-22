using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

public class TriggerToHack : MonoBehaviour
{


    [SerializeField] private float Range = 0.5f;
    [SerializeField] private float WaitTime;
    [SerializeField] private GameObject player;
    public HackableObject hackableObject;

    bool Hackable = true;
    bool HasBeenHacked = false;
    float ObjectX;
    float ObjectZ;
    float PlayerX;
    float PlayerZ;

    void Update()
    {
         ObjectX = transform.position.x;    //get stuff for range calculation
         ObjectZ = transform.position.z;
         PlayerX = player.transform.position.x;
         PlayerZ = player.transform.position.z;

         Vector2 PlayerPos = new Vector2(PlayerX, PlayerZ); //calculate range
         Vector2 ObjectPos = new Vector2(ObjectX, ObjectZ);
    
        if (Vector2.Distance(PlayerPos, ObjectPos) < Range) // if player is is range make it hackable
            {
                Hackable = true;       
                //display the e popup
               // Debug.Log("in range!");
            }
        else    // if player isnt in range with the interactable make it unhackable
            {
                Hackable = false;
            }

        if ((Input.GetKeyDown("e")) && Hackable == true)    //if you try to hack it and it can be hacked
            {
                StartCoroutine(WaitforXSeconds());                
            }
    }

        IEnumerator WaitforXSeconds()    //enumerators can wait
        {
            yield return new WaitForSeconds(WaitTime);  //wait x seconds (right now 3)

            if (Input.GetKeyUp("e") == true)  // if you ever took key off right now broke
            {
                yield break; // just a return for coroutines
            }
            else if (HasBeenHacked == false)
                {
                    HasBeenHacked = true;
                    Debug.Log("Run Minigame"); 
                    Debug.Log("call script on object that is getting hacked");
                            hackableObject.FunctionToCall();
                }
            else 
                {
                    Debug.Log("call script on object that is getting hacked");
                    hackableObject.FunctionToCall();
                }
        }

}
