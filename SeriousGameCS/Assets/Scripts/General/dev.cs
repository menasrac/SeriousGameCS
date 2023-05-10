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
    //private player player;

    // Start is called before the first frame update
    void Start()
    {
        levelText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        //player = GameObject.FindObjectOfType<player>();
       
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

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("levelup!");
            player.level += 1;
        }
    }

}
