using UnityEngine;
using UnityEngine.SceneManagement;  //for  loading scenes
using System.Collections; //for the Coroutine

public class ComicScroller : MonoBehaviour
{

[SerializeField] private float YSpeed;    //serialized for tooling ie can be changed in the editor
[SerializeField] private float WaitTime; 
[SerializeField] private float EndPoint; // - 2.84
Vector3 direction; // to take values in and put the in a vector 3 controlling direction
//camera scroll


    void Update() //call readInput every frame
        {
            ReadInput();
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
    void ReadInput()
    {
        direction = new Vector3(0, YSpeed, 0);     // this vector 3 represents ( x, y, z ) with we will minus YSpeed by whatever value we make YSpeed
    }
    IEnumerator EndOfComic()    //enumerators can wait
    {
        yield return new WaitForSeconds(WaitTime);  //wait
        SceneManager.LoadScene("Main_Scene_Blockout", LoadSceneMode.Single); //load new scene
    }

}
