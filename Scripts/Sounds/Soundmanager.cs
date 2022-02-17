using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Soundmanager : MonoBehaviour
{
   [SerializeField] Slider volumeSlider;
     void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 40);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Update is called once per frame
    public void ChandeVolume ()
    {
        AudioListener.volume = volumeSlider.value;
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
