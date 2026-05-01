using UnityEngine;
using System.Collections;
using TMPro;

public class Pt4QteArray : MonoBehaviour
{      
    public HookTriggerToHack hookTriggerToHack;

    public float timer = 5f; //The time limitation for the QTE
    private int currentIndex = 0; //The index that will be use for running through the QTE array
    public int i;

    [SerializeField] private TextMeshProUGUI[] texts; //This is a text array so that you can put the QTE letters in the correct order in the inspector

    public Animator timeAnimator;
    
    private KeyCode[]qteSequence = {KeyCode.F, KeyCode.V, KeyCode.Z, KeyCode.J}; //The QTE array that also has the sequence of the QTE


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (TextMeshProUGUI t in texts) //Changes every text variable in the text array to black
            t.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < 0f)
        {
            timer =5f;
        }
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
                    hookTriggerToHack.P4hasBeenHacked = true;
                    gameObject.SetActive(false);
                    return;
                }
            }
            else if(Input.anyKeyDown) //When the player enters any letter that is not required
                {
                    texts[currentIndex].color = Color.red;
                    timeAnimator.SetBool("Pause", true);


                    Debug.Log("QTE failed");
                    gameObject.SetActive(false);


                Debug.Log("QTE failed");
                gameObject.SetActive(false);
                timer = 5f;


                    return;
                }
            else if (timer <= 0) //When the timer hits 0
            {
                i = 0;
                    foreach (TextMeshProUGUI t in texts)
                    {
                        i++;
                        if( currentIndex < i)
                        {
                        t.color = Color.red;
                        }

                        if(currentIndex+1 == i)
                        {
                        t.color = Color.white;
                        }

                    }

                    Debug.Log("QTE failed");
                    gameObject.SetActive(false);
                    timer = 5f;
            }

         return;
        }
}





