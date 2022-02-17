using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inimigos : MonoBehaviour
{
    public int Damage;
    
    public int VidaAtual;
   
    public GameObject Inimigo;

   /* public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Atacar")){
            VidaAtual -= Damage;

        }
    }*/
    
    public void TakeDamage(int dano)
    {
        VidaAtual -=dano;
        Debug.Log("Damage");
        if (VidaAtual <= 0)
        {
            Morre();

            
        }

        void Morre()
        {
            Destroy(Inimigo);
            Debug.Log("Morreu");
        }
    }
   




}
