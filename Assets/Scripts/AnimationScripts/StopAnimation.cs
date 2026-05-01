using UnityEngine;

public class ClickStop : MonoBehaviour
{
     public Animator thisAnimator;

    void Start()
    {
        thisAnimator = gameObject.GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        thisAnimator.enabled = false;
    }
}
