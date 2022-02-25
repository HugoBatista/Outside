using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class troca : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.gameObject.CompareTag("Player"))
    {
        SceneManager.LoadScene(2);
    }
    }



   
}