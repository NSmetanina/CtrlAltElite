using UnityEngine;
using UnityEngine.UI;
public class SpriteDirectionController : MonoBehaviour
{
    //On player input change to the correct sprite

    KeyCode activeKey = KeyCode.None;
    KeyCode lastActiveKey = KeyCode.None;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite StickmanSpriteSheet_Foward; //so I can put the right sprites in the variables
    [SerializeField] Sprite StickmanSpriteSheet_Right;
    [SerializeField] Sprite StickmanSpriteSheet_Left;
    [SerializeField] Sprite StickmanSpriteSheet_Back;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()   // Update the game on character sprite turns
    {
        if (activeKey == KeyCode.None)
        {
            GetInitialKeyCode();
        }//used if you start moving

        if (activeKey != KeyCode.None && Input.GetKeyUp(activeKey))
        {
            GetNewKeyCode();
        } //used because keycode has just changed

        if (activeKey != KeyCode.None && lastActiveKey == activeKey)    
        {
            UpdateSprite();
        }//used to change sprite

        lastActiveKey = activeKey;
    }

    void GetInitialKeyCode()
    {
        if ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            activeKey = KeyCode.W;
        }   //Set active key to up
        else if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            activeKey = KeyCode.A;
        }   //Set active key to left
        else if ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            activeKey = KeyCode.S;
        }   //Set active key to down
        else if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            activeKey = KeyCode.D;
        }   //Set active key to right
    }

    void GetNewKeyCode()
    {
        if ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.UpArrow))) 
        {
            activeKey = KeyCode.W;
        }   //Set active key to up
        else if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            activeKey = KeyCode.A;
        }   //Set active key to left
        else if ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            activeKey = KeyCode.S;
        }   //Set active key to down
        else if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            activeKey = KeyCode.D;
        }   //Set active key to right
        else 
        {
            activeKey = KeyCode.None;
        }
    }   //used because keycode has just changed // uses get key "down" not just get key.

    void UpdateSprite()     //Update Sprite is called if the sprite is to change
    {
        if ((activeKey == KeyCode.W) || (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            spriteRenderer.sprite = StickmanSpriteSheet_Back;
        }
        else if ((activeKey == KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow))) //had to swap left and right because of the isometric camera changing the players view
        {
            spriteRenderer.sprite = StickmanSpriteSheet_Right;      
        }
        else if ((activeKey == KeyCode.S) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            spriteRenderer.sprite = StickmanSpriteSheet_Foward;
        }
        else if ((activeKey == KeyCode.D) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            spriteRenderer.sprite = StickmanSpriteSheet_Left;
        }
    }
}