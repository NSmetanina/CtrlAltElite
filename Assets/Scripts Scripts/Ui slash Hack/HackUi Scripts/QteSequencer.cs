using UnityEngine;
using System.Collections;
using TMPro;

public class QteSequencer : MonoBehaviour
{
    public ForLoopQte forLoopQte;
    public int[] SequencePart = new int[4];
    private int i;
    
    public KeyCode[] qteSequence = new KeyCode[4];

    public void Awake()
    {
        // FillArray();
        // SetQteActive();
    }
    public void SetQteActive()
        {
            transform.GetChild(16).gameObject.SetActive(true);

            for (i = 0; i <= 3; i++ )
            {
                        Debug.Log("SetActive 1 bit" + SequencePart[i]);
                        transform.GetChild(SequencePart[i] +(4*i)).gameObject.SetActive(true);

            }
        }

    public void FillArray()
        {
            for (i = 0; i <= 3; i++ )
            {
                SequencePart[i] = Random.Range(0, 4);
                Debug.Log("" + SequencePart[i]);

                if (SequencePart[i] == 0)
                    {
                        qteSequence[i] = KeyCode.Z;
                    }
                else if ((SequencePart[i] == 1))
                    {
                        qteSequence[i] = KeyCode.X;
                    }
                else if ((SequencePart[i] == 2))
                    {
                        qteSequence[i] = KeyCode.C;
                    }
                else if ((SequencePart[i] == 3))
                    {
                        qteSequence[i] = KeyCode.V;
                    }
            }
        }
}

