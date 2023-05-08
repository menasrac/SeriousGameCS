using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TipPrefab : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Image image;
    public TextMeshProUGUI descriptionText;

    public void Initialize(string title, Sprite sprite, string description)
    {
        titleText.text = title;
        image.sprite = sprite;
        //descriptionText.text = description;
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        { 
            close();
        }
    }

    public void close()
    {
        Destroy(gameObject);

        if (!PauseMenu.GameIsPaused)
        {
            main.ResumeGame();
        }
    }
}
