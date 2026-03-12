using System.Collections;
using System.Collections.Generic;
using UnityEngine;

        //This script was made from this tutorial "How To Make A Blob Shadow In Unity" on youtube https://youtu.be/ZGFdfrjyI5U?si=TDS05f06gSv4NBAS 

public class BlobShadow : MonoBehaviour     
{
    public GameObject shadow;
    public RaycastHit hit;
    public float offset;

    private void FixedUpdate()
    {
        Ray downRay = new Ray(new Vector3(this.transform.position.x, this.transform.position.y - offset, this.transform.position.z), -Vector3.up);

        //gets the hit from the raycast and converts it unto a vector3
        Vector3 hitPosition = hit.point;
        //transofrm the shadow to the location
        shadow.transform.position = hitPosition;

        //Cast a ray straight downwards, reads back where it lands (this is optional but reccomended)
        if(Physics.Raycast(downRay, out hit))
        {
            print(hit.transform);   
        }
    }
}

