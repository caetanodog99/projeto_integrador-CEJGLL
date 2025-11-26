using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class voltarCreditos : MonoBehaviour
{
    [SerializeField] private string telaCreditos;
    [SerializeField] private string telaInicial;

    public void VoltarInicio()
    {
        SceneManager.UnloadSceneAsync(telaCreditos);
        SceneManager.LoadScene(telaInicial);
    }
}
