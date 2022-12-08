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
        // Detects if the inReach event is true and presses E
        if (inReach && Input.GetKeyDown(KeyCode.E))
        {
            //play the button audio
            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            StartCoroutine(NextScene());
        }
    }
    // Enter the RedButton's trigger to display the word prompt and set the event to true
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            WinNote.SetActive(true);
            inReach = true;
        }
    }
    // Exit the RedButton's trigger to hide the word prompt and set the event to false
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            WinNote.SetActive(false);
            inReach = false;
        }
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(1f);
        //Switching scenes to 03Exit
        SceneManager.LoadScene("03Exit", LoadSceneMode.Single);
    }
}
