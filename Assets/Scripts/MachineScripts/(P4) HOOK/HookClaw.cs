using UnityEngine;
using System.Collections; //for the Coroutine
public class HookClaw : MonoBehaviour
{
    [SerializeField] private float Time; 

    public Animator HookAnimator;

    public GameObject CameraMain;
    public GameObject CameraCutawayP4;

    public GameObject assembledPartFour;
    //public GameObject P3ani;
    
    public void HookBehaviour() // gets called from wallTriggerToHack
    {
        HookAnimator.SetTrigger("P4ComeDown");
        CameraCutawayP4.SetActive(true);
        CameraMain.SetActive(false);
        StartCoroutine(P4Anim());
    }

     IEnumerator P4Anim()    //enumerators can wait
    {
        yield return new WaitForSeconds(Time);//wait
         //P3ani.SetActive(false);
         assembledPartFour.SetActive(true);
        CameraCutawayP4.SetActive(false);
        CameraMain.SetActive(true);
    }
}
