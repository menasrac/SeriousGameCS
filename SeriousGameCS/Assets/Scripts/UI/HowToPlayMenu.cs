using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayMenu : MonoBehaviour
{
    public GameObject HowToPlayPanel;

    public void HowToPlayButton()
    {
        HowToPlayPanel.SetActive(true);
    }

    public void UnderstoodButton()
    {
        HowToPlayPanel.SetActive(false);
    }
}
