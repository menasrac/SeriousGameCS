using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    static MusicManager instance;


    private int musicIndex = 0;
    private static AudioClip mainMenuMusic;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        mainMenuMusic = Resources.Load<AudioClip>("Sounds/Music/Login/Breaking Sweat - BalloonPlanet");
    }

    // Start is called before the first frame update
    void Start()
    {
        //audioSource.clip = playlist[0];
        //audioSource.Play();



    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying && main.state == main.STATE.IN_GAME)
        {
            PlayNextSong();
        }
 

    }
    
 

    void PlayNextSong()
    {
        musicIndex = (musicIndex + 1) % playlist.Length;
        audioSource.clip = playlist[musicIndex];
        audioSource.Play();
    }

    public static void StopMusic()
    {
        instance.audioSource.Stop();
    }

    public static void MainMenuMusic()
    {
        StopMusic();
        if (!instance.audioSource.isPlaying)
        {
            instance.audioSource.clip = mainMenuMusic;
            instance.audioSource.Play();
        }
    }


}


