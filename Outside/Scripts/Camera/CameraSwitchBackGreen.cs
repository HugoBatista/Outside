using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchBackGreen : MonoBehaviour
{
    public Camera SalaPrincipal;
    public Camera CameraPuzzel2;
    public BoxCollider2D trigger;

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            SalaPrincipal.enabled = true;
            
            CameraPuzzel2.enabled = false;


        }
    }
}
