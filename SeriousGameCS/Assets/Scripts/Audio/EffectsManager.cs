using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    public AudioClip selectedItemSound;

    private static EffectsManager instance;
    public AudioSource audioSource;

    public AudioClip cardboardSound, electronicSound, glassSound, greenSound, metalSound, nonrecyclableSound, plasticSound, trashSound;
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


    public static void PlayItemTypeSound(Item.ItemType itemType)
    {
        switch (itemType)
        {
            case Item.ItemType.Cardboard:
                instance.audioSource.PlayOneShot(instance.cardboardSound);
                break;
            case Item.ItemType.Electronic:
                instance.audioSource.PlayOneShot(instance.electronicSound);
                break;
            case Item.ItemType.Glass:
                instance.audioSource.PlayOneShot(instance.glassSound);
                break;
            case Item.ItemType.Green:
                instance.audioSource.PlayOneShot(instance.greenSound);
                break;
            case Item.ItemType.Metal:
                instance.audioSource.PlayOneShot(instance.metalSound);
                break;
            case Item.ItemType.Nonrecyclable:
                instance.audioSource.PlayOneShot(instance.nonrecyclableSound);
                break;
            case Item.ItemType.Plastic:
                Debug.Log("plastic");
                instance.audioSource.PlayOneShot(instance.plasticSound);
                break;
            case Item.ItemType.Trash:
                instance.audioSource.PlayOneShot(instance.trashSound);
                break;
            default:
                break;
        }
    }


}
