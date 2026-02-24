using UnityEngine;

public class ClickStop : MonoBehaviour
{
     public Animator thisAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {

        thisAnimator.enabled = false;
    }
}
