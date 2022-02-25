using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDoor : MonoBehaviour
{
    public Text textComponent;
    public string[] lines;
    public float textSpeed;
    public KeyCode interactKey;
    private int index;
    public GameObject collider;
    public GameObject collider1;
    public GameObject collider2;
    public GameObject collider3;
    
    void Start()
    {
        collider.SetActive(true);
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        textComponent.text = string.Empty; // faz com que o que tem dentro do texto do TMPro fique vazio e seja preenchido pelas listas que iram ter o seu texto independentemente para a apari��o com a colisao do personagem com x coisa.
        StartDialouge(); // Faz com que o sistema de dialogo inicie 
    }

   
    void Update()
    { 
        if (Input.GetKeyDown(interactKey)) // se precionarmos a Key determinada no mortor do Unity Faz com que o proximo texto apare�a
        {
            if (textComponent.text == lines[index])
            {
                NextLine(); //Com a Key determinada e precionada, muda para o proximo texto
            }
            else
            {
                StopAllCoroutines(); // com a Key precionada e sem mais  linhas o dialgo termina.
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialouge() // Sistema de dialgo iniciado.
    {
        index = 0;
        StartCoroutine(TypeLine()); //Tipo de linha para ser analizada pelo index.
    }

    IEnumerator TypeLine()
    {

        foreach (char c in lines[index].ToCharArray()) // numero de listas atravez das linhas dos elementos que pretencem ao sistema de dialogo.
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed); // tempo de speed de cada caracter a aparecer no painel de dialgo.
        }

    }

    void NextLine()  // Passa para a proxima linha
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty; // Faz com que o Texto que for escrito no "Text" seja substituido pelo Texto determinado pelas linhas dos elementos do sistema de  dialogo.
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false); // Desativa o sistema e desliga até encontrar o proximo collider que ira ativar o texto do sistema de dialogo.
            collider.SetActive(false);
            collider1.SetActive(false);
            collider2.SetActive(false);
            collider3.SetActive(false);
        }
    }

   
}