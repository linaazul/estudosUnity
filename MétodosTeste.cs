using System.IO;
using UnityEngine;

public class MétodosTeste : MonoBehaviour
{
    // Método
    //int somar(int a, int b)
    //{
    //    return a + b;
    //}

    //public int forca = 10;

    bool EstaVivo(int vida)
    {
        return vida > 0;
    }

    private void Start()
    {
        //    int danoFinal = CalcularDano(forca);
        //    Debug.Log("Dano causado: " + danoFinal);
        //}

        //int CalcularDano(int forcaBase)
        //{
        //    int dano = forcaBase * 2;
        //    return dano;

        int vidaAtual = 5;
        if (EstaVivo(vidaAtual)){
            Debug.Log("O jogador está vivo.");
        }
        else
        {
            Debug.Log("O jogador MORREU.");
        }

    }
}
