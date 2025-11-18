using UnityEngine;

public class painelMorte : MonoBehaviour
{
    public inimigo boss;
    public player jogador;
    [SerializeField] private GameObject painelVoceMorreu;
    [SerializeField] private GameObject painelJoystick;
    [SerializeField] private GameObject painelCoracoes;
    [SerializeField] private Animator animator;

    void Update()
    {
        if (painelVoceMorreu)
        {
            animator.Play("tela_morte");
            painelJoystick.SetActive(false);
            painelCoracoes.SetActive(false);
        }
    }
    

    public void TentarNovamente()
    {
        painelJoystick.SetActive(true);
        painelCoracoes.SetActive(true);
        this.gameObject.SetActive(false);
        boss.ReiniciarVida();
        jogador.ReiniciarVida();
        Time.timeScale = 1f;
    }
}
