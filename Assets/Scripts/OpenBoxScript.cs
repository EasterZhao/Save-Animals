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


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);

        }
    }

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

        else if (keyOBNeeded.activeInHierarchy == false && inReach && Input.GetKeyDown(KeyCode.E))
        {
            openText.SetActive(false);
            keyMissingText.SetActive(true);
            //play the box locked audio
            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }

        if (isOpen)
        {
            boxOB.GetComponent<BoxCollider>().enabled = false;
            boxOB.GetComponent<OpenBoxScript>().enabled = false;
        }
    }
}