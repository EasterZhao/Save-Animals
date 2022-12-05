using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// https://www.youtube.com/watch?v=eC05j7rh_LM
public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;

    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();

            }
            else
            {
                PauseGame();

            }
        }

        if (isGamePaused && pauseMenu != null)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
            Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }


    //Cancel  pause game
    public void ResumeGame()
    {
        //Time unlocked 
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    //Pause game
    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("exit");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("00Start");
    }

}