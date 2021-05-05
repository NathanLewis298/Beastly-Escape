using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UILevelSelect : MonoBehaviour
{
    public AudioSource Music;
    public Image MusicImage;

    public Sprite on, off;

    public GameObject Page2;

    public GameObject shopUIMenu;
    public GameObject shopOpenButton;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void MuteMusic()
    {
       

        if (Music.isPlaying)
            Music.Pause();


        else
            Music.Play();

        MusicImage.sprite = (Music.isPlaying) ? on : off;
    }


    public void NextPage()
    {
        Page2.SetActive(true);
    }

    public void BackPage()
    {
        Page2.SetActive(false);
    }

    private void Quit()
    {
        Application.Quit();
    }

    public void OpenShop()
    {
        shopUIMenu.SetActive(true);
        shopOpenButton.SetActive(false);
    }


    public void CloseShop()
    {
        shopUIMenu.SetActive(false);
        shopOpenButton.SetActive(true);
    }


}



