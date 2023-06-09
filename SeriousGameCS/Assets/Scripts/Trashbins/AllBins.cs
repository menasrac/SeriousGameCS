using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBins : MonoBehaviour
{
    public GameObject yellowBin;
    public GameObject greenBin;
    public GameObject glassBin;
    public GameObject trashBin;
    public GameObject dechetterieBin;
    public GameObject electronicBin;
    static AllBins allBins;

    private void Awake()
    {
        allBins = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        trashBin.SetActive(true);

    }
    public static void Reset()
    {
        allBins.greenBin.SetActive(false);
        allBins.glassBin.SetActive(false);
        allBins.dechetterieBin.SetActive(false);
        allBins.electronicBin.SetActive(false);
    }
   
    //Lorsque l'item est n'est mis dans aucune poubelle -> donc dans la poubelle grise
    public static void letInGarbage(Item item)
    {
        if (item.type != Item.ItemType.Trash)
        {
            player.AddPoints(-2 * item.score);
            player.onError();
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
                compareItemToBin(item, new List<Item.ItemType> {Item.ItemType.Plastic, Item.ItemType.Metal, Item.ItemType.Cardboard});
                break;

            case Bin.BinType.Glass:
                compareItemToBin(item, new List<Item.ItemType> { Item.ItemType.Glass});
                break;
            case Bin.BinType.Green:
                compareItemToBin(item, Item.ItemType.Green);
                break;
            case Bin.BinType.Electronic:
                compareItemToBin(item, Item.ItemType.Electronic); 
                break;
            case Bin.BinType.Dechetterie:
                compareItemToBin(item, new List<Item.ItemType> { Item.ItemType.Green, Item.ItemType.Electronic, Item.ItemType.Nonrecyclable});
                break;
            case Bin.BinType.Trash:
                letInGarbage(item);
                break;
            default:
                break;
        }

    }
    /// <summary>
    /// Active la poubelle de nom binName.
    /// </summary>
    /// <param name="binName"></param>
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
            case "electronic":
                allBins.electronicBin.SetActive(true);
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// S'occupe d'activer les poubelles en fonction du niveau. Doit �tre appel� � chaque niveau.
    /// </summary>
    /// <param name="level"></param>
    public static void ManageBinSpawnOnLevel(int level)
    {
        switch (level)
        {
            default:
                break;
            case 2:
                ActivateBin("glass");
                break;
            case 4:
                ActivateBin("green");
                break;
            case 5:
                ActivateBin("electronic");
                break;
            case 6:
                ActivateBin("dechetterie");
                break;
        }
    }

    //S'occupe de donner ou retirer les points en comparant le type de l'item � l'itemType donn� en argument
    private static void compareItemToBin(Item item, Item.ItemType itemType)
    {
        if (item.type == itemType)
        {
            player.AddPoints(item.score);
        }
        else
        {
            player.AddPoints(-2 * item.score);
            player.onError();
        }
    }

    //Meme chose mais avec une liste d'itemType
    private static void compareItemToBin(Item item, List<Item.ItemType> itemTypeList)
    {
        bool isGood = false;
        foreach (Item.ItemType itemType in itemTypeList)
        {


            if (item.type == itemType)
            {
                player.AddPoints(item.score);
                isGood = true;
            }

        }
        if (!isGood)
        {
            player.AddPoints(-2 * item.score);
            player.onError();
        }
    }


 }