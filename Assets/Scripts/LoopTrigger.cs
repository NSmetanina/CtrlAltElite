using UnityEngine;

public class LoopTrigger : MonoBehaviour
{
    public Animator anim;
    public Collider endBlock;
   
    void Start()
    {
        anim = GetComponent<Animator>();
        endBlock = GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider endBlock)
    {
        
        if (endBlock.CompareTag("Respawn"))
        {
            anim.Play("ObjectMove", 0, 0f);
            Debug.Log("It is looping");
        }
    }

}
