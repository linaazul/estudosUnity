using UnityEngine;

public class inimigo : MonoBehaviour
{
    public void Start()
    {
        //Só pode ser acessada diretamente sem ser declarada porque é uma variavel estatica
        GlobalScore.scoreGlobal += 10;
    }
}
