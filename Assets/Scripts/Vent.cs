using UnityEngine;

public class Vent : MonoBehaviour
{
    public Animator ventAnimator; //the animator name is NewPivot

    public GameObject UiBombPart1;
    public GameObject UiBombPart2;
    public GameObject UiBombPart3;
    public GameObject UiBombPart4;

    // Update is called once per frame
    void Update()
    {
        if(UiBombPart1.activeSelf == true && UiBombPart2.activeSelf == true && UiBombPart3.activeSelf == true && UiBombPart4.activeSelf == true)
        {
            ventAnimator.SetTrigger("OpenVent");
        }
    }
}
