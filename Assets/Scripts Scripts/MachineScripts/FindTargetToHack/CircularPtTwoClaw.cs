using UnityEngine;
using System.Collections; //for the Coroutine

public class CircularPtTwoClaw : MonoBehaviour
{
    [SerializeField] private float WaitTime; 
    public Animator centreClawAnim;
    public Animator rotationAnim;
    public GameObject assemblePiece;
    
    public void HackPtTwoBehaviour()
    {
        
        rotationAnim.SetTrigger("CenterRotate");
        Debug.Log("Start waiting");
        StartCoroutine(WaitAnimationLength());
        StartCoroutine(WaitRotationAnimationLength());
        
    }

     IEnumerator WaitAnimationLength()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);//wait
        Debug.Log("set active");
        assemblePiece.SetActive(true);  //set the assemble part active
        centreClawAnim.SetTrigger("P2PickUp");
        //Start Camera Pan
    }
    IEnumerator WaitRotationAnimationLength()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);//wait
        Debug.Log("set active");
        //End Camera Pan
    }
}
