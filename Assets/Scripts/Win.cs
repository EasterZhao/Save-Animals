using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject WinNote;
    public bool inReach;
    public bool endAudio = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( inReach && Input.GetKeyDown(KeyCode.E))
        {
            WinPanel.SetActive(true);
            WinNote.SetActive(false);
            endAudio = true;
            Destroy(this);
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
}
