using UnityEngine;
using System.Collections; //for the Coroutine

public class CircularClaw : MonoBehaviour
{
    [SerializeField] private float WaitTime; 
    public Animator centreClawAnim;
    public GameObject assemblePiece;

    public GameObject CameraMain;
    public GameObject CameraCutawayP1;
    
    public void HackBehaviour()
    {
        centreClawAnim.SetTrigger("WakeUp");
        CameraCutawayP1.SetActive(true);
        CameraMain.SetActive(false);
        centreClawAnim.SetTrigger("P1PickUp");
        Debug.Log("Start waiting");
        StartCoroutine(WaitAnimationLength());

    }

     IEnumerator WaitAnimationLength()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);//wait
        Debug.Log("set active");
        assemblePiece.SetActive(true);  //set the assemble part active
        CameraMain.SetActive(true);
        CameraCutawayP1.SetActive(false);
    }
}
