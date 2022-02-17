using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
  
    public Sprite Chest_1;

    void Update() {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Chest_1;
        }
        
    }
}
