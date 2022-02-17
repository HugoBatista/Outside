using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour //O jogador tem que ter a tag "Player"
{
    public Canvas Dialogue;
    public Text texto_do_bau_Trancado;
    public Text texto_do_bau_Destrancado;
    public Text Texto_da_Porta_Trancada;
    public Text Texto_da_Porta_Destrancada;
    public Image imagem_porta;
    public Image imagem_porta2;
    public Image imagem_bau_Trancado;
    public Image imagem_bau_Destrancado;

    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject Jogador;
    public static bool Trancada = true;
    public GameObject Door;

    void Start()
    {
        
        
        Jogador = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.StarterKey == false ) //Bau
        {
            texto_do_bau_Trancado.enabled = true;
            imagem_bau_Trancado.enabled = true;
        }
        else
        {
            texto_do_bau_Trancado.enabled = false;
            imagem_bau_Trancado.enabled = false;
        }
        //Texto e imagem do bau trancado ^^
        
        if (Vector2.Distance(transform.position, Jogador.transform.position) < distancia && Inventario_Chaves.StarterKey == true)  //Bau
        {
            texto_do_bau_Destrancado.enabled = true;
            imagem_bau_Destrancado.enabled = true;
        }
        else
        {
            texto_do_bau_Destrancado.enabled = false;
            imagem_bau_Destrancado.enabled = false;
        }
        //Texto e imagem do bau destrancado ^^
        
        if (Vector2.Distance(Door.transform.position,Jogador.transform.position) < distancia && Trancada == true) //Porta
        {
            Texto_da_Porta_Trancada.enabled = true;
            imagem_porta.enabled = true;
        }
        else
        {
            Texto_da_Porta_Trancada.enabled = false;
            imagem_porta.enabled = false;
        }
        //Texto e imagem da porta trancada ^^
        
        if (Vector2.Distance(Door.transform.position, Jogador.transform.position) < distancia && Trancada == false) //Porta
        {
            Texto_da_Porta_Destrancada.enabled = true;
            imagem_porta2.enabled = true;
        }
        else
        {
            Texto_da_Porta_Destrancada.enabled = false;
            imagem_porta2.enabled = false;
        }
        //Texto e imagem da porta destrancada 
    }
}
