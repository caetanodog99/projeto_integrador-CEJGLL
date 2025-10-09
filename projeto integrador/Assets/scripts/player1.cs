using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private FixedJoystick joystick;

    private SpriteRenderer sprite;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        //movimenta��o

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
        //direcao.x = 0;
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

    private void ResetLayer()
    {
        anim.SetLayerWeight(0, 0);
        anim.SetLayerWeight(1, 0);
        anim.SetLayerWeight(2, 0);
        anim.SetLayerWeight(3, 0);
    }
}