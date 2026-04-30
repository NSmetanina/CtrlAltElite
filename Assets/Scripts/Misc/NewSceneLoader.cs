using UnityEngine;
using UnityEngine.SceneManagement;


public class NewSceneLoader : MonoBehaviour
{
    public Collider Cube;
    public string sceneName;

    private void OnTriggerEnter(Collider Cube)  // when an object touches the object with the script
        {
             SceneManager.LoadScene(sceneName, LoadSceneMode.Single);   //load the new scene
        }
}
