using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    

    public void ApanharStarterKey()
    {
        Inventario_Chaves.StarterKey = true;
        Debug.Log("O jogador apanhou uma chave antiga do bau!");
        Debug.Log(Inventario_Chaves.StarterKey);
    }

    public void ApanharChaveAmarela()
    {
        Inventario_Chaves.YellowKey = true;
        Debug.Log("O jogador encontrou uma chave amarela no bau!");
        Debug.Log(Inventario_Chaves.YellowKey);
    }

    public void ApanharChaveVerde()
    {
        Inventario_Chaves.GreenKey = true;
        Debug.Log("O jogador encontrou uma chave verde no bau!");
        Debug.Log(Inventario_Chaves.GreenKey);
    }

    public void ApanharChaveAzul()
    {
        Inventario_Chaves.BlueKey = true;
        Debug.Log("O jogador encontrou uma chave azul no bau!");
        Debug.Log(Inventario_Chaves.BlueKey);
    }

    public void ApanharChaveFake1()
    {
        Inventario_Chaves.FakeKey1 = true;
        Debug.Log("O jogador encontrou uma chave azul no bau!");
        Debug.Log(Inventario_Chaves.FakeKey1);
    }

    public void ApanharChaveFake2()
    {
        Inventario_Chaves.FakeKey2 = true;
        Debug.Log("O jogador encontrou uma chave azul no bau!");
        Debug.Log(Inventario_Chaves.FakeKey2);
    }

    public void ApanharChaveFake3()
    {
        Inventario_Chaves.FakeKey3 = true;
        Debug.Log("O jogador encontrou uma chave azul no bau!");
        Debug.Log(Inventario_Chaves.FakeKey3);
    }
}
