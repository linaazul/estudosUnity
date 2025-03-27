using UnityEngine;

public class LoopsTeste : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int index = 0;
        int seguranca = 0;

        while (index <5 && seguranca < 5000)
        {
            Debug.Log(index);
            seguranca++;
        }
        Debug.Log("Escapou do loop graças a variável segurança.");
    }
}
