using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin
{
    public Sprite sprite;
    public BinType type;

    public enum BinType
    {
        Plastic,
        Glass,
        Green,
        Batteries,
        Dechetterie,
        Trash
    }
    public Bin(Sprite sprite, BinType type)
    {
        this.sprite = sprite;
        this.type = type;
    }

}
public class Bins : MonoBehaviour
{
    public float hoverSize = 1.2f;
    public float defaultSize = 1f;
    public Bin.BinType binType;
    public ConveyorBelt belt;
    public Sprite sprite1, sprite2;
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
        GetComponent<SpriteRenderer>().sprite = sprite2;
    }

    //Event lorsque la souris quitte la zone du bouton
    public void OnMouseExit()
    {
        //Restaure la taille du texte par d?faut lorsque la souris quitte le bouton
        transform.localScale = new Vector3(defaultSize, defaultSize, defaultSize);
        GetComponent<SpriteRenderer>().sprite = sprite1;
    }

    public void OnClick()
    {
        Transform selectedItem = ConveyorBelt.getSelectedItem();
        if (selectedItem != null)
        {

            Item item = selectedItem.GetComponent<ItemScript>().item;

            AllBins.checkTrash(item, binType, belt);
            EffectsManager.PlayItemTypeSound(item.type);
            Destroy(selectedItem.gameObject);
        }
    }

}