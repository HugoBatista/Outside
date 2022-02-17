using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vida : MonoBehaviour
{
    public Transform RespawnBeacon;
    public Text TextoVida;
    public int Damage =1;
    
    
    [SerializeField]
    int maxvida=10;
    
    [SerializeField]
    int vida=10;
    

    

    
    
    void Start()
    {
        
    }
    public int GetVida()
    {
        return vida;
         
    }

    public void Update()
    {
        TextoVida.text = "Vida: " + GetVida();
        
        if (vida <= 0) 
        {
            Debug.Log("O player morreu");
            transform.position = RespawnBeacon.position;
            vida = 5;

        }

 
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo")){
            vida -= Damage;

        }
    }
    
    
    public void healVida(int valor)
    {
        vida+=valor;
        if(vida>maxvida)
        {
            vida=maxvida;
        }
        
    }
    
}