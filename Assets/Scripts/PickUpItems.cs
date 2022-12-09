using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=KEWihN-qm1M&t=49s
public class PickUpItems : MonoBehaviour
{
    public GameObject pickupOB;
    public GameObject activatingOB;

    public GameObject pickupText;

    public bool inReach;

    // Player enters the Key's trigger to display the word prompt and set the event to true
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            pickupText.SetActive(true);
        }
    }
    // Player Exits the Key's trigger to hide the word prompt and set the event to false
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            pickupText.SetActive(false);
        }
    }


    void Update()
    {
        // Player presses E to pick up the key
        if(inReach && Input.GetKeyDown(KeyCode.E))
        {
            pickupOB.SetActive(false);
            activatingOB.SetActive(true);
            pickupText.SetActive(false);
        }
        
    }
}