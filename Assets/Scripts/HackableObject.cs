using UnityEngine;

public class HackableObject : MonoBehaviour
{
    public void FunctionToCall()
    {
                if (gameObject.tag.Contains("Elevator"))
        {
            Debug.Log("Function from ScriptA is called, I'm "+gameObject.name);
        }

    }

}
