using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // wasd movement system

    //variable list 
    public float speed;

    // float YSpeed; these are called later
    // float XSpeed;
    public Vector3 direction; // to take values in and put the in a vector 3 controlling direction

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
        transform.position += direction * speed * Time.deltaTime;
    }

    void ReadInput()
    {
        float XSpeed = Input.GetAxisRaw("Horizontal");  // Input.GetAxisRaw("Horizontal"); & Input.GetAxisRaw("Vertical"); are methods by unity that already mean wasd and arrow keys for movement
        float YSpeed = Input.GetAxisRaw("Vertical");    // this is getting and calling x and y speed here
        direction = new Vector3(XSpeed, 0, YSpeed);     // this vector 3 represents ( x, y, z ) with Xspeed and Yspeed in their represtitive axis controlling movement where the player cant go up or down
        direction.Normalize();                          // this is used for when the player is moving diagonally and converts this movement into the  "normal" original speed rather than being faster going diagonally
    }
}
