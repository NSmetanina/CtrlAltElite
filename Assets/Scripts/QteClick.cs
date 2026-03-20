using NUnit.Framework;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using TMPro;

public class QteClick : MonoBehaviour
{
    public GameObject guideObject;
   public Animator guideAnimation;
    public TextMeshProUGUI zText;
   private float timer = 1f;

   private bool isActive = false;

   void OnEnable()
    {
        isActive = true;
        zText.color = Color.black;
        guideAnimation.SetBool("StartQte", true);
    }

    void Update()
    {
        if(!isActive) 
        return;
        timer -= Time.deltaTime;
        
            
        if (Input.GetKey(KeyCode.Z))
        {             
            EndQTE(true);
        }
        else if(Input.anyKeyDown)
        {
            EndQTE(false);
        }
        
        else if (timer <= 0)
        {
            // EndQTE(false);
            // guideObject.SetActive(true);
            isActive = false;
            Debug.Log("QTE failed");
        }
    }

    void EndQTE(bool wasSuccessful)
    {
        isActive = false;
        
        if (wasSuccessful)
        {
            zText.color = Color.green;
            guideObject.SetActive(false);
            Debug.Log("QTE successed");
        }
        else
        {
            zText.color = Color.red;
            guideObject.SetActive(false);
            Debug.Log("QTE failed");
        }
        
    }

}
