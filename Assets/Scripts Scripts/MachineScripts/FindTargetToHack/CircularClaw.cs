using UnityEngine;
using System.Collections; //for the Coroutine

public class CircularClaw : MonoBehaviour
{
    [SerializeField] private float WaitTime; 
    public Animator centreClawAnim;
    
    public void HackBehaviour()
    {
        centreClawAnim.SetTrigger("WakeUp");
        StartCoroutine(WaitAnimationLength());
    }

     IEnumerator WaitAnimationLength()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);  //wait
    }
}
