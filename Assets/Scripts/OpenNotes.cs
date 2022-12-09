using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://www.youtube.com/watch?v=JIuaBUsmRfs
public class OpenNotes : MonoBehaviour
{
    [SerializeField]
    private GameObject Panel;

    public GameObject MessagePanel;
    public bool Action;
    void Start()
    {
        Action = false;
    }

    public void Update()
    {
        // If the player presses E and is in the trigger, the note page opens
        if (Input.GetKeyDown(KeyCode.E))
        {

            if (Action == true)
            {
                MessagePanel.SetActive(false);
                Panel.SetActive(true);
                Action = false;
            }
        }


    }
    // Player enters the Note's trigger to display the word prompt and set the event to true
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            MessagePanel.SetActive(true);
            Action = true;
        }
    }
    // Exit the Note's trigger to hide the word prompt and set the event to false
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            MessagePanel.SetActive(false);
            Action = false;
            Panel.SetActive(false);
        }
    }


}
