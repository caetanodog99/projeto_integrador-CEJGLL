using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class painelMorte : MonoBehaviour
{
    public inimigo boss;
    public player jogador;
    [SerializeField] private GameObject painelVoceMorreu;
    [SerializeField] private GameObject botaoPause;
    [SerializeField] private GameObject painelJoystick;
    [SerializeField] private GameObject painelCoracoes;
    [SerializeField] private AudioSource somMorte;

    void Update()
    {
        if (painelVoceMorreu)
        {
            somMorte.Play();
            painelJoystick.SetActive(false);
            botaoPause.SetActive(false);
            painelCoracoes.SetActive(false);
            StartCoroutine(tempoPraZerar());
        }
        IEnumerator  tempoPraZerar()
        {
            yield return new WaitForSeconds(1.2f);
            Time.timeScale = 0f;

        }
    }
    

    public void TentarNovamente()
    {
        painelJoystick.SetActive(true);
        botaoPause.SetActive(true);
        painelCoracoes.SetActive(true);
        this.gameObject.SetActive(false);
        boss.ReiniciarVida();
        jogador.ReiniciarVida();
        Time.timeScale = 1f;
    }
}
