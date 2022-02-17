using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController4 : MonoBehaviour
{
    public GameObject SalaPrincipal;
    public GameObject PuzzleAmarelo;
    public GameObject PuzzleVerde;
    public GameObject PuzzleAzul;
    //public GameObject LutaFinal;
    

    void Start() 
    {
        SalaPrincipal.SetActive(false);
        PuzzleAmarelo.SetActive(false);
        PuzzleAzul.SetActive(false);
        PuzzleVerde.SetActive(true);
        //LutaFinal.SetActive(false);

        
    }
    void OnTriggerEnter2D(Collider2D hit) {
        if(hit.tag == "Player")
        {
            SalaPrincipal.SetActive(true);
            PuzzleAmarelo.SetActive(true);
            PuzzleAzul.SetActive(true);
            PuzzleVerde.SetActive(false);
            //LutaFinal.SetActive(true);
            //Destroy (Ativar);
        }
    }
}
