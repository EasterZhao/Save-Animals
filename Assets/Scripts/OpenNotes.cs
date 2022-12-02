using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            MessagePanel.SetActive(true);
            Action = true;
        }
    }
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
