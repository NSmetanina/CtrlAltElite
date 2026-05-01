using UnityEngine;
using System.Collections; //for the Coroutine

public class WallClaw : MonoBehaviour
{
    // [SerializeField] private float WaitTime; 

    public Animator WallClawAnimator;
    public Animator centreClawAnim;

    public float WaitingTime;
    public float SecondWaitingTime;

    public GameObject assembledPartThree;
    public GameObject staticP3;
    
    public void HackBehaviour() // gets called from wallTriggerToHack
    {

        staticP3.SetActive(false);
        WallClawAnimator.SetTrigger("MoveP3");
        StartCoroutine(SecondPartClawAnim());
    }

     IEnumerator SecondPartClawAnim()    //enumerators can wait
    {

        yield return new WaitForSeconds(WaitingTime);//wait
        centreClawAnim.SetTrigger("P2PickUp");
        yield return new WaitForSeconds(SecondWaitingTime);//wait
        assembledPartThree.SetActive(true);
    }
}
