using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class menuprincipal : MonoBehaviour
{
    [SerializeField] private string telajogo;
    [SerializeField] private string telacreditos;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private AudioSource somPausar;
    [SerializeField] private AudioSource somDespausar;
    [SerializeField] private AudioSource somInteração;
    [SerializeField] private AudioSource somIniciar;


    public void jogar()
    {
        somIniciar.Play();
        SceneManager.LoadScene(telajogo); 
    }

    public void Aopcoes()
    {
        somPausar.Play();
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void Fopcoes()
    {
        somDespausar.Play();
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

  

    public void creditos()
    {
        somInteração.Play();
        SceneManager.LoadScene(telacreditos);
    }

    public void sair()
    {
        somInteração.Play();
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
