using UnityEngine;

public class ShowAssemblePiece : MonoBehaviour
{
    public GameObject assemblePiece;

    public void ShowPiece()
    {
        assemblePiece.SetActive(true);
    }
}
