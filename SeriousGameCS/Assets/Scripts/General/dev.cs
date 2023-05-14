using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dev : MonoBehaviour
{
    public ConveyorBelt conveyorBelt;
    public GameObject yellowBinGO;
    private TextMeshProUGUI levelText;
    public player playerInstance;
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

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("levelup!");
            player.level += 1;
            playerInstance.newLevel();
        }
    }

}
