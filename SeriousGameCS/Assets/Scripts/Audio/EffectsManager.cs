using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    public AudioClip selectedItemSound;

    private static EffectsManager instance;
    public AudioSource audioSource;

    public AudioClip cardboardSound, electronicSound, glassSound, greenSound, metalSound, nonrecyclableSound, plasticSound, trashSound;


    private AudioClip[] cardboardSounds, electronicSounds, glassSounds, greenSounds, metalSounds, nonrecyclableSounds, plasticSounds, trashSounds;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        LoadSounds(ref cardboardSounds, "Cardboard");
        LoadSounds(ref glassSounds, "Glass");
        LoadSounds(ref greenSounds, "Green");
        LoadSounds(ref metalSounds, "Metal");
        LoadSounds(ref electronicSounds, "Electronic");
        LoadSounds(ref nonrecyclableSounds, "Nonrecyclable");
        LoadSounds(ref plasticSounds, "Plastic");
        LoadSounds(ref trashSounds, "Trash");
    }

    void LoadSounds(ref AudioClip[] audioClips, string name)
    {
        try
        {
            audioClips = Resources.LoadAll<AudioClip>("Sounds/Trashed/" + name);
        }
        catch (Exception)
        {
            audioClips = null;
            Debug.Log("Erreur de chargement de texture pour les sons " + name + ". La playlist ne sera pas chargée.");
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
    //Jouer un son si c'est possible
    private static void TrySound(AudioClip[] audioClips)
    {
        if(audioClips.Length != 0)
        {
            instance.audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
        }
    }

    
    //Joue le son d'un type d'item
    public static void PlayItemTypeSound(Item.ItemType itemType)
    {
        switch (itemType)
        {
            case Item.ItemType.Cardboard:
                TrySound(instance.cardboardSounds);
                break;
            case Item.ItemType.Electronic:
                TrySound(instance.electronicSounds);
                break;
            case Item.ItemType.Glass:
                TrySound(instance.glassSounds);
                
                break;
            case Item.ItemType.Green:
                TrySound(instance.greenSounds);
                
                break;
            case Item.ItemType.Metal:
                TrySound(instance.metalSounds);
                
                break;
            case Item.ItemType.Nonrecyclable:
                TrySound(instance.nonrecyclableSounds);
                
                break;
            case Item.ItemType.Plastic:
                TrySound(instance.plasticSounds);
                break;
            case Item.ItemType.Trash:
                TrySound(instance.trashSounds);
                break;
            default:
                break;
        }
    }


}
