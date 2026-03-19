using UnityEngine;

public class HackTrigger : MonoBehaviour
{
    void Update()
    {
        PressKeyToSetActive();

    }
    public GameObject HackMenu;
    public Animator QteStartAnimator;
    public void PressKeyToSetActive()
    {
        if (Input.GetKey(KeyCode.E))
        {
            HackMenu.SetActive(true);
            QteStartAnimator.SetBool("StartQte", true);
            Debug.Log ("Hack Menu Activated");
        }

    }
}
