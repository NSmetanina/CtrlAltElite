using UnityEngine;

public class UiPartCollection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    public BombPartCollectorScript bombPartCollectorScript;

    public GameObject UIBombPart1;
    public GameObject UIBombPart2;
    public GameObject UIBombPart3;
    public GameObject UIBombPart4;

    void Update()
    {
        if (bombPartCollectorScript.BombPart1PreSetUp.activeInHierarchy)
        {   //partCollection.BombPart1PreSetUp.activeInHierarchy
            UIBombPart1.SetActive(true);
        }
        if (bombPartCollectorScript.BombPart2PreSetUp.activeInHierarchy)
        {
            UIBombPart2.SetActive(true);
        }
        if (bombPartCollectorScript.BombPart3PreSetUp.activeInHierarchy)
        {
            UIBombPart3.SetActive(true);
        }
        if (bombPartCollectorScript.BombPart4PreSetUp.activeInHierarchy)
        {
            UIBombPart4.SetActive(true);
        }
    }
}
