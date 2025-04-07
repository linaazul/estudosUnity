using System;
using UnityEngine;

public class TransformEstudo : MonoBehaviour
{
    public Transform objetoTeste;
    public Vector3 valor;
    public float velocidade;
    private void Update()
    {
        //valor.x = 5;

        //ou seja, o transform do objeto selecionado vai ter a posi��o alterada pelo valor do vector
        objetoTeste.position = valor;

        //outra forma de fazer:
        //objetoTeste.position = new Vector3(*valores *);
        //objetoTeste.position.x -> funciona como compara��o mas n�o funciona para atribui��o

        // Translar para uma dire��o
        // Esse c�digo pede pra ele se mover para a direita
        // Usar translate n�o � muito bom pois ele ignora triggers
        objetoTeste.Translate(Vector3.right * velocidade);

        //dire��es:
        //foward
        //back
        //right
        //left
        //up
        //down (-up)
        //duas formas de mover objetos:
        objetoTeste.Rotate(90 * velocidade, 90 * velocidade, 90 * velocidade);

        //caso eu queira rotar o objeto de forma imediata
        //eulerAngles --> seta um valor de rota��o
        objetoTeste.eulerAngles = new Vector3(30, 45, 0);
    }
}
