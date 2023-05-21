using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    private static GameObject prefab; // Référence au prefab
    private static Canvas canvas;
    //public GameObject content;

    private void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/newLevelTip");
        canvas = GameObject.FindObjectOfType<Canvas>();
    }

    //Création d'un nouveau Tip
    private static TipPrefab CreateTip(string title, Sprite sprite, string description)
    {
        GameObject newPrefab = Instantiate(prefab, canvas.transform); // Instancier le prefab
        TipPrefab customPrefabScript = newPrefab.GetComponent<TipPrefab>(); // Obtenir le script CustomPrefab attaché au prefab
        customPrefabScript.Initialize(title, sprite, description); // Appeler la méthode Initialize pour personnaliser le prefab
        return(customPrefabScript); 
    }
 

    public static void newLevelTip(int level, GameObject content)
    {
        Texture2D texture;
        Sprite sprite;
        TipPrefab tip;
        switch (level)
        {

            case 2:
                texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                tip = CreateTip("Tip2", sprite, "Tip2");
                break;
            case 3:
                texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                tip = CreateTip("Tip3", sprite, "Tip3");
                break;
            case 4:
                texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                tip = CreateTip("Tip4", sprite, "Tipi4");
                break;
            default:
                texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                tip = CreateTip("TipD", sprite, "TipiD");
                break;
        }
        main.PauseGame();
        Debug.Log(tip.titleText.text);
        addToTipHistory(tip, content);
    }

    private static void addToTipHistory(TipPrefab tipPrefab, GameObject content)
    {
        TipPrefab newTipPrefab = Instantiate(tipPrefab, content.transform); // Créer une nouvelle instance de TipPrefab

        // Effectuer les modifications nécessaires sur la nouvelle instance
        newTipPrefab.removeCloseButton();
    }
}

