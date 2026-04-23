using UnityEngine;

public class UiPartCollection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    public PartCollection partCollection;

    public GameObject UIBombPart1;
    public GameObject UIBombPart2;
    public GameObject UIBombPart3;
    public GameObject UIBombPart4;

    void Update()
    {
        if (partCollection.BombPart1PreSetUp.activeInHierarchy)
        {   //partCollection.BombPart1PreSetUp.activeInHierarchy
            UIBombPart1.SetActive(true);
        }
        if (partCollection.BombPart2PreSetUp.activeInHierarchy)
        {
            UIBombPart2.SetActive(true);
        }
        if (partCollection.BombPart3PreSetUp.activeInHierarchy)
        {
            UIBombPart3.SetActive(true);
        }
        if (partCollection.BombPart4PreSetUp.activeInHierarchy)
        {
            UIBombPart4.SetActive(true);
        }
    }
}
