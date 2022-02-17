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


    public GameObject MiniBoss;

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
        TextoVida.text = "Mini Boss: " + GetVida();
        
        if (VidaAtual <= 0) 
        {
            WallFake9.SetActive(false);
            Destroy(MiniBoss);
            Destroy(TextoVida);
            Debug.Log("O inimigo morreu");
            

        }

 
    }


}
