using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayAudio : MonoBehaviour
{
    public AudioSource Soma_Tocha_yes;

    void Start()
    {
        Soma_Tocha_yes.Play();
        GetComponent<AudioSource> ().playOnAwake = false;
    }
}

