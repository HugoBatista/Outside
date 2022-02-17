using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControll2 : MonoBehaviour
{
    public GameObject WallFake6;
    public GameObject Ativar;
    

    void Start() 
    {
        WallFake6.SetActive(false);
        
    }
    void OnTriggerEnter2D(Collider2D hit) {
        if(hit.tag == "Player")
        {
            WallFake6.SetActive(true);
            Destroy (Ativar);
        }
    }
}
