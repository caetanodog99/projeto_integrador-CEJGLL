using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class inimigo : MonoBehaviour
{

    //[SerializeField] private Transform alvo;
    //[SerializeField] private float velocidadeMovimento;
    [SerializeField] private Rigidbody2D rigidbody;
    private int vida;

    public void Start()
    {
        vida = 5;
    }

    void Update()
    {
        Debug.Log("a vida do boss: " + vida);
        //Vector2 posicaoAlvo = this.alvo.position;
        //Vector2 posicaoAtual = this.transform.position;
        //Vector2 direcao = posicaoAlvo - posicaoAtual;
        //direcao = direcao.normalized;

        //this.rigidbody.linearVelocity = (this.velocidadeMovimento * direcao);
    }

    public void ReceberDano()
    {
        this.vida--;
        if (vida <= 0)
        {
            Debug.Log("o boss ja era!");
            Destruir(true);
        }
    }

    private void Destruir(bool derrotado)
    {
        Destroy(this.gameObject);
    }
}
