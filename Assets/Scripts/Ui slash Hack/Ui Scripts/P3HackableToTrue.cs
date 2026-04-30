using UnityEngine;

public class P3HackableToTrue : MonoBehaviour
{
   
   public GameObject AssembledPartThree;

    public CircularTriggerToHack circularTriggerToHack;

            public void OnTriggerEnter(Collider collision) 
                {
                    if(AssembledPartThree.activeSelf == false)
                    {
                        circularTriggerToHack.hackable = true;
                    }
                }
            
            public void OnTriggerExit(Collider collision) 
                {
                    if(AssembledPartThree.activeSelf == false)
                    {
                        circularTriggerToHack.hackable = false;
                    }
                }
}
