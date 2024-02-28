using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject SFXAudioSource;

    void Start()
    {
        PlayBGM();
    }
    
    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SFXAudioSource, spawnPosition, Quaternion.identity);
    }
}
