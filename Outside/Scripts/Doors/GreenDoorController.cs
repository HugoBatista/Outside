using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDoorController : MonoBehaviour
{
    public BoxCollider2D PortaVerde;//Porta Verde

    public void AbrirPortaVerde(GameObject DoorGreen) //Jogador pega a chave Amarela e destranca a porta Verde 
    {
        if (Inventario_Chaves.YellowKey == true)
        {
            Debug.Log("A chave Amarela abriu a porta Verde!");
            PortaVerde.enabled = true;
            Mensagem_Verde.Trancada = false;
        }
        else
        {
            Debug.Log("A porta Verde, nao se mexeu... Mas reparas numa luz amarela a brilhar da sua fechadura");
        }
    }
}
