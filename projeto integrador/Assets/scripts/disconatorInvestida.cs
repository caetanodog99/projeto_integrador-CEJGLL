using UnityEngine;
using System.Collections;

public class disconatorInvestida : MonoBehaviour
{
    [SerializeField] private Transform alvo;
    [SerializeField] private float tempoAtaque = 3f;
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private AudioSource somInvestida;

    private float proximoAtaque = 0f;
    private Vector3 posicaoOriginal;

    void Start()
    {
        posicaoOriginal = transform.position;
    }

    void Update()
    {
        if (Time.time >= proximoAtaque)
        {
            StartCoroutine(Investida());
            proximoAtaque = Time.time + tempoAtaque;
        }
    }

    IEnumerator Investida()
    {

        yield return StartCoroutine(MoverAte(alvo.position));

        yield return new WaitForSeconds(1f);

        yield return StartCoroutine(MoverAte(posicaoOriginal));
    }

    IEnumerator MoverAte(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.1f)
        {
            somInvestida.Play();
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidade * Time.deltaTime);
            yield return null;
        }
    }
}