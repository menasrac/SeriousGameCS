using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player : MonoBehaviour
{
    public float score = 0f;
    public TextMeshProUGUI scoreText;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
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

    private void updateLevel()
    {
        if (getSupposedLevel(score) > level)
        {
        }
    }
    private int getSupposedLevel(float score)
    {
        if (score >= 100 && score < 150)
        {
            return (1);
        }
        if (score >= 150 && score < 200)
        {
            return (2);
        }
        else
        {
            return (0);
        }
    }
    public void AddPoints(float points)
    {
        score += points;
    }


<<<<<<< Updated upstream
=======
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

    public void newLevel()
    {

    }
        
>>>>>>> Stashed changes
}
