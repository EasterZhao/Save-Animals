using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeline : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable() 
    {
    SceneManager.LoadScene("02Main",LoadSceneMode.Single);
    }
    //hou mian quxiao
}
