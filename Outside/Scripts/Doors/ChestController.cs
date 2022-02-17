using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen;
    public Sprite Chest_1;

    public void OpenChest()
    {
        if(!isOpen)
        {
            isOpen = true;
            Debug.Log("UAU CONSEGUISTE ABRIR A MERDA DO BAU");
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Chest_1;
        }
    }
}
