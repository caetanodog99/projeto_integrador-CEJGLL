using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class inimigo : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody;
    private int vida;
    [SerializeField] private GameObject painelVitoria;
    [SerializeField] public AudioSource somMorte;
    [SerializeField] public AudioSource somDano;
    public void Start()
    {
        vida = 7;
    }

    void Update()
    {
        Debug.Log("vida do boss: " + vida);
    }

    public void ReceberDano()
    {
        somDano.Play();
        this.vida--;
        if (vida <= 0)
        {
            somMorte.Play();
            StartCoroutine(ExecutarDepoisDaMorte());
        }
        IEnumerator ExecutarDepoisDaMorte()
        {
            yield return new WaitForSeconds(1.5f);

            Destruir(true);
            painelVitoria.SetActive(true);
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
        this.vida = 7;
    }
}
