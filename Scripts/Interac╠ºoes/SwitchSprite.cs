using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchSprite : MonoBehaviour
{
    public GameObject FakeChest; //Bau fake 1
    

    /*public void OpenWall(GameObject FakeChest1)
    {
        if(Inventario_Chaves.FakeKey1 == true)
        {
            Collider.enabled = true;

        }
    }*/
    void Update()
    {
        if (Inventario_Chaves.FakeKey1 == true)
        {
            FakeChest.SetActive(false);

        }
    }


}
