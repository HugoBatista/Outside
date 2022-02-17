using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBoss : MonoBehaviour
{
    public int Damage;
    public int VidaAtual;
    public GameObject WallFake9;
    public Text TextoVida;

    public GameObject Inimigos;
    public GameObject Boss;

    public int GetVida()
    {
        return VidaAtual;
         
    }
    
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            VidaAtual -= Damage;
        }
    }

    public void Update()
    {
        TextoVida.text = "Boss: " + GetVida();
        
        if (VidaAtual <= 0) 
        {
            WallFake9.SetActive(false);
            Destroy(Boss);
            Destroy(TextoVida);
            Destroy(Inimigos);
            Debug.Log("O inimigo morreu");
            

        }

 
    }


}
