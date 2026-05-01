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
    public GameObject P3ani;
    
    public void HackBehaviour() // gets called from wallTriggerToHack
    {

        staticP3.SetActive(false);
        WallClawAnimator.SetTrigger("MoveP3");
        StartCoroutine(SecondPartClawAnim());
    }

     IEnumerator SecondPartClawAnim()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitingTime);//wait
        P3ani.SetActive(false);
        centreClawAnim.SetBool("P3PickUp", true);//problem here
        Debug.Log("Goes righrt hhere");
        yield return new WaitForSeconds(SecondWaitingTime);//wait
        assembledPartThree.SetActive(true);
    }
}
