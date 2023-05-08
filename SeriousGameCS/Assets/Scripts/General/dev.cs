using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dev : MonoBehaviour
{
    public ConveyorBelt conveyorBelt;
    public RawImage selectedItemImage;
    public GameObject yellowBinGO;
    private TextMeshProUGUI levelText;
    private player player;

    // Start is called before the first frame update
    void Start()
    {
        levelText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        player = GameObject.FindObjectOfType<player>();
        ////Charger l'image depuis les ressources
        //Texture2D texture = Resources.Load<Texture2D>("Bins/yellowBin");

        //if (texture == null)
        //{
        //    Debug.LogError("texture existe po");
        //}
        //Sprite sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 25.0f, 0, SpriteMeshType.Tight);
        //Bin yellowBin = new Bin(sprite, Item.ItemType.Plastic);
        //Bins representation = yellowBinGO.AddComponent<Bins>();
        //yellowBinGO.AddComponent<SpriteRenderer>();

        //yellowBinGO.name = "Yellow Bin";

        //representation.Init(yellowBin);
        //SpriteRenderer yellowSpr = yellowBinGO.GetComponent<SpriteRenderer>();
        //yellowSpr.drawMode = SpriteDrawMode.Sliced;
        //yellowSpr.size = new Vector2(64.85f, 68.5f);

        //// Vérifier que l'image a bien été chargée
        //if (sprite == null)
        //{
        //    Debug.LogError("Impossible de charger l'image");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "level=" + player.level;
        Transform selectedItem = conveyorBelt.getSelectedItem();
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(selectedItem);
        }

        if (selectedItem != null )
        {
            selectedItemImage.gameObject.SetActive(true);
            selectedItemImage.texture = selectedItem.GetComponent<SpriteRenderer>().sprite.texture;
        }
        else
        {
            selectedItemImage.gameObject.SetActive(false);
        }
    }

}
