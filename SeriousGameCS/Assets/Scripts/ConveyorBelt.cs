
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConveyorBelt : MonoBehaviour
{
    public player player;
    public GameObject selectedPanel;
    public float itemSpeed = 5f; // Vitesse des objets sur le tapis roulant
    public float conveyorSpeed = 0.5f;
    Vector3 spawnPoint = new Vector3(-8f, 0f, 0f);
    private static Transform selectedItem = null; // Variable pour stocker l'objet sélectionné
    float _lastSpawnTime = 0.0f;
    private int duration;
    private Items items;

    //private static ConveyorBelt instance;
    private void Awake()
    {
        //instance = this;
    }
    void Start()
    {
        items = new Items();
    }
    int i = 0;

    void Update()
    {
        //Faire apparaitre les items toutes les duration sec
        duration = 3;
        if (Time.time > _lastSpawnTime + duration)
        {

            Item item = chooseRandomItem(player.level);
            //On check qu'il n'y pas de pbs de texture
            if (item.sprite == null)
            {
                item = new Item("plasticBottle", 10f, Item.ItemType.Plastic);
            }
            AddItem(item);
            _lastSpawnTime = Time.time;
        }

        // Faire bouger les objets sur le tapis roulant
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform item = transform.GetChild(i);
            item.position += new Vector3(itemSpeed * Time.deltaTime, 0f, 0f);
        }

        //Vector3 rightEdge = transform.position + transform.right * transform.localScale.x * 0.5f;

        // Si l'objet entre dans la zone de sélection, on le met en sélectionné
        if (transform.childCount > 0 && transform.GetChild(0).localPosition.x > 0.3f)
        {
            Transform item = transform.GetChild(0);
            ItemScript itemScript = item.GetComponent<ItemScript>(); // Ajoutez cette ligne
            itemScript.SelectItem(); // Ajoutez cette ligne
            selectedItem = transform.GetChild(0); // Stocker l'objet sélectionné
            selectedItem.GetComponent<ItemScript>().SelectItem(); // Activer la sélection de l'objet
        }
        // Si l'objet est sorti de la zone du tapis roulant, le supprimer
        if (transform.childCount > 0 && transform.GetChild(0).localPosition.x + transform.GetChild(0).localScale.x * 0.5f > transform.right.x * 0.5f)
        {
            AllBins.letInGarbage(transform.GetChild(0).GetComponent<ItemScript>().item);
            Destroy(transform.GetChild(0).gameObject);
            Destroy(selectedItem.gameObject);
        }

        //Animer le tapis
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(-itemSpeed/15*Time.time, 0f);

    }

    public Item chooseRandomItem(int Gamestate)
    {
        List<Item> allItems = items.GetItems(Gamestate);

        int randomIndex = Random.Range(0, allItems.Count);

        // Obtient un élément aléatoire à partir de la liste des items
        Item randomItem = allItems[randomIndex];
        return (randomItem);
    }

    public void AddItem(Item item)
    {
        GameObject newItem = new GameObject();
        ItemScript representation = newItem.AddComponent<ItemScript>();
        newItem.AddComponent<SpriteRenderer>();
        newItem.name = item.name;
        //newItem.transform.parent = transform;
        representation.Init(item);

        // Ajouter le nouvel objet à la liste des enfants du tapis roulant
        newItem.transform.SetParent(transform);

        // Positionner le nouvel objet sur le tapis roulant
        Vector3 spawnPosition = new Vector3(-0.5f, 0, -1);
        newItem.transform.localPosition = spawnPosition;
        newItem.transform.localScale = new Vector3(0.002563929f*0.66f, 0.01785761f*0.66f, 0.2f);
        
    }

    public static Transform getSelectedItem()
    {
        return (selectedItem);
    }

  public void clearItems()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }



}

