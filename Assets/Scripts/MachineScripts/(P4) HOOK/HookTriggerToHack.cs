using UnityEngine;
using System.Collections;
using TMPro;

public class HookTriggerToHack : MonoBehaviour
{
    public HookClaw hookclaw;

    public GameObject HackMenu;

    public bool P4hackable = false; //hackable if in objects collider

    public bool P4hasBeenHacked; //If prev hacked one is made true
   

    void Start()
    {
        P4hasBeenHacked = false;
    }

        public void OnTriggerEnter(Collider collision) 
                    {
                        P4hackable = true;
                    }
            
        public void OnTriggerExit(Collider collision) 
            {               
                P4hackable = false;
            }

        void Update()
        {
            if (P4hackable)
            {
                
                if (Input.GetKeyDown("e"))    //if you try to hack it and it can be hacked
                {

                    if (P4hasBeenHacked == false)
                        {
                            // hasBeenHacked = true;
                            
                            Debug.Log("Run Minigame"); //also use this space to/for sprite directrion somehow
                            HackMenu.SetActive(true);
                            Debug.Log ("Hack Menu Activated");
                        }
                    else 
                        {
                            Debug.Log("WallClawRuns");
                            hookclaw.HookBehaviour();
                        }

                }
            }
            
    }
}



