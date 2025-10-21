using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class AtaqueCurto : MonoBehaviour
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

    //public IEnumerator DestruirDepois()
    //{
    //    yield return new WaitForSeconds(1f);
    //    Destroy(gameObject);
    //}

    void AtacarCurto()
    {
        GameObject golpeCurto = Instantiate(prefabAtaque, pontoDeAtaque.position, Quaternion.identity);
        Destroy(golpeCurto, 1f);
        //DestruirDepois();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            player jogador = collider.GetComponent<player>();
            jogador.ReceberDano();

        }
    }
}