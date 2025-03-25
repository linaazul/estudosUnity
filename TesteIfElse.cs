using Unity.VisualScripting;
using UnityEngine;

public class TesteIfElse : MonoBehaviour
{
    //public int valor;
    //public bool verdadeiro;
    //public Light luz;

    private void Start()
    {

    }

    private void Update()
    {
        //Formas de identificar um input:
        //input.GetKeyDown ---> Caso o usuário apertou uma tecla
        //input.GetKey ---> Caso usuario esteja segurando uma tecla
        //input.GetKeyUp ---> Caso o usuário soltou uma tecla

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X foi apertado.");
        }
        
        if(Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Z está sendo pressionado.");
        }

        if(Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("C foi solto.");
        }

        //if (luz.enabled == false)
        //{
        //    Debug.Log("Luz não está ativa.");
        //}else if(luz.enabled == true)
        //{
        //    Debug.Log("Luz está ativa.");
        //}

        //if (valor > 5)
        //{
        //    verdadeiro = true;
        //}
        //else
        //{
        //    verdadeiro = false;
        //}

        //if (verdadeiro)
        //{
        //    print("Verdadeiro");
        //    Debug.Log("é verdadeiro.");
        //}
    }
}
