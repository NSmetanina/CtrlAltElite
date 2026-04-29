using UnityEngine;

public class ShowAssemblePiece : MonoBehaviour
{
    public GameObject assemblePiece;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ShowPiece()
    {
        assemblePiece.SetActive(true);
    }
}
