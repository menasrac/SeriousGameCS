using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectedPanel : MonoBehaviour
{
    public RawImage selectedItemImage;
    public TextMeshProUGUI selectedItemName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform selectedItem = ConveyorBelt.getSelectedItem();
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(selectedItem);
        }

        if (selectedItem != null)
        {
            selectedItemImage.gameObject.SetActive(true);
            selectedItemName.gameObject.SetActive(true);
            selectedItemName.text = FormatString(selectedItem.name);
            selectedItemImage.texture = selectedItem.GetComponent<SpriteRenderer>().sprite.texture;
        }
        else
        {
            selectedItemImage.gameObject.SetActive(false);
            selectedItemName.gameObject.SetActive(false);
        }
    }

    public static string FormatString(string input)
    {
        string output;
        if (input == null)
        {
            return "No Input";
        }
        string[] words = input.Split(char.Parse("_"));
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
        }
        return string.Join(" ", words);
    }


}
