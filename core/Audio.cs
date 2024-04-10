using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio instance { get; private set; }
    private AudioSource soundSource;
    private AudioSource musicSource;


    private void Awake()
    {
        instance = this;
        soundSource = GetComponent<AudioSource>();
        musicSource = transform.GetChild(0).GetComponent<AudioSource>();
    }


    public void PlaySound(AudioClip _sound)
    {
       soundSource.PlayOneShot(_sound);
    }
    public void changeSound(float _change)
    {
        float currentVolume = PlayerPrefs.GetFloat("soundVolume",1);
        currentVolume +=  _change;
        if (currentVolume > 1)
        {
            currentVolume = 0;
        } else if (currentVolume < 0)
        {
            currentVolume = 1;
        }
        soundSource.volume = currentVolume;
        PlayerPrefs.SetFloat("soundVolume", currentVolume);
    }
    public void changeMusic(float _change)
    {

        float currentVolume = PlayerPrefs.GetFloat("musicVolume",1);
        currentVolume +=  _change;
        if (currentVolume > 1)
        {
            currentVolume = 0;
        }
        else if (currentVolume < 0)
        {
            currentVolume = 1;
        }
        musicSource.volume = currentVolume;
        PlayerPrefs.SetFloat("musicVolume", currentVolume);

    }

}
