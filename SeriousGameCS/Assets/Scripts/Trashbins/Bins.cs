using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin
{
    public Sprite sprite;
    public Item.ItemType type;

    public Bin(Sprite sprite, Item.ItemType type)
    {
        this.sprite = sprite;
        this.type = type;
    }

}
public class Bins : MonoBehaviour
{
    public float hoverSize = 1.2f;
    public float defaultSize = 1f;
    public Item.ItemType binType;
    public ConveyorBelt belt;
    public player player;
    public void Init(Bin bin)
    {
        GetComponent<SpriteRenderer>().sprite = bin.sprite;
        GetComponent<Bins>().binType = bin.type;
        // Associer une image au sprite de la poubelle

    }
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(defaultSize, defaultSize, defaultSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Event lorsque la souris entre dans la zone du bouton
    public void OnMouseEnter()
    {
        //Change la taille du texte lorsque la souris est sur le bouton
        transform.localScale = new Vector3(hoverSize, hoverSize, hoverSize);
    }

    //Event lorsque la souris quitte la zone du bouton
    public void OnMouseExit()
    {
        //Restaure la taille du texte par d�faut lorsque la souris quitte le bouton
        transform.localScale = new Vector3(defaultSize, defaultSize, defaultSize);
    }

    public void OnClick()
    {
        Transform selectedItem = belt.getSelectedItem();
        if (selectedItem != null)
        {

            Item item = selectedItem.GetComponent<ItemScript>().item;
            if (item.type == binType)
            {
                player.AddPoints(item.score);
            }
            else
            {
                player.AddPoints(-2*item.score);
                player.onError();
            }
            Destroy(selectedItem.gameObject);
        }
    }

    //Lorsque l'item est n'est mis dans aucune poubelle -> donc dans la poubelle grise
    public static void letInGarbage(Item item)
    {
        if (item.type != Item.ItemType.Organic)
        {
            player.onError();
            player.AddPoints(-2*item.score);
        }
        else
        {
            player.AddPoints(item.score);
        }
    }
}
