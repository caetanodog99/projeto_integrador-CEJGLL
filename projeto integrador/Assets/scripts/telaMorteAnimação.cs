using UnityEngine;

public class telaMorteAnimação : MonoBehaviour
{
    [SerializeField]private Animator animator;
    [SerializeField]private GameObject telaMorte;

    void Update()
    {
        Debug.Log("status ");
        Debug.Log(telaMorte.activeInHierarchy);
        if (telaMorte.activeInHierarchy)
        {
            Debug.Log("caiu no if de ativo do script separado");
            animator.Play("tela_morte");
        }
    }
}
