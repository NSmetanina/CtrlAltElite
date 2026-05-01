using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{

    public GameObject UIMenu;
    //public bool pauseMenuActive;
    private bool isActive = false; //This variable is to prevent the code to repeat too many times

    public string sceneName;

    void Start()
    {
        isActive = true; //So that the program runs
        UIMenu.SetActive(false);
        //pauseMenuActive = false;
        
    }

    void Update()
    {
        if (!isActive) //If isActive becomes false, stop the program
            return;
        PressKeyToSetActive();
    }
    


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

    //public GameObject objectToToggle;
    //public void ActivateObjectBtn()
    //{
    //    objectToToggle.SetActive(true);
    //}

    public void PressKeyToSetActive()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            

            Debug.Log("You pressed q");
            if (isActive == true) 
            {
                UIMenu.SetActive(true);
                //pauseMenuActive = true;
                //if (Input.GetKey(KeyCode.Q))
                //{
                //    isActive = false;
                //    UIMenu.SetActive(false);
                //    Debug.Log("Disappeareddddddddddddddddddddddddddddddddddddddddddddddddd");
                //}
            }
            else
            {
                UIMenu.SetActive(false);
                //pauseMenuActive = false;
            }

        }
    }

    public void BackButtonPressed()
    {

        UIMenu.SetActive(false);
        Debug.Log("Back pressed");
    }
}
