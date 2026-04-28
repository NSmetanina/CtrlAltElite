using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // wasd movement system

            //variable list 
    public float speed;
    public bool IsGrounded;
    public float JumpPower;
    Vector3 direction;
    // float YSpeed; XSpeed are called later
    public Rigidbody rb;

        void OnCollisionStay(Collision collisionVariable) // need to put a variable here or this wont work
        {
        if (collisionVariable.gameObject.tag == ("ElevatorGround"))  //grounds have the ground tag only this way you can only jump the the thing you are coliding wiht has the ground tag
                {
                IsGrounded = true;
                }
        }
        void OnCollisionExit(Collision collisionVariable)
        {
            IsGrounded = false;
        }

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // used to get the Rigidbody (so the script can see this objects Rigidbody from now on)
    }

    void Update() //call readInput every frame
    {
        ReadInput();
    }
    void FixedUpdate() //move at a fixed interval default is every 0.02 secs
    {
        Movement();
    }

    void Movement()     //change position based on direction from read input * set movement speed * fixed Deltatime ( so movement is consistent )
    {
        transform.position += (direction*(-1)) * speed * Time.deltaTime; // Direction is minus 1 because of the camera
    }

    void Jump()
    {
            Debug.Log("spacebar is pressed and the position is " + transform.position); 
            rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }

    void ReadInput()
    {
        float XSpeed = Input.GetAxisRaw("Horizontal");  // Input.GetAxisRaw("Horizontal"); & Input.GetAxisRaw("Vertical"); are methods by unity that already mean wasd and arrow keys for movement
        float YSpeed = Input.GetAxisRaw("Vertical");    // this is getting and calling x and y speed here


        if((Input.GetKeyDown(KeyCode.Space)) && (IsGrounded == true))
        {
                Jump();
        }


        direction = new Vector3(XSpeed, 0f, YSpeed);     // this vector 3 represents ( x, y, z ) with Xspeed and Yspeed in their represtitive axis controlling movement where the player cant go up or down
        direction.Normalize();                          // this is used for when the player is moving diagonally and converts this movement into the  "normal" original speed rather than being faster going diagonally
    }
}

        