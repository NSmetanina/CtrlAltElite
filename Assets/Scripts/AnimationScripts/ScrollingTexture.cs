using UnityEngine;

public class ScrollingTexture : MonoBehaviour
{
    public float ScrollSpeedX;
    public float ScrollSpeedY;
    public float StepSize;
    private MeshRenderer meshRenderer;   

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float offsetX = Mathf.Floor(Time.time * ScrollSpeedX) * StepSize;
        float offsetY = Mathf.Floor(Time.time * ScrollSpeedY) * StepSize;
        meshRenderer.material.mainTextureOffset = new Vector2(offsetX, offsetY  );
    }
}
