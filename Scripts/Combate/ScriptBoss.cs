using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBoss : MonoBehaviour
{
    public int Damage;
    public int VidaAtual;
    public GameObject WallFake9;
    public GameObject Escada;
    public Text TextoVida;

    public GameObject Inimigos;
    public GameObject Boss;

    public int GetVida()
    {
        return VidaAtual;
         
    }
    
   
    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
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
            Destroy(Boss);
            Debug.Log("Morreu");

            WallFake9.SetActive(false);
            Escada.SetActive(true);
            Destroy(Boss);
            Destroy(TextoVida);
            Destroy(Inimigos);
            Debug.Log("O inimigo morreu");
        }
    }

    public void Update()
    {
        TextoVida.text = "Boss: " + GetVida();
        
        
 
    }


}
