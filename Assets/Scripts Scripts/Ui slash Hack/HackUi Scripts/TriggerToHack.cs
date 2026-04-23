using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections;

public class TriggerToHack : MonoBehaviour
{
    public HackableObject hackableObject;
    public GameObject HackMenu;

    [SerializeField] private float waitTime;

    bool hackable = false; //hackable if in objects collider
    bool hasBeenHacked = false; //If prev haced one is made true
    
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

                if (hasBeenHacked == false)
                    {
                        hasBeenHacked = true;
                        
                        Debug.Log("Run Minigame"); //also use this space to/for sprite directrion somehow
                        HackMenu.SetActive(true);
                        Debug.Log ("Hack Menu Activated");
                        
                        Debug.Log("call script on object that is getting hacked");
                        hackableObject.FindTargetToHack();
                    }
                else
                    {
                        Debug.Log("call script on object that is getting hacked");
                        hackableObject.FindTargetToHack();
                    }

            }
        }
        

        
    }
}

