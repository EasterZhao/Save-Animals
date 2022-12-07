using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=JIuaBUsmRfs
public class Note : MonoBehaviour
{
    public GameObject NotePanel;
    public GameObject NoteOB;
    void Update()
    {
        // 
        if (NoteOB.activeInHierarchy)
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
    // Exit the Note panel
    public void Exit()
    {
        NotePanel.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
