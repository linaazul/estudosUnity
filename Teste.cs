using UnityEngine;
//Permite usar coisas como lista e fila.
using System.Collections;
//Permite usar listas mais avançadas e dicionários.
using System.Collections.Generic;

//O MonoBehaviour permite que minha classe seja vinculada a um objeto do jogo e se torne um componente.
public class Teste : MonoBehaviour
{

    public int teste;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Exemplos de coisas que são usadas no start: Setar uma váriavel antes do código rodar.
    void Start()
    {

    }

    // Update is called once per frame
    // Exemplos de coisas que são usadas no update: Caminhar, pular
    void Update()
    {
        print("Testando o código.");
        teste++;
    }
}
