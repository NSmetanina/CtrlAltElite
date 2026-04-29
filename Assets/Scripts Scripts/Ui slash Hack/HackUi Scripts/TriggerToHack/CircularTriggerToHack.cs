using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections;

public class CircularTriggerToHack : MonoBehaviour
{
    // public HackableObject hackableObject;
    public GameObject HackMenu;
    public HackableObject hackableObject;
    public CircularClaw circularClaw;
    public Transform playersTransform;
    public GameObject AssemblePOne;

    bool hackable = false; //hackable if in objects collider

    public bool hasBeenHacked = false; //If prev hacked one is made true
   

    
    
    public void OnTriggerEnter(Collider collision) 
    {
         if(AssemblePOne.activeSelf == false)
        {
            hackable = true;
            collision.transform.SetParent(transform);
        }
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

            if (Input.GetKeyDown("e"))    //if you try to hack it and it can be hacked
            {

                if (hasBeenHacked == false)
                    {
                        hasBeenHacked = true;
                        
                        Debug.Log("Run Minigame"); //also use this space to/for sprite directrion somehow
                        HackMenu.SetActive(true);
                        Debug.Log ("Hack Menu Activated");
                    }
                else 
                    {
                        Debug.Log("CircularClawRuns");
                        circularClaw.HackBehaviour();
                        playersTransform.transform.SetParent(null);
                    }

            }
        }
        

        
    }
}

