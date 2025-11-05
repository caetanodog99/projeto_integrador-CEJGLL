using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ataquePlayer : MonoBehaviour
{
    [SerializeField] private GameObject prefabAtaque;
    [SerializeField] private Transform pontoDeAtaque;
    [SerializeField] private float tempoAtaque = 1f;
    [SerializeField] private AudioSource somAtaque;

    private float proximoAtaque = 0f;

    void Update()
    {
        if (Time.time >= proximoAtaque)
        {
            Atacar();
            proximoAtaque = Time.time + tempoAtaque;

        }
    }


    void Atacar()
    {
        
        Vector2 posicaoAjustada = pontoDeAtaque.position + new Vector3(0f, 5f);
        Quaternion rotacao = Quaternion.Euler(0f, 0f, 180f);
        somAtaque.Play();
        GameObject golpeCurto = Instantiate(prefabAtaque, posicaoAjustada, rotacao);
        Destroy(golpeCurto, 0.5f);
    }


}