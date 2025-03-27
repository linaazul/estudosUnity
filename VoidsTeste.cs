using UnityEngine;

public class VoidsTeste : MonoBehaviour
{
    // É chamado em um intervalo fixo independentemente do framerate atual do jogo
    // Usado para realizar cálculos físicos
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Teste.");
        }
    }


    // Serve para chamar eventos.
    // Não tem colisão sólida. -> IsTrigger é ativado para atravessar objetos.
    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o código rodando)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colidiu.");
    }

    // Semelhante ao OnTrigger
    // A colisão é sólida.
    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o código rodando)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colidiu.");
    }


    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o código rodando).
    // Não é sólido.
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Descolidiu.");
    }

    // Realiza uma ação ao 'descolidir' com um objeto.
    // A colisão é sólida. -> IsTrigger é desativado para não atravessar objetos.
    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o código rodando).
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Descolidiu.");
    }

    // Realiza uma ação ao 'continuamente' ao colidir com um objeto.
    //A colisão não é sólida -> IsTrigger é ativado para atravessar objetos.
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Colidindo.");
    }

    //Realiza uma ação ao 'continuamente' ao colidir com um objeto.
    //A colisão é sólida.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colidindo.");
    }

    // Não é recomendado fazer condições ou loops dentro dos voids citados acima.


    private void Start()
    {
        MostrarNome("Anaa", 20);
    }

    // Voids Personalizados:
    void MostrarNome(string nome, int idade)
    {
        Debug.Log(nome + " e " + idade);
    }

}
