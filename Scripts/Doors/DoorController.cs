using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
  
    public BoxCollider2D PortaInicial; //Porta Inicial
    public BoxCollider2D PortaAmarela; //Porta Amarela
    
    public void OpenDoor(GameObject Door)//Jogador pega a chave inical e destranca a porta Inicial
    {     
         if(Inventario_Chaves.StarterKey == true) 
         {
            Mensagem.Trancada = false;
             Debug.Log("A chave antiga abriu a porta!");
             PortaInicial.enabled= true; 
         }
        else
        {
            Debug.Log("A porta esta trancada...");
        }
    }

    public void AbrirPortaAmarela(GameObject DoorYellow) //Jogador com a chave inicial consegue abrir a porta Amarela
    {
        if (Inventario_Chaves.StarterKey == true)
        {
            Mensagem_Amarelo.Trancada = false;
            Debug.Log("A chave antiga abriu a porta Amarela!");
            PortaAmarela.enabled = true;
        }
        else
        {
            Debug.Log("Como e que tu chegaste aqui :0");
        }
    }

    
    
    
}
