using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class inimigo : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody;
    private int vida;
    [SerializeField] private GameObject painelVitoria;

    public void Start()
    {
        vida = 5;
    }

    void Update()
    {
        Debug.Log("a vida do boss: " + vida);
    }

    public void ReceberDano()
    {
        this.vida--;
        if (vida <= 0)
        {
            painelVitoria.SetActive(true);
            Destruir(true);
            Time.timeScale = 0f;
        }
    }

    private void Destruir(bool derrotado)
    {
        Destroy(this.gameObject);
    }

    public void ReiniciarVida()
    {
        this.vida = 5;
    }
}
