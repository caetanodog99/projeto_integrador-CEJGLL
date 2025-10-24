using UnityEngine;

public class painelMorte : MonoBehaviour
{
    public inimigo boss;
    public player jogador;

    public void TentarNovamente()
    {
        this.gameObject.SetActive(false);
        boss.ReiniciarVida();
        jogador.ReiniciarVida();
        Time.timeScale = 1f;
    }
}
