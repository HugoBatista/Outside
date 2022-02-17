using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool JogoEmPausa = false;
    public GameObject MenuPausa;
    public GameObject ExitButton;
    public GameObject Return;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JogoEmPausa)
            {
                Retornar();
            }
            else
            {
                Pausa();
            }
        }

        

        void Pausa()
        {
            Time.timeScale = 0;
            MenuPausa.SetActive(true);
            JogoEmPausa = true;
        }
    }
         public void Sair()
         {

            Application.Quit();
         }
         public void Retornar()
         {
             MenuPausa.SetActive(false);
             Time.timeScale = 1;
                JogoEmPausa = false;
         }
}
