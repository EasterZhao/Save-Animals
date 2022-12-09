using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=c2Ze4WRUgKY&t=2s
public class OpenKeypad : MonoBehaviour
{
    public GameObject keypadOB;
    public GameObject keypadText;

    public bool inReach;


    void Start()
    {
        inReach = false;
    }

    // Player enters the Keypad's trigger to display the word prompt and set the event to true
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            keypadText.SetActive(true);

        }
    }

    // Player Exits the Keypad's trigger to hide the word prompt and set the event to false
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            keypadText.SetActive(false);

        }
    }


    void Update()
    {
        // If the player presses E and is in the trigger, the keypad page opens
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            keypadOB.SetActive(true);
        }

    }
}