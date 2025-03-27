using UnityEngine;

public class VoidsTeste : MonoBehaviour
{
    // � chamado em um intervalo fixo independentemente do framerate atual do jogo
    // Usado para realizar c�lculos f�sicos
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Teste.");
        }
    }


    // Serve para chamar eventos.
    // N�o tem colis�o s�lida. -> IsTrigger � ativado para atravessar objetos.
    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o c�digo rodando)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colidiu.");
    }

    // Semelhante ao OnTrigger
    // A colis�o � s�lida.
    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o c�digo rodando)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colidiu.");
    }


    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o c�digo rodando).
    // N�o � s�lido.
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Descolidiu.");
    }

    // Realiza uma a��o ao 'descolidir' com um objeto.
    // A colis�o � s�lida. -> IsTrigger � desativado para n�o atravessar objetos.
    // Um dos objetos que colidem deve ter um Rigidbody. (De preferencia o que tem o c�digo rodando).
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Descolidiu.");
    }

    // Realiza uma a��o ao 'continuamente' ao colidir com um objeto.
    //A colis�o n�o � s�lida -> IsTrigger � ativado para atravessar objetos.
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Colidindo.");
    }

    //Realiza uma a��o ao 'continuamente' ao colidir com um objeto.
    //A colis�o � s�lida.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colidindo.");
    }

    // N�o � recomendado fazer condi��es ou loops dentro dos voids citados acima.


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
