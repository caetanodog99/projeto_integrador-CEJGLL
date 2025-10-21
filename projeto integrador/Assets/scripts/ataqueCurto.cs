using UnityEngine;

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

    void AtacarCurto()
    {
        GameObject golpeCurto = Instantiate(prefabAtaque, pontoDeAtaque.position, Quaternion.identity);
        Destroy(golpeCurto, 1f);
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