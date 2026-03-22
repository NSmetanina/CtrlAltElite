using UnityEngine;

public class ScriptA : MonoBehaviour
{   
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void FunctionToCall()
    {
        Debug.Log("Function from ScriptA is called, I'm "+gameObject.name);
    }
}
