using UnityEngine;

public class inimigo : MonoBehaviour
{
    public void Start()
    {
        //S� pode ser acessada diretamente sem ser declarada porque � uma variavel estatica
        GlobalScore.scoreGlobal += 10;
    }
}
