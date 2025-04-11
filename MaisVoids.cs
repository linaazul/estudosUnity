using UnityEngine;

public class MaisVoids : MonoBehaviour
{
    // Esse void vem antes do void Start
    // utilizado quando voce quer que algo aconteça antes mesmo do jogo começar
    private void Awake()
    {
        Debug.Log("Void awake");
    }

    //sempre que um objeto é ativado esse void é executado
    private void OnEnable()
    {
        Debug.Log("Void on enable");
    }

    //sempre que um objeto é desativado esse void é executado
    void OnDisable()
    {
        Debug.Log("Void on disable");
    }

    // Esse void é executado após o update
    private void LateUpdate()
    {
        Debug.Log("Void late update");
    }

    // É chamado quando o objeto é destruido, deletado
    private void OnDestroy()
    {
        Debug.Log("Void on destroy");
    }

    // Quando o jogo fechar ele executa.
    private void OnApplicationQuit()
    {
        Debug.Log("Void on application quit");
    }

    // basicamente pausa o jogo quando você da alt tab ou clica em outra janela
    private void OnApplicationFocus(bool focus)
    {
        Debug.Log("Foquei!");
    }   
}
