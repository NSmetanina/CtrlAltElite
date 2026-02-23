using UnityEngine;

public class ScrollingTexture : MonoBehaviour
{
    public float ScrollSpeedX;
    public float ScrollSpeedY;
    public float StepSize;
    private MeshRenderer meshRenderer;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Mathf.Floor(Time.time * ScrollSpeedX) * StepSize;
        float offsetY = Mathf.Floor(Time.time * ScrollSpeedY) * StepSize;
        meshRenderer.material.mainTextureOffset = new Vector2(offsetX, offsetY  );
    }
}
