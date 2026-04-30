using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    //For simple UI interactions in the start menu

    public string sceneName;

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);//we will have a public field that we can use the name of a scene to load
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //this will load the next scene in the build index. 0 is always loaded first, the 1 and so on
    }

    public void QuitGameBtn()
    {
        Application.Quit();
        Debug.Log("Application has Quit. This will only quit when running Build");
    }

}
