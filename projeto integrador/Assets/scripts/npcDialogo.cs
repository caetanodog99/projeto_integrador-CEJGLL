using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class npcDialogo : MonoBehaviour
{   
    [SerializeField] private GameObject telaDialogoNPC;
    [SerializeField] private GameObject telaDialogoAcessibilidade;
    [SerializeField] private GameObject telaDialogoBecca;
    [SerializeField] private GameObject telaDialogoNPCLivro;
    [SerializeField] private GameObject telaDialogoBeccaLivro;
    [SerializeField] private AudioSource somInteracao;
    [SerializeField] private GameObject telaPreparese;
    [SerializeField] private string telaBoss;
    [SerializeField] private Animator animator;


    public void BotaoProximoAcessibilidade()
    {
        somInteracao.Play();
        telaDialogoAcessibilidade.SetActive(false);
        telaDialogoBecca.SetActive(true);
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
        telaPreparese.SetActive(true);
        StartCoroutine(CarregarCena());
    }

    private IEnumerator CarregarCena()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(telaBoss);
    }

    public void BotaoVoltar()
    {
        somInteracao.Play();
        telaDialogoNPC.SetActive(false);
        telaDialogoBecca.SetActive(false);
        telaDialogoBeccaLivro.SetActive(false);
        telaDialogoNPCLivro.SetActive(false);
        telaDialogoAcessibilidade.SetActive(false);
        Time.timeScale = 1f;
    }

    public void AtivarTexto()
    {
        somInteracao.Play();
        telaDialogoAcessibilidade.SetActive(true);
        Time.timeScale = 0f;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            StartCoroutine(TextoDelay());
            animator.SetBool("idle", true);
        }
        else
        {
            animator.SetBool("idle", false);
        }
    }
    IEnumerator TextoDelay()
    {
        yield return new WaitForSeconds(1f);
        AtivarTexto();
    }
}
