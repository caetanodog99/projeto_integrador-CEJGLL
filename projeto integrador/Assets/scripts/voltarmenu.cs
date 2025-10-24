using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class voltarmenu : MonoBehaviour
{
    [SerializeField] private string telabar;
    [SerializeField] private string menuinicial;
    [SerializeField] private string telaboss;

    public void voltar()
    {
        SceneManager.UnloadScene(telabar);
        SceneManager.LoadScene(menuinicial);
        
    }

    public void voltarBar()
    {
        SceneManager.UnloadScene(telaboss);
        SceneManager.LoadScene(telabar);

    }
}
