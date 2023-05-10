using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBins : MonoBehaviour
{
    public GameObject yellowBin;
    public GameObject greenBin;
    public GameObject glassBin;
    public GameObject dechetterieBin;
    static AllBins allBins;

    // Start is called before the first frame update
    void Start()
    {
        allBins = this;
        greenBin.SetActive(false);
        glassBin.SetActive(false);
        dechetterieBin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Lorsque l'item est n'est mis dans aucune poubelle -> donc dans la poubelle grise
    public static void letInGarbage(Item item)
    {
        if (item.type != Item.ItemType.Organic)
        {
            player.onError();
            player.AddPoints(-2 * item.score);
        }
        else
        {
            player.AddPoints(item.score);
        }
    }

    public static void checkTrash(Item item, Bin.BinType binType, ConveyorBelt conveyorBelt)
    {
        switch (binType)
        {
            case Bin.BinType.Plastic:
                if (item.type == Item.ItemType.Plastic)
                {
                    player.AddPoints(item.score);
                }
                else
                {
                    player.AddPoints(-2 * item.score);
                    player.onError();
                }
                break;

            case Bin.BinType.Glass:
                if (item.type == Item.ItemType.Glass)
                {
                    player.AddPoints(item.score);
                }
                else
                {
                    player.AddPoints(-2 * item.score);
                    player.onError();
                }
                break;
            case Bin.BinType.Green:
                if (item.type == Item.ItemType.Organic)
                {
                    player.AddPoints(2 * item.score);
                }
                else
                {
                    player.AddPoints(-2 * item.score);
                    player.onError();
                }
                break;
            case Bin.BinType.Dechetterie:
                if (item.type == Item.ItemType.Organic)
                {
                    player.AddPoints(2 * item.score);
                }
                else
                {
                    player.AddPoints(-2 * item.score);
                    player.onError();
                }
                break;
            default:
                break;
        }

    }

    public static void ActivateBin(string binName)
    {

        switch (binName)
        {
            case "glass":
                allBins.glassBin.SetActive(true);
                break;
            case "green":
                allBins.greenBin.SetActive(true);
                break;
            case "dechetterie":
                allBins.dechetterieBin.SetActive(true);
                break;
            default:
                break;
        }
    }
}