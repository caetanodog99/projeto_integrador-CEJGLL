using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class inimigo : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody;
    private int vida;
    [SerializeField] private GameObject painelVitoria;
    [SerializeField] public AudioSource somMorte;



    public void Start()
    {
        vida = 1;
    }

    void Update()
    {
        Debug.Log("vida do boss: " + vida);
    }

    public void ReceberDano()
    {
        this.vida--;
        if (vida <= 0)
        {
            somMorte.Play();
            painelVitoria.SetActive(true);
            Destruir(true);
            Time.timeScale = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            player jogador = collider.GetComponent<player>();
            jogador.ReceberDano();

        }
    }

    private void Destruir(bool derrotado)
    {

        Destroy(this.gameObject);
    }

    public void ReiniciarVida()
    {
        this.vida = 1;
    }
}
