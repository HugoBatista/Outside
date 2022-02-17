using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField]
    int healAmount;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag.Equals("Player"))
        {
            other.GetComponent<Vida>().healVida(healAmount);
            
        }    
    }
}