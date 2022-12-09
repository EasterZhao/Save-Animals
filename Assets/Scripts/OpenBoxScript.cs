using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=KEWihN-qm1M&t=49s
public class OpenBoxScript : MonoBehaviour
{
    public Animator boxOB;
    public GameObject keyOBNeeded;
    public GameObject openText;
    public GameObject keyMissingText;


    public bool inReach;
    public bool isOpen;



    void Start()
    {
        inReach = false;
        openText.SetActive(false);
        keyMissingText.SetActive(false);
    }

    // Player enters the Box's trigger to display the word prompt and set the event to true
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);

        }
    }

    // Exit the Box's trigger to hide the word prompt and set the event to false
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
            keyMissingText.SetActive(false);
        }
    }


    void Update()
    {
        //  If the player has the key and presses E, open the box
        if (keyOBNeeded.activeInHierarchy == true && inReach && Input.GetKeyDown(KeyCode.E))
        {
            keyOBNeeded.SetActive(false);
            boxOB.SetBool("open", true);
            openText.SetActive(false);
            keyMissingText.SetActive(false);
            isOpen = true;
            //play the box opened audio
            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }

        //  If the player presses E and there is no key the word locked is displayed
        else if (keyOBNeeded.activeInHierarchy == false && inReach && Input.GetKeyDown(KeyCode.E))
        {
            openText.SetActive(false);
            keyMissingText.SetActive(true);
            //play the box locked audio
            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }

        // If the box opens the current code and the collision body of the box disappears
        if (isOpen)
        {
            boxOB.GetComponent<BoxCollider>().enabled = false;
            boxOB.GetComponent<OpenBoxScript>().enabled = false;
        }
    }
}