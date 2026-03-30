using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

public class TriggerToHack : MonoBehaviour
{
    public HackableObject hackableObject;

    [SerializeField] private float waitTime;
    //public Script hackAction;

    bool hackable = false;
    bool hasBeenHacked = false;
   // GameObject hackRange;
    
    public void OnTriggerEnter(Collider collision) 
    {
        hackable = true;
        collision.transform.SetParent(transform);
    }
     public void OnTriggerExit(Collider collision) 
    {
        hackable = false;
        collision.transform.SetParent(null);
    }

    void Update()
    {
        if (hackable)
        {
        
            Debug.Log("in range!");

            if (Input.GetKeyDown("e"))    //if you try to hack it and it can be hacked
            {
                // StartCoroutine(WaitforXSeconds());
                if (hasBeenHacked == false)
                {
                    hasBeenHacked = true;
                    Debug.Log("Run Minigame"); 
                    Debug.Log("call script on object that is getting hacked");
                    hackableObject.HackBehaviour();
                }
                else
                {
                    Debug.Log("call script on object that is getting hacked");
                    hackableObject.HackBehaviour();
                }

            }
        }
        

        
    }
}

