using UnityEngine;
using System.Collections;
using Unity.Collections.LowLevel.Unsafe;

public class ataqueLata : MonoBehaviour
{
    [SerializeField] private GameObject prefabAtaque;
    [SerializeField] private Transform pontoSpawnLata;
    [SerializeField] private Transform alvo;
    [SerializeField] private float tempoAtaque = 3f;
    [SerializeField] private float velocidade = 5f;

    private float proximoAtaque = 0f;

    private void Start()
    {

    }

    void Update()
    {
        if (Time.time >= proximoAtaque)
        {
            AtacarProjetil();
            proximoAtaque = Time.time + tempoAtaque;
        }



    }

    void AtacarProjetil()
    {
        Vector2 posicaoMax = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 posicaoMin = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        float posicaoX = Random.Range(posicaoMin.x, posicaoMax.x);
        Vector3 posicaoAjustada = pontoSpawnLata.position + new Vector3(posicaoX, 0f, 1f);
        GameObject golpeLata = Instantiate(prefabAtaque, posicaoAjustada, Quaternion.identity);



        StartCoroutine(MoverAteAlvo(golpeLata, alvo.position, velocidade));
    }


    IEnumerator MoverAteAlvo(GameObject objeto, Vector3 destino, float velocidade)
    {
        while (objeto != null && Vector3.Distance(objeto.transform.position, destino) > 0.1f)
        {
            objeto.transform.position = Vector3.MoveTowards(objeto.transform.position, destino, velocidade * Time.deltaTime);
            yield return null;
        }

    }
}