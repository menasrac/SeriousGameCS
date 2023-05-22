using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button button;
    public GameObject audioPanel;
    private Vector2 scale;
    private void Start()
    {
        scale = button.transform.localScale;
    }

    public void OnClick()
    {
        audioPanel.SetActive(true);
    }

    public void OnHover()
    { 
        Debug.Log("Hovered");
        LeanTween.scale(button.transform.gameObject,(1.5f * scale), 0.1f).setEase(LeanTweenType.clamp).setIgnoreTimeScale(true);
    }

    public void LeaveHover()
    {
        Debug.Log("LeaveHove");
        LeanTween.scale(button.transform.gameObject, scale, 0.2f).setEase(LeanTweenType.clamp).setIgnoreTimeScale(true);
    }
}
