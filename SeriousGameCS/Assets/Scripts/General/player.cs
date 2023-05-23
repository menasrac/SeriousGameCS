using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    public static float score;
    private static float initialScore = 50;
    public TextMeshProUGUI scoreText;
    public static int level = 1;
    public static int remainingLives;
    public GameObject heartPanel;
    public static Transform heart1, heart2, heart3;
    public GameObject mainGO;
    public static main main;
    public GameObject tipContent;

    public AudioClip errorSound;

    public GameObject gamePanel;

    static player _player;

    private void Awake()
    {
        _player = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = initialScore;
        main = mainGO.GetComponent<main>();
        heart1 = heartPanel.transform.GetChild(0);
        heart2 = heartPanel.transform.GetChild(1);
        heart3 = heartPanel.transform.GetChild(2);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
        updateLevel();

        if (Input.GetKeyDown(KeyCode.A))
        {
            AddPoints(10f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(level);
        }
    }
    //Fonction pour augmenter le niveau de 1 lorsque le score est suffisant, et qui fait appel à newLevel
    private void updateLevel()
    {
        if (getSupposedLevel(score) > level)
        {
            level = getSupposedLevel(score);
            newLevel();
        }
    }
    //Renvoie le niveau qu'on est censé avoir
    private int getSupposedLevel(float score)
    {
        if (score >= 100 && score < 150)
        {
            return (2);
        }
        if (score >= 150 && score < 200)
        {
            return (3);
        }
        if (score >= 200 && score < 250)
        {
            return (4);
        }
        if (score >= 250 && score < 300)
        {
            return (5);
        }
        if (score >= 300 && score < 350)
        {
            return (6);
        }
        if (score >= 350 && score < 400)
        {
            return (7);
        }
        else
        {
            return (1);
        }
    }
    //Ajout du nombre de points
    public static void AddPoints(float points)
    {
        score += points;
    }

    //Erreur commise
    public static void onError()
    {
        EffectsManager.PlaySelectedItemSound(_player.errorSound);
        LeanTween.move(_player.gamePanel.gameObject, UnityEngine.Random.insideUnitCircle * 2.0f, 0.5f).setEasePunch();
        switch (remainingLives)
        {
            case 3:
                remainingLives -= 1;
                heart1.gameObject.SetActive(false);
                break;
            case 2:
                remainingLives -= 1;
                heart2.gameObject.SetActive(false);
                break;
            case 1:
                remainingLives -= 1;
                heart3.gameObject.SetActive(false);
                main.GameOver();
                break;
        }
    }
    //Ce qu'on fait lorsqu'on monte de level
    public void newLevel()
    {
        Tip.newLevelTip(level, tipContent);
        ConveyorBelt.deltaTime -= 0.1f;
        AllBins.ManageBinSpawnOnLevel(level);
    }
    //Reset les coeurs graphiques
    public static void resetLivesUI()
    {
        heart1.gameObject.SetActive(true); 
        heart2.gameObject.SetActive(true); 
        heart3.gameObject.SetActive(true);
    }
    //Reset la vie restante et le score
    public static void resetPlayer()
    {
        level = 1;
        Tip.clearTipHistory(_player.tipContent);
        Tip.newLevelTip(level, _player.tipContent);
        score = initialScore;
        remainingLives = 3;
    }

}

