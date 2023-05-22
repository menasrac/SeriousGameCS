using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TipPrefab : MonoBehaviour
{
    public TMP_Text descriptionText;
    public TMP_Text titleText;
    public Image image;
    //public TextMeshProUGUI descriptionText;
    public GameObject closeButton;

    public void Initialize(string title, Sprite sprite, string description)
    {
        titleText.text = title;
        image.sprite = sprite;
        descriptionText.text = description;

        // Description parameters
        descriptionText.font = Resources.Load<TMP_FontAsset>("Fonts/Arial SDF"); // Font
        descriptionText.color = Color.black; // Color
        descriptionText.fontSize = 24; // Size
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        { 
            close();
        }
    }

    private bool isClosed;

    public bool IsClosed
    {
        get { return isClosed; }
    }


    public void close()
    {
        isClosed = true;
        Destroy(gameObject);

        if (!PauseMenu.GameIsPaused)
        {
            main.ResumeGame();
        }
    }

    public void removeCloseButton()
    {
        Destroy(closeButton);
    }
}
