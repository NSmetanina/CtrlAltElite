using UnityEngine;
using System.Collections; //for the Coroutine

public class CircularPtTwoClaw : MonoBehaviour
{
    [SerializeField] private float WaitTime; 
    [SerializeField] private float WaitForSecondPartAnimation; 
    [SerializeField] private float WaitInBetweenRotationAndP2PickUp; 
    public Animator centreClawAnim;
    public Animator rotationAnim;
    // public GameObject assemblePiece;
    public GameObject originalP2;
    public GameObject assemblePiece2;
    public GameObject BoxColider;
    public CircularTriggerToHack circularTriggerToHack;

    public void HackPtTwoBehaviour()
    {
        
        rotationAnim.SetTrigger("CenterRotate");
        circularTriggerToHack.hackable = false;
        BoxColider.SetActive(false);
        Debug.Log("Start waiting");
        StartCoroutine(WaitAnimationLength());
        StartCoroutine(WaitRotationAnimationLength());
        
    }

     IEnumerator WaitAnimationLength()    //enumerators can wait
    {
        Debug.Log("set p2  active");
        yield return new WaitForSeconds(WaitInBetweenRotationAndP2PickUp);//wait
        // assemblePiece.SetActive(true);  //set the assemble part active
        centreClawAnim.SetTrigger("P2PickUp");
        originalP2.SetActive(false);
        yield return new WaitForSeconds(WaitForSecondPartAnimation);//wait
        assemblePiece2.SetActive(true);
        
                //Start Camera Pan
    }

    IEnumerator WaitRotationAnimationLength()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);//wait
        Debug.Log("set active");
        //End Camera Pan
    }
}
