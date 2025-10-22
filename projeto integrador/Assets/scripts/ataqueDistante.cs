using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ataqueDistante : MonoBehaviour
{
    [SerializeField] private GameObject prefabAtaque;
    [SerializeField] private Transform pontoDeAtaque;
    [SerializeField] private float tempoAtaque = 3f;
    [SerializeField] private Transform alvo;
    [SerializeField] private float velocidadeMovimento;
    [SerializeField] private Rigidbody2D rigidbody;
    private float proximoAtaque = 0f;

    void Update()
    {
        if (Time.time >= proximoAtaque)
        {
            AtacarCurto();
            proximoAtaque = Time.time + tempoAtaque;

        }
        Vector2 posicaoAlvo = this.alvo.position;
        Vector2 posicaoAtual = this.transform.position;
        Vector2 direcao = posicaoAlvo - posicaoAtual;
        direcao = direcao.normalized;

        this.GetComponent<Rigidbody>().linearVelocity = (this.velocidadeMovimento * direcao);
    }


    void AtacarCurto()
    {
        Vector3 posicaoAjustada = pontoDeAtaque.position + new Vector3(0f, 0f, 1f);
        GameObject golpeCurto = Instantiate(prefabAtaque, posicaoAjustada, Quaternion.identity);
        Destroy(golpeCurto, 1f);

    }


}