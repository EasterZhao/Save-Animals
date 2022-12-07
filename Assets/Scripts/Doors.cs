using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class Doors : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    public bool inReach;
    void Start()
    {
        // Set inReach event to false
        inReach = false;
    }
    // Enter the Door's trigger to display the word prompt and set the event to true
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }
    // Exit the Door's trigger to hide the word prompt and set the event to false
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }

    void Update()
    {
        // Detects if the inReach event is true and presses E
        // Execute the DoorOpens method
        if (inReach && Input.GetKeyDown(KeyCode.E))
        {
            DoorOpens();
        }
        // Conditions not met,Execute the DoorCloses method
        else
        {
            DoorCloses();
        }

    }
    void DoorOpens ()
    {
        // Play the door Open animation
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        
         //play the door opened audio
        var audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void DoorCloses()
    {
        // Play the door Closed animation
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }

}
