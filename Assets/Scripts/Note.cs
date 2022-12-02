using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject NotePanel;
    public GameObject NoteOB;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(NoteOB.activeInHierarchy)
        {
            NotePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
         else
        {
            Time.timeScale = 1f; 
        }
    }

        public void Exit()
    {
        NotePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
