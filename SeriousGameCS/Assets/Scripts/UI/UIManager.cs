using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (panelTips.activeInHierarchy)
        {
            main.PauseGame();
        }
    }
    public GameObject panelWelcomePage;
    public GameObject panelInGame;
    public GameObject panelGameOver;
    public GameObject panelTips;

    public void LaunchLevel2()
    {
        main main = GameObject.FindObjectOfType<main>();
        if (main != null)
            main.LaunchGame(2);
    }

    public void GoToStateWelcome()
    {
        panelWelcomePage.SetActive(true);
        panelGameOver.SetActive(false);
        panelInGame.SetActive(false);
    }

    public void GoToStateInGame()
    {
        panelWelcomePage.SetActive(false);
        panelGameOver.SetActive(false);
        panelInGame.SetActive(true);
    }

    public void GoToStateGameOver()
    {
        panelWelcomePage.SetActive(false);
        panelGameOver.SetActive(true);
        panelInGame.SetActive(false);
    }

    public void openTipMenu()
    { 
        panelTips.SetActive(true);
        main.PauseGame();
    }
    public void closeTipMenu()
    {
        panelTips.SetActive(false);
        main.ResumeGame();
    }
}
