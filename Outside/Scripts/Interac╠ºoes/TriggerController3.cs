using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController3 : MonoBehaviour
{
    public GameObject Minions0;
    public GameObject Minions1;
    public GameObject Minions2;
    public GameObject Minions3;
    public GameObject Minions4;
    public GameObject Boss;
    public GameObject Texto;
    

    void Start() 
    {
        Minions0.SetActive(false);
        Minions1.SetActive(false);
        Minions2.SetActive(false);
        Minions3.SetActive(false);
        Minions4.SetActive(false);
        Boss.SetActive(false);
        Texto.SetActive(false);
        
    }
    void OnTriggerEnter2D(Collider2D hit) {
        if(hit.tag == "Player")
        {
            Minions0.SetActive(true);
            Minions1.SetActive(true);
            Minions2.SetActive(true);
            Minions3.SetActive(true);
            Minions4.SetActive(true);
            Boss.SetActive(true);
            Texto.SetActive(true);
            
        }
    }
}
