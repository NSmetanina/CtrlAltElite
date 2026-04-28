using UnityEngine;
using UnityEngine.Rendering;

public class RotateClaw : MonoBehaviour
{
    public GameObject center;
    public float smoothTime = 0.3f;
    public float targetYRotation; //Variable to store the target Y rotation angle
    public float currentYRotation; //Variable to store the current Y rotation angle
    private float velocity; //Variable to store the velocity of the rotation (used for SmoothDampAngle)

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //Check for left arrow key press
        {
            targetYRotation += 90f;
            Debug.Log ("Left Arrow is pressed");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) //Check for right arrow key press
        {
            targetYRotation -= 90f;
            Debug.Log ("Right Arrow is pressed");
        }
        //SmoothDampAngle is used to simulate the smooth rotation on a railing (built-in function in Unity)
        currentYRotation = Mathf.SmoothDampAngle(currentYRotation, targetYRotation, ref velocity, smoothTime); //(current angle, target angle, reference to velocity, time to smooth)

        //Set the rotation of the center object to a new Quaternion based on the current Y rotation
        center.transform.rotation = Quaternion.Euler(0, currentYRotation, 0); 
    }
    
}
