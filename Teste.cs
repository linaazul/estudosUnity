using UnityEngine;
//Permite usar coisas como lista e fila.
using System.Collections;
//Permite usar listas mais avan�adas e dicion�rios.
using System.Collections.Generic;

//O MonoBehaviour permite que minha classe seja vinculada a um objeto do jogo e se torne um componente.
public class Teste : MonoBehaviour
{

    public int teste;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Exemplos de coisas que s�o usadas no start: Setar uma v�riavel antes do c�digo rodar.
    void Start()
    {

    }

    // Update is called once per frame
    // Exemplos de coisas que s�o usadas no update: Caminhar, pular
    void Update()
    {
        print("Testando o c�digo.");
        teste++;
    }
}
