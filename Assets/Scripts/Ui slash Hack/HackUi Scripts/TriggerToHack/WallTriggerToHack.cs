using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

public class WallTriggerToHack : MonoBehaviour
{
    public WallClaw wallClaw;

    public GameObject HackMenu;
    public GameObject InRangeUi4;

    public bool P3hackable = false; //hackable if in objects collider

    public bool P3hasBeenHacked; //If prev hacked one is made true
   

    void Start()
    {
        P3hasBeenHacked = false;
    }

        public void OnTriggerEnter(Collider collision) 
                    {
                        P3hackable = true;
                    }
            
        public void OnTriggerExit(Collider collision) 
            {               
                P3hackable = false;
            }

        void Update()
        {
            if (P3hackable)
            {
                
                if (Input.GetKeyDown("e"))    //if you try to hack it and it can be hacked
                {

                    if (P3hasBeenHacked == false)
                        {
                            // hasBeenHacked = true;
                            
                            Debug.Log("Run Minigame"); //also use this space to/for sprite directrion somehow
                            HackMenu.SetActive(true);
                            Debug.Log ("Hack Menu Activated");
                        }
                    else 
                        {
                            Debug.Log("WallClawRuns");
                            wallClaw.HackBehaviour();
                        }

                }
            }
            if(P3hackable == true)
                    {
                        InRangeUi4.SetActive(true);
                    }
                    else
                    {
                        InRangeUi4.SetActive(false);
                    }
            
    }
}



