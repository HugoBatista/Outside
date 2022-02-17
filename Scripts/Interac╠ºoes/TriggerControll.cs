using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControll : MonoBehaviour
{
    public GameObject Luz;
    public AudioSource Tocha;

    void Start() 
    {
        Luz.SetActive(false);
        Tocha = GetComponent<AudioSource> ();
    }
    IEnumerator OnTriggerEnter2D(Collider2D hit) {
        if(hit.tag == "Player")
        {
            Luz.SetActive(true);
            Tocha.Play ();
            yield return new WaitForSeconds(3);
            Destroy (Tocha);
            
        }
    }
}
