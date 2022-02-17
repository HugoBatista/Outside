using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoorController : MonoBehaviour
{
    public BoxCollider2D PortaAzul;//Porta Azul


    public void AbrirPortaAzul(GameObject DoorBlue) //Jogador pega a chave Verde e destranca a porta Azul
    {
        if (Inventario_Chaves.GreenKey == true)
        {
            Debug.Log("A chave Verde abriu a porta Azul!");
            PortaAzul.enabled = true;
            Mensagem_Azul.Trancada = false;
        }
        else
        {
            Debug.Log("A porta Azul, nao se mexeu... Mas reparas numa luz verde a brilhar da sua fechadura");
        }
    }
}
