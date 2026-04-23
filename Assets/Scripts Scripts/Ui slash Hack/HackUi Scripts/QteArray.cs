using UnityEngine;
using System.Collections;
using TMPro;

public class ForLoopQte : MonoBehaviour
{
    public QteSequencer qteSequencer;
    public float timer = 5f; //The time limitation for the QTE
    private bool isActive = false; //This variable is to prevent the code to repeat too many times
    public TextMeshProUGUI[] texts; //This is a text array so that you can put the QTE letters in the correct order in the inspector
    private int currentIndex = 0; //The index that will be use for running through the QTE array
    public Animator timeAnimator;
    bool Running = false;
    
    void ResetArray()
    {
        qteSequencer.FillArray();
        if (Running = true)
        {
            qteSequencer.SetQteActive();
            isActive = true; //So that the program runs
        }
        foreach (TextMeshProUGUI t in texts) //Changes every text variable in the text array to black
        t.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive) //If isActive becomes false, stop the program
        {
            currentIndex = 0;
            Running = false;
            ResetArray();
            return;
        }
        Running = true;
    timer -= Time.deltaTime; //Starting the count down

            if (Input.GetKeyDown(qteSequencer.qteSequence[currentIndex])) //When the input of the player matches with the sequence of the QTE array
                {
                    texts[currentIndex].color = Color.green; //Change colour of the text that the player is inputting for
                    currentIndex++; //Add one to the currentIndex so it goes to the next one in the array
                    Debug.Log("at index" + currentIndex);

                    if (currentIndex > 3) //When the player has gone through all of the letters in the QTE array
                        {
                            isActive = false; //Stops the program
                            texts[currentIndex].color = Color.green;
                            timeAnimator.SetBool("Pause", true); //Pauses the time bar animation

                            Debug.Log("QTE Successed");
                            gameObject.SetActive(false);
                            
                        }
                }
            else if(Input.anyKeyDown) //When the player enters any letter that is not required
                {
                    isActive = false; 
                    texts[currentIndex].color = Color.red;
                    timeAnimator.SetBool("Pause", true);

                    Debug.Log("QTE failed");
                    gameObject.SetActive(false);


                    return;
                }
            else if (timer <= 0) //When the timer hits 0
            {
                foreach (TextMeshProUGUI t in texts)
                t.color = Color.red;
                isActive = false;

                Debug.Log("QTE failed");
                gameObject.SetActive(false);


                return;
            }
    }

}

