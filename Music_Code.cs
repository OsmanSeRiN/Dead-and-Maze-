using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Code : MonoBehaviour
{
    public GameObject PlayMusic,PauseMusic;

    public void MusicOn() 
    {
        PlayMusic.SetActive(false);
        PauseMusic.SetActive(true);
    }

    public void MusicOff () 
    {
       PlayMusic.SetActive(true);
       PauseMusic.SetActive(false);    
    }
}
