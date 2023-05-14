using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;


public class Item
{
    public string name;
    public float score;
    public Sprite sprite;
    public ItemType type;
    public int level = 1;
    public enum ItemType
    {
        Plastic,
        Glass,
        Metal,
        Trash,
        Cardboard,
        Green,
        Electronic,
        Nonrecyclable
    }
    public Item(string name, float score, ItemType type)
    {
        this.name = name;
        this.score = score;
        this.type = type;
        try
        {
            Texture2D texture = Resources.Load<Texture2D>("Sprites/" + name);
            this.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f);
        }
        catch (Exception)
        {
            Debug.Log("Erreur de chargement de texture pour l'item " + this.name + ". L'item ne sera pas chargé.");
            this.sprite = null;
        }

    }
    public Item(string name, float score, Sprite sprite,ItemType type)
    {
        this.name = name;
        this.score = score;
        this.sprite = sprite;
        this.type = type;
    }
    public Item setLevel(int level)
    {
        this.level = level;
        return this;
    }

}
//On va définir nos items ici
public class Items
{
    public Item plasticBottle = new Item("plastic_Bottle", 10f, Item.ItemType.Plastic).setLevel(1);
    public Item apple = new Item("apple", 10f, Item.ItemType.Trash).setLevel(2);
    public Item yogurt = new Item("yogurt", 10f, Item.ItemType.Plastic).setLevel(1);
    public Item glassBottle = new Item("glassBottle", 10f, Item.ItemType.Glass).setLevel(3);
    public Item peelings = new Item("peelings", 10f, Item.ItemType.Trash).setLevel(1);
    public Item cardboardbox = new Item("cardboardbox", 10f, Item.ItemType.Cardboard).setLevel(2);
    public Item cardboard = new Item("cardboard", 10f, Item.ItemType.Cardboard).setLevel(2);
    public Item chipsbag = new Item("chipsbag", 10f, Item.ItemType.Plastic).setLevel(2);
    public Item coffeecapsule = new Item("coffeecapsule", 10f, Item.ItemType.Metal).setLevel(4);
    public Item napkin = new Item("napkin", 10f, Item.ItemType.Cardboard).setLevel(2);
    public Item babybel = new Item("babybel", 20f, Item.ItemType.Trash).setLevel(2);
    public Item bagOfChips = new Item("bagOfChips", 10f, Item.ItemType.Plastic).setLevel(1);
    public Item batteries = new Item("batteries", 30f, Item.ItemType.Electronic).setLevel(6);
    public Item plasticSpoon = new Item("plasticSpoon", 20f, Item.ItemType.Trash).setLevel(3);
    public Item toothpaste = new Item("toothpaste", 10f, Item.ItemType.Plastic).setLevel(1);
    public Item ketchupBottle = new Item("ketchupBottle", 10f, Item.ItemType.Plastic).setLevel(1);
    public Item plasticBag = new Item("plasticBag", 10f, Item.ItemType.Plastic).setLevel(2);
    public Item can = new Item("can", 15f, Item.ItemType.Metal).setLevel(2);
    public Item canned = new Item("canned", 15f, Item.ItemType.Metal).setLevel(2);
    public Item brokenPhone = new Item("brokenPhone", 25f, Item.ItemType.Electronic).setLevel(6);
    public Item plants = new Item("plants", 10f, Item.ItemType.Green).setLevel(4);
    public Item microwave = new Item("microwave", 40, Item.ItemType.Electronic).setLevel(6);
    public Item bottleOfPills = new Item("bottleOfPills", 10f, Item.ItemType.Nonrecyclable).setLevel(2);
    public Item mouse = new Item("mouse", 20f, Item.ItemType.Electronic).setLevel(6);
    public Item toy = new Item("toy", 15f, Item.ItemType.Nonrecyclable).setLevel(4);
    public Item wood = new Item("wood", 25f, Item.ItemType.Nonrecyclable).setLevel(2);













    //On veut une liste avec tous les items
    public List<Item> GetItems()
    {
        List<Item> allItems = new List<Item> {plasticBottle, apple, yogurt, glassBottle, peelings, cardboardbox,
            cardboard, chipsbag, coffeecapsule, napkin, babybel, bagOfChips, batteries, plasticSpoon, toothpaste,
            ketchupBottle, plasticBag,can, canned, brokenPhone, plants, bottleOfPills, mouse, toy, wood };

        return allItems;

    }
    public List<Item> GetItems(int level)
    {
        List<Item> allItems = this.GetItems();

        List<Item> filteredItems = allItems.Where(item => item.level <= level).ToList();

        return filteredItems;

    }

}
public class ItemScript : MonoBehaviour
{

    public Item item;
    private bool isSelected = false;
    private bool isScaled = false;
    //public float score;
    //public Sprite sprite;
    //public Item.ItemType type;
    void Start()
    {
    }

    public void Init(Item item)
    {
        GetComponent<SpriteRenderer>().sprite = item.sprite;
        GetComponent<ItemScript>().item = item;
        // Associer une image au sprite de l'item

    }
    void Update()
    {
        if (isSelected && !isScaled)
        {
            // Faire grossir l'objet et l'afficher en surbrillance
            LeanTween.scale(transform.gameObject, new Vector3(2*0.002563929f * 0.66f,2*0.01785761f * 0.66f), 0.2f).setEase(LeanTweenType.clamp);
            //Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            //GetComponent<Renderer>().material.color = randomColor;
            isScaled = true;
        }
        //createJson();
    }

    public void SelectItem()
    {
        isSelected = true;
    }

    public void DeselectItem()
    {
        isSelected = false;
    }

    //public void createJson()
    //{
    //    List<GameStateItemData> gameStateItemList = new List<GameStateItemData>();

    //    // Ajouter des données pour GameState 1
    //    GameStateItemData gameStateItemData1 = new GameStateItemData();
    //    gameStateItemData1.gameState = 1;
    //    gameStateItemData1.itemDataList = new List<Item>();
    //    gameStateItemData1.itemDataList.Add(new Item("plasticBottle", 10.0f, Item.ItemType.Plastic));
    //    gameStateItemData1.itemDataList.Add(new Item("apple", 20.0f, Item.ItemType.Organic));
    //    gameStateItemList.Add(gameStateItemData1);
    //    foreach (GameStateItemData element in gameStateItemList)
    //    {
    //        Debug.Log(element.itemDataList);
    //    }

    //    //// Ajouter des données pour GameState 2
    //    //GameStateItemData gameStateItemData2 = new GameStateItemData();
    //    //gameStateItemData2.gameState = 2;
    //    //gameStateItemData2.itemDataList = new List<Item>();
    //    //gameStateItemData2.itemDataList.Add(new Item("nom de l'objet 3", 30.0f, Item.ItemType.Plastic));
    //    //gameStateItemData2.itemDataList.Add(new Item("nom de l'objet 4", 40.0f, Item.ItemType.Metal));
    //    //gameStateItemList.Add(gameStateItemData2);

    //    // Enregistrer dans un fichier JSON
    //    string jsonData = JsonUtility.ToJson(gameStateItemList);
    //    Debug.Log(jsonData);
    //    System.IO.File.WriteAllText(Application.dataPath + "/gameStateItemData.json", jsonData);
    //}
}


