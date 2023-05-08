using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    private static GameObject prefab; // Référence au prefab
    private static Canvas canvas;

    private void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/newLevelTip");
        canvas = GameObject.FindObjectOfType<Canvas>();
        ExampleUsage();
    }

    //Création d'un nouveau Tip
    private static void CreateTip(string title, Sprite sprite, string description)
    {
        GameObject newPrefab = Instantiate(prefab, canvas.transform); // Instancier le prefab
        TipPrefab customPrefabScript = newPrefab.GetComponent<TipPrefab>(); // Obtenir le script CustomPrefab attaché au prefab
        customPrefabScript.Initialize(title, sprite, description); // Appeler la méthode Initialize pour personnaliser le prefab
    }

    // Utilisation de CreatePrefab
    private void ExampleUsage()
    {
        string title = "Mon titre";
        Texture2D texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
        Sprite sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);        
        string description = "Ma description";
        CreateTip(title, sprite, description);
    }
}

