using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class inimigo : MonoBehaviour
{

    [SerializeField] private Transform alvo;
    [SerializeField] private float velocidadeMovimento;
    [SerializeField] private Rigidbody2D rigidbody;

    

    void Update()
    {
        Vector2 posicaoAlvo = this.alvo.position;
        Vector2 posicaoAtual = this.transform.position;
        Vector2 direcao = posicaoAlvo - posicaoAtual;
        direcao = direcao.normalized;

        this.rigidbody.linearVelocity = (this.velocidadeMovimento * direcao);
        
    }
}
