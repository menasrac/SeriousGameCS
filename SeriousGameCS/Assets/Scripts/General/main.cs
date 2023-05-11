using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public ConveyorBelt conveyorBelt; // Une référence vers le script du tapis roulant
    private static ConveyorBelt conveyorBeltInstance;


    public enum STATE { WELCOME_PAGE, IN_GAME, GAME_OVER }

    public static STATE state;

    //public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        conveyorBeltInstance = conveyorBelt;
        Menu();
    }

    // Update is called once per frame
    void Update()
    {

        switch (state)
        {
            case STATE.WELCOME_PAGE:
                UpdateWelcome();
                break;
            case STATE.IN_GAME:
                UpdateInGame();
                break;
            case STATE.GAME_OVER:
                UpdateGameOver();
                break;
        }

    }
    //Ajouter des points au joueur

    public static void UpdateWelcome()
    {

    }

    public static void UpdateInGame()
    {

    }

    public static void UpdateGameOver()
    {
        
    }

    public static void Menu()
    {
        state = STATE.WELCOME_PAGE;
        PauseGame();
        UIManager.GoToStateWelcome();
    }

    public static void LaunchGame()
    {
        state = STATE.IN_GAME;

        ResumeGame();
        player.resetPlayer();
        conveyorBeltInstance.clearItems();
        UIManager.GoToStateInGame();

    }

    public static void GameOver()
    {
        state = STATE.GAME_OVER;
        // Afficher le panneau GameOver
        UIManager.GoToStateGameOver();
        // Eteindre la musique du jeu

        // Se déconnecter du serveur
    }

    //Pour reprendre le cours du temps
    public static void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    //Pour arrêter le cours du temps
    public static void PauseGame()
    {
        Time.timeScale = 0f;
    }
}
