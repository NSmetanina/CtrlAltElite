using UnityEngine;
using System.Collections;

public class QteArrayImage : MonoBehaviour
{
    public Animator fanAnimator;
    public float timer = 5f; //The time limitation for the QTE
    public UnityEngine.UI.Image[] texts; //This is a text array so that you can put the QTE letters in the correct order in the inspector
    private int currentIndex = 0; //The index that will be use for running through the QTE array
    public Animator timeAnimator;
    private KeyCode[]qteSequence = {KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V}; //The QTE array that also has the sequence of the QTE
    public TriggerToHack triggerToHack;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // foreach (UnityEngine.UI.Image t in texts) //Changes every text variable in the text array to black
        // t.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; //Starting the count down
    
            if (Input.GetKeyDown(qteSequence[currentIndex])) //When the input of the player matches with the sequence of the QTE array
            {
                texts[currentIndex].color = Color.green; //Change colour of the text that the player is inputting for
                currentIndex++; //Add one to the currentIndex so it goes to the next one in the array
                Debug.Log("at index" + currentIndex);

                if (currentIndex > 3) //When the player has gone through all of the letters in the QTE array
                {
                    currentIndex = 3;
                    texts[currentIndex].color = Color.green;
                    timeAnimator.SetBool("Pause", true); //Pauses the time bar animation

                    Debug.Log("QTE Succededsed");
                    triggerToHack.hasBeenHacked = true;
                    gameObject.SetActive(false);
                    fanAnimator.SetBool("StopFan", true);

                }
            }
            else if(Input.anyKeyDown) //When the player enters any letter that is not required
                {
                    texts[currentIndex].color = Color.red;
                    timeAnimator.SetBool("Pause", true);


                    Debug.Log("QTE failed");
                    gameObject.SetActive(false);
                    fanAnimator.SetBool("StopFan", false);

                Debug.Log("QTE failed");
                gameObject.SetActive(false);
                timer = 5f;


                    return;
                }
            else if (timer <= 0) //When the timer hits 0
            {

                foreach (UnityEngine.UI.Image t in texts)
                t.color = Color.red;

                Debug.Log("QTE failed");
                gameObject.SetActive(false);
                fanAnimator.SetBool("StopFan", false);


                foreach (UnityEngine.UI.Image t in texts)
                if (t.color != Color.green)
                {
                    t.color = Color.red;
                }

                Debug.Log("QTE failed");
                gameObject.SetActive(false);
                timer = 5f;


                return;
            }
    }

}

