using System.Collections;
using UnityEngine;
using TMPro;

public class prepararTela : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoTempo;
    [SerializeField] private GameObject telaPreparese;
    private float intervalo = 1.1f;

    void Awake()
    {
        Time.timeScale = 0f;
    }

    private void Start()
    {

        if (textoTempo != null && telaPreparese != null)
        {
            StartCoroutine(CiclarContagemRegressiva());
        }
        else
        {
            Debug.LogWarning("Texto ou telaPreparese não atribuídos.");
        }
    }

    private IEnumerator CiclarContagemRegressiva()
    {
        for (int i = 3; i >= 1; i--)
        {
            textoTempo.text = i.ToString() + "!";
            yield return new WaitForSecondsRealtime(intervalo);
        }

        textoTempo.text = "Já!";
        yield return new WaitForSecondsRealtime(intervalo);

        telaPreparese.SetActive(false);
        Time.timeScale = 1f;
    }
}
