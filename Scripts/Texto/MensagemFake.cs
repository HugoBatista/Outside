using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MensagemFake : MonoBehaviour
{
    public Text Texto_BauFake1_Trancado;
    public Text Texto_BauFake1_Destrancado;
    public Text Texto_BauFake2_Trancado;
    public Text Texto_BauFake2_Destrancado;
    public Text Texto_BauFake3_Trancado;
    public Text Texto_BauFake3_Destrancado;
    public Image imagem_do_puzzle2_do_bau_Trancado;
    public Image imagem_do_puzzle2_do_bau_Destrancado;


    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject Jogador;
    public static bool Trancada = true;
    public GameObject DoorGreen;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.FakeKey1 == false) //Bau
        {
            Texto_BauFake1_Trancado.enabled = true;
            imagem_do_puzzle2_do_bau_Trancado.enabled = true;
        }
        else
        {
            Texto_BauFake1_Trancado.enabled = false;
            imagem_do_puzzle2_do_bau_Trancado.enabled = false;
        }
        //Texto e imagem do bau trancado "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.FakeKey1 == true)  //Bau
        {
            Texto_BauFake1_Destrancado.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_BauFake1_Destrancado.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }
        //Texto e imagem do bau destrancado "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.FakeKey2 == false) //Bau
        {
            Texto_BauFake2_Trancado.enabled = true;
            imagem_do_puzzle2_do_bau_Trancado.enabled = true;
        }
        else
        {
            Texto_BauFake2_Trancado.enabled = false;
            imagem_do_puzzle2_do_bau_Trancado.enabled = false;
        }
        //Texto e imagem do bau trancado "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.FakeKey2 == true)  //Bau
        {
            Texto_BauFake2_Destrancado.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_BauFake2_Destrancado.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }
        //Texto e imagem do bau destrancado "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.FakeKey3 == false) //Bau
        {
            Texto_BauFake3_Trancado.enabled = true;
            imagem_do_puzzle2_do_bau_Trancado.enabled = true;
        }
        else
        {
            Texto_BauFake3_Trancado.enabled = false;
            imagem_do_puzzle2_do_bau_Trancado.enabled = false;
        }
        //Texto e imagem do bau trancado "VERDE" ^^

        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.FakeKey3 == true)  //Bau
        {
            Texto_BauFake3_Destrancado.enabled = true;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = true;
        }
        else
        {
            Texto_BauFake3_Destrancado.enabled = false;
            imagem_do_puzzle2_do_bau_Destrancado.enabled = false;
        }
        //Texto e imagem do bau destrancado "VERDE" ^^

    }
}
