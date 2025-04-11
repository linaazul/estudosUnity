using UnityEngine;

public class Activation : MonoBehaviour
{
    //public GameObject objeto;
    public bool ativo;
    public BoxCollider colisor;
    
    private void Update()
    {
        //Duas formas de ativar o objeto.
        //ativo = objeto.activeSelf;
        //objeto.SetActive(ativo);

        //Enabled funciona para detectar se o objeto está ativo ou não.
        if (colisor.enabled)
        {
            Debug.Log("Colisor ativo");
        }

        //para desativar o script voce pode usar this.
        //this.enabled = false;

        //para desativar o objeto inteiro:
        //this.gameObject.SetActive(false);
    }
}
