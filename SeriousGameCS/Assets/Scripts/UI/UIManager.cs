using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (panelTips.activeInHierarchy)
        {
            main.PauseGame();
        }
    }
    private static UIManager instance;
    public GameObject panelWelcomePage;
    public GameObject panelInGame;
    public GameObject panelGameOver;
    public GameObject panelTips;

    public void LaunchLevel()
    {
        main main = GameObject.FindObjectOfType<main>();
        if (main != null)
            main.LaunchGame();
    }

    public static void GoToStateWelcome()
    {
        instance.panelWelcomePage.SetActive(true);
        instance.panelGameOver.SetActive(false);
        instance.panelInGame.SetActive(false);
        instance.panelTips.SetActive(false);
    }

    public static void GoToStateInGame()
    {
        instance.panelWelcomePage.SetActive(false);
        instance.panelGameOver.SetActive(false);
        instance.panelInGame.SetActive(true);
        instance.panelTips.SetActive(false);
        player.resetLivesUI();

    }

    public static void GoToStateGameOver()
    {
        instance.panelWelcomePage.SetActive(false);
        instance.panelGameOver.SetActive(true);
        instance.panelInGame.SetActive(false);
        instance.panelTips.SetActive(false);
        GameOverMenu.GameOverScore();
    }

    public static void openTipMenu()
    { 
        instance.panelTips.SetActive(true);
        main.PauseGame();
    }
    public static void closeTipMenu()
    {
        instance.panelTips.SetActive(false);
        main.ResumeGame();
    }
}
