using UnityEngine;

public class HackTrigger : MonoBehaviour
{
    void Update()
    {
        PressKeyToSetActive();
        return;

    }
    public GameObject HackMenu;
    public void PressKeyToSetActive()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HackMenu.SetActive(true);
            Debug.Log ("Hack Menu Activated");
        }

    }
}
