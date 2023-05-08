
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject pauseButton;
    public GameObject StartMenuPanel;
    public GameObject inGamePanel;

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        main.ResumeGame();
        GameIsPaused = false;
    }
    
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        main.PauseGame();
        GameIsPaused = true;
    }
    public void Menu()
    {
        inGamePanel.SetActive(false);
        StartMenuPanel.SetActive(true);
        main.PauseGame();
    }

    public void Quit()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }
}
