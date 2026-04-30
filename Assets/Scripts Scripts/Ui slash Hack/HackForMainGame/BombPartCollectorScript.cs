using UnityEngine;

public class BombPartCollectorScript : MonoBehaviour
{

    public GameObject BombPart1PreSetUp;
    public GameObject BombPart2PreSetUp;
    public GameObject BombPart3PreSetUp;
    public GameObject BombPart4PreSetUp;

    public GameObject UIBombPart1;
    public GameObject UIBombPart2;
    public GameObject UIBombPart3;
    public GameObject UIBombPart4;

    void Update()
        {
            if (BombPart1PreSetUp.activeSelf == true) //player gets BombPart1
            {
                UIBombPart1.SetActive(true);
            }
            else if (BombPart2PreSetUp.activeSelf == true)
            {
                UIBombPart2.SetActive(true);
            }
            else if(BombPart3PreSetUp.activeSelf == true)
            {
                UIBombPart3.SetActive(true);
            }
            else if(BombPart4PreSetUp.activeSelf == true)
            {
                UIBombPart4.SetActive(true);
            }
        }

}
