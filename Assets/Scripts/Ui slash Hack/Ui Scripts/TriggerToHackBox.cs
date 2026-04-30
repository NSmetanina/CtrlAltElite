using UnityEngine;

public class TriggerToHackBox : MonoBehaviour
{
    public GameObject AssembledPartTwo;

    public CircularTriggerToHack circularTriggerToHack;

            public void OnTriggerEnter(Collider collision) 
                {
                    if(AssembledPartTwo.activeSelf == false)
                    {
                    circularTriggerToHack.hackable = true;
                    }
                }
            
            public void OnTriggerExit(Collider collision) 
                {
                    if(AssembledPartTwo.activeSelf == false)
                    {
                    circularTriggerToHack.hackable = false;
                    }
                }
}
