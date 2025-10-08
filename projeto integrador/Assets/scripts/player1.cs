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
                                                
        if (direcao.y != 0 || direcao.x != 0)           //fazer um componente de correndo pra cada direção
        {
            anim.SetLayerWeight(0, 1);
            anim.SetLayerWeight(1, 2);
            anim.SetLayerWeight(2, 3);
            anim.SetLayerWeight(3, 0);

        }
     


        if (direcao != Vector2.zero)
        {
            anim.SetBool("correndo", false);
        }
        else
        {
            anim.SetBool("correndo", true);
        }



    }
}