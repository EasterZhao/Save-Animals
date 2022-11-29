using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
  public void QuitApplication()
  {
    Application.Quit();
    //Debug.Log("exit");
  }
  
  public void LoadScene(string scenename)
  {
    SceneManager.LoadScene(scenename,LoadSceneMode.Single);
  }
}