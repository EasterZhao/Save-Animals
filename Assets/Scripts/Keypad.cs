using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//https://www.youtube.com/watch?v=c2Ze4WRUgKY&t=2s
public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;
    public GameObject hud;
    public GameObject inv;


    public GameObject animateOB;
    public Animator ANI;

    public GameObject keypadPanel;

    public TMP_Text textOB;
    private string answer = "24351";

    AudioSource audioSource;

    public AudioClip right;

    public AudioClip wrong;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Number(int number)
    {
        // Enter a number then returns a number as a string.
        textOB.text += number.ToString();
    }

    public void Execute()
    {
        // The value entered, the right is displayed right ,wrong is displayed wrong
        if (textOB.text == answer)
        {
            textOB.text = "Right";
            audioSource.PlayOneShot(right, 1F);

        }
        else
        {
            textOB.text = "Wrong";
            audioSource.PlayOneShot(wrong, 1F);
        }


    }

    // Empty the text border
    public void Clear()
    {
        {
            textOB.text = "";
        }
    }

    // Exit the Keypad Panel
    public void Exit()
    {
        keypadOB.SetActive(false);
        inv.SetActive(true);
        hud.SetActive(true);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
    IEnumerator EnableKeypadPanel()
    {
        yield return new WaitForSeconds(1f);
        Exit();
        Cursor.lockState = CursorLockMode.Locked;
    }


    public void Update()
    {
        if (keypadOB.activeInHierarchy)
        {
            hud.SetActive(false);
            inv.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
            if (textOB.text == "Right")
            {
                ANI.SetBool("animate", true);
                Debug.Log("its open");
                Time.timeScale = 1f;
                StartCoroutine(EnableKeypadPanel());
            }

        }

    }
}