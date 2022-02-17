using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;
    float input_x = 0;
    float input_y = 0;
    public float speed = 2.0f;
    bool isWalking = false;
   
    
    public bool StarterKey;
    public bool BlueKey;
    public bool GreenKey;
    public bool YellowKey;

    

    // Start is called before the first frame update
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x != 0 || input_y != 0);

        if (isWalking)
        {
            var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("input_x", input_x);
            playerAnimator.SetFloat("input_y", input_y);
        }

        playerAnimator.SetBool("isWalking", isWalking);

        if (Inventario_Chaves.StarterKey == true)
        {
            StarterKey = true;
        }

        if (Inventario_Chaves.YellowKey == true)
        {
            YellowKey = true;
        }

        if (Inventario_Chaves.GreenKey == true)
        {
            GreenKey = true;
        }

        if (Inventario_Chaves.BlueKey == true)
        {
            BlueKey = true;
        }

        
    }
    

}