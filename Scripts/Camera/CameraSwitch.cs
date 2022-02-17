using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera SalaPrincipal;
    public Camera MainCamera;
    public BoxCollider2D trigger;

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if  (trigger.gameObject.tag == "Player")
        {
            SalaPrincipal.enabled = true;
            MainCamera.enabled = false;
        }
    }

}
