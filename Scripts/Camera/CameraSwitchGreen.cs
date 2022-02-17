using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchGreen : MonoBehaviour
{
    public Camera SalaPrincipal;
    public Camera CameraPuzzel2;
    public BoxCollider2D trigger;

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            SalaPrincipal.enabled = false;
            CameraPuzzel2.enabled = true;
        }
    }

}
