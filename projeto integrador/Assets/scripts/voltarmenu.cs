using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class voltarmenu : MonoBehaviour
{
    [SerializeField] private string telajogo;
    [SerializeField] private string menuinicial;

    public void voltar()
    {
        SceneManager.UnloadScene(telajogo);
        SceneManager.LoadScene(menuinicial);
        
    }
}
