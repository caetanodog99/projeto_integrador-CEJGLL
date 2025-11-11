using UnityEngine;
using UnityEngine.SceneManagement;

public class npcDialogo : MonoBehaviour
{
    [SerializeField] private GameObject telaDialogoNPC;
    [SerializeField] private GameObject telaDialogoBecca;
    [SerializeField] private GameObject telaDialogoNPCLivro;
    [SerializeField] private GameObject telaDialogoBeccaLivro;
    [SerializeField] private string telaBoss;
    [SerializeField] private AudioSource somInteracao;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void BotaoProximoBecca() 
    {
        somInteracao.Play();
        telaDialogoBecca.SetActive(false);
        telaDialogoNPC.SetActive(true);
    }

    public void BotaoProximoNPC()
    {
        somInteracao.Play();
        telaDialogoNPC.SetActive(false);
        telaDialogoBeccaLivro.SetActive(true);
    }

    public void BotaoProximoBeccaLivro()
    {
        somInteracao.Play();
        telaDialogoBeccaLivro.SetActive(false);
        telaDialogoNPCLivro.SetActive(true);
        
    }

    public void BotaoBatalhar()
    {
        somInteracao.Play();
        telaDialogoNPC.SetActive(false);
        telaDialogoBecca.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(telaBoss);
    }

    public void BotaoVoltar()
    {
        somInteracao.Play();
        telaDialogoNPC.SetActive(false);
        telaDialogoBecca.SetActive(false);
        telaDialogoBeccaLivro.SetActive(false);
        telaDialogoNPCLivro.SetActive(false);
        Time.timeScale = 1f;
    }

    public void AtivarTexto()
    {
        somInteracao.Play();
        telaDialogoBecca.SetActive(true);
        Time.timeScale = 0f;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            AtivarTexto();

        }
    }
}
