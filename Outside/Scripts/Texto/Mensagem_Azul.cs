using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem_Azul : MonoBehaviour
{
    public Text Texto_do_puzzle3_da_Porta_Trancada;
    public Text Texto_do_puzzle3_da_Porta_Destrancada;
    public Text Texto_do_puzzle3_do_bau_Trancada;
    public Text Texto_do_puzzle3_do_bau_Destrancada;
    public Image imagem_porta;
    public Image imagem_porta2;
    public Image imagem_do_puzzle3_do_bau_Trancado;
    public Image imagem_do_puzzle3_do_bau_Destrancado;

    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject Jogador;
    public static bool Trancada = true;
    public GameObject DoorBlue;
    public bool Aberto;


    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Vector2.Distance(DoorBlue.transform.position, Jogador.transform.position) < distancia && Trancada == true) //Porta
        {
            Texto_do_puzzle3_da_Porta_Trancada.enabled = true;
            imagem_porta2.enabled = true;
        }
        else
        {
            Texto_do_puzzle3_da_Porta_Trancada.enabled = false;
            imagem_porta2.enabled = false;
        }
        //Texto e imagem da porta trancada "AMARELA" ^^

        if (Vector2.Distance(DoorBlue.transform.position, Jogador.transform.position) < distancia && Trancada == false) //Porta
        {
            Texto_do_puzzle3_da_Porta_Destrancada.enabled = true;
            imagem_porta.enabled = true;
        }
        else
        {
            Texto_do_puzzle3_da_Porta_Destrancada.enabled = false;
            imagem_porta.enabled = false;
        }
        //Texto e imagem da porta destrancada "AMARELA" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.GreenKey == false) //Bau
        {
            Texto_do_puzzle3_do_bau_Trancada.enabled = true;
            imagem_do_puzzle3_do_bau_Trancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle3_do_bau_Trancada.enabled = false;
            imagem_do_puzzle3_do_bau_Trancado.enabled = false;
        }
        //Texto e imagem do bau trancado "AMARELA" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.GreenKey == true)  //Bau
        {
            Texto_do_puzzle3_do_bau_Destrancada.enabled = true;
            imagem_do_puzzle3_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle3_do_bau_Destrancada.enabled = false;
            imagem_do_puzzle3_do_bau_Destrancado.enabled = false;
        }
        //Texto e imagem do bau destrancado "AMARELA" ^^
    }

   /* public void MostrarTexto()
    {
        
            if (!Aberto)
            {
                Aberto = false;
                
                this.gameObject.GetComponent<>().sprite = Chest_1;
            }
        
    }*/
}
