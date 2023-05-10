using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public static float score = 50f;
    public TextMeshProUGUI scoreText;
    public static int level = 1;
    private static int remainingLives = 3;
    public GameObject heartPanel;
    private static Transform heart1, heart2, heart3;
    public GameObject mainGO;
    public static main main;
    public GameObject tipContent;

    // Start is called before the first frame update
    void Start()
    {
        main = mainGO.GetComponent<main>();
        heart1 = heartPanel.transform.GetChild(0);
        heart2 = heartPanel.transform.GetChild(1);
        heart3 = heartPanel.transform.GetChild(2);
        Debug.Log(heart1.name + heart3.name);
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
        Debug.Log(remainingLives + "onError");
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
        switch (level)
        {
            default:
                break;
            case 2:
                AllBins.ActivateBin("green");
                break;
            case 4:
                AllBins.ActivateBin("glass");
                break;
            case 6:
                AllBins.ActivateBin("dechetterie");
                break;
        }
    }

}
