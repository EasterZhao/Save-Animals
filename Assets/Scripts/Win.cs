using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject WinNote;
    public bool inReach;
    
    void Update()
    {
        //Detects if the inReach event is true and presses E
        if ( inReach && Input.GetKeyDown(KeyCode.E))
        {
            //
             SceneManager.LoadScene("03Exit", LoadSceneMode.Single);
        }
    }
     
        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" )
        {
            WinNote.SetActive(true);
            inReach = true;
        }
    }

            void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach" )
        {
            WinNote.SetActive(false);
            inReach = false;
        }
    }
}
