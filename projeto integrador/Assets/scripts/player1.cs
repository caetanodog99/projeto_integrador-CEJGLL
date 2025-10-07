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

        float horizontal = 1;//this.joystick.Horizontal;
        float vertical = this.joystick.Vertical;

        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb.linearVelocity = direction.normalized * speed;
        //transform.Translate(direction.normalized * speed);
       // rb.AddForce(direction * speed);

        if (direction.x != 0)
        {
            anim.SetLayerWeight(0, 0);
            anim.SetLayerWeight(1, 0);
        }

        if (direction != Vector2.zero)
        {
            anim.SetBool("andando", true);
        }
        else
        {
            anim.SetBool("andando", false);
        }



    }
}