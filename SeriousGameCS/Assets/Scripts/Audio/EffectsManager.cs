using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    public AudioClip selectedItemSound;

    private static EffectsManager instance;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySelectedItemSound(AudioClip clip)
    {
        instance.audioSource.PlayOneShot(clip);
    }


}
