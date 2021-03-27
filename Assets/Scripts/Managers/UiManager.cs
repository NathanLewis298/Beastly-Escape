using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public AudioSource Music;
    public Image MusicImage;

    public Sprite on, off;


    public void MuteMusic()
    {
        if (Music.isPlaying)
            Music.Pause();
        else
            Music.Play();

        MusicImage.sprite = (Music.isPlaying) ? on : off;
    }


  
}
