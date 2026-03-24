using UnityEngine;
using UnityEngine.SceneManagement;


public class NewSceneLoader : MonoBehaviour
{
    public Collider Cube;

    private void OnTriggerEnter(Collider Cube)  // when an object touches the object with the script
        {
            // if (collisionVariable.gameObject.tag.Contains("Ground"))
            // {
             SceneManager.LoadScene("Main_Scene_Blockout", LoadSceneMode.Single);   //load the new scene
            // }
        }
}
