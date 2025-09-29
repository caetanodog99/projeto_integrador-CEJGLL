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

    public void jogar()
    {
        SceneManager.LoadScene(telajogo); 
    }

    public void Aopcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void Fopcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

  

    public void creditos()
    {
        SceneManager.LoadScene(telacreditos);
    }

    public void sair()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
