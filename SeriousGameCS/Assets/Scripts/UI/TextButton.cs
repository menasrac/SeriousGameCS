using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextButton : MonoBehaviour
{
    public GameObject buttonText;
    public float hoverSize = 1.2f;
    public float defaultSize = 1f;

    void Start()
    {
        //buttonText.text = "Jouer";
        //Initialise la taille du texte par défaut
        buttonText.transform.localScale = new Vector3(defaultSize, defaultSize, defaultSize);
    }

    //Event lorsque la souris entre dans la zone du bouton
    public void OnMouseEnter()
    {
        //Change la taille du texte lorsque la souris est sur le bouton
        buttonText.transform.localScale = new Vector3(hoverSize, hoverSize, hoverSize);
    }

    //Event lorsque la souris quitte la zone du bouton
    public void OnMouseExit()
    {
        //Restaure la taille du texte par défaut lorsque la souris quitte le bouton
        buttonText.transform.localScale = new Vector3(defaultSize, defaultSize, defaultSize);
    }
    
}
