using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    private static GameObject prefab; // Référence au prefab
    private static Canvas canvas;
    //private Coroutine tipCoroutine;
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
        string description;
        switch (level)
        {
            case 1:
                //texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Plastic Bottles go to the Yellow Bin";
                //tip = CreateTip("Tip1", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/yogurt");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Empty yogurts go to the Yellow Bin";
                //tip = CreateTip("Tip2", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/toothpaste");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Empty toothpaste goes to the Yellow Bin";
                //tip = CreateTip("Tip3", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/peelings");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Peelings cannot be recycled";
                //tip = CreateTip("Tip4", sprite, description);

                texture = Resources.Load<Texture2D>("Sprites/Jauneetmarron");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                description = "";
                tip = CreateTip("Tip1", sprite, description);


                break;

            case 2:
                //texture = Resources.Load<Texture2D>("Sprites/wood");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Wood can't be recycled";
                //tip = CreateTip("Tip5", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/plasticbag");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Plastic bags go to the Yellow bin";
                //tip = CreateTip("Tip6", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/napkin");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Napkins go to the Yellow Bin";
                //tip = CreateTip("Tip7", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/Cardboardbox");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Cardboard boxes go to the Yellow Bin";
                //tip = CreateTip("Tip8", sprite, description);

                texture = Resources.Load<Texture2D>("Sprites/GreenBin");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                description = "";
                tip = CreateTip("Tip2", sprite, description);

                break;



            case 3:
                //texture = Resources.Load<Texture2D>("Sprites/glassBottle");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Recycle this glass bottle by throwing it to the green bin";
                //tip = CreateTip("Tip9", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/plasticspoon");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Plastic spoons must be thrown to the Yellow Bin";
                //tip = CreateTip("Tip10", sprite, description);

                texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                tip = CreateTip("Tip3", sprite, "Tip3");
                break;

            case 4:
                //texture = Resources.Load<Texture2D>("Sprites/polybox");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Poly box goes to ";
                //tip = CreateTip("Tip11", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/Pot-nutella-5kg 2");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Empty Nutella contents go to the Green Bin";
                //tip = CreateTip("Tip12", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/toy");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "toys don't go to the Yellow Bin when broken !";
                //tip = CreateTip("Tip13", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/usednapkin");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Used napkins cannot be recycled";
                //tip = CreateTip("Tip14", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/plants");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Plants cannot be recyled";
                //tip = CreateTip("Tip15", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/dense-confetti");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "After the party, throw confettis to the Yellow Bin";
                //tip = CreateTip("Tip16", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/Coffeecapsule");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Coffeecapsules go to the Yellow Bin";
                //tip = CreateTip("Tip17", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/Bottle of Pills");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Figure it out yourself about this one";
                //tip = CreateTip("Tip18", sprite, description);

                texture = Resources.Load<Texture2D>("Sprites/Exceptions");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                description = "";
                tip = CreateTip("Tip3", sprite, description);

                break;


            case 6:
                //texture = Resources.Load<Texture2D>("Sprites/batteries");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Pay attention to recycling batteries";
                //tip = CreateTip("Tip19", sprite, description);

                //texture = Resources.Load<Texture2D>("Sprites/microwave");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "Apagnan";
                //tip = CreateTip("Tip20", sprite, description);
               
                //texture = Resources.Load<Texture2D>("Sprites/Brokenphone");
                //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                //description = "If it is broken you cannot recyle your phone";
                //tip = CreateTip("Tip21", sprite, description);

                texture = Resources.Load<Texture2D>("Sprites/E-déchets");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                description = "";
                tip = CreateTip("Tip4", sprite, description);
                break;
            
            default:
                texture = Resources.Load<Texture2D>("Sprites/plasticBottle");
                sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
                description = "You can eat it, not recycle it understood ?";
                tip = CreateTip("TipD", sprite, description);
                break;
        }
        main.PauseGame();
        //Debug.Log(tip.titleText.text);
        //addToTipHistory(tip, content);

        // Arrête la coroutine précédente s'il y en a une
        //if (tipCoroutine != null)
        //{
          //StopCoroutine(tipCoroutine);
        //}

        // Lance la coroutine pour afficher les tips les uns après les autres
        //tipCoroutine = StartCoroutine(DisplayTips(tip, content));
    }

    private static void addToTipHistory(TipPrefab tipPrefab, GameObject content)
    {
        TipPrefab newTipPrefab = Instantiate(tipPrefab, content.transform); // Créer une nouvelle instance de TipPrefab

        // Effectuer les modifications nécessaires sur la nouvelle instance
        newTipPrefab.removeCloseButton();
    }
    //private static IEnumerator DisplayTips(TipPrefab tipPrefab, GameObject content)
    //{
        // Créez une liste de tips pour stocker les tips à afficher
      //  List<TipPrefab> tips = new List<TipPrefab>();

        // Instanciez tous les tips et ajoutez-les à la liste
        //foreach (TipPrefab tip in tipPrefab)
        //{
          //  TipPrefab newTipPrefab = Instantiate(tip, content.transform);
            //newTipPrefab.removeCloseButton();
            //tips.Add(newTipPrefab);

            // Attendez un certain laps de temps avant d'afficher le prochain tip
            //yield return new WaitForSeconds(2.0f); // Temps en secondes à ajuster selon vos besoins
        //}

        // Affichez les tips un par un
        //foreach (TipPrefab tip in tips)
        //{
          //  tip.gameObject.SetActive(true);

            // Attendez que l'utilisateur ferme le tip avant d'afficher le suivant
            //yield return new WaitUntil(() => tip.IsClosed);

            // Masquez le tip actuel avant d'afficher le suivant
            //tip.gameObject.SetActive(false);
        //}

        // Réactivez le jeu une fois que tous les tips ont été affichés
        //main.ResumeGame();
    //}

}

