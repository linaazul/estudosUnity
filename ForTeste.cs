using UnityEngine;

public class ForTeste : MonoBehaviour
{
    void Start()
    {
        for(int index = 1; index<= 5; index++)
        {
            Debug.Log("Contador: " + index);
        }
        // Usar o for quando se sabe o n�mero de itera��es.
        // Usar o While quando o n�mero de itera��es for desconhecido.


        Debug.Log("Fim do loop.");
    }
}
