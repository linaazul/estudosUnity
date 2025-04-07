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

        //ou seja, o transform do objeto selecionado vai ter a posição alterada pelo valor do vector
        objetoTeste.position = valor;

        //outra forma de fazer:
        //objetoTeste.position = new Vector3(*valores *);
        //objetoTeste.position.x -> funciona como comparação mas não funciona para atribuição

        // Translar para uma direção
        // Esse código pede pra ele se mover para a direita
        // Usar translate não é muito bom pois ele ignora triggers
        objetoTeste.Translate(Vector3.right * velocidade);

        //direções:
        //foward
        //back
        //right
        //left
        //up
        //down (-up)
        //duas formas de mover objetos:
        //objetoTeste.Rotate(90 * velocidade, 90 * velocidade, 90 * velocidade);

        //caso eu queira rotar o objeto de forma imediata
        //eulerAngles --> seta um valor de rotação
        objetoTeste.eulerAngles = new Vector3(30, 45, 0);
    }
}
