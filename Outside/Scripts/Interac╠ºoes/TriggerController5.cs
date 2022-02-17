using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController5 : MonoBehaviour
{
    public GameObject AtivarLutaFinal;
    
    public BoxCollider2D trigger;

    
    void OnTriggerEnter2D(Collider2D trigger) {
        if (trigger.gameObject.tag == "Player")
        {
            Debug.Log("aativou");
            AtivarLutaFinal.SetActive(true);
            
        }
    }
}
