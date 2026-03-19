using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class QteClick : MonoBehaviour
{
   public Animator fadeAnimation;
   public Animator zAnimation;
   public float timer;


    void Update()
    {
        timer -= Time.deltaTime;
        if(Input.anyKeyDown && timer > 0)
        {
            
            if (Input.GetKey(KeyCode.Z))
            {             
                zAnimation.SetBool("IsClicked", true); 
                fadeAnimation.SetBool("StartQte", false);
                Debug.Log("QTE successed");
            }
            else
            {
                // qteSucessed = false;
                zAnimation.SetBool("failed", true);  
                fadeAnimation.SetBool("StartQte", false);
                Debug.Log("QTE failed(input)");
            }
        }
        if (timer <= 0)
        {
            timer = 0;
            zAnimation.SetBool("failed", true); 
            fadeAnimation.SetBool("StartQte", false);
            // fadeAnimation.D;
            Debug.Log("QTE failed");
        }
            

    }
    

    void OnEnable()
    {
        timer = 1.30f;
    }

}