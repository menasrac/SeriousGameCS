using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public ConveyorBelt conveyorBelt; // Une référence vers le script du tapis roulant



    public enum STATE { WELCOME_PAGE, IN_GAME, GAME_OVER }

    public STATE state;

    //public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        //state = STATE.WELCOME_PAGE;
        //uiManager.GoToStateWelcome();

        //coroutine = AddItem();
        //StartCoroutine(coroutine);

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
        }

    }
    //Ajouter des points au joueur

    public void UpdateWelcome()
    {

    }

    public void UpdateInGame()
    {

    }

    public void LaunchGame(int numLevel)
    {
        state = STATE.IN_GAME;
    }

    public void GameOver()
    {
        state = STATE.GAME_OVER;
        // Afficher le panneau GameOver

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
