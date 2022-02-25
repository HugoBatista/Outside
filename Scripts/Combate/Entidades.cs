using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entidades : MonoBehaviour
{
    public int Damage;
    public int VidaAtual;
    public GameObject WallFake9;
    public Text TextoVida;

    public GameObject InimigosMini;

    public GameObject MiniBoss;

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
            Destroy(MiniBoss);
            Debug.Log("Morreu");
            WallFake9.SetActive(false);
            Destroy(MiniBoss);
            Destroy(InimigosMini);
            Destroy(TextoVida);
            Debug.Log("O inimigo morreu");
        }
    }

    public void Update()
    {
        TextoVida.text = "Mini Boss: " + GetVida();
        
        

 
    }


}
