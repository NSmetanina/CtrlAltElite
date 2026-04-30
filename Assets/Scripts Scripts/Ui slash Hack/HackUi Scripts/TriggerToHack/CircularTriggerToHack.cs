using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

public class CircularTriggerToHack : MonoBehaviour
{
    // public HackableObject hackableObject;
    public BombPartCollectorScript bombPartCollectorScript;
    public GameObject HackMenu;
    public HackableObject hackableObject;
    public CircularClaw circularClaw;
    public CircularPtTwoClaw circularPtTwoClaw;
    public Transform playersTransform;
    public GameObject AssemblePOne;
    public bool SecondParentActivate;
    public int WaitTime;

    public bool hackable = false; //hackable if in objects collider

    public bool hasThisBeenHacked; //If prev hacked one is made true
   

    void Start()
    {
        hasThisBeenHacked = false;
    }
    
    public void OnTriggerEnter(Collider collision) 
    {
            if(AssemblePOne.activeSelf == false || SecondParentActivate == true)
            {
                Debug.Log("In TriggerBox");
                hackable = true;
                collision.transform.SetParent(transform);
            }
        }
        public void OnTriggerExit(Collider collision) 
        {
            hackable = false;
            collision.transform.SetParent(null);
            if (AssemblePOne.activeSelf == false)
                {
                StartCoroutine(ActivateSecondThing());
                }
        }

        void Update()
        {
            if (hackable)
            {

                if (Input.GetKeyDown("e"))    //if you try to hack it and it can be hacked
                {

                    if (hasThisBeenHacked == false)
                        {
                            // hasBeenHacked = true;
                            
                            Debug.Log("Run Minigame"); //also use this space to/for sprite directrion somehow
                            HackMenu.SetActive(true);
                            Debug.Log ("Hack Menu Activated");
                        }
                    else 
                        {
                            Debug.Log("CircularClawRuns");
                            if (AssemblePOne.activeSelf == false)
                            {
                                circularClaw.HackBehaviour();
                                hackable = false;
                            }
                            else
                            {
                                circularPtTwoClaw.HackPtTwoBehaviour();
                            }
                            playersTransform.transform.SetParent(null);
                        }

                }
            }
            
    }
    IEnumerator ActivateSecondThing()    //enumerators can wait
        {
            yield return new WaitForSeconds(WaitTime);//wait
            SecondParentActivate = true;
            
        }
}

