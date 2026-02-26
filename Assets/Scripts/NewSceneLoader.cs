using UnityEngine;
using UnityEngine.SceneManagement;


public class NewSceneLoader : MonoBehaviour
{
    public Collider Cube;

    private void OnTriggerEnter(Collider Cube)
        {
             SceneManager.LoadScene("Main_Scene_Blockout", LoadSceneMode.Single);
        }
}
