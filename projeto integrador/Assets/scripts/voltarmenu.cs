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
    [SerializeField] private AudioSource somPausar;
    [SerializeField] private AudioSource somDespausar;
    [SerializeField] private AudioSource somInteração;

    public void VoltarBar()
    {
        somInteração.Play();
        SceneManager.UnloadSceneAsync(telaBoss);
        SceneManager.LoadScene(telaBar);
        Time.timeScale = 1f;
    }

    public void Aopcoes()
    {
        somPausar.Play();
        joystick.SetActive(false);
        painelOpcoes.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Fopcoes()
    {
        somDespausar.Play();
        painelOpcoes.SetActive(false);
        joystick.SetActive(true);
        Time.timeScale = 1f;
    }

    public void sair()
    {
        somInteração.Play();
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
