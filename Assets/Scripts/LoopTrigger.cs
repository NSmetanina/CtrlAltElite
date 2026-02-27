using UnityEngine;

public class LoopTrigger : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Respawn"))
        {
            anim.Play("ObjectMove", 0, 0f);
            Debug.Log("It is looping");
        }
    }

}
