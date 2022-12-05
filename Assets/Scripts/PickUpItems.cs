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


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            pickupText.SetActive(true);
        }
    }

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
        if(inReach && Input.GetKeyDown(KeyCode.E))
        {
            pickupOB.SetActive(false);
            activatingOB.SetActive(true);
            pickupText.SetActive(false);
        }
        
    }
}