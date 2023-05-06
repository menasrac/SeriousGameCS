using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject StartMenuPanel;
    public GameObject inGamePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame ()
    {
        inGamePanel.SetActive(true);
        StartMenuPanel.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Quit()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }
}
