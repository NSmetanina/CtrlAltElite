using UnityEngine;
using UnityEngine.UI;
public class FullSpriteDirectionController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private PlayerController playerController;  //so i can refrence playercontroller script
    private Animator animator;  //so i can set triggers

    KeyCode activeKey = KeyCode.None;
    KeyCode lastActiveKey = KeyCode.None;

    [SerializeField] Sprite SpritePrototype_Forward; //assigning standing sprites so I can put the right sprites in the variables
    [SerializeField] Sprite SpritePrototype_Right;
    [SerializeField] Sprite SpritePrototype_Left;
    [SerializeField] Sprite SpritePrototype_Back;

    [SerializeField] Sprite SpritePrototype_HackingForward; //assigning hacking sprites
    [SerializeField] Sprite SpritePrototype_HackingRight;
    [SerializeField] Sprite SpritePrototype_HackingLeft;
    [SerializeField] Sprite SpritePrototype_HackingBack;

    [SerializeField] Sprite SpritePrototype_WalkingFoward1; //assigning Walking foward sprites
    [SerializeField] Sprite SpritePrototype_WalkingFoward2;
    [SerializeField] Sprite SpritePrototype_WalkingFoward3;

    [SerializeField] Sprite SpritePrototype_WalkingRight1; //assigning Walking right sprites
    [SerializeField] Sprite SpritePrototype_WalkingRight2;
    [SerializeField] Sprite SpritePrototype_WalkingRight3;
    
    [SerializeField] Sprite SpritePrototype_WalkingLeft1; //assigning Walking left sprites
    [SerializeField] Sprite SpritePrototype_WalkingLeft2;
    [SerializeField] Sprite SpritePrototype_WalkingLeft3;

    [SerializeField] Sprite SpritePrototype_WalkingBack1; //assigning Walking back sprites
    [SerializeField] Sprite SpritePrototype_WalkingBack2;
    [SerializeField] Sprite SpritePrototype_WalkingBack3;
    
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();

    }

    void Update()   
    {
        lastActiveKey = activeKey;
        GetNewKeyCode(); // The player gets a new activeKey here or sets the activeKey to none
        UpdateSprite(); //using activeKey this will display the correct animation and disable others
                        //using lastActiveKey this will
    }

    void GetNewKeyCode()
    {
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow))) 
        {
            activeKey = KeyCode.W;
            //Debug.Log("Set active key to up");
        }   
        else if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            activeKey = KeyCode.A;
            //Debug.Log("Set active key to left");
        }   
        else if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            activeKey = KeyCode.S;
            //Debug.Log("Set active key to down");
        }   
        else if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            activeKey = KeyCode.D;
            //Debug.Log("Set active key to right");
        }   
        else 
        {
            activeKey = KeyCode.None;
            //Debug.Log("Not Moving");
        }
    }   //used because keycode has just changed

   void UpdateSprite()     //Update Sprite is called if the sprite is to change
    {
        //if (minigame is running){HackSprites();} //for hacking sprites i send to idle because there is no animation there so i can add sprites through sprite renderer

        animator.enabled = true; //since i am using animator always in this method i need to re-enable animator in case it was disabled
       
        if ((activeKey == KeyCode.W))
            {
                animator.SetBool("IsMovingLeft", false);        //disable moving otherways and disabling idle
                animator.SetBool("IsMovingRight", false); 
                animator.SetBool("IsMovingBack", false);
                animator.SetBool("Idle", false);                

                animator.SetBool("IsMovingForward", true);      //enable bool moving correct way ie if w then forward
            }
        else if ((activeKey == KeyCode.A))
            {
                animator.SetBool("IsMovingForward", false); 
                animator.SetBool("IsMovingRight", false); 
                animator.SetBool("IsMovingBack", false);
                animator.SetBool("Idle", false);

                animator.SetBool("IsMovingLeft", true);
            }
        else if ((activeKey == KeyCode.S))
            {
                animator.SetBool("IsMovingForward", false); 
                animator.SetBool("IsMovingLeft", false); 
                animator.SetBool("IsMovingRight", false);
                animator.SetBool("Idle", false);

                animator.SetBool("IsMovingBack", true);
            }
        else if ((activeKey == KeyCode.D))
            {
                animator.SetBool("IsMovingForward", false); 
                animator.SetBool("IsMovingLeft", false); 
                animator.SetBool("IsMovingBack", false);
                animator.SetBool("Idle", false);

                animator.SetBool("IsMovingRight", true);
            }
        else if (activeKey == KeyCode.None)
            {
                animator.SetBool("IsMovingForward", false); 
                animator.SetBool("IsMovingLeft", false); 
                animator.SetBool("IsMovingBack", false);
                animator.SetBool("IsMovingRight", false);
                
                animator.SetBool("Idle", true);
                if(false) //you are running the minigame
                {
                    HackSprites();
                }
                else
                {
                    SetIdleSprite();
                }
            }
    }


    void HackSprites() //fix soon
    {
                animator.SetBool("IsMovingForward", false); 
                animator.SetBool("IsMovingLeft", false); 
                animator.SetBool("IsMovingBack", false);
                animator.SetBool("IsMovingRight", false);
                
                animator.SetBool("Idle", true);
                //Debug.Log("Works");

    }   //used because you are now hacking

    void SetIdleSprite()
    {
        animator.enabled = false; //since i am setting sprites in sprite renderer manually i need animator to stop being in control of sprite renderer
        //Debug.Log("last active key is " + lastActiveKey);
        if(lastActiveKey == KeyCode.W)
        { 
            spriteRenderer.sprite = SpritePrototype_Forward;
            //Debug.Log("Idle Forward");
        }
        else if(lastActiveKey == KeyCode.A)
        { 
            spriteRenderer.sprite = SpritePrototype_Left;
            //Debug.Log("Idle Left");
        }
        else if(lastActiveKey == KeyCode.S)
        {
             spriteRenderer.sprite = SpritePrototype_Back;
             //Debug.Log("Idle Back");
        }
        else if(lastActiveKey == KeyCode.D)
        { 
            spriteRenderer.sprite = SpritePrototype_Right;
            //Debug.Log("Idle Right");
        }
        // else 
        // { Debug.Log("Didnt work");}
    }
}


