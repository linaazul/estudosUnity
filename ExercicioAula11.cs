using UnityEngine;

public class ExercicioAula11 : MonoBehaviour
{
    public Transform personagemMovimentacao;
    public float velocidadeMovimentacao;
    void Update()
    {
        // Enquanto a tecla está pressionada o "personagem" se move para frente
        if (Input.GetKey(KeyCode.UpArrow)) {
            personagemMovimentacao.Translate(Vector3.forward * velocidadeMovimentacao);
        }
        // Enquanto a tecla está pressionada o "personagem" se move para trás
        if (Input.GetKey(KeyCode.DownArrow))
        {
            personagemMovimentacao.Translate(Vector3.back * velocidadeMovimentacao);
        }
        // Enquanto a tecla está pressionada o eixo x do "personagem" se move para baixo.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            personagemMovimentacao.Rotate(velocidadeMovimentacao, 0, 0);
        }
        // Enquanto a tecla está pressionada o eixo x do "personagem" se move para cima.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            personagemMovimentacao.Rotate(-velocidadeMovimentacao, 0, 0);
        }
    }
}
 