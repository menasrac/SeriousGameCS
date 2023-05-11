using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    private static GameOverMenu instance;
    public TextMeshProUGUI gameOverText;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    public void PlayAgain()
    {
        main.LaunchGame();
    }

    public static void GameOverScore()
    {
        instance.gameOverText.text = $"Your final score is : {player.score}";
    }
}
