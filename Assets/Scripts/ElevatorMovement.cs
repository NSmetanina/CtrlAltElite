using UnityEngine;

    //is called when other script calls this script

public class ElevatorMovement : MonoBehaviour
{

    public float ElevatorYPosition;
    public float TopStopPoint; // put in in inspector
    public float BottomStopPoint;
    [SerializeField] float MovementSpeed;
    Vector3 direction;
    
    void Update()
        {
            ElevatorYPosition = transform.position.y;
        }

    void Start()
        {
            direction = new Vector3(0, MovementSpeed, 0);  
        }

    public void MoveDown()
        {
            while (ElevatorYPosition != BottomStopPoint)
            {
                transform.position -= direction * Time.deltaTime; 
            }
        }

    public void MoveUp()
        {
            while (ElevatorYPosition != TopStopPoint)
            {
                transform.position += direction * Time.deltaTime;
            } 
        }

}