using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public ScriptA theOtherScript;

    // Update is called once per frame
    void Update()
    {
        theOtherScript.FunctionToCall();
    }

}
