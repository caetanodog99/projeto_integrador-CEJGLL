using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class voltarmenu : MonoBehaviour
{
    [SerializeField] private string telaBoss;
    [SerializeField] private string telaBar;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject joystick;

    public void VoltarBar()
    {
        SceneManager.UnloadSceneAsync(telaBoss);
        SceneManager.LoadScene(telaBar);
        Time.timeScale = 1f;
    }

    public void Aopcoes()
    {
        joystick.SetActive(false);
        painelOpcoes.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Fopcoes()
    {
        painelOpcoes.SetActive(false);
        joystick.SetActive(true);
        Time.timeScale = 1f;
    }

    public void sair()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
