using UnityEngine;

public class LoopTrigger : MonoBehaviour
{
    public Animator anim;
    public AnimationClip animationClip;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Respawn"))
        {
            anim.Play(animationClip.name, 0, 0f);
            Debug.Log("It is looping");
        }
    }

}
