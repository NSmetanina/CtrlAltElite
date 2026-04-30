using UnityEngine;
using System.Collections.Generic;

public class PartCollection : MonoBehaviour
{
    public GameObject BombPart1PreSetUp;
    public GameObject BombPart2PreSetUp;
    public GameObject BombPart3PreSetUp;
    public GameObject BombPart4PreSetUp;
    
    public GameObject InitialBombPart;
    public GameObject InitialBombPart2;
    public GameObject InitialBombPart3;
    public GameObject InitialBombPart4;
    public enum Bomb
    {
        CollectedPart, 
        NotCollected
    }

    public enum BombCollection
        {
            BombPart1,
            BombPart2,
            BombPart3,
            BombPart4
        }

            public BombCollection BombPart1 = (BombCollection)Bomb.NotCollected;
            public BombCollection BombPart2 = (BombCollection)Bomb.NotCollected;
            public BombCollection BombPart3 = (BombCollection)Bomb.NotCollected;
            public BombCollection BombPart4 = (BombCollection)Bomb.NotCollected;

        void Update()
        {
            if (BombPart1 == (BombCollection)Bomb.CollectedPart) //player gets BombPart1
            {
                BombPart1PreSetUp.SetActive(true); // need the actual asset names
                InitialBombPart.SetActive(false);
            }
            else if (BombPart2 == (BombCollection)Bomb.CollectedPart)
            {
                BombPart2PreSetUp.SetActive(true);
                InitialBombPart2.SetActive(true);
            }
            else if(BombPart3 == (BombCollection)Bomb.CollectedPart)
            {
                BombPart3PreSetUp.SetActive(true);
                InitialBombPart3.SetActive(true);
            }
            else if(BombPart4 == (BombCollection)Bomb.CollectedPart)
            {
                BombPart4PreSetUp.SetActive(true);
                InitialBombPart4.SetActive(true);
            }
        }

}
