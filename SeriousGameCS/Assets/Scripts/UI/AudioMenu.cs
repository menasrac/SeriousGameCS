using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;

[RequireComponent(typeof(Slider))]
public class AudioMenu : MonoBehaviour
{
    public Slider mainSlider, musicSlider, effectsSlider;
    public AudioMixer mixer;
    public Button Button;
    public GameObject menu;
    public TextMeshProUGUI mainSliderPercentage, musicSliderPercentage, effectsSliderPercentage;
    private void Start()
    {
        mainSlider.value = 0.5f;
        mainSliderPercentage.text = percentage(mainSlider.value) + "%";
        musicSliderPercentage.text = percentage(musicSlider.value) + "%";
        effectsSliderPercentage.text = percentage(effectsSlider.value) + "%";

    }

    public void UpdateValueOnChange()
    {
        mixer.SetFloat("Master", 20.0f*Mathf.Log(mainSlider.value));
        mixer.SetFloat("Music", 20.0f * Mathf.Log(musicSlider.value));
        mixer.SetFloat("Effects", 20.0f * Mathf.Log(effectsSlider.value));

        mainSliderPercentage.text = percentage(mainSlider.value) + "%";
        musicSliderPercentage.text = percentage(musicSlider.value) + "%";
        effectsSliderPercentage.text = percentage(effectsSlider.value) + "%";
    }

    public void closeWindow()
    {
        menu.SetActive(false);
    }
    string percentage(float value)
    {
        return Mathf.Round(value * 100f).ToString();
    }
}
