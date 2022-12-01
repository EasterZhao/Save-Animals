using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;
    public GameObject hud;
    public GameObject inv;


    public GameObject animateOB;
    public Animator ANI;


    public TMP_Text textOB;
    public string answer = "12345";

    public bool animate;


    void Start()
    {
  

    }
    


    public void Number(int number)
    {
        textOB.text += number.ToString();
    }

    public void Execute()
    {
        if (textOB.text == answer)
        {
            textOB.text = "Right";

        }
        else
        {
            textOB.text = "Wrong";
        }


    }

    public void Clear()
    {
        {
            textOB.text = "";
        }
    }

    public void Exit()
    {
        keypadOB.SetActive(false);
        inv.SetActive(true);
        hud.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Update()
    {
       // if (textOB.text == "Right" && animate)
        //{
            //ANI.SetBool("animate", true);
            //Debug.Log("its open");
        //}


        if(keypadOB.activeInHierarchy)
        {
            hud.SetActive(false);
            inv.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
           if (textOB.text == "Right" )
        {
            ANI.SetBool("animate", true);
            Debug.Log("its open");
            Time.timeScale = 1f;
        }

        }

    }
}