using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class socoSoda : MonoBehaviour
{
    [SerializeField] private GameObject prefabAtaque;
    [SerializeField] private Transform pontoDeAtaque;
    [SerializeField] private float tempoAtaque = 3f;
    private float proximoAtaque = 0f;

    void Update()
    {
        if (Time.time >= proximoAtaque)
        {
            AtacarCurto();
            proximoAtaque = Time.time + tempoAtaque;

        }
    }


    void AtacarCurto()
    {
        Vector3 posicaoAjustada = pontoDeAtaque.position + new Vector3(0f, -4f, 1f);
        GameObject golpeCurto = Instantiate(prefabAtaque, posicaoAjustada, Quaternion.identity);
        Destroy(golpeCurto, 1f);

    }


}