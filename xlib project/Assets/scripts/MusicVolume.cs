using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    private AudioSource audiosrc;
    private float musicVolume = 1f;
    public void Start()
    {
        audiosrc = GetComponent<AudioSource>();

    }

    private void Update()
    {
        audiosrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }


}



