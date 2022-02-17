using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem_Verde : MonoBehaviour
{
    public Text Texto_do_puzzle2_da_Porta_Trancada;
    public Text Texto_PortaVerde_Destrancada;
    public Text Texto_do_puzzle2_do_bau_Trancada;
    public Text Texto_do_puzzle2_do_bau_Destrancada;
    public Text Texto_do_puzzle2_BauFake1;
    public Text Texto_do_puzzle2_BauFake2;
    public Text Texto_do_puzzle2_BauFake3;
    public Image imagem_porta;
    public Image imagem_porta2;
    public Image imagem_do_puzzle2_do_bau_Trancado;
    public Image imagem_do_puzzle2_do_bau_Destrancado;
    

    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject Jogador;
    private GameObject Fake;
    public static bool Trancada = true;
    public GameObject DoorGreen;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Vector2.Distance(DoorGreen.transform.position, Jogador.transform.position) < distancia && Trancada == true) //Porta
        {
            Texto_do_puzzle2_da_Porta_Trancada.enabled = true;
            imagem_porta.enabled = true;
        }
        else
        {
            Texto_do_puzzle2_da_Porta_Trancada.enabled = false;
            imagem_porta.enabled = false;
        }
        //Texto e imagem da porta trancada "VERDE" ^^

        if (Vector2.Distance(DoorGreen.transform.position, Jogador.transform.position) < distancia && Trancada == false) //Porta
        {
            Texto_PortaVerde_Destrancada.enabled = true;
            imagem_porta2.enabled = true;
        }
        else
        {
            Texto_PortaVerde_Destrancada.enabled = false;
            imagem_porta2.enabled = false;
        }
        //Texto e imagem da porta destrancada "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.GreenKey == false) //Bau
        {
            Texto_do_puzzle2_do_bau_Trancada.enabled = true;
            imagem_do_puzzle2_do_bau_Trancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle2_do_bau_Trancada.enabled = false;
            imagem_do_puzzle2_do_bau_Trancado.enabled = false;
        }
        //Texto e imagem do bau trancado "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.GreenKey == true)  //Bau
        {
            Texto_do_puzzle2_do_bau_Destrancada.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle2_do_bau_Destrancada.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }
        //Texto e imagem do bau destrancado "VERDE" ^^
        
        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia)  //Bau
        {
            Texto_do_puzzle2_BauFake1.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle2_BauFake1.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }

        if (Vector2.Distance(transform.position, Fake.transform.position) < distancia)  //Bau
        {
            Texto_do_puzzle2_BauFake2.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle2_BauFake2.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }

        if (Vector2.Distance(transform.position, Fake.transform.position) < distancia)  //Bau
        {
            Texto_do_puzzle2_BauFake3.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_do_puzzle2_BauFake3.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }
    }
}
