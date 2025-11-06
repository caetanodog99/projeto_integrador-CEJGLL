using UnityEngine;

public class animacaoWalkman : MonoBehaviour
{
    public Animator animator;

    public void BotaoIniciar()
    {
        animator.SetTrigger("Play");
    }

    public void BotaoOpcoes()
    {
        animator.SetTrigger("Pause");
    }

    public void BotaoCreditos()
    {
        animator.SetTrigger("Creditos");
    }

    public void BotaoSair()
    {
        animator.SetTrigger("Sair");
    }
}