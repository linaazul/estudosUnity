using UnityEngine;

public class ForTeste : MonoBehaviour
{
    void Start()
    {
        for(int index = 1; index<= 5; index++)
        {
            Debug.Log("Contador: " + index);
        }
        // Usar o for quando se sabe o número de iterações.
        // Usar o While quando o número de iterações for desconhecido.


        Debug.Log("Fim do loop.");
    }
}
