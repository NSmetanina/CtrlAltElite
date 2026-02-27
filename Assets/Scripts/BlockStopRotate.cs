using UnityEngine;

public class BlockStopRotate : MonoBehaviour
{
    public RotateClaw rotationScript; //Reference to the RotateClaw script
    private bool blocked = false; //Flag to indicate if rotation is blocked
    private float stopAngle; //Variable to store the angle at which rotation should stop

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) //Check for left or right arrow key pressed
        {
            blocked = false; 
        }

        if (blocked)
        {
            rotationScript.targetYRotation = stopAngle; //Set the target rotation to the stop angle
            rotationScript.center.transform.rotation = Quaternion.Euler(0, stopAngle, 0); //Set the rotation of the center object to the stop angle
        }
    }

    private void OnTriggerEnter(Collider other) //Check for collision with the block
    {
        
        if (other.CompareTag("Block")) //Check if the collided object has the tag "Block"
        {
            blocked = true;
            stopAngle = rotationScript.currentYRotation; //Store the current rotation angle as the stop angle
            Debug.Log("You hit the block!");
        }
    }

}
