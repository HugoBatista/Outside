using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject DialogueBox;
    

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(isInRange) // se o personagem estiver no alcance ativa.
        {
            if(Input.GetKeyDown(interactKey)) // Se apertar a tecla que esta determinada no unity faz a a��o.
            {
                interactAction.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            DialogueBox.SetActive(true);
            
            Debug.Log("Player now in Range");
        }
    }
    private void OnTriggerExit2D(Collider2D collison)
    {
        isInRange = false;
        DialogueBox.SetActive(false);
        
        Debug.Log("Player not on Range");
    }
    
}
