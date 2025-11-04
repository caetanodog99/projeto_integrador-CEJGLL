using UnityEngine;
using System.Collections;

public class ataqueDistante : MonoBehaviour
{
    [SerializeField] private GameObject prefabAtaque;
    [SerializeField] private Transform pontoDeAtaque;
    [SerializeField] private Transform alvo;
    [SerializeField] private float tempoAtaque = 3f;
    [SerializeField] private float velocidade = 5f;

    private float proximoAtaque = 0f;

    void Start()
    {

        proximoAtaque = Time.time + 2f;
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
        Vector3 posicaoAjustada = pontoDeAtaque.position + new Vector3(0f, 0f, 1f);
        GameObject golpeDistante = Instantiate(prefabAtaque, posicaoAjustada, Quaternion.identity);

        StartCoroutine(MoverAteAlvo(golpeDistante, alvo.position, velocidade));
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