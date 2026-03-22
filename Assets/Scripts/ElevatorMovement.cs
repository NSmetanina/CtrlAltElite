using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{

    //is called when other script calls this script
  /*
    [SerializeField] float elevator; 
    [SerializeField] float StopPointUp;
    [SerializeField] float StopPointBottom;
    [SerializeField] private float YSpeed;
    Vector3 elevator = new Vector3;
    
    void Start
        {
            direction = new Vector3(0, YSpeed, 0);
        }

    void OnEnable() //call readInput every frame
            {
                
                if (elevator == transform(0, StopPointBottom, 0))
                    {
                        
                    }

                if (elevator == transform(0, StopPointUp, 0))
                    {
                        GoDown
                    }

            }

    void FixedUpdate()
        {
            if(gameObject.transform.position.y <= EndPoint) 
            {
                StartCoroutine(EndOfComic());
            }
            else
            {
                Movement();
            }
        }
    void Movement()     //change position based on direction from read input * set movement speed * fixed Deltatime ( so movement is consistent )
        {
            transform.position -= direction * Time.deltaTime; // move based on direction
        }
    */
}

