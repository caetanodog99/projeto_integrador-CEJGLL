using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private FixedJoystick joystick;

    [SerializeField] private GameObject painelMorte;

    [SerializeField] private GameObject prefabPlayer;

    private SpriteRenderer sprite;

    private Animator anim;

    private int vida;

    [SerializeField] private Image[] coracao;
    [SerializeField] private Sprite coracaoCheio;
    [SerializeField] private Sprite coracaoVazio;

    [SerializeField] private AudioSource somMorte;
    public void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

        vida = 3;
       
    }

    public void ReceberDano()
    {
        this.vida--;
        PerderCoracao();
        if (vida <= 0)
        {
            somMorte.Play();
            prefabPlayer.SetActive(false);
            painelMorte.SetActive(true);
            Time.timeScale = 0f; 
        }
    }

    public void ReiniciarVida()
    {
        Vector2 posicao = new Vector2(3.25f, -9f);
        prefabPlayer.transform.position = posicao;
        prefabPlayer.SetActive(true);
        this.vida = 3;
        coracao[0].sprite = coracaoCheio;
        coracao[1].sprite = coracaoCheio;
        coracao[2].sprite = coracaoCheio;

    }



    private void FixedUpdate()
    {
        

        float horizontal = this.joystick.Horizontal;
        float vertical = this.joystick.Vertical;


        Vector2 direcao = new Vector2(horizontal, vertical);
        rb.linearVelocity = direcao.normalized;
        this.GetComponent<Rigidbody2D>().linearVelocity = direcao * this.speed;

        if(direcao.x != 0)
        {
            ResetLayer();
            anim.SetLayerWeight(0, 1);
            if (direcao.x > 0)
            {
                ResetLayer();
                anim.SetLayerWeight(1, 1);
                sprite.flipX = false;
            }
            else if (direcao.x < 0)
            {
                ResetLayer();
                anim.SetLayerWeight(0, 1);
                sprite.flipX = true;
            }
        }
        
        if (direcao.y > 0 && direcao.y > direcao.x)
        {
            ResetLayer();
            anim.SetLayerWeight(3, 1);
        }
        if (direcao.y < 0 && direcao.y < direcao.x)
        {
            ResetLayer();
            anim.SetLayerWeight(2, 1);
        }


        if (direcao != Vector2.zero)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }

    }

    void PerderCoracao()
    {
        for (int i = 0; i < coracao.Length; i++)
        {
            if(i < vida)
            {
                coracao[i].sprite = coracaoCheio;
            }
            else
            {
                coracao[i].sprite = coracaoVazio;
            }

        }
    }

    private void ResetLayer()
    {
        anim.SetLayerWeight(0, 0);
        anim.SetLayerWeight(1, 0);
        anim.SetLayerWeight(2, 0);
        anim.SetLayerWeight(3, 0);
    }
}